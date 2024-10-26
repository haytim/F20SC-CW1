namespace Coursework_1
{
    partial class DownUI
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
            this.NotifBulkBox = new System.Windows.Forms.TextBox();
            this.BulkInputBox = new System.Windows.Forms.TextBox();
            this.Download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotifBulkBox
            // 
            this.NotifBulkBox.Location = new System.Drawing.Point(3, 3);
            this.NotifBulkBox.Name = "NotifBulkBox";
            this.NotifBulkBox.ReadOnly = true;
            this.NotifBulkBox.Size = new System.Drawing.Size(201, 20);
            this.NotifBulkBox.TabIndex = 0;
            this.NotifBulkBox.Text = "Enter filename for bulk download below!";
            // 
            // BulkInputBox
            // 
            this.BulkInputBox.Location = new System.Drawing.Point(3, 29);
            this.BulkInputBox.Name = "BulkInputBox";
            this.BulkInputBox.Size = new System.Drawing.Size(365, 20);
            this.BulkInputBox.TabIndex = 1;
            this.BulkInputBox.Text = "bulk.txt";
            // 
            // Download
            // 
            this.Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Download.Location = new System.Drawing.Point(654, 29);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(113, 26);
            this.Download.TabIndex = 2;
            this.Download.Text = "Download!";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // DownUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.Download);
            this.Controls.Add(this.BulkInputBox);
            this.Controls.Add(this.NotifBulkBox);
            this.Name = "DownUI";
            this.Size = new System.Drawing.Size(770, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NotifBulkBox;
        private System.Windows.Forms.TextBox BulkInputBox;
        private System.Windows.Forms.Button Download;
    }
}
