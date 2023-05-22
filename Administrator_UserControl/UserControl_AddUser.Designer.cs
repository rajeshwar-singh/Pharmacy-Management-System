
namespace WindowsFormsApp1.Administrator_UserControl
{
    partial class UserControl_AddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_AddUser));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddUser_userRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddUser_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddUser_mobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddUser_userName = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddUser_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddUser_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddUser_DOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddUser_btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.AddUser_btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB(Date of Birth)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile No";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(621, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(621, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // AddUser_userRole
            // 
            this.AddUser_userRole.BackColor = System.Drawing.Color.Transparent;
            this.AddUser_userRole.BorderColor = System.Drawing.Color.Black;
            this.AddUser_userRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AddUser_userRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddUser_userRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_userRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_userRole.FocusedState.Parent = this.AddUser_userRole;
            this.AddUser_userRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_userRole.ForeColor = System.Drawing.Color.Black;
            this.AddUser_userRole.HoverState.Parent = this.AddUser_userRole;
            this.AddUser_userRole.ItemHeight = 30;
            this.AddUser_userRole.Items.AddRange(new object[] {
            "Administrator",
            "Pharmacist"});
            this.AddUser_userRole.ItemsAppearance.Parent = this.AddUser_userRole;
            this.AddUser_userRole.Location = new System.Drawing.Point(106, 169);
            this.AddUser_userRole.Name = "AddUser_userRole";
            this.AddUser_userRole.ShadowDecoration.Parent = this.AddUser_userRole;
            this.AddUser_userRole.Size = new System.Drawing.Size(340, 36);
            this.AddUser_userRole.TabIndex = 8;
            this.AddUser_userRole.SelectedIndexChanged += new System.EventHandler(this.AddUser_userRole_SelectedIndexChanged);
            // 
            // AddUser_name
            // 
            this.AddUser_name.BorderColor = System.Drawing.Color.Black;
            this.AddUser_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddUser_name.DefaultText = "";
            this.AddUser_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddUser_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddUser_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUser_name.DisabledState.Parent = this.AddUser_name;
            this.AddUser_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUser_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_name.FocusedState.Parent = this.AddUser_name;
            this.AddUser_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_name.ForeColor = System.Drawing.Color.Black;
            this.AddUser_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_name.HoverState.Parent = this.AddUser_name;
            this.AddUser_name.Location = new System.Drawing.Point(106, 276);
            this.AddUser_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddUser_name.Name = "AddUser_name";
            this.AddUser_name.PasswordChar = '\0';
            this.AddUser_name.PlaceholderText = "";
            this.AddUser_name.SelectedText = "";
            this.AddUser_name.ShadowDecoration.Parent = this.AddUser_name;
            this.AddUser_name.Size = new System.Drawing.Size(340, 36);
            this.AddUser_name.TabIndex = 15;
            // 
            // AddUser_mobile
            // 
            this.AddUser_mobile.BorderColor = System.Drawing.Color.Black;
            this.AddUser_mobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddUser_mobile.DefaultText = "";
            this.AddUser_mobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddUser_mobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddUser_mobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUser_mobile.DisabledState.Parent = this.AddUser_mobile;
            this.AddUser_mobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUser_mobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_mobile.FocusedState.Parent = this.AddUser_mobile;
            this.AddUser_mobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_mobile.ForeColor = System.Drawing.Color.Black;
            this.AddUser_mobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_mobile.HoverState.Parent = this.AddUser_mobile;
            this.AddUser_mobile.Location = new System.Drawing.Point(106, 493);
            this.AddUser_mobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddUser_mobile.Name = "AddUser_mobile";
            this.AddUser_mobile.PasswordChar = '\0';
            this.AddUser_mobile.PlaceholderText = "";
            this.AddUser_mobile.SelectedText = "";
            this.AddUser_mobile.ShadowDecoration.Parent = this.AddUser_mobile;
            this.AddUser_mobile.Size = new System.Drawing.Size(340, 36);
            this.AddUser_mobile.TabIndex = 17;
            // 
            // AddUser_userName
            // 
            this.AddUser_userName.BorderColor = System.Drawing.Color.Black;
            this.AddUser_userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddUser_userName.DefaultText = "";
            this.AddUser_userName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddUser_userName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddUser_userName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUser_userName.DisabledState.Parent = this.AddUser_userName;
            this.AddUser_userName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUser_userName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_userName.FocusedState.Parent = this.AddUser_userName;
            this.AddUser_userName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_userName.ForeColor = System.Drawing.Color.Black;
            this.AddUser_userName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_userName.HoverState.Parent = this.AddUser_userName;
            this.AddUser_userName.Location = new System.Drawing.Point(626, 276);
            this.AddUser_userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddUser_userName.Name = "AddUser_userName";
            this.AddUser_userName.PasswordChar = '\0';
            this.AddUser_userName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.AddUser_userName.PlaceholderText = "";
            this.AddUser_userName.SelectedText = "";
            this.AddUser_userName.ShadowDecoration.Parent = this.AddUser_userName;
            this.AddUser_userName.Size = new System.Drawing.Size(340, 36);
            this.AddUser_userName.TabIndex = 18;
            this.AddUser_userName.TextChanged += new System.EventHandler(this.AddUser_userName_TextChanged);
            // 
            // AddUser_password
            // 
            this.AddUser_password.BorderColor = System.Drawing.Color.Black;
            this.AddUser_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddUser_password.DefaultText = "";
            this.AddUser_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddUser_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddUser_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUser_password.DisabledState.Parent = this.AddUser_password;
            this.AddUser_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUser_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_password.FocusedState.Parent = this.AddUser_password;
            this.AddUser_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_password.ForeColor = System.Drawing.Color.Black;
            this.AddUser_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_password.HoverState.Parent = this.AddUser_password;
            this.AddUser_password.Location = new System.Drawing.Point(624, 391);
            this.AddUser_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddUser_password.Name = "AddUser_password";
            this.AddUser_password.PasswordChar = '\0';
            this.AddUser_password.PlaceholderText = "";
            this.AddUser_password.SelectedText = "";
            this.AddUser_password.ShadowDecoration.Parent = this.AddUser_password;
            this.AddUser_password.Size = new System.Drawing.Size(340, 36);
            this.AddUser_password.TabIndex = 19;
            // 
            // AddUser_email
            // 
            this.AddUser_email.BorderColor = System.Drawing.Color.Black;
            this.AddUser_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddUser_email.DefaultText = "";
            this.AddUser_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddUser_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddUser_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUser_email.DisabledState.Parent = this.AddUser_email;
            this.AddUser_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUser_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_email.FocusedState.Parent = this.AddUser_email;
            this.AddUser_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_email.ForeColor = System.Drawing.Color.Black;
            this.AddUser_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUser_email.HoverState.Parent = this.AddUser_email;
            this.AddUser_email.Location = new System.Drawing.Point(626, 169);
            this.AddUser_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddUser_email.Name = "AddUser_email";
            this.AddUser_email.PasswordChar = '\0';
            this.AddUser_email.PlaceholderText = "";
            this.AddUser_email.SelectedText = "";
            this.AddUser_email.ShadowDecoration.Parent = this.AddUser_email;
            this.AddUser_email.Size = new System.Drawing.Size(340, 36);
            this.AddUser_email.TabIndex = 20;
            this.AddUser_email.TextChanged += new System.EventHandler(this.guna2TextBox6_TextChanged);
            // 
            // AddUser_DOB
            // 
            this.AddUser_DOB.BorderThickness = 1;
            this.AddUser_DOB.CheckedState.Parent = this.AddUser_DOB;
            this.AddUser_DOB.FillColor = System.Drawing.Color.White;
            this.AddUser_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.AddUser_DOB.HoverState.Parent = this.AddUser_DOB;
            this.AddUser_DOB.Location = new System.Drawing.Point(106, 391);
            this.AddUser_DOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.AddUser_DOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.AddUser_DOB.Name = "AddUser_DOB";
            this.AddUser_DOB.ShadowDecoration.Parent = this.AddUser_DOB;
            this.AddUser_DOB.Size = new System.Drawing.Size(340, 36);
            this.AddUser_DOB.TabIndex = 21;
            this.AddUser_DOB.Value = new System.DateTime(2023, 5, 20, 20, 31, 43, 1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Location = new System.Drawing.Point(539, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 523);
            this.panel1.TabIndex = 22;
            // 
            // AddUser_btnSignUp
            // 
            this.AddUser_btnSignUp.BorderRadius = 19;
            this.AddUser_btnSignUp.BorderThickness = 1;
            this.AddUser_btnSignUp.CheckedState.Parent = this.AddUser_btnSignUp;
            this.AddUser_btnSignUp.CustomImages.Parent = this.AddUser_btnSignUp;
            this.AddUser_btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_btnSignUp.ForeColor = System.Drawing.Color.White;
            this.AddUser_btnSignUp.HoverState.FillColor = System.Drawing.Color.White;
            this.AddUser_btnSignUp.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.AddUser_btnSignUp.HoverState.Parent = this.AddUser_btnSignUp;
            this.AddUser_btnSignUp.Image = ((System.Drawing.Image)(resources.GetObject("AddUser_btnSignUp.Image")));
            this.AddUser_btnSignUp.ImageSize = new System.Drawing.Size(30, 30);
            this.AddUser_btnSignUp.Location = new System.Drawing.Point(624, 484);
            this.AddUser_btnSignUp.Name = "AddUser_btnSignUp";
            this.AddUser_btnSignUp.ShadowDecoration.Parent = this.AddUser_btnSignUp;
            this.AddUser_btnSignUp.Size = new System.Drawing.Size(153, 45);
            this.AddUser_btnSignUp.TabIndex = 23;
            this.AddUser_btnSignUp.Text = "Sign Up";
            this.AddUser_btnSignUp.Click += new System.EventHandler(this.AddUser_btnSignUp_Click);
            // 
            // AddUser_btnReset
            // 
            this.AddUser_btnReset.BorderRadius = 19;
            this.AddUser_btnReset.BorderThickness = 1;
            this.AddUser_btnReset.CheckedState.Parent = this.AddUser_btnReset;
            this.AddUser_btnReset.CustomImages.Parent = this.AddUser_btnReset;
            this.AddUser_btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_btnReset.ForeColor = System.Drawing.Color.White;
            this.AddUser_btnReset.HoverState.FillColor = System.Drawing.Color.White;
            this.AddUser_btnReset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.AddUser_btnReset.HoverState.Parent = this.AddUser_btnReset;
            this.AddUser_btnReset.Image = ((System.Drawing.Image)(resources.GetObject("AddUser_btnReset.Image")));
            this.AddUser_btnReset.ImageSize = new System.Drawing.Size(30, 30);
            this.AddUser_btnReset.Location = new System.Drawing.Point(814, 484);
            this.AddUser_btnReset.Name = "AddUser_btnReset";
            this.AddUser_btnReset.ShadowDecoration.Parent = this.AddUser_btnReset;
            this.AddUser_btnReset.Size = new System.Drawing.Size(152, 45);
            this.AddUser_btnReset.TabIndex = 24;
            this.AddUser_btnReset.Text = "Reset";
            this.AddUser_btnReset.Click += new System.EventHandler(this.AddUser_reset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(987, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(680, 547);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "*Check User Role once before Sign Up";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // UserControl_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddUser_btnReset);
            this.Controls.Add(this.AddUser_btnSignUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddUser_DOB);
            this.Controls.Add(this.AddUser_email);
            this.Controls.Add(this.AddUser_password);
            this.Controls.Add(this.AddUser_userName);
            this.Controls.Add(this.AddUser_mobile);
            this.Controls.Add(this.AddUser_name);
            this.Controls.Add(this.AddUser_userRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_AddUser";
            this.Size = new System.Drawing.Size(1085, 726);
            this.Load += new System.EventHandler(this.UserControl_AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox AddUser_userRole;
        private Guna.UI2.WinForms.Guna2TextBox AddUser_name;
        private Guna.UI2.WinForms.Guna2TextBox AddUser_email;
        private Guna.UI2.WinForms.Guna2TextBox AddUser_password;
        private Guna.UI2.WinForms.Guna2TextBox AddUser_userName;
        private Guna.UI2.WinForms.Guna2TextBox AddUser_mobile;
        private Guna.UI2.WinForms.Guna2DateTimePicker AddUser_DOB;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button AddUser_btnSignUp;
        private Guna.UI2.WinForms.Guna2Button AddUser_btnReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
