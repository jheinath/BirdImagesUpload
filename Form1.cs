using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BirdImagesUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(this);
            textBoxFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var accessToken = textBoxAccessToken.Text;
            var folder = textBoxFolder.Text;
            var intervalInSeconds = double.Parse(numericUpDownInterval.Text);

            var (isValid, errorMsg) = ValidateInput(accessToken, folder);

            if (isValid == false)
            {
                textBoxOutput.Text = errorMsg;
                return;
            }

            var timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(UploadData);
            timer.Interval = intervalInSeconds * 1000;
            timer.Enabled = true;
            timer.Start();
        }

        private static void UploadData(object source, ElapsedEventArgs e)
        {
            
        }

        private static Tuple<bool, string> ValidateInput(string accessToken, string folder)
        {
            var errorMsg = string.Empty;
            var isValid = true;

            if (string.IsNullOrWhiteSpace(accessToken))
            {
                isValid = false;
                errorMsg += $"Invalid Access Token{Environment.NewLine}";
            }

            if (string.IsNullOrWhiteSpace(folder))
            {
                isValid = false;
                errorMsg += $"Invalid Folder{Environment.NewLine}";
            }

            //Interval will always be valid since the UI controls what input values can be entered

            return new Tuple<bool, string>(isValid, errorMsg);
        }
    }
}
