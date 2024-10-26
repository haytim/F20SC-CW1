namespace Coursework_1
{
    partial class SetUI
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
            this.NotifSetBox = new System.Windows.Forms.TextBox();
            this.setHomeBox = new System.Windows.Forms.TextBox();
            this.SetSave = new System.Windows.Forms.Button();
            this.ResetHomeBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotifSetBox
            // 
            this.NotifSetBox.Location = new System.Drawing.Point(3, 3);
            this.NotifSetBox.Name = "NotifSetBox";
            this.NotifSetBox.ReadOnly = true;
            this.NotifSetBox.Size = new System.Drawing.Size(300, 20);
            this.NotifSetBox.TabIndex = 0;
            this.NotifSetBox.Text = "Set your home page url using the options below!";
            // 
            // setHomeBox
            // 
            this.setHomeBox.Location = new System.Drawing.Point(3, 29);
            this.setHomeBox.Name = "setHomeBox";
            this.setHomeBox.Size = new System.Drawing.Size(459, 20);
            this.setHomeBox.TabIndex = 1;
            // 
            // SetSave
            // 
            this.SetSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetSave.Location = new System.Drawing.Point(660, 29);
            this.SetSave.Name = "SetSave";
            this.SetSave.Size = new System.Drawing.Size(113, 26);
            this.SetSave.TabIndex = 2;
            this.SetSave.Text = "Save";
            this.SetSave.UseVisualStyleBackColor = true;
            this.SetSave.Click += new System.EventHandler(this.SetSave_Click);
            // 
            // ResetHomeBox
            // 
            this.ResetHomeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetHomeBox.Location = new System.Drawing.Point(660, 61);
            this.ResetHomeBox.Name = "ResetHomeBox";
            this.ResetHomeBox.Size = new System.Drawing.Size(113, 26);
            this.ResetHomeBox.TabIndex = 3;
            this.ResetHomeBox.Text = "Reset to Default";
            this.ResetHomeBox.UseVisualStyleBackColor = true;
            this.ResetHomeBox.Click += new System.EventHandler(this.ResetHomeBox_Click);
            // 
            // SetUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.ResetHomeBox);
            this.Controls.Add(this.SetSave);
            this.Controls.Add(this.setHomeBox);
            this.Controls.Add(this.NotifSetBox);
            this.Name = "SetUI";
            this.Size = new System.Drawing.Size(776, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NotifSetBox;
        private System.Windows.Forms.TextBox setHomeBox;
        private System.Windows.Forms.Button SetSave;
        private System.Windows.Forms.Button ResetHomeBox;
    }
}
