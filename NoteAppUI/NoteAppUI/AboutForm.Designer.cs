using System.ComponentModel;

namespace NoteAppUI
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.labelName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.labelGitHub = new System.Windows.Forms.Label();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(210, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "NoteApp";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(12, 32);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(210, 23);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "v 1.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Location = new System.Drawing.Point(12, 55);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(210, 23);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Автор: Монгуш Саян";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(12, 78);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(210, 23);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "E-Mail:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.Location = new System.Drawing.Point(12, 101);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(210, 23);
            this.linkLabelEmail.TabIndex = 4;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "sayan.monugsh@gmail.com";
            this.linkLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelEmail.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmail_LinkClicked);
            // 
            // labelGitHub
            // 
            this.labelGitHub.Location = new System.Drawing.Point(12, 124);
            this.labelGitHub.Name = "labelGitHub";
            this.labelGitHub.Size = new System.Drawing.Size(210, 23);
            this.labelGitHub.TabIndex = 5;
            this.labelGitHub.Text = "GitHub:";
            this.labelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.Location = new System.Drawing.Point(12, 147);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(210, 23);
            this.linkLabelGitHub.TabIndex = 6;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "https://github.com/dvizhman/NoteApp1";
            this.linkLabelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelGitHub.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 221);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.labelGitHub);
            this.Controls.Add(this.linkLabelEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
        private System.Windows.Forms.Label labelGitHub;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
    }
}