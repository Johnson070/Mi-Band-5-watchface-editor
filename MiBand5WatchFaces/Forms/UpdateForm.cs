using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBand5WatchFaces.Forms
{
    public partial class UpdateForm : Form
    {
        WebClient web = new WebClient();
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));
        string url;
        string path;

        public UpdateForm(string url, string path)
        {
            InitializeComponent();
            this.url = url;
            this.path = path;
        }

        void StartDownload(string url, string saveFile)
        {
            bar.Value = 0;
            //bar.Style = ProgressBarStyle.Continuous;
            infoTextBox.Text = "";

            Uri uri = new Uri(url);

            web = new WebClient();
            web.DownloadProgressChanged += Web_DownloadProgressChanged;
            web.DownloadFileCompleted += Web_DownloadFileCompleted;
            web.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            web.DownloadFileAsync(uri, saveFile);
        }

        void WebClient_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            try
            {
                bar.Value = e.ProgressPercentage;
                infoTextBox.Text = e.ProgressPercentage.ToString() + "%" + "   " + (Convert.ToDouble(e.BytesReceived) / 1024 / 1024).ToString("0,00") + " MB" + "  /  " + (Convert.ToDouble(e.TotalBytesToReceive) / 1024 / 1024).ToString("0.00") + " MB";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            bar.Value = 100;
            infoTextBox.Text = "";

            MessageBox.Show(res.GetString("UpdateDownloadExit"), res.GetString("Update"), MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            bar.Value = e.ProgressPercentage;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            web.CancelAsync();
            this.Close();
        }

        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            web.CancelAsync();
        }

        private void UpdateForm_Shown(object sender, EventArgs e)
        {
            StartDownload(url, path);
        }
    }
}
