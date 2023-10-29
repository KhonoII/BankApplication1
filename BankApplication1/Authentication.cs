using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using System.Net.Mail;
using System.Data.SQLite;
using System.Web.UI.WebControls;
using System.Collections;

namespace BankApplication1
{
    public partial class Authentication : MaterialForm
    {
       
        public string username;
        string path = "users.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\users.db";
        private int Code;

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Authentication()
        {
            InitializeComponent();
         

        }

        public Authentication(String data) { 
            InitializeComponent();
            this.username = data;
        }

        private void Authentication_Load(object sender, EventArgs e)
        {

            //when loaded send email
            Random random = new Random();
            this.Code = random.Next(100000, 999999);

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string query = "SELECT email FROM users WHERE Username = @username";

                using (var MyCommand2 = new SQLiteCommand(query, con))
                {
                    MyCommand2.Parameters.AddWithValue("@username", this.username);
                    string emailAddress = MyCommand2.ExecuteScalar()?.ToString();

                    using (var mm = new MailMessage())
                    using (var sc = new SmtpClient("smtp.gmail.com"))
                    {
                        mm.From = new MailAddress("databasesender123@gmail.com");
                        mm.To.Add(emailAddress);
                        mm.Subject = "Code to access Dashboard";
                        mm.Body = "Your access code is " + this.Code;
                        sc.Port = 587;
                        sc.Credentials = new System.Net.NetworkCredential("databasesender123@gmail.com", "lrix gpvb nnph kstm");
                        sc.EnableSsl = true;
                        sc.Send(mm);
                    }
                }
                con.Close();
            }

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
       
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            //if code from email is correct goto dashboard
            if (EnterCode.Text == this.Code.ToString())
            {
                
                this.Hide();
                LumiBank form = new LumiBank(username);
                form.ShowDialog();
               

            }
            else {
                MessageBox.Show("You have entered the wrong code please resend a new one");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //create a random code and send to an email
            Random random = new Random();
            this.Code = random.Next(100000, 999999);

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string query = "SELECT email FROM users WHERE Username = @username";

                using (var MyCommand2 = new SQLiteCommand(query, con))
                {
                    MyCommand2.Parameters.AddWithValue("@username", this.username);
                    string emailAddress = MyCommand2.ExecuteScalar()?.ToString();

                    using (var mm = new MailMessage())
                    using (var sc = new SmtpClient("smtp.gmail.com"))
                    {
                        mm.From = new MailAddress("databasesender123@gmail.com");
                        mm.To.Add(emailAddress);
                        mm.Subject = "Code to access Dashboard";
                        mm.Body = "Your access code is " + this.Code;
                        sc.Port = 587;
                        sc.Credentials = new System.Net.NetworkCredential("databasesender123@gmail.com", "lrix gpvb nnph kstm");
                        sc.EnableSsl = true;
                        sc.Send(mm);
                    }
                }
                con.Close();
            }
        }
    }
}
