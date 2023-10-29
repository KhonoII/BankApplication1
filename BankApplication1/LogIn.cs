using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin.Properties;

namespace BankApplication1
{
    public partial class LogIn : MaterialForm
    {

        public static LogIn instance;
        string path = "users.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\users.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public LogIn()
        {
            InitializeComponent();
            instance = this;
           
            
        }
        //createDB
        //create the userhistory folder
        private void LogIn_Load(object sender, EventArgs e)
        {
            CreateDB();
            CreateFolder();
        }

        private void LgnButton_Click(object sender, EventArgs e)
        {
            //checks if there's input in boxes
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                //check usernames and password if it matches
                using (var con = new SQLiteConnection(cs))
                {
                    con.Open();

                    string selectQuery = "SELECT * FROM users WHERE Username = @Username AND Password = @Password";
                    using (var command = new SQLiteCommand(selectQuery, con))
                    {
                        command.Parameters.AddWithValue("@Username", txtUsername.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);

                        using (var mdr = command.ExecuteReader())
                        {
                            //if login successful update lastlogin
                            if (mdr.Read())
                            {
                                string query = "UPDATE users SET LastLogin = @LastLogin WHERE Username = @Username";
                                using (var updateCommand = new SQLiteCommand(query, con))
                                {
                                    updateCommand.Parameters.AddWithValue("@LastLogin", dateTimePicker1.Value.Date);
                                    updateCommand.Parameters.AddWithValue("@Username", txtUsername.Text);
                                    updateCommand.ExecuteNonQuery();
                                }

                                Authentication frm2 = new Authentication(txtUsername.Text);
                                
                                this.Hide();
                                mdr.Close();
                                frm2.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Login Information! Try again.");
                            }
                            
                        }
                    }
                    con.Close();
                }
            }
        }

        //goes to the account creation
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount frm3 = new CreateAccount();
            frm3.ShowDialog();
        }

        private void CreateDB()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table users (ID INTEGER, UID INTEGER, FirstName TEXT, LastName TEXT, Gender TEXT, Birthday DATE, email varchar(255), Username varchar(255), Password varchar(255), LastLogin DATE, Money INTEGER, PRIMARY KEY(id AUTOINCREMENT))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }

            }
            else
            {
                Console.WriteLine("Database already exists");
                return;
            }
        }

        private void CreateFolder()
        {
            string Location = @"" + Application.StartupPath;
            string path = System.IO.Path.Combine(Location, "UserHistory");
            System.IO.Directory.CreateDirectory(path);

        }

        
    }
}
