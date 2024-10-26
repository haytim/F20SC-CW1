namespace Coursework_1
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            tableLayoutPanel1 = new TableLayoutPanel();
            reloadButton = new Button();
            forButton = new Button();
            backButton = new Button();
            searchButton = new Button();
            searchBox = new TextBox();
            panel1 = new Panel();
            searchUI1 = new SearchUI();
            setUI1 = new SetUI();
            favUI1 = new FavUI();
            hisUI1 = new HisUI();
            downUI1 = new DownUI();
            setButton = new Button();
            homeButton = new Button();
            hisButton = new Button();
            favButton = new Button();
            downButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(reloadButton, 2, 0);
            tableLayoutPanel1.Controls.Add(forButton, 1, 0);
            tableLayoutPanel1.Controls.Add(backButton, 0, 0);
            tableLayoutPanel1.Controls.Add(searchButton, 4, 0);
            tableLayoutPanel1.Controls.Add(searchBox, 3, 0);
            tableLayoutPanel1.Location = new Point(14, 54);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.MinimumSize = new Size(905, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(910, 37);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // reloadButton
            // 
            reloadButton.AutoSize = true;
            reloadButton.Location = new Point(186, 3);
            reloadButton.Margin = new Padding(4, 3, 4, 3);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(83, 30);
            reloadButton.TabIndex = 2;
            reloadButton.Text = "&Reload";
            reloadButton.UseVisualStyleBackColor = true;
            reloadButton.Click += reloadButton_Click;
            // 
            // forButton
            // 
            forButton.AutoSize = true;
            forButton.Location = new Point(95, 3);
            forButton.Margin = new Padding(4, 3, 4, 3);
            forButton.Name = "forButton";
            forButton.Size = new Size(83, 30);
            forButton.TabIndex = 2;
            forButton.Text = "&>";
            forButton.UseVisualStyleBackColor = true;
            forButton.Click += forButton_Click;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Location = new Point(4, 3);
            backButton.Margin = new Padding(4, 3, 4, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(83, 30);
            backButton.TabIndex = 1;
            backButton.Text = "&<";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.AutoSize = true;
            searchButton.Location = new Point(774, 3);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(132, 30);
            searchButton.TabIndex = 2;
            searchButton.Text = "&Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.Location = new Point(277, 3);
            searchBox.Margin = new Padding(4, 3, 4, 3);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(489, 29);
            searchBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(searchUI1);
            panel1.Controls.Add(setUI1);
            panel1.Controls.Add(favUI1);
            panel1.Controls.Add(hisUI1);
            panel1.Controls.Add(downUI1);
            panel1.Location = new Point(14, 98);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.MinimumSize = new Size(905, 427);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 427);
            panel1.TabIndex = 3;
            // 
            // searchUI1
            // 
            searchUI1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchUI1.AutoScroll = true;
            searchUI1.AutoSize = true;
            searchUI1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchUI1.BackColor = Color.White;
            searchUI1.Location = new Point(0, 0);
            searchUI1.Margin = new Padding(4, 3, 4, 3);
            searchUI1.MinimumSize = new Size(905, 427);
            searchUI1.Name = "searchUI1";
            searchUI1.Size = new Size(905, 427);
            searchUI1.TabIndex = 0;
            // 
            // setUI1
            // 
            setUI1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            setUI1.AutoScroll = true;
            setUI1.AutoSize = true;
            setUI1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            setUI1.Location = new Point(0, 0);
            setUI1.Margin = new Padding(4, 3, 4, 3);
            setUI1.Name = "setUI1";
            setUI1.Size = new Size(905, 90);
            setUI1.TabIndex = 1;
            // 
            // favUI1
            // 
            favUI1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            favUI1.AutoScroll = true;
            favUI1.AutoSize = true;
            favUI1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            favUI1.f1 = null;
            favUI1.Location = new Point(0, 0);
            favUI1.Margin = new Padding(4, 3, 4, 3);
            favUI1.Name = "favUI1";
            favUI1.Size = new Size(905, 423);
            favUI1.TabIndex = 2;
            // 
            // hisUI1
            // 
            hisUI1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hisUI1.AutoScroll = true;
            hisUI1.AutoSize = true;
            hisUI1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hisUI1.f1 = null;
            hisUI1.Location = new Point(0, 0);
            hisUI1.Margin = new Padding(4, 3, 4, 3);
            hisUI1.Name = "hisUI1";
            hisUI1.Size = new Size(905, 423);
            hisUI1.TabIndex = 3;
            // 
            // downUI1
            // 
            downUI1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downUI1.AutoScroll = true;
            downUI1.AutoSize = true;
            downUI1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            downUI1.BackColor = Color.White;
            downUI1.f1 = null;
            downUI1.Location = new Point(4, 0);
            downUI1.Margin = new Padding(4, 3, 4, 3);
            downUI1.Name = "downUI1";
            downUI1.Size = new Size(898, 58);
            downUI1.TabIndex = 4;
            // 
            // setButton
            // 
            setButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            setButton.AutoSize = true;
            setButton.Location = new Point(769, 3);
            setButton.Margin = new Padding(4, 3, 4, 3);
            setButton.Name = "setButton";
            setButton.Size = new Size(132, 29);
            setButton.TabIndex = 3;
            setButton.Text = "S&ettings";
            setButton.UseVisualStyleBackColor = true;
            setButton.Click += setButton_Click;
            // 
            // homeButton
            // 
            homeButton.AutoSize = true;
            homeButton.Location = new Point(4, 3);
            homeButton.Margin = new Padding(4, 3, 4, 3);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(83, 29);
            homeButton.TabIndex = 2;
            homeButton.Text = "H&ome";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // hisButton
            // 
            hisButton.AutoSize = true;
            hisButton.Location = new Point(95, 3);
            hisButton.Margin = new Padding(4, 3, 4, 3);
            hisButton.Name = "hisButton";
            hisButton.Size = new Size(83, 29);
            hisButton.TabIndex = 2;
            hisButton.Text = "&History";
            hisButton.UseVisualStyleBackColor = true;
            hisButton.Click += hisButton_Click;
            // 
            // favButton
            // 
            favButton.AutoSize = true;
            favButton.Location = new Point(186, 3);
            favButton.Margin = new Padding(4, 3, 4, 3);
            favButton.Name = "favButton";
            favButton.Size = new Size(83, 29);
            favButton.TabIndex = 3;
            favButton.Text = "&Favourites";
            favButton.UseVisualStyleBackColor = true;
            favButton.Click += favButton_Click;
            // 
            // downButton
            // 
            downButton.Location = new Point(277, 3);
            downButton.Margin = new Padding(4, 3, 4, 3);
            downButton.Name = "downButton";
            downButton.Size = new Size(83, 30);
            downButton.TabIndex = 3;
            downButton.Text = "&Downloads";
            downButton.UseVisualStyleBackColor = true;
            downButton.Click += downButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(downButton, 3, 0);
            tableLayoutPanel2.Controls.Add(favButton, 2, 0);
            tableLayoutPanel2.Controls.Add(hisButton, 1, 0);
            tableLayoutPanel2.Controls.Add(homeButton, 0, 0);
            tableLayoutPanel2.Controls.Add(setButton, 5, 0);
            tableLayoutPanel2.Location = new Point(14, 14);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.MinimumSize = new Size(905, 37);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(905, 37);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // Browser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(930, 539);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(946, 578);
            MinimumSize = new Size(946, 578);
            Name = "Browser";
            Text = "Web Browser";
            Load += Browser_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Panel panel1;
        private SetUI setUI1;
        private FavUI favUI1;
        private HisUI hisUI1;
        private DownUI downUI1;
        public SearchUI searchUI1;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button hisButton;
        private System.Windows.Forms.Button favButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

