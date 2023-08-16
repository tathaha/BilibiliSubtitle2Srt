using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using BilibiliSubtitle2SRT;
using System.Drawing;

namespace BilibiliSubtitle2SRT
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            Text = "Information"; // Set the title of the form
            ShowIcon = false;     // Hide the app icon in the form's title bar
            MaximizeBox = false; // Hide the Maximize button
            MinimizeBox = true;  // Hide the control box (minimize, maximize, close buttons)

            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Create labels for the links
            Label lblDiscord = new Label();
            Label lblGitHub = new Label();
            Label lblTwitter = new Label();
            Label lblYouTube = new Label();

            lblDiscord.Text = "Discord";
            lblGitHub.Text = "GitHub";
            lblTwitter.Text = "Twitter";
            lblYouTube.Text = "YouTube";

            lblDiscord.AutoSize = true;
            lblGitHub.AutoSize = true;
            lblTwitter.AutoSize = true;
            lblYouTube.AutoSize = true;

            // Set the locations for the links
            lblDiscord.Location = new System.Drawing.Point(20, 20);
            lblGitHub.Location = new System.Drawing.Point(20, 50);
            lblTwitter.Location = new System.Drawing.Point(20, 80);
            lblYouTube.Location = new System.Drawing.Point(20, 110);

            // Wire up the Click event for each label
            lblDiscord.Click += (sender, e) => OpenLink("https://discord.com/");
            lblGitHub.Click += (sender, e) => OpenLink("https://github.com/");
            lblTwitter.Click += (sender, e) => OpenLink("https://twitter.com/");
            lblYouTube.Click += (sender, e) => OpenLink("https://youtube.com/");

            // Add the labels to the InfoForm
            Controls.Add(lblDiscord);
            Controls.Add(lblGitHub);
            Controls.Add(lblTwitter);
            Controls.Add(lblYouTube);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        


        private void OpenLink(string url)
        {
            Process.Start(url); // Open the provided URL in the default web browser
        }
    }
}
