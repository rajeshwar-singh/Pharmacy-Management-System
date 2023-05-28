﻿
namespace WindowsFormsApp1
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.profile_btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedicines = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pUserControl_addMedicine1 = new WindowsFormsApp1.Pharmacist_UserControl.pUserControl_addMedicine();
            this.pUserControl_Dashboard1 = new WindowsFormsApp1.Pharmacist_UserControl.pUserControl_Dashboard();
            this.pUserControl_viewMedicines1 = new WindowsFormsApp1.Pharmacist_UserControl.pUserControl_viewMedicines();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.profile_btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2Button6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.btnViewMedicines);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(13, 248);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(263, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // profile_btnLogout
            // 
            this.profile_btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.profile_btnLogout.CheckedState.Parent = this.profile_btnLogout;
            this.profile_btnLogout.CustomImages.Parent = this.profile_btnLogout;
            this.profile_btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.profile_btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btnLogout.ForeColor = System.Drawing.Color.White;
            this.profile_btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.profile_btnLogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.profile_btnLogout.HoverState.Parent = this.profile_btnLogout;
            this.profile_btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("profile_btnLogout.Image")));
            this.profile_btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.profile_btnLogout.Location = new System.Drawing.Point(13, 651);
            this.profile_btnLogout.Name = "profile_btnLogout";
            this.profile_btnLogout.ShadowDecoration.Parent = this.profile_btnLogout;
            this.profile_btnLogout.Size = new System.Drawing.Size(263, 45);
            this.profile_btnLogout.TabIndex = 6;
            this.profile_btnLogout.Text = "Log Out";
            this.profile_btnLogout.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacist";
            // 
            // guna2Button6
            // 
            this.guna2Button6.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button6.CheckedState.Parent = this.guna2Button6;
            this.guna2Button6.CustomImages.Parent = this.guna2Button6;
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.HoverState.Parent = this.guna2Button6;
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button6.Location = new System.Drawing.Point(12, 590);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.Parent = this.guna2Button6;
            this.guna2Button6.Size = new System.Drawing.Size(263, 45);
            this.guna2Button6.TabIndex = 5;
            this.guna2Button6.Text = "Sell Medicine";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button5
            // 
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button5.Location = new System.Drawing.Point(13, 521);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(263, 45);
            this.guna2Button5.TabIndex = 4;
            this.guna2Button5.Text = "Medicine Validity Check";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMedicine.CheckedState.Parent = this.btnAddMedicine;
            this.btnAddMedicine.CustomImages.Parent = this.btnAddMedicine;
            this.btnAddMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.HoverState.Parent = this.btnAddMedicine;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddMedicine.Location = new System.Drawing.Point(13, 314);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.ShadowDecoration.Parent = this.btnAddMedicine;
            this.btnAddMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnAddMedicine.TabIndex = 1;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button4.Location = new System.Drawing.Point(13, 453);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(263, 45);
            this.guna2Button4.TabIndex = 3;
            this.guna2Button4.Text = "Modify Medicine";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnViewMedicines
            // 
            this.btnViewMedicines.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedicines.CheckedState.Parent = this.btnViewMedicines;
            this.btnViewMedicines.CustomImages.Parent = this.btnViewMedicines;
            this.btnViewMedicines.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewMedicines.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicines.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicines.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewMedicines.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicines.HoverState.Parent = this.btnViewMedicines;
            this.btnViewMedicines.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicines.Image")));
            this.btnViewMedicines.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewMedicines.Location = new System.Drawing.Point(13, 383);
            this.btnViewMedicines.Name = "btnViewMedicines";
            this.btnViewMedicines.ShadowDecoration.Parent = this.btnViewMedicines;
            this.btnViewMedicines.Size = new System.Drawing.Size(263, 45);
            this.btnViewMedicines.TabIndex = 2;
            this.btnViewMedicines.Text = "View Medicine";
            this.btnViewMedicines.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pUserControl_viewMedicines1);
            this.panel2.Controls.Add(this.pUserControl_addMedicine1);
            this.panel2.Controls.Add(this.pUserControl_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(276, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1102, 768);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // pUserControl_addMedicine1
            // 
            this.pUserControl_addMedicine1.BackColor = System.Drawing.Color.White;
            this.pUserControl_addMedicine1.Location = new System.Drawing.Point(-2, 0);
            this.pUserControl_addMedicine1.Name = "pUserControl_addMedicine1";
            this.pUserControl_addMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.pUserControl_addMedicine1.TabIndex = 1;
            // 
            // pUserControl_Dashboard1
            // 
            this.pUserControl_Dashboard1.BackColor = System.Drawing.Color.White;
            this.pUserControl_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.pUserControl_Dashboard1.Name = "pUserControl_Dashboard1";
            this.pUserControl_Dashboard1.Size = new System.Drawing.Size(1104, 765);
            this.pUserControl_Dashboard1.TabIndex = 0;
            // 
            // pUserControl_viewMedicines1
            // 
            this.pUserControl_viewMedicines1.BackColor = System.Drawing.Color.White;
            this.pUserControl_viewMedicines1.Location = new System.Drawing.Point(0, 0);
            this.pUserControl_viewMedicines1.Name = "pUserControl_viewMedicines1";
            this.pUserControl_viewMedicines1.Size = new System.Drawing.Size(1104, 770);
            this.pUserControl_viewMedicines1.TabIndex = 2;
            this.pUserControl_viewMedicines1.Load += new System.EventHandler(this.pUserControl_viewMedicines1_Load);
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button profile_btnLogout;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicines;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Pharmacist_UserControl.pUserControl_Dashboard pUserControl_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Pharmacist_UserControl.pUserControl_addMedicine pUserControl_addMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Pharmacist_UserControl.pUserControl_viewMedicines pUserControl_viewMedicines1;
    }
}