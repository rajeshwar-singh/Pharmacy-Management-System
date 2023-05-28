
namespace WindowsFormsApp1.Pharmacist_UserControl
{
    partial class pUserControl_addMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pUserControl_addMedicine));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedicineId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMedicineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedicineNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManuDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtExpiryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPerUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine ID";
            // 
            // txtMedicineId
            // 
            this.txtMedicineId.BorderColor = System.Drawing.Color.Black;
            this.txtMedicineId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineId.DefaultText = "";
            this.txtMedicineId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicineId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicineId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineId.DisabledState.Parent = this.txtMedicineId;
            this.txtMedicineId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineId.FocusedState.Parent = this.txtMedicineId;
            this.txtMedicineId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineId.ForeColor = System.Drawing.Color.Black;
            this.txtMedicineId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineId.HoverState.Parent = this.txtMedicineId;
            this.txtMedicineId.Location = new System.Drawing.Point(177, 194);
            this.txtMedicineId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMedicineId.Name = "txtMedicineId";
            this.txtMedicineId.PasswordChar = '\0';
            this.txtMedicineId.PlaceholderText = "";
            this.txtMedicineId.SelectedText = "";
            this.txtMedicineId.ShadowDecoration.Parent = this.txtMedicineId;
            this.txtMedicineId.Size = new System.Drawing.Size(340, 36);
            this.txtMedicineId.TabIndex = 2;
            this.txtMedicineId.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.BorderColor = System.Drawing.Color.Black;
            this.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineName.DefaultText = "";
            this.txtMedicineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineName.DisabledState.Parent = this.txtMedicineName;
            this.txtMedicineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineName.FocusedState.Parent = this.txtMedicineName;
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.ForeColor = System.Drawing.Color.Black;
            this.txtMedicineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineName.HoverState.Parent = this.txtMedicineName;
            this.txtMedicineName.Location = new System.Drawing.Point(177, 319);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.PasswordChar = '\0';
            this.txtMedicineName.PlaceholderText = "";
            this.txtMedicineName.SelectedText = "";
            this.txtMedicineName.ShadowDecoration.Parent = this.txtMedicineName;
            this.txtMedicineName.Size = new System.Drawing.Size(340, 36);
            this.txtMedicineName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medicine Name";
            // 
            // txtMedicineNumber
            // 
            this.txtMedicineNumber.BorderColor = System.Drawing.Color.Black;
            this.txtMedicineNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineNumber.DefaultText = "";
            this.txtMedicineNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicineNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicineNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineNumber.DisabledState.Parent = this.txtMedicineNumber;
            this.txtMedicineNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineNumber.FocusedState.Parent = this.txtMedicineNumber;
            this.txtMedicineNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineNumber.ForeColor = System.Drawing.Color.Black;
            this.txtMedicineNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineNumber.HoverState.Parent = this.txtMedicineNumber;
            this.txtMedicineNumber.Location = new System.Drawing.Point(177, 449);
            this.txtMedicineNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMedicineNumber.Name = "txtMedicineNumber";
            this.txtMedicineNumber.PasswordChar = '\0';
            this.txtMedicineNumber.PlaceholderText = "";
            this.txtMedicineNumber.SelectedText = "";
            this.txtMedicineNumber.ShadowDecoration.Parent = this.txtMedicineNumber;
            this.txtMedicineNumber.Size = new System.Drawing.Size(340, 36);
            this.txtMedicineNumber.TabIndex = 6;
            this.txtMedicineNumber.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Medicine Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Manufacturing Date";
            // 
            // txtManuDate
            // 
            this.txtManuDate.BorderThickness = 1;
            this.txtManuDate.CheckedState.Parent = this.txtManuDate;
            this.txtManuDate.FillColor = System.Drawing.Color.White;
            this.txtManuDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtManuDate.HoverState.Parent = this.txtManuDate;
            this.txtManuDate.Location = new System.Drawing.Point(177, 582);
            this.txtManuDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtManuDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtManuDate.Name = "txtManuDate";
            this.txtManuDate.ShadowDecoration.Parent = this.txtManuDate;
            this.txtManuDate.Size = new System.Drawing.Size(340, 36);
            this.txtManuDate.TabIndex = 8;
            this.txtManuDate.Value = new System.DateTime(2023, 5, 26, 13, 0, 36, 718);
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.BorderThickness = 1;
            this.txtExpiryDate.CheckedState.Parent = this.txtExpiryDate;
            this.txtExpiryDate.FillColor = System.Drawing.Color.White;
            this.txtExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtExpiryDate.HoverState.Parent = this.txtExpiryDate;
            this.txtExpiryDate.Location = new System.Drawing.Point(607, 194);
            this.txtExpiryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExpiryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.ShadowDecoration.Parent = this.txtExpiryDate;
            this.txtExpiryDate.Size = new System.Drawing.Size(340, 36);
            this.txtExpiryDate.TabIndex = 10;
            this.txtExpiryDate.Value = new System.DateTime(2023, 5, 26, 13, 0, 36, 718);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(603, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Expiry  Date";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderColor = System.Drawing.Color.Black;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(607, 319);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(340, 36);
            this.txtQuantity.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(603, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity";
            // 
            // txtPerUnitPrice
            // 
            this.txtPerUnitPrice.BorderColor = System.Drawing.Color.Black;
            this.txtPerUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPerUnitPrice.DefaultText = "";
            this.txtPerUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPerUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPerUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPerUnitPrice.DisabledState.Parent = this.txtPerUnitPrice;
            this.txtPerUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPerUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPerUnitPrice.FocusedState.Parent = this.txtPerUnitPrice;
            this.txtPerUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPerUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPerUnitPrice.HoverState.Parent = this.txtPerUnitPrice;
            this.txtPerUnitPrice.Location = new System.Drawing.Point(607, 449);
            this.txtPerUnitPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerUnitPrice.Name = "txtPerUnitPrice";
            this.txtPerUnitPrice.PasswordChar = '\0';
            this.txtPerUnitPrice.PlaceholderText = "";
            this.txtPerUnitPrice.SelectedText = "";
            this.txtPerUnitPrice.ShadowDecoration.Parent = this.txtPerUnitPrice;
            this.txtPerUnitPrice.Size = new System.Drawing.Size(340, 36);
            this.txtPerUnitPrice.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(603, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Price Per Unit";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 19;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(619, 582);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(130, 41);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 19;
            this.btnReset.BorderThickness = 1;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.HoverState.FillColor = System.Drawing.Color.White;
            this.btnReset.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReset.Location = new System.Drawing.Point(817, 582);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(130, 41);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pUserControl_addMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPerUnitPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtManuDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedicineNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedicineId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pUserControl_addMedicine";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.pUserControl_addMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPerUnitPrice;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtExpiryDate;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtManuDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineNumber;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}
