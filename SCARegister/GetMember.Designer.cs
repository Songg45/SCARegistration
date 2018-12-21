namespace WindowsFormsApp2
{
    partial class GetMember
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
            this.CopyButton = new System.Windows.Forms.Button();
            this.MemberWeb = new Gecko.GeckoWebBrowser();
            this.MemberHelp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyButton.Location = new System.Drawing.Point(13, 290);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 20);
            this.CopyButton.TabIndex = 1;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // MemberWeb
            // 
            this.MemberWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberWeb.FrameEventsPropagateToMainWindow = false;
            this.MemberWeb.Location = new System.Drawing.Point(13, 13);
            this.MemberWeb.Name = "MemberWeb";
            this.MemberWeb.Size = new System.Drawing.Size(617, 271);
            this.MemberWeb.TabIndex = 2;
            this.MemberWeb.UseHttpActivityObserver = true;
            // 
            // MemberHelp
            // 
            this.MemberHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberHelp.Location = new System.Drawing.Point(93, 290);
            this.MemberHelp.Name = "MemberHelp";
            this.MemberHelp.ReadOnly = true;
            this.MemberHelp.Size = new System.Drawing.Size(382, 20);
            this.MemberHelp.TabIndex = 3;
            this.MemberHelp.Text = "Once logged in, select \"Copy\" to automatically send membership # to main form.";
            // 
            // GetMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 354);
            this.Controls.Add(this.MemberHelp);
            this.Controls.Add(this.MemberWeb);
            this.Controls.Add(this.CopyButton);
            this.Name = "GetMember";
            this.Text = "MemberWeb";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GetMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CopyButton;
        private Gecko.GeckoWebBrowser MemberWeb;
        private System.Windows.Forms.TextBox MemberHelp;

    }
}