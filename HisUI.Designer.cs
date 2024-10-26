namespace Coursework_1
{
    partial class HisUI
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
            this.NotifHistory = new System.Windows.Forms.TextBox();
            this.hisFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ClearHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotifHistory
            // 
            this.NotifHistory.Location = new System.Drawing.Point(3, 3);
            this.NotifHistory.Multiline = true;
            this.NotifHistory.Name = "NotifHistory";
            this.NotifHistory.ReadOnly = true;
            this.NotifHistory.Size = new System.Drawing.Size(300, 20);
            this.NotifHistory.TabIndex = 0;
            this.NotifHistory.Text = "View History Below!";
            // 
            // hisFlowPanel
            // 
            this.hisFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hisFlowPanel.AutoScroll = true;
            this.hisFlowPanel.Location = new System.Drawing.Point(3, 29);
            this.hisFlowPanel.Name = "hisFlowPanel";
            this.hisFlowPanel.Size = new System.Drawing.Size(770, 335);
            this.hisFlowPanel.TabIndex = 1;
            // 
            // ClearHistory
            // 
            this.ClearHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearHistory.Location = new System.Drawing.Point(660, 3);
            this.ClearHistory.Name = "ClearHistory";
            this.ClearHistory.Size = new System.Drawing.Size(113, 26);
            this.ClearHistory.TabIndex = 0;
            this.ClearHistory.Text = "Clear History";
            this.ClearHistory.UseVisualStyleBackColor = true;
            this.ClearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // HisUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.ClearHistory);
            this.Controls.Add(this.hisFlowPanel);
            this.Controls.Add(this.NotifHistory);
            this.Name = "HisUI";
            this.Size = new System.Drawing.Size(776, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NotifHistory;
        private System.Windows.Forms.FlowLayoutPanel hisFlowPanel;
        private System.Windows.Forms.Button ClearHistory;
    }
}
