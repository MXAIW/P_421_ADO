namespace Academy
{
    partial class ItemForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbName.Location = new System.Drawing.Point(125, 26);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(647, 29);
            this.tbName.TabIndex = 8;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelname.Location = new System.Drawing.Point(27, 29);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(107, 24);
            this.labelname.TabIndex = 7;
            this.labelname.Text = "Название: ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelID.Location = new System.Drawing.Point(12, 417);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 24);
            this.labelID.TabIndex = 16;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelname);
            this.Name = "ItemForm";
            this.Text = "DirectionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelID;
    }
}