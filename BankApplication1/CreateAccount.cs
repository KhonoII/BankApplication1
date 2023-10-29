
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin.Properties;
using System.Drawing.Text;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BankApplication1
{

    public partial class CreateAccount : MaterialForm
    {

        string path = "users.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\users.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
     
  

        public CreateAccount()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
         

        }
        //load items into the CBO box
        private void Form1_Load(object sender, EventArgs e)
        {
           
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Prefer to not say");

        }
        //create the account on click
        private void create_account_Click(object sender, EventArgs e)
        {
            Boolean isMoney;
            //checks for correct inputs
            if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }
           

            if (string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrEmpty(cboGender.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtCPassword.Text) || string.IsNullOrEmpty(StartMoney.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }
            else
            {
                using (var con = new SQLiteConnection(cs))
                {
                    con.Open();
                    using (var cmd1 = new SQLiteCommand("SELECT * FROM users WHERE Username = @UserName", con))
                    using (var cmd2 = new SQLiteCommand("SELECT * FROM users WHERE Email = @UserEmail", con))
                    {
                        cmd1.Parameters.AddWithValue("@UserName", txtUsername.Text);
                        cmd2.Parameters.AddWithValue("@UserEmail", txtEmail.Text);

                        bool userExists = false, mailExists = false;

                        using (var dr1 = cmd1.ExecuteReader())
                        {
                            if (userExists = dr1.HasRows)
                                MessageBox.Show("Username not available!");
                        }

                        using (var dr2 = cmd2.ExecuteReader())
                        {
                            if (mailExists = dr2.HasRows)
                                MessageBox.Show("Email not available!");
                        }

                        if (Int32.Parse(StartMoney.Text) < 100)
                        {
                            MessageBox.Show("Did not input the appropriate amount of money", "Error");
                            isMoney = true;
                        }
                        else
                        {
                            isMoney = false;
                        }

                        // Check if user or email does not exist
                        if (!(userExists || mailExists || isMoney))
                        {
                            Random random = new Random();
                            int ID;
                            while (true)
                            {
                                ID = random.Next(100000, 999999);

                                if (!IsRandomNumberUsed(con, ID))
                                {
                                    break;
                                }
                            }

                            string iquery = "INSERT INTO users(`UID`,`FirstName`,`LastName`,`Gender`,`Birthday`,`Email`,`Username`, `Password`,`Money`) VALUES (@ID, @FirstName, @LastName, @Gender, @Birthday, @Email, @Username, @Password, @StartMoney)";

                            using (var commandDatabase = new SQLiteCommand(iquery, con))
                            {
                                commandDatabase.Parameters.AddWithValue("@ID", ID);
                                commandDatabase.Parameters.AddWithValue("@FirstName", txtFName.Text);
                                commandDatabase.Parameters.AddWithValue("@LastName", txtLName.Text);
                                commandDatabase.Parameters.AddWithValue("@Gender", cboGender.Text);
                                commandDatabase.Parameters.AddWithValue("@Birthday", dateTimePicker1.Value.Date);
                                commandDatabase.Parameters.AddWithValue("@Email", txtEmail.Text);
                                commandDatabase.Parameters.AddWithValue("@Username", txtUsername.Text);
                                commandDatabase.Parameters.AddWithValue("@Password", txtPassword.Text);
                                commandDatabase.Parameters.AddWithValue("@StartMoney", StartMoney.Text);

                                commandDatabase.CommandTimeout = 60;

                                try
                                {
                                    SQLiteDataReader myReader = commandDatabase.ExecuteReader();
                                }
                                catch (Exception ex)
                                {
                                    // Show any error message.
                                    MessageBox.Show(ex.Message);
                                }
                            }

                            MessageBox.Show("Account Successfully Created!");
                            LogIn form = new LogIn();
                            this.Hide();
                            form.ShowDialog();
                        }
                    }
                }
            }

        }
        static bool IsRandomNumberUsed(SQLiteConnection connection, int randomNumber)
        {
            // Check if the random number already exists in the database.
            string query = "SELECT COUNT(*) FROM users WHERE UID = @RandomNumber";
            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@RandomNumber", randomNumber);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        //goes to login page
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn frm1 = new LogIn();   
            this.Hide();
            frm1.ShowDialog();
        }
        
        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Define a regex pattern to match special characters
            string pattern = @"[!@#\$%\^&\*\(\)_\+=\[{\]};:'"",<>\./?\\|]"; // You can add more special characters

            // Check if the pressed key is a digit or a special character
            if (char.IsDigit(e.KeyChar) || Regex.IsMatch(e.KeyChar.ToString(), pattern))
            {
                e.Handled = true; // Block the input
            }
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Define a regex pattern to match special characters
            string pattern = @"[!@#\$%\^&\*\(\)_\+=\[{\]};:'"",<>\./?\\|]"; 

            // Check if the pressed key is a digit or a special character
            if (char.IsDigit(e.KeyChar) || Regex.IsMatch(e.KeyChar.ToString(), pattern))
            {
                e.Handled = true; // Block the input
            }
        }
        private void StartMoney_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the input if it's not a digit or a control character
            }
        }
        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
