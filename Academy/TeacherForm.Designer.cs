namespace Academy
{
    partial class TeacherForm
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
            this.dtpWorkSince = new System.Windows.Forms.DateTimePicker();
            this.labelWorkSince = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpWorkSince
            // 
            this.dtpWorkSince.CustomFormat = "yyyy.MMMM.dd";
            this.dtpWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkSince.Location = new System.Drawing.Point(169, 345);
            this.dtpWorkSince.Name = "dtpWorkSince";
            this.dtpWorkSince.Size = new System.Drawing.Size(313, 29);
            this.dtpWorkSince.TabIndex = 17;
            // 
            // labelWorkSince
            // 
            this.labelWorkSince.AutoSize = true;
            this.labelWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelWorkSince.Location = new System.Drawing.Point(53, 349);
            this.labelWorkSince.Name = "labelWorkSince";
            this.labelWorkSince.Size = new System.Drawing.Size(120, 24);
            this.labelWorkSince.TabIndex = 16;
            this.labelWorkSince.Text = "Работает с: ";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpWorkSince);
            this.Controls.Add(this.labelWorkSince);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Controls.SetChildIndex(this.labelWorkSince, 0);
            this.Controls.SetChildIndex(this.dtpWorkSince, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpWorkSince;
        private System.Windows.Forms.Label labelWorkSince;
    }
}