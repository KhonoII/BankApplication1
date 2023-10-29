using System.Windows.Forms;

namespace BankApplication1
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtFName = new MaterialSkin.Controls.MaterialTextBox();
            this.cboGender = new MaterialSkin.Controls.MaterialComboBox();
            this.txtLName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.create_account = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.StartMoney = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-request-money-64.png");
            this.imageList1.Images.SetKeyName(1, "icons8-withdrawal-limit-80.png");
            this.imageList1.Images.SetKeyName(2, "icons8-data-transfer-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-male-user-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-home.gif");
            this.imageList1.Images.SetKeyName(5, "BankCreate.png");
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel2.Location = new System.Drawing.Point(424, 152);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(140, 14);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "already have an account?";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(522, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Get Started";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto", 10F);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(643, 148);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 24);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log In";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtFName
            // 
            this.txtFName.AnimateReadOnly = false;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFName.Depth = 0;
            this.txtFName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFName.Hint = "First Name";
            this.txtFName.LeadingIcon = null;
            this.txtFName.Location = new System.Drawing.Point(176, 194);
            this.txtFName.MaxLength = 50;
            this.txtFName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFName.Multiline = false;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(305, 50);
            this.txtFName.TabIndex = 6;
            this.txtFName.Text = "";
            this.txtFName.TrailingIcon = null;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
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
            this.cboGender.Location = new System.Drawing.Point(176, 381);
            this.cboGender.MaxDropDownItems = 4;
            this.cboGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(305, 49);
            this.cboGender.StartIndex = 0;
            this.cboGender.TabIndex = 7;
            // 
            // txtLName
            // 
            this.txtLName.AnimateReadOnly = false;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLName.Depth = 0;
            this.txtLName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLName.Hint = "Last Name";
            this.txtLName.LeadingIcon = null;
            this.txtLName.Location = new System.Drawing.Point(710, 194);
            this.txtLName.MaxLength = 50;
            this.txtLName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLName.Multiline = false;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(323, 50);
            this.txtLName.TabIndex = 8;
            this.txtLName.Text = "";
            this.txtLName.TrailingIcon = null;
            this.txtLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLName_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(176, 285);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 50);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Username";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(710, 285);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(323, 50);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Password";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(710, 380);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(323, 50);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtCPassword
            // 
            this.txtCPassword.AnimateReadOnly = false;
            this.txtCPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPassword.Depth = 0;
            this.txtCPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPassword.Hint = "Confirm Password";
            this.txtCPassword.LeadingIcon = null;
            this.txtCPassword.Location = new System.Drawing.Point(176, 493);
            this.txtCPassword.MaxLength = 50;
            this.txtCPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCPassword.Multiline = false;
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Password = true;
            this.txtCPassword.Size = new System.Drawing.Size(298, 50);
            this.txtCPassword.TabIndex = 13;
            this.txtCPassword.Text = "";
            this.txtCPassword.TrailingIcon = null;
            // 
            // create_account
            // 
            this.create_account.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.create_account.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.create_account.Depth = 0;
            this.create_account.HighEmphasis = true;
            this.create_account.Icon = null;
            this.create_account.Location = new System.Drawing.Point(490, 685);
            this.create_account.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.create_account.MouseState = MaterialSkin.MouseState.HOVER;
            this.create_account.Name = "create_account";
            this.create_account.NoAccentTextColor = System.Drawing.Color.Empty;
            this.create_account.Size = new System.Drawing.Size(147, 36);
            this.create_account.TabIndex = 14;
            this.create_account.Text = "Create Account";
            this.create_account.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.create_account.UseAccentColor = false;
            this.create_account.UseVisualStyleBackColor = true;
            this.create_account.Click += new System.EventHandler(this.create_account_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(424, 632);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(373, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel3.Location = new System.Drawing.Point(541, 600);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 14);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Date of Birth";
            // 
            // StartMoney
            // 
            this.StartMoney.AnimateReadOnly = false;
            this.StartMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartMoney.Depth = 0;
            this.StartMoney.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StartMoney.Hint = "Deposit Money (Minimum 100)";
            this.StartMoney.LeadingIcon = null;
            this.StartMoney.Location = new System.Drawing.Point(710, 493);
            this.StartMoney.MaxLength = 50;
            this.StartMoney.MouseState = MaterialSkin.MouseState.OUT;
            this.StartMoney.Multiline = false;
            this.StartMoney.Name = "StartMoney";
            this.StartMoney.Size = new System.Drawing.Size(323, 50);
            this.StartMoney.TabIndex = 17;
            this.StartMoney.Text = "";
            this.StartMoney.TrailingIcon = null;
            this.StartMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartMoney_KeyPress);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 770);
            this.Controls.Add(this.StartMoney);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.create_account);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Name = "CreateAccount";
            this.Sizable = false;
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtFName;
        private MaterialSkin.Controls.MaterialComboBox cboGender;
        private MaterialSkin.Controls.MaterialTextBox txtLName;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtCPassword;
        private MaterialSkin.Controls.MaterialButton create_account;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox StartMoney;
    }
}

