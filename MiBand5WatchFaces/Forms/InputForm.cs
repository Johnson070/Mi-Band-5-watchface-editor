using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBand5WatchFaces
{
    public partial class InputForm : Form
    {
        public int value = -1;

        public InputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = Convert.ToInt16(maskedTextBox.Text.Substring(0,4));
            this.Close();
        }
    }
}
