namespace Coursework_1
{
    partial class SearchUI
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
            this.Display = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.httpTitle = new System.Windows.Forms.TextBox();
            this.httpResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Display.Location = new System.Drawing.Point(3, 29);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Display.Size = new System.Drawing.Size(770, 338);
            this.Display.TabIndex = 0;
            // 
            // httpTitle
            // 
            this.httpTitle.Location = new System.Drawing.Point(3, 3);
            this.httpTitle.Name = "httpTitle";
            this.httpTitle.ReadOnly = true;
            this.httpTitle.Size = new System.Drawing.Size(293, 20);
            this.httpTitle.TabIndex = 1;
            // 
            // httpResponse
            // 
            this.httpResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.httpResponse.Location = new System.Drawing.Point(660, 3);
            this.httpResponse.Name = "httpResponse";
            this.httpResponse.ReadOnly = true;
            this.httpResponse.Size = new System.Drawing.Size(113, 20);
            this.httpResponse.TabIndex = 2;
            // 
            // SearchUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.httpResponse);
            this.Controls.Add(this.httpTitle);
            this.Controls.Add(this.Display);
            this.Name = "SearchUI";
            this.Size = new System.Drawing.Size(776, 370);
            this.Load += new System.EventHandler(this.SearchUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox httpResponse;
        public System.Windows.Forms.TextBox httpTitle;
    }
}
