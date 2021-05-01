using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBand5WatchFaces
{
    public partial class SupportAuthorForm : Form
    {
        public SupportAuthorForm()
        {
            InitializeComponent();
        }

        private void BTCbutton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1bZXvd4sUPBKCHym3XrDpjxAjXKYfXa5a");
            MessageBox.Show("Copied to clipboard!");
        }

        private void ETHbutton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0x742dcd12f1725c02110f0ca70da686d0f080af0e");
            MessageBox.Show("Copied to clipboard!");
        }

        private void USDTbutton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0x742dcd12f1725c02110f0ca70da686d0f080af0e");
            MessageBox.Show("Copied to clipboard!");
        }

        private void PayPalbutton_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://paypal.me/j0hnson070";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Alertbutton_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://www.donationalerts.com/r/johnson070";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
