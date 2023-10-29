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
using MaterialSkin.Properties;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Data.SQLite;
using System.Drawing.Text;
using System.Windows.Forms.VisualStyles;
using System.Net.Mail;
using System.Collections;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using ZXing;
using ZXing.Common;
using ZXing.Datamatrix.Encoder;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Media;
using System.Text.RegularExpressions;

namespace BankApplication1
{
    public partial class LumiBank : MaterialForm
    {
        int UID, tempOtherID;
        string Sent, SentFor;
        int thisAccAmm, otherAccAmm;
        string pather = "users.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\users.db";
        public string username, email;
        private int Code;
        private SeriesCollection seriesCollection;
        private ChartValues<double> values;
        private Queue<double> updateQueue;
        private int maxUpdates = 4;

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public LumiBank()
        {
            InitializeComponent();
            initializeLineChart();
            this.username = username;
        }

        public LumiBank(String username) {
            InitializeComponent();
            this.username = username;
          initializeLineChart();

        
        
    }


        //on load, get a users UID, create their database, shows history data, get current account money and update the data on livechart
        private void DashBoard_Load(object sender, EventArgs e)
        {
            getUID();
            CreateDB();
            data_show();
            AmountGetterCurr();
            userEmail();
            currentMoney.Text = "PHP "+this.thisAccAmm;
            UIDtext.Text = "UID: "+this.UID.ToString();
            UpdateData(this.thisAccAmm);
            sentfr();
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Prefer to not say");
          
        }

        private void initializeLineChart() {
            values = new ChartValues<double>();
            var lineSeries = new LineSeries
            {
                Title = "Money",
                Values = values
            };

            seriesCollection = new SeriesCollection { lineSeries };
            cartesianChart1.Series = seriesCollection;

            // Initialize the updateQueue
            updateQueue = new Queue<double>();

            // Add some initial data points
            for (int i = 0; i < maxUpdates; i++)
            {
                values.Add(0);
            } 
          

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Money Records",
                LabelFormatter = value => value.ToString("C")
            });
            

            cartesianChart1.LegendLocation = LegendLocation.None;

           
        }
        //creates a new user history db based on there uid
        private void CreateDB()
        {

            string path = Application.StartupPath + "\\UserHistory\\" + UID + ".db";
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table history (Type TEXT, SentBy TEXT, SentTo TEXT, Amount INTEGER)";
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

        private void UpdateData(int newData)
        {
            // Add the new data to the update queue
            updateQueue.Enqueue(newData);

            // If the queue exceeds the maximum allowed updates, dequeue the oldest update
            if (updateQueue.Count > maxUpdates)
            {
                updateQueue.Dequeue();
            }

            // Update the ChartValues with the data from the update queue
            values.Clear();
            values.AddRange(updateQueue);

            // Refresh the chart
            cartesianChart1.Update();
        }
        //get UID 
        private void getUID()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string query = "SELECT UID FROM users WHERE Username = @Username;";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", this.username);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        this.UID = Int32.Parse(result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("No UID");
                        return;
                    }
                }
                con.Close();
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //when logout page is clicked, logout
        private void LogOutTabPage_Click(object sender, EventArgs e)
        {
          
        }
        //show history data
        private void data_show()
        {
            string cs2 = @"URI=file:" + Application.StartupPath + "\\UserHistory\\" + this.UID + ".db";

            using (var con = new SQLiteConnection(cs2))
            {
                con.Open();
                string stm = "SELECT * FROM history";

                using (var cmd = new SQLiteCommand(stm, con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3));
                        }
                        
                    }
                }
               
                con.Close();
            }
        }
        //tansfermoney on click
        private void TranferMoneyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //gets the other users tempID
                this.tempOtherID = Int32.Parse(userUID.Text);
                AmountGetterOther(this.tempOtherID);
                string email = "";
                //check if account amount is less than 0
                if ((this.thisAccAmm - Int32.Parse(TransferMoney.Text)) <= 0)
                {
                    MessageBox.Show("You have dont have enough money or in debt");
                    return;
                }
                else
                {
                    this.thisAccAmm = this.thisAccAmm - Int32.Parse(TransferMoney.Text);
                    if (this.thisAccAmm <= 0)
                    {
                        this.thisAccAmm = 0;
                    }


                    this.otherAccAmm = this.otherAccAmm + Int32.Parse(TransferMoney.Text);

                    if (this.otherAccAmm <= 0)
                    {
                        this.otherAccAmm = 0;
                    }
                    //update user databse to reflect money 
                    updateUsers();

                    string message = "You have been sent PHP" + TransferMoney.Text;
                    //send email and get the emails of sentTo and sentFrom
                    sendEmail(message, this.email);
                    sentTo(Int32.Parse(userUID.Text));
                   

                    //Insert into a users own history database
                    string cs2 = @"URI=file:" + Application.StartupPath + "\\UserHistory\\" + this.UID + ".db";
                    using (var con2 = new SQLiteConnection(cs2))
                    {
                        con2.Open();

                        using (var cmd = new SQLiteCommand(con2))
                        {
                        
                            string type = "Sent";
                            string sentBy = this.SentFor;
                            string sentTo = this.Sent;
                            int amount = Int32.Parse(TransferMoney.Text);

                            cmd.CommandText = "INSERT INTO history(Type, SentBy, SentTo, Amount) VALUES (@Type, @SentBy, @SentTo, @Amount)";
                            cmd.Parameters.AddWithValue("@Type", type);
                            cmd.Parameters.AddWithValue("@SentBy", sentBy);
                            cmd.Parameters.AddWithValue("@SentTo", sentTo);
                            cmd.Parameters.AddWithValue("@Amount", amount);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                dataGridView1.Rows.Clear();
                                data_show();
                            }
                            else
                            {
                                MessageBox.Show("Insert failed.");
                            }
                            con2.Close();
                        }
                    }

                    //Insert into a users own history database
                    string cs3 = @"URI=file:" + Application.StartupPath + "\\UserHistory\\" + Int32.Parse(userUID.Text) + ".db";

                    using (var con3 = new SQLiteConnection(cs3))
                    {
                        con3.Open();

                        using (var cmd2 = new SQLiteCommand(con3))
                        {
                            cmd2.CommandText = "INSERT INTO history(Type, SentBy, SentTo, Amount) VALUES (@Type, @SentBy, @SentTo, @Amount)";

                            string type1 = "Received";
                            int AMOUNT1 = Int32.Parse(TransferMoney.Text);

                            cmd2.Parameters.AddWithValue("@Type", type1);
                            cmd2.Parameters.AddWithValue("@SentBy", this.SentFor);
                            cmd2.Parameters.AddWithValue("@SentTo", this.Sent);
                            cmd2.Parameters.AddWithValue("@Amount", AMOUNT1);

                            // Execute the insert query
                            int rowsAffected = cmd2.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {


                            }
                            else
                            {
                                MessageBox.Show("Insert failed.");
                            }
                        }
                        con3.Close();
                    }

                    currentMoney.Text = "PHP " + this.thisAccAmm;
                    UpdateData(this.thisAccAmm);



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        //Withdraws money from databse
        private void materialButton1_Click(object sender, EventArgs e)
        {
            int withdrawAmount = Int32.Parse(withdraw.Text);
            this.thisAccAmm = this.thisAccAmm - withdrawAmount;
            if (this.thisAccAmm <= 0) {
                MessageBox.Show("You have no money or in debt");
            } else { 
                using (var con = new SQLiteConnection(cs)) {
                    con.Open();
                    using (var cmd = new SQLiteCommand(con)) {
                        try {
                            cmd.CommandText = "UPDATE users SET Money = @Money WHERE UID = @UID";
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@Money", thisAccAmm);
                            cmd.Parameters.AddWithValue("@UID", this.UID);
                            cmd.ExecuteNonQuery();
                        } catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                string cs2 = @"URI=file:" + Application.StartupPath + "\\UserHistory\\" + this.UID + ".db";
                using (var con2 = new SQLiteConnection(cs2))
                {
                    con2.Open();

                    using (var cmd = new SQLiteCommand(con2))
                    {

                        string type = "Withdraw";
                        string sentBy = this.SentFor;
                        int amount = Int32.Parse(withdraw.Text);

                        cmd.CommandText = "INSERT INTO history(Type, SentBy, SentTo, Amount) VALUES (@Type, @SentBy, @SentTo, @Amount)";
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@SentBy", sentBy);
                        cmd.Parameters.AddWithValue("@SentTo", sentBy);
                        cmd.Parameters.AddWithValue("@Amount", amount);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected <= 0)
                        {
                            MessageBox.Show("Insert failed.");

                        }
                      
                      
                        
                        con2.Close();
                    }
                }
                string message = "You have withdrawn PHP" + withdrawAmount;
            sendEmail(message, this.email);
            BarcodeGenerate(withdraw.Text);
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(new Bitmap(BarcodeBox.Image));
            if (result != null) {
                MoneyParse.Text = result.Text;
            }
                currentMoney.Text = "PHP " + this.thisAccAmm;
                UpdateData(this.thisAccAmm);
                dataGridView1.Rows.Clear();
                data_show();
            }
        }

        private void sentTo(int ID) {
            var con = new SQLiteConnection(cs);
            con.Open();
            string query = "SELECT email FROM users WHERE UID = '" + ID + "';";
            SQLiteCommand MyCommand2 = new SQLiteCommand(query, con);
            object result = MyCommand2.ExecuteScalar();

            if (result != null)
            {
                this.Sent = result.ToString();
            }
            else
            {
                MessageBox.Show("No UID");
                return;
            }

            con.Close();
        }
        private void sentfr()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string query = "SELECT email FROM users WHERE UID = @UID";

                using (SQLiteCommand MyCommand2 = new SQLiteCommand(query, con))
                {
                    MyCommand2.Parameters.AddWithValue("@UID", this.UID);

                    object result = MyCommand2.ExecuteScalar();

                    if (result != null)
                    {
                        this.SentFor = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No UID");
                        return;
                    }
                }
            }
        }


        //get current accounts money
        private void AmountGetterCurr()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string query = "SELECT Money FROM Users where UID = @UID;";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UID", this.UID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        this.thisAccAmm = Int32.Parse(result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("No UID");
                        return;
                    }
                }
            }
        }

        //get other accounts money for transfer
        private void AmountGetterOther(int ID)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string query = "SELECT Money FROM Users where UID = @UID;";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UID", ID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        this.otherAccAmm = Int32.Parse(result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("No UID");
                        return;
                    }
                }
            }
        }
        //update the user money row in database
        private void updateUsers()
        {


            using (var con1 = new SQLiteConnection(@"Data Source=" + pather))
            {
                con1.Open();
                using (var transaction = con1.BeginTransaction()) {
                    try
                    {
                        string query = @"
    UPDATE users
    SET Money = CASE
        WHEN UID = @uid1 THEN @amount1
        WHEN UID = @uid2 THEN @amount2
        ELSE Money
    END
    WHERE UID IN (@uid1, @uid2);";
                        using (var cmd1 = new SQLiteCommand(query, con1))
                        {
                            cmd1.Prepare();
                            cmd1.Parameters.AddWithValue("@uid1", this.UID);
                            cmd1.Parameters.AddWithValue("@amount1", this.thisAccAmm);
                            cmd1.Parameters.AddWithValue("@uid2", this.tempOtherID);
                            cmd1.Parameters.AddWithValue("@amount2", this.otherAccAmm);



                            cmd1.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }

                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                } 
            } 
        }
        //deposit the money on click
        private void depositMoney_Click(object sender, EventArgs e)
        {
            int deposited = Int32.Parse(Deposit.Text);
            
            this.thisAccAmm = this.thisAccAmm + deposited;

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    try
                    {
                        cmd.CommandText = "UPDATE users SET Money = @Money WHERE UID = @UID";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@Money", thisAccAmm);
                        cmd.Parameters.AddWithValue("@UID", this.UID);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            string cs2 = @"URI=file:" + Application.StartupPath + "\\UserHistory\\" + this.UID + ".db";
            using (var con2 = new SQLiteConnection(cs2))
            {
                con2.Open();

                using (var cmd = new SQLiteCommand(con2))
                {

                    string type = "Deposited";
                    string sentBy = this.SentFor;
                    int amount = Int32.Parse(Deposit.Text);

                    cmd.CommandText = "INSERT INTO history(Type, SentBy, SentTo, Amount) VALUES (@Type, @SentBy, @SentTo, @Amount)";
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@SentBy", sentBy);
                    cmd.Parameters.AddWithValue("@SentTo", sentBy);
                    cmd.Parameters.AddWithValue("@Amount", amount);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Insert failed.");
                    }
                    
                    
                    con2.Close();
                }
            }
            string message = "You have Deposited PHP" + Deposit.Text;
            sendEmail(message, this.email);
            BarcodeGenerateDeposit(Deposit.Text);
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(new Bitmap(qrcodeBox.Image));
            if (result != null)
            {
                depositparse.Text = result.Text;
            }
            currentMoney.Text = "PHP " + this.thisAccAmm;
            UpdateData(this.thisAccAmm);
            dataGridView1.Rows.Clear();
            data_show();
        }

    

        //sendEmail function
        public void sendEmail(string message,string email)
        {
            MailMessage mm = new MailMessage();
            SmtpClient sc = new SmtpClient("smtp.gmail.com");
            mm.From = new MailAddress("databasesender123@gmail.com");
            mm.To.Add(email);
            mm.Subject = "Money transferred";
            mm.Body = "You have been sent PHP" + TransferMoney.Text;
            sc.Port = 587;
            sc.Credentials = new System.Net.NetworkCredential("databasesender123@gmail.com", "lrix gpvb nnph kstm");
            sc.EnableSsl = true;
            sc.Send(mm);
        }
        //send user email
        public void userEmail() {

            using (var con = new SQLiteConnection(this.cs))
            {
                con.Open();
                string query = "SELECT email FROM users WHERE UID = @uid";
                SQLiteCommand emailCommand = new SQLiteCommand(query, con);
                emailCommand.Parameters.AddWithValue("@uid", this.UID);

                this.email = emailCommand.ExecuteScalar()?.ToString();

                con.Close(); // Close the connection after retrieving the email
            }
        }
        //generates barcodes
        public void BarcodeGenerate(string text) { 
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false};
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION,ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(text);
            Graphics g = Graphics.FromImage(bitmap);
            BarcodeBox.Image = bitmap;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LogIn form = new LogIn();
            this.Hide();
            form.ShowDialog();
        }

        private void update_account_Click(object sender, EventArgs e)
        {

            //checks for correct inputs
         
            if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }


            if (string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrEmpty(cboGender.Text)   || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtCPassword.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            { 

                    string iquery = "UPDATE users SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, Birthday = @Birthday, Password = @Password WHERE UID = @UserID";

                    using (var con1 = new SQLiteConnection(cs))
                    {
                        con1.Open();

                        using (var cmd = new SQLiteCommand(iquery, con1))
                        {
                            // Replace @FirstName, @LastName, @Gender, @Birthday, @Email, @Username, @Password, and @UserID with parameter values.
                            cmd.Parameters.AddWithValue("@FirstName", txtFName.Text);
                            cmd.Parameters.AddWithValue("@LastName", txtLName.Text);
                            cmd.Parameters.AddWithValue("@Gender", cboGender.Text);
                            cmd.Parameters.AddWithValue("@Birthday", dateTimePicker1.Value.Date);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@UserID", this.UID); // Provide the user's ID here

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Update success. Rows affected: " + rowsAffected);
                            }
                            else
                            {
                                MessageBox.Show("Update failed. User not found.");
                            }
                        }
                        con1.Close();
                    }

                

            }
        }
    

        public void BarcodeGenerateDeposit(string text)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(text);
            Graphics g = Graphics.FromImage(bitmap);
            qrcodeBox.Image = bitmap;
        }
        //only allow digit inputs
        public void Deposit_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the input if it's not a digit or a control character
            }

        }
        public void TransferMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the input if it's not a digit or a control character
            }
        }
        public void withdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the input if it's not a digit or a control character
            }
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
    }
  }
 
