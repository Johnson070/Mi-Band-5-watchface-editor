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
    public partial class CircleScaleForm : Form
    {
        public WatchFaceLibrary watch;
        public CircleScale circleScale;
        StateWatchface state;
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

        bool startForm = false;
        public bool saved = false;
        public bool delete = false; // height = 630 670

        private Color convertColorFromString(string _color) => Color.FromArgb(Convert.ToInt16(_color.Substring(2, 2), 16), Convert.ToInt16(_color.Substring(4, 2), 16), Convert.ToInt16(_color.Substring(6, 2), 16));

        private void Render()
        {
            VisualRender visual = new VisualRender(watch, state);
            previewImage.BackgroundImage = visual.GenWatchface();
        }

        public CircleScaleForm(WatchFaceLibrary watch, CircleScale circleScale, DefaultDictionary<int, Image> images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.circleScale = circleScale;
            this.watch.imagesBuff = images;
            this.state = state;

            startAngleNum.Value = circleScale.StartAngle;
            endAngleNum.Value = circleScale.EndAngle;
            widthNum.Value = circleScale.Width;
            radiusXNum.Value = circleScale.RadiusX;
            radiusYNum.Value = circleScale.RadiusY;
            centerXNum.Value = circleScale.CenterX;
            centerYNum.Value = circleScale.CenterY;
            colorButton.BackColor = convertColorFromString(circleScale.Color);

            startForm = true;
            Render();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorButton.BackColor = colorDialog.Color;
                circleScale.Color = $"0x{colorDialog.Color.R.ToString("X2")}{colorDialog.Color.G.ToString("X2")}{colorDialog.Color.B.ToString("X2")}";
            }

            Render();
        }

        private void changeNumericValue(object sender, EventArgs e)
        {
            if (startForm)
            {
                circleScale.StartAngle = (int)startAngleNum.Value;
                circleScale.EndAngle = (int)endAngleNum.Value;
                circleScale.Width = (int)widthNum.Value;
                circleScale.RadiusX = (int)radiusXNum.Value;
                circleScale.RadiusY = (int)radiusYNum.Value;
                circleScale.CenterX = (int)centerXNum.Value;
                circleScale.CenterY = (int)centerYNum.Value;

                Render();
            }
        }

        private void NumberFormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PropertiesGroupBox.Enabled)
                if (saved == false && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    saved = true;
                    delete = false;
                }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saved = true;
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete = true;
            saved = false;
            this.Close();
        }
    }
}
