
namespace WindowsFormsApp1.Administrator_UserControl
{
    partial class UserControl_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Profile));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profile_userName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.profile_userRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.profile_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.profile_DOB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.profile_Mobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.profile_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.profile_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.profile_btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.profile_btnReset = new Guna.UI2.WinForms.Guna2Button();
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
            this.label1.Location = new System.Drawing.Point(134, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // profile_userName
            // 
            this.profile_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_userName.Location = new System.Drawing.Point(179, 435);
            this.profile_userName.Name = "profile_userName";
            this.profile_userName.Size = new System.Drawing.Size(219, 27);
            this.profile_userName.TabIndex = 2;
            this.profile_userName.Text = "username";
            this.profile_userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profile_userName.Click += new System.EventHandler(this.profile_userName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Role";
            // 
            // profile_userRole
            // 
            this.profile_userRole.BackColor = System.Drawing.Color.Transparent;
            this.profile_userRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.profile_userRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profile_userRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_userRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_userRole.FocusedState.Parent = this.profile_userRole;
            this.profile_userRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_userRole.ForeColor = System.Drawing.Color.Black;
            this.profile_userRole.HoverState.Parent = this.profile_userRole;
            this.profile_userRole.ItemHeight = 30;
            this.profile_userRole.Items.AddRange(new object[] {
            "Administrator",
            "Pharmacist"});
            this.profile_userRole.ItemsAppearance.Parent = this.profile_userRole;
            this.profile_userRole.Location = new System.Drawing.Point(572, 71);
            this.profile_userRole.Name = "profile_userRole";
            this.profile_userRole.ShadowDecoration.Parent = this.profile_userRole;
            this.profile_userRole.Size = new System.Drawing.Size(357, 36);
            this.profile_userRole.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // profile_Name
            // 
            this.profile_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profile_Name.DefaultText = "";
            this.profile_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.profile_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.profile_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profile_Name.DisabledState.Parent = this.profile_Name;
            this.profile_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profile_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_Name.FocusedState.Parent = this.profile_Name;
            this.profile_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_Name.ForeColor = System.Drawing.Color.Black;
            this.profile_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_Name.HoverState.Parent = this.profile_Name;
            this.profile_Name.Location = new System.Drawing.Point(572, 164);
            this.profile_Name.Name = "profile_Name";
            this.profile_Name.PasswordChar = '\0';
            this.profile_Name.PlaceholderText = "";
            this.profile_Name.SelectedText = "";
            this.profile_Name.ShadowDecoration.Parent = this.profile_Name;
            this.profile_Name.Size = new System.Drawing.Size(357, 36);
            this.profile_Name.TabIndex = 6;
            // 
            // profile_DOB
            // 
            this.profile_DOB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profile_DOB.DefaultText = "";
            this.profile_DOB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.profile_DOB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.profile_DOB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profile_DOB.DisabledState.Parent = this.profile_DOB;
            this.profile_DOB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profile_DOB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_DOB.FocusedState.Parent = this.profile_DOB;
            this.profile_DOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_DOB.ForeColor = System.Drawing.Color.Black;
            this.profile_DOB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_DOB.HoverState.Parent = this.profile_DOB;
            this.profile_DOB.Location = new System.Drawing.Point(572, 252);
            this.profile_DOB.Name = "profile_DOB";
            this.profile_DOB.PasswordChar = '\0';
            this.profile_DOB.PlaceholderText = "";
            this.profile_DOB.SelectedText = "";
            this.profile_DOB.ShadowDecoration.Parent = this.profile_DOB;
            this.profile_DOB.Size = new System.Drawing.Size(357, 36);
            this.profile_DOB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "DOB (Date Of Birth)";
            // 
            // profile_Mobile
            // 
            this.profile_Mobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profile_Mobile.DefaultText = "";
            this.profile_Mobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.profile_Mobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.profile_Mobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profile_Mobile.DisabledState.Parent = this.profile_Mobile;
            this.profile_Mobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profile_Mobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_Mobile.FocusedState.Parent = this.profile_Mobile;
            this.profile_Mobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_Mobile.ForeColor = System.Drawing.Color.Black;
            this.profile_Mobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_Mobile.HoverState.Parent = this.profile_Mobile;
            this.profile_Mobile.Location = new System.Drawing.Point(572, 342);
            this.profile_Mobile.Name = "profile_Mobile";
            this.profile_Mobile.PasswordChar = '\0';
            this.profile_Mobile.PlaceholderText = "";
            this.profile_Mobile.SelectedText = "";
            this.profile_Mobile.ShadowDecoration.Parent = this.profile_Mobile;
            this.profile_Mobile.Size = new System.Drawing.Size(357, 36);
            this.profile_Mobile.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mobile No.";
            // 
            // profile_Email
            // 
            this.profile_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profile_Email.DefaultText = "";
            this.profile_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.profile_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.profile_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profile_Email.DisabledState.Parent = this.profile_Email;
            this.profile_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profile_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_Email.FocusedState.Parent = this.profile_Email;
            this.profile_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_Email.ForeColor = System.Drawing.Color.Black;
            this.profile_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_Email.HoverState.Parent = this.profile_Email;
            this.profile_Email.Location = new System.Drawing.Point(572, 435);
            this.profile_Email.Name = "profile_Email";
            this.profile_Email.PasswordChar = '\0';
            this.profile_Email.PlaceholderText = "";
            this.profile_Email.SelectedText = "";
            this.profile_Email.ShadowDecoration.Parent = this.profile_Email;
            this.profile_Email.Size = new System.Drawing.Size(357, 36);
            this.profile_Email.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email Address";
            // 
            // profile_Password
            // 
            this.profile_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profile_Password.DefaultText = "";
            this.profile_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.profile_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.profile_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profile_Password.DisabledState.Parent = this.profile_Password;
            this.profile_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profile_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_Password.FocusedState.Parent = this.profile_Password;
            this.profile_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_Password.ForeColor = System.Drawing.Color.Black;
            this.profile_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profile_Password.HoverState.Parent = this.profile_Password;
            this.profile_Password.Location = new System.Drawing.Point(572, 524);
            this.profile_Password.Name = "profile_Password";
            this.profile_Password.PasswordChar = '\0';
            this.profile_Password.PlaceholderText = "";
            this.profile_Password.SelectedText = "";
            this.profile_Password.ShadowDecoration.Parent = this.profile_Password;
            this.profile_Password.Size = new System.Drawing.Size(357, 36);
            this.profile_Password.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(569, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password";
            // 
            // profile_btnUpdate
            // 
            this.profile_btnUpdate.BorderRadius = 19;
            this.profile_btnUpdate.BorderThickness = 1;
            this.profile_btnUpdate.CheckedState.Parent = this.profile_btnUpdate;
            this.profile_btnUpdate.CustomImages.Parent = this.profile_btnUpdate;
            this.profile_btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.profile_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btnUpdate.ForeColor = System.Drawing.Color.White;
            this.profile_btnUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.profile_btnUpdate.HoverState.FillColor = System.Drawing.Color.White;
            this.profile_btnUpdate.HoverState.ForeColor = System.Drawing.Color.Black;
            this.profile_btnUpdate.HoverState.Parent = this.profile_btnUpdate;
            this.profile_btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("profile_btnUpdate.Image")));
            this.profile_btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.profile_btnUpdate.Location = new System.Drawing.Point(572, 599);
            this.profile_btnUpdate.Name = "profile_btnUpdate";
            this.profile_btnUpdate.ShadowDecoration.Parent = this.profile_btnUpdate;
            this.profile_btnUpdate.Size = new System.Drawing.Size(160, 46);
            this.profile_btnUpdate.TabIndex = 15;
            this.profile_btnUpdate.Text = "Update";
            this.profile_btnUpdate.Click += new System.EventHandler(this.profile_btnUpdate_Click);
            // 
            // profile_btnReset
            // 
            this.profile_btnReset.BorderRadius = 19;
            this.profile_btnReset.BorderThickness = 1;
            this.profile_btnReset.CheckedState.Parent = this.profile_btnReset;
            this.profile_btnReset.CustomImages.Parent = this.profile_btnReset;
            this.profile_btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.profile_btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btnReset.ForeColor = System.Drawing.Color.White;
            this.profile_btnReset.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.profile_btnReset.HoverState.FillColor = System.Drawing.Color.White;
            this.profile_btnReset.HoverState.ForeColor = System.Drawing.Color.Black;
            this.profile_btnReset.HoverState.Parent = this.profile_btnReset;
            this.profile_btnReset.Image = ((System.Drawing.Image)(resources.GetObject("profile_btnReset.Image")));
            this.profile_btnReset.ImageSize = new System.Drawing.Size(35, 35);
            this.profile_btnReset.Location = new System.Drawing.Point(769, 599);
            this.profile_btnReset.Name = "profile_btnReset";
            this.profile_btnReset.ShadowDecoration.Parent = this.profile_btnReset;
            this.profile_btnReset.Size = new System.Drawing.Size(160, 46);
            this.profile_btnReset.TabIndex = 16;
            this.profile_btnReset.Text = "Reset";
            this.profile_btnReset.Click += new System.EventHandler(this.profile_btnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(664, 665);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "*Check the details before updation";
            // 
            // UserControl_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.profile_btnReset);
            this.Controls.Add(this.profile_btnUpdate);
            this.Controls.Add(this.profile_Password);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.profile_Email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.profile_Mobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.profile_DOB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.profile_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.profile_userRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profile_userName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UserControl_Profile";
            this.Size = new System.Drawing.Size(1085, 726);
            this.Load += new System.EventHandler(this.UserControl_Profile_Load);
            this.Enter += new System.EventHandler(this.UserControl_Profile_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button profile_btnReset;
        private Guna.UI2.WinForms.Guna2Button profile_btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox profile_Password;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox profile_Email;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox profile_Mobile;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox profile_DOB;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox profile_Name;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox profile_userRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label profile_userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}
