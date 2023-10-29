namespace BankApplication1
{
    partial class LumiBank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LumiBank));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SentFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SentTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.UIDtext = new MaterialSkin.Controls.MaterialLabel();
            this.currentMoney = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.userUID = new MaterialSkin.Controls.MaterialTextBox();
            this.TransferMoney = new MaterialSkin.Controls.MaterialTextBox();
            this.TransferMoneyBtn = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.MoneyParse = new MaterialSkin.Controls.MaterialTextBox();
            this.BarcodeBox = new System.Windows.Forms.PictureBox();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.withdraw = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.depositparse = new MaterialSkin.Controls.MaterialTextBox();
            this.qrcodeBox = new System.Windows.Forms.PictureBox();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.Deposit = new MaterialSkin.Controls.MaterialTextBox();
            this.depositMoney = new MaterialSkin.Controls.MaterialButton();
            this.LogOutTabPage = new System.Windows.Forms.TabPage();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.update_account = new MaterialSkin.Controls.MaterialButton();
            this.txtCPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLName = new MaterialSkin.Controls.MaterialTextBox();
            this.cboGender = new MaterialSkin.Controls.MaterialComboBox();
            this.txtFName = new MaterialSkin.Controls.MaterialTextBox();
            this.logout = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBox)).BeginInit();
            this.materialCard4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrcodeBox)).BeginInit();
            this.materialCard7.SuspendLayout();
            this.LogOutTabPage.SuspendLayout();
            this.materialCard8.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.LogOutTabPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1421, 766);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ImageKey = "icons8-bank-100.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1413, 733);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.cartesianChart1);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(40, 328);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(590, 395);
            this.materialCard2.TabIndex = 2;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(0, 76);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(560, 293);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(223, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 29);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Statistics";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.SentFrom,
            this.SentTo,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(663, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(664, 339);
            this.dataGridView1.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // SentFrom
            // 
            this.SentFrom.HeaderText = "Sent From";
            this.SentFrom.MinimumWidth = 8;
            this.SentFrom.Name = "SentFrom";
            this.SentFrom.Width = 150;
            // 
            // SentTo
            // 
            this.SentTo.HeaderText = "SentTo";
            this.SentTo.MinimumWidth = 8;
            this.SentTo.Name = "SentTo";
            this.SentTo.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 150;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.UIDtext);
            this.materialCard1.Controls.Add(this.currentMoney);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(97, 31);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1113, 250);
            this.materialCard1.TabIndex = 0;
            // 
            // UIDtext
            // 
            this.UIDtext.AutoSize = true;
            this.UIDtext.Depth = 0;
            this.UIDtext.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UIDtext.Location = new System.Drawing.Point(499, 223);
            this.UIDtext.MouseState = MaterialSkin.MouseState.HOVER;
            this.UIDtext.Name = "UIDtext";
            this.UIDtext.Size = new System.Drawing.Size(84, 19);
            this.UIDtext.TabIndex = 2;
            this.UIDtext.Text = "UID:000000";
            // 
            // currentMoney
            // 
            this.currentMoney.AutoSize = true;
            this.currentMoney.Depth = 0;
            this.currentMoney.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.currentMoney.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.currentMoney.Location = new System.Drawing.Point(434, 86);
            this.currentMoney.MouseState = MaterialSkin.MouseState.HOVER;
            this.currentMoney.Name = "currentMoney";
            this.currentMoney.Size = new System.Drawing.Size(87, 29);
            this.currentMoney.TabIndex = 1;
            this.currentMoney.Text = "PHP100";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(461, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(158, 29);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Current Money";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialCard3);
            this.tabPage2.Controls.Add(this.TransferMoneyBtn);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.ImageKey = "icons8-transfer-100.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1413, 733);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transfer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.userUID);
            this.materialCard3.Controls.Add(this.TransferMoney);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(164, 135);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1037, 131);
            this.materialCard3.TabIndex = 11;
            // 
            // userUID
            // 
            this.userUID.AnimateReadOnly = false;
            this.userUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userUID.Depth = 0;
            this.userUID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userUID.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.userUID.Hint = "Enter user UID";
            this.userUID.LeadingIcon = null;
            this.userUID.Location = new System.Drawing.Point(44, 45);
            this.userUID.MaxLength = 50;
            this.userUID.MouseState = MaterialSkin.MouseState.OUT;
            this.userUID.Multiline = false;
            this.userUID.Name = "userUID";
            this.userUID.Size = new System.Drawing.Size(316, 50);
            this.userUID.TabIndex = 0;
            this.userUID.Text = "";
            this.userUID.TrailingIcon = null;
            // 
            // TransferMoney
            // 
            this.TransferMoney.AnimateReadOnly = false;
            this.TransferMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransferMoney.Depth = 0;
            this.TransferMoney.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TransferMoney.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TransferMoney.Hint = "Enter Money (Cannot Exceed current money)";
            this.TransferMoney.LeadingIcon = null;
            this.TransferMoney.Location = new System.Drawing.Point(654, 45);
            this.TransferMoney.MaxLength = 50;
            this.TransferMoney.MouseState = MaterialSkin.MouseState.OUT;
            this.TransferMoney.Multiline = false;
            this.TransferMoney.Name = "TransferMoney";
            this.TransferMoney.Size = new System.Drawing.Size(310, 50);
            this.TransferMoney.TabIndex = 1;
            this.TransferMoney.Text = "";
            this.TransferMoney.TrailingIcon = null;
            this.TransferMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransferMoney_KeyPress);
            // 
            // TransferMoneyBtn
            // 
            this.TransferMoneyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TransferMoneyBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.TransferMoneyBtn.Depth = 0;
            this.TransferMoneyBtn.HighEmphasis = true;
            this.TransferMoneyBtn.Icon = null;
            this.TransferMoneyBtn.Location = new System.Drawing.Point(585, 340);
            this.TransferMoneyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TransferMoneyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TransferMoneyBtn.Name = "TransferMoneyBtn";
            this.TransferMoneyBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.TransferMoneyBtn.Size = new System.Drawing.Size(149, 36);
            this.TransferMoneyBtn.TabIndex = 10;
            this.TransferMoneyBtn.Text = "Transfer Money";
            this.TransferMoneyBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TransferMoneyBtn.UseAccentColor = false;
            this.TransferMoneyBtn.UseVisualStyleBackColor = true;
            this.TransferMoneyBtn.Click += new System.EventHandler(this.TranferMoneyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transfer Money";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialCard5);
            this.tabPage3.Controls.Add(this.BarcodeBox);
            this.tabPage3.Controls.Add(this.materialCard4);
            this.tabPage3.ImageKey = "1682308.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1413, 733);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Withdraw";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.MoneyParse);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(719, 537);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(315, 129);
            this.materialCard5.TabIndex = 5;
            // 
            // MoneyParse
            // 
            this.MoneyParse.AnimateReadOnly = false;
            this.MoneyParse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoneyParse.Depth = 0;
            this.MoneyParse.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MoneyParse.LeadingIcon = null;
            this.MoneyParse.Location = new System.Drawing.Point(26, 33);
            this.MoneyParse.MaxLength = 50;
            this.MoneyParse.MouseState = MaterialSkin.MouseState.OUT;
            this.MoneyParse.Multiline = false;
            this.MoneyParse.Name = "MoneyParse";
            this.MoneyParse.ReadOnly = true;
            this.MoneyParse.Size = new System.Drawing.Size(273, 50);
            this.MoneyParse.TabIndex = 4;
            this.MoneyParse.Text = "";
            this.MoneyParse.TrailingIcon = null;
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.Location = new System.Drawing.Point(618, 30);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(646, 498);
            this.BarcodeBox.TabIndex = 3;
            this.BarcodeBox.TabStop = false;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.withdraw);
            this.materialCard4.Controls.Add(this.materialButton1);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(93, 175);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(429, 282);
            this.materialCard4.TabIndex = 2;
            // 
            // withdraw
            // 
            this.withdraw.AnimateReadOnly = false;
            this.withdraw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.withdraw.Depth = 0;
            this.withdraw.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.withdraw.Hint = "withdraw";
            this.withdraw.LeadingIcon = null;
            this.withdraw.Location = new System.Drawing.Point(32, 34);
            this.withdraw.MaxLength = 50;
            this.withdraw.MouseState = MaterialSkin.MouseState.OUT;
            this.withdraw.Multiline = false;
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(380, 50);
            this.withdraw.TabIndex = 0;
            this.withdraw.Text = "";
            this.withdraw.TrailingIcon = null;
            this.withdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.withdraw_KeyPress);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(163, 148);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(100, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Withdraw";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialCard6);
            this.tabPage4.Controls.Add(this.qrcodeBox);
            this.tabPage4.Controls.Add(this.materialCard7);
            this.tabPage4.ImageKey = "icons8-deposit-100.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1413, 733);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Deposit";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.depositparse);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(713, 558);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(315, 129);
            this.materialCard6.TabIndex = 8;
            // 
            // depositparse
            // 
            this.depositparse.AnimateReadOnly = false;
            this.depositparse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depositparse.Depth = 0;
            this.depositparse.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.depositparse.LeadingIcon = null;
            this.depositparse.Location = new System.Drawing.Point(23, 33);
            this.depositparse.MaxLength = 50;
            this.depositparse.MouseState = MaterialSkin.MouseState.OUT;
            this.depositparse.Multiline = false;
            this.depositparse.Name = "depositparse";
            this.depositparse.ReadOnly = true;
            this.depositparse.Size = new System.Drawing.Size(273, 50);
            this.depositparse.TabIndex = 4;
            this.depositparse.Text = "";
            this.depositparse.TrailingIcon = null;
            // 
            // qrcodeBox
            // 
            this.qrcodeBox.Location = new System.Drawing.Point(646, 48);
            this.qrcodeBox.Name = "qrcodeBox";
            this.qrcodeBox.Size = new System.Drawing.Size(646, 498);
            this.qrcodeBox.TabIndex = 7;
            this.qrcodeBox.TabStop = false;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.Deposit);
            this.materialCard7.Controls.Add(this.depositMoney);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(121, 193);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(429, 282);
            this.materialCard7.TabIndex = 6;
            // 
            // Deposit
            // 
            this.Deposit.AnimateReadOnly = false;
            this.Deposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Deposit.Depth = 0;
            this.Deposit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Deposit.Hint = "deposit";
            this.Deposit.LeadingIcon = null;
            this.Deposit.Location = new System.Drawing.Point(32, 34);
            this.Deposit.MaxLength = 50;
            this.Deposit.MouseState = MaterialSkin.MouseState.OUT;
            this.Deposit.Multiline = false;
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(380, 50);
            this.Deposit.TabIndex = 0;
            this.Deposit.Text = "";
            this.Deposit.TrailingIcon = null;
            this.Deposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Deposit_KeyPress);
            // 
            // depositMoney
            // 
            this.depositMoney.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.depositMoney.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.depositMoney.Depth = 0;
            this.depositMoney.HighEmphasis = true;
            this.depositMoney.Icon = null;
            this.depositMoney.Location = new System.Drawing.Point(163, 148);
            this.depositMoney.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.depositMoney.MouseState = MaterialSkin.MouseState.HOVER;
            this.depositMoney.Name = "depositMoney";
            this.depositMoney.NoAccentTextColor = System.Drawing.Color.Empty;
            this.depositMoney.Size = new System.Drawing.Size(81, 36);
            this.depositMoney.TabIndex = 1;
            this.depositMoney.Text = "Deposit";
            this.depositMoney.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.depositMoney.UseAccentColor = false;
            this.depositMoney.UseVisualStyleBackColor = true;
            this.depositMoney.Click += new System.EventHandler(this.depositMoney_Click);
            // 
            // LogOutTabPage
            // 
            this.LogOutTabPage.Controls.Add(this.materialCard8);
            this.LogOutTabPage.Controls.Add(this.logout);
            this.LogOutTabPage.ImageKey = "icons8-power-100.png";
            this.LogOutTabPage.Location = new System.Drawing.Point(4, 29);
            this.LogOutTabPage.Name = "LogOutTabPage";
            this.LogOutTabPage.Size = new System.Drawing.Size(1413, 733);
            this.LogOutTabPage.TabIndex = 4;
            this.LogOutTabPage.Text = "Settings || LogOut";
            this.LogOutTabPage.UseVisualStyleBackColor = true;
            this.LogOutTabPage.Click += new System.EventHandler(this.LogOutTabPage_Click);
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.materialLabel3);
            this.materialCard8.Controls.Add(this.dateTimePicker1);
            this.materialCard8.Controls.Add(this.update_account);
            this.materialCard8.Controls.Add(this.txtCPassword);
            this.materialCard8.Controls.Add(this.txtPassword);
            this.materialCard8.Controls.Add(this.txtLName);
            this.materialCard8.Controls.Add(this.cboGender);
            this.materialCard8.Controls.Add(this.txtFName);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(170, 46);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(1063, 586);
            this.materialCard8.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel3.Location = new System.Drawing.Point(726, 277);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 14);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(611, 311);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(323, 26);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // update_account
            // 
            this.update_account.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.update_account.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.update_account.Depth = 0;
            this.update_account.HighEmphasis = true;
            this.update_account.Icon = null;
            this.update_account.Location = new System.Drawing.Point(432, 395);
            this.update_account.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.update_account.MouseState = MaterialSkin.MouseState.HOVER;
            this.update_account.Name = "update_account";
            this.update_account.NoAccentTextColor = System.Drawing.Color.Empty;
            this.update_account.Size = new System.Drawing.Size(149, 36);
            this.update_account.TabIndex = 25;
            this.update_account.Text = "Update account";
            this.update_account.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.update_account.UseAccentColor = false;
            this.update_account.UseVisualStyleBackColor = true;
            this.update_account.Click += new System.EventHandler(this.update_account_Click);
            // 
            // txtCPassword
            // 
            this.txtCPassword.AnimateReadOnly = false;
            this.txtCPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPassword.Depth = 0;
            this.txtCPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPassword.Hint = "Confirm Password";
            this.txtCPassword.LeadingIcon = null;
            this.txtCPassword.Location = new System.Drawing.Point(84, 277);
            this.txtCPassword.MaxLength = 50;
            this.txtCPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCPassword.Multiline = false;
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Password = true;
            this.txtCPassword.Size = new System.Drawing.Size(298, 50);
            this.txtCPassword.TabIndex = 24;
            this.txtCPassword.Text = "";
            this.txtCPassword.TrailingIcon = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Password";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(611, 156);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(323, 50);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtLName
            // 
            this.txtLName.AnimateReadOnly = false;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLName.Depth = 0;
            this.txtLName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLName.Hint = "Last Name";
            this.txtLName.LeadingIcon = null;
            this.txtLName.Location = new System.Drawing.Point(611, 21);
            this.txtLName.MaxLength = 50;
            this.txtLName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLName.Multiline = false;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(323, 50);
            this.txtLName.TabIndex = 20;
            this.txtLName.Text = "";
            this.txtLName.TrailingIcon = null;
            // 
            // cboGender
            // 
            this.cboGender.AutoResize = false;
            this.cboGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGender.Depth = 0;
            this.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboGender.DropDownHeight = 174;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.DropDownWidth = 121;
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Hint = "Gender";
            this.cboGender.IntegralHeight = false;
            this.cboGender.ItemHeight = 43;
            this.cboGender.Location = new System.Drawing.Point(77, 135);
            this.cboGender.MaxDropDownItems = 4;
            this.cboGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(305, 49);
            this.cboGender.StartIndex = 0;
            this.cboGender.TabIndex = 19;
            // 
            // txtFName
            // 
            this.txtFName.AnimateReadOnly = false;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFName.Depth = 0;
            this.txtFName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFName.Hint = "First Name";
            this.txtFName.LeadingIcon = null;
            this.txtFName.Location = new System.Drawing.Point(77, 21);
            this.txtFName.MaxLength = 50;
            this.txtFName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFName.Multiline = false;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(305, 50);
            this.txtFName.TabIndex = 18;
            this.txtFName.Text = "";
            this.txtFName.TrailingIcon = null;
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
            // 
            // logout
            // 
            this.logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logout.Depth = 0;
            this.logout.HighEmphasis = true;
            this.logout.Icon = null;
            this.logout.Location = new System.Drawing.Point(45, 674);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logout.MouseState = MaterialSkin.MouseState.HOVER;
            this.logout.Name = "logout";
            this.logout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logout.Size = new System.Drawing.Size(78, 36);
            this.logout.TabIndex = 0;
            this.logout.Text = "logout";
            this.logout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logout.UseAccentColor = false;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "istockphoto-1382305677-612x612 (1).png");
            this.imageList1.Images.SetKeyName(1, "istockphoto-1382305677-612x612 (1)-fotor-bg-remover-20231024224016.png");
            this.imageList1.Images.SetKeyName(2, "istockphoto-1382305677-612x612 (1).jpg");
            this.imageList1.Images.SetKeyName(3, "istockphoto-1382305677-612x612.jpg");
            this.imageList1.Images.SetKeyName(4, "BankCreate1.png");
            this.imageList1.Images.SetKeyName(5, "BankCreate.png");
            this.imageList1.Images.SetKeyName(6, "icons8-request-money-64.png");
            this.imageList1.Images.SetKeyName(7, "icons8-withdrawal-limit-80.png");
            this.imageList1.Images.SetKeyName(8, "icons8-data-transfer-48.png");
            this.imageList1.Images.SetKeyName(9, "icons8-male-user-48.png");
            this.imageList1.Images.SetKeyName(10, "icons8-home.gif");
            this.imageList1.Images.SetKeyName(11, "icons8-deposit-100.png");
            this.imageList1.Images.SetKeyName(12, "icons8-withdrawal-limit-100.png");
            this.imageList1.Images.SetKeyName(13, "icons8-transfer-100.png");
            this.imageList1.Images.SetKeyName(14, "icons8-bank-100.png");
            this.imageList1.Images.SetKeyName(15, "1682308.png");
            this.imageList1.Images.SetKeyName(16, "icons8-power-100.png");
            // 
            // LumiBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1427, 833);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "LumiBank";
            this.Text = "LumiBank";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBox)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrcodeBox)).EndInit();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.LogOutTabPage.ResumeLayout(false);
            this.LogOutTabPage.PerformLayout();
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage LogOutTabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn SentFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn SentTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private MaterialSkin.Controls.MaterialTextBox TransferMoney;
        private MaterialSkin.Controls.MaterialTextBox userUID;
        private MaterialSkin.Controls.MaterialButton TransferMoneyBtn;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox withdraw;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.PictureBox BarcodeBox;
        private MaterialSkin.Controls.MaterialTextBox MoneyParse;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialTextBox depositparse;
        private System.Windows.Forms.PictureBox qrcodeBox;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialTextBox Deposit;
        private MaterialSkin.Controls.MaterialButton depositMoney;
        private MaterialSkin.Controls.MaterialLabel currentMoney;
        private MaterialSkin.Controls.MaterialLabel UIDtext;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private MaterialSkin.Controls.MaterialButton logout;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialButton update_account;
        private MaterialSkin.Controls.MaterialTextBox txtCPassword;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtLName;
        private MaterialSkin.Controls.MaterialComboBox cboGender;
        private MaterialSkin.Controls.MaterialTextBox txtFName;
    }
    }