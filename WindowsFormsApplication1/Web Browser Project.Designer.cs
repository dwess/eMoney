namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.urlBar = new System.Windows.Forms.ToolStripTextBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.browser = new System.Windows.Forms.RichTextBox();
            this.searchText = new System.Windows.Forms.Button();
            this.navigateLink = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.homeButton,
            this.urlBar,
            this.goButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(735, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backButton
            // 
            this.backButton.AccessibleName = "backButton";
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 22);
            this.backButton.Text = "backButton";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(23, 22);
            this.forwardButton.Text = "forwardButton";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeButton.Name = "homeButton";
            this.homeButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.homeButton.Size = new System.Drawing.Size(23, 22);
            this.homeButton.Text = "toolStripButton3";
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // urlBar
            // 
            this.urlBar.Name = "urlBar";
            this.urlBar.Size = new System.Drawing.Size(200, 25);
            this.urlBar.Click += new System.EventHandler(this.urlBar_Click);
            // 
            // goButton
            // 
            this.goButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(23, 22);
            this.goButton.Text = "toolStripButton4";
            this.goButton.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(48, 57);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(639, 427);
            this.browser.TabIndex = 1;
            this.browser.Text = "";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(237, 28);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(99, 23);
            this.searchText.TabIndex = 2;
            this.searchText.Text = "Search Links";
            this.searchText.UseVisualStyleBackColor = true;
            this.searchText.Click += new System.EventHandler(this.searchText_Click);
            // 
            // navigateLink
            // 
            this.navigateLink.Location = new System.Drawing.Point(356, 28);
            this.navigateLink.Name = "navigateLink";
            this.navigateLink.Size = new System.Drawing.Size(68, 23);
            this.navigateLink.TabIndex = 3;
            this.navigateLink.Text = "Navigate";
            this.navigateLink.UseVisualStyleBackColor = true;
            this.navigateLink.Click += new System.EventHandler(this.navigateLink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 517);
            this.Controls.Add(this.navigateLink);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton homeButton;
        private System.Windows.Forms.ToolStripTextBox urlBar;
        private System.Windows.Forms.ToolStripButton goButton;
        protected System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.RichTextBox browser;
        private System.Windows.Forms.Button searchText;
        private System.Windows.Forms.Button navigateLink;
    }
}

