namespace Coursework_1
{
    partial class FavUI
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
            this.NotifNameBox = new System.Windows.Forms.TextBox();
            this.AddFav = new System.Windows.Forms.Button();
            this.NotifURLBox = new System.Windows.Forms.TextBox();
            this.favFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FavNameInputBox = new System.Windows.Forms.TextBox();
            this.FavURLInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NotifNameBox
            // 
            this.NotifNameBox.Location = new System.Drawing.Point(3, 3);
            this.NotifNameBox.Name = "NotifNameBox";
            this.NotifNameBox.ReadOnly = true;
            this.NotifNameBox.Size = new System.Drawing.Size(300, 20);
            this.NotifNameBox.TabIndex = 0;
            this.NotifNameBox.Text = "Enter the Favourite Name Below!";
            // 
            // AddFav
            // 
            this.AddFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFav.Location = new System.Drawing.Point(660, 28);
            this.AddFav.Name = "AddFav";
            this.AddFav.Size = new System.Drawing.Size(113, 26);
            this.AddFav.TabIndex = 1;
            this.AddFav.Text = "Add";
            this.AddFav.UseVisualStyleBackColor = true;
            this.AddFav.Click += new System.EventHandler(this.AddFav_Click);
            // 
            // NotifURLBox
            // 
            this.NotifURLBox.Location = new System.Drawing.Point(309, 3);
            this.NotifURLBox.Name = "NotifURLBox";
            this.NotifURLBox.ReadOnly = true;
            this.NotifURLBox.Size = new System.Drawing.Size(300, 20);
            this.NotifURLBox.TabIndex = 2;
            this.NotifURLBox.Text = "Enter the Favourite URL Below!";
            // 
            // favFlowPanel
            // 
            this.favFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favFlowPanel.AutoScroll = true;
            this.favFlowPanel.Location = new System.Drawing.Point(3, 60);
            this.favFlowPanel.Name = "favFlowPanel";
            this.favFlowPanel.Size = new System.Drawing.Size(770, 304);
            this.favFlowPanel.TabIndex = 3;
            // 
            // FavNameInputBox
            // 
            this.FavNameInputBox.Location = new System.Drawing.Point(3, 28);
            this.FavNameInputBox.Multiline = true;
            this.FavNameInputBox.Name = "FavNameInputBox";
            this.FavNameInputBox.Size = new System.Drawing.Size(300, 26);
            this.FavNameInputBox.TabIndex = 4;
            // 
            // FavURLInputBox
            // 
            this.FavURLInputBox.Location = new System.Drawing.Point(309, 28);
            this.FavURLInputBox.Multiline = true;
            this.FavURLInputBox.Name = "FavURLInputBox";
            this.FavURLInputBox.Size = new System.Drawing.Size(300, 26);
            this.FavURLInputBox.TabIndex = 5;
            // 
            // FavUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.FavURLInputBox);
            this.Controls.Add(this.FavNameInputBox);
            this.Controls.Add(this.favFlowPanel);
            this.Controls.Add(this.NotifURLBox);
            this.Controls.Add(this.AddFav);
            this.Controls.Add(this.NotifNameBox);
            this.Name = "FavUI";
            this.Size = new System.Drawing.Size(776, 367);
            this.Load += new System.EventHandler(this.FavUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NotifNameBox;
        private System.Windows.Forms.Button AddFav;
        private System.Windows.Forms.TextBox NotifURLBox;
        private System.Windows.Forms.FlowLayoutPanel favFlowPanel;
        private System.Windows.Forms.TextBox FavURLInputBox;
        public System.Windows.Forms.TextBox FavNameInputBox;
    }
}
