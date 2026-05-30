namespace Academy
{
    partial class HumanForm
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
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelLastname.Location = new System.Drawing.Point(72, 13);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(101, 24);
            this.labelLastname.TabIndex = 0;
            this.labelLastname.Text = "Фамилия: ";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelFirstName.Location = new System.Drawing.Point(117, 71);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(56, 24);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Имя: ";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelMiddleName.Location = new System.Drawing.Point(65, 129);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(108, 24);
            this.labelMiddleName.TabIndex = 2;
            this.labelMiddleName.Text = "Отчество: ";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelBirthDate.Location = new System.Drawing.Point(13, 187);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(160, 24);
            this.labelBirthDate.TabIndex = 3;
            this.labelBirthDate.Text = "Дата рождения: ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelEmail.Location = new System.Drawing.Point(106, 245);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(67, 24);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email: ";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelPhone.Location = new System.Drawing.Point(73, 303);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(100, 24);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Телефон: ";
            // 
            // tbLastName
            // 
            this.tbLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbLastName.Location = new System.Drawing.Point(169, 11);
            this.tbLastName.MaxLength = 50;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(313, 29);
            this.tbLastName.TabIndex = 6;
            // 
            // tbFirstName
            // 
            this.tbFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbFirstName.Location = new System.Drawing.Point(169, 69);
            this.tbFirstName.MaxLength = 50;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(313, 29);
            this.tbFirstName.TabIndex = 7;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbMiddleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.tbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbMiddleName.Location = new System.Drawing.Point(169, 127);
            this.tbMiddleName.MaxLength = 50;
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(313, 29);
            this.tbMiddleName.TabIndex = 8;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "yyyy.MMMM.dd";
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(169, 185);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(313, 29);
            this.dtpBirthDate.TabIndex = 9;
            // 
            // tbEmail
            // 
            this.tbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbEmail.Location = new System.Drawing.Point(169, 243);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(313, 29);
            this.tbEmail.TabIndex = 10;
            // 
            // tbPhone
            // 
            this.tbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPhone.Location = new System.Drawing.Point(169, 301);
            this.tbPhone.MaxLength = 16;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(313, 29);
            this.tbPhone.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnOK.Location = new System.Drawing.Point(516, 407);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 31);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCancel.Location = new System.Drawing.Point(633, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 31);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(489, 11);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(244, 316);
            this.pictureBoxPhoto.TabIndex = 14;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelID.Location = new System.Drawing.Point(12, 417);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 24);
            this.labelID.TabIndex = 15;
            // 
            // HumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HumanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HumanForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelID;
    }
}