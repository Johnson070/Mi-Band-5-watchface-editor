using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBand5WatchFaces.Forms
{
    public partial class AnalogDialFaceForm : Form
    {
        public WatchFaceLibrary watch;

        StateWatchface state;
        VisualRender render;
        public bool Save;

        public void Render(StateWatchface state = null)
        {
            render = new VisualRender(watch, state);
            ImagePic.BackgroundImage = render.GenWatchface();
        }

        public static T DeepCopy<T>(T other)
        {
            if (other == null) return default(T);

            string clone = JsonConvert.SerializeObject(other);
            return JsonConvert.DeserializeObject<T>(clone);
        }

        public AnalogDialFaceForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.state = state;
            this.watch.imagesBuff = Images;

            this.watch.AnalogDialFace = this.watch.AnalogDialFace == null ? new AnalogDialFace() : this.watch.AnalogDialFace;
            Render(state);

            if (watch.AnalogDialFace.Hours != null)
            {
                hoursCheckbox.Checked = true;
                propertiesHoursGroup.Enabled = true;
                AddArrowHoursButton.Text = "Edit arrow";
                if (watch.AnalogDialFace.Hours.CenterImage != null)
                    AddCenterImageHoursButton.Text = "Edit center image";
                AddColorButtonHours.BackColor = convertColorFromString(watch.AnalogDialFace.Hours.Color);
                posXHours.Value = watch.AnalogDialFace.Hours.Center.X;
                posYHours.Value = watch.AnalogDialFace.Hours.Center.Y;
                OnlyborderHours.Checked = watch.AnalogDialFace.Hours.OnlyBorder;
            }
            if (watch.AnalogDialFace.Minutes != null)
            {
                minutesCheckbox.Checked = true;
                PropertiesMinutesGroupBox.Enabled = true;
                AddArrowMinutesButton.Text = "Edit arrow";
                if (watch.AnalogDialFace.Minutes.CenterImage != null)
                    AddCenterImageMinutesButton.Text = "Edit center image";
                AddColorMinutesButton.BackColor = convertColorFromString(watch.AnalogDialFace.Minutes.Color);
                posXMinutes.Value = watch.AnalogDialFace.Minutes.Center.X;
                posYMinutes.Value = watch.AnalogDialFace.Minutes.Center.Y;
                OnlyborderMinutes.Checked = watch.AnalogDialFace.Minutes.OnlyBorder;
            }
        }

        private void AddArrowHoursButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.AnalogDialFace.Hours = watchface.AnalogDialFace.Hours == null ? new ClockHand() : watchface.AnalogDialFace.Hours;
            ArrowPaintForm arrowPaintForm = new ArrowPaintForm(watchface.AnalogDialFace.Hours.Shape);
            arrowPaintForm.ShowDialog();

            if (arrowPaintForm.Save && arrowPaintForm.shape.Count > 0)
            {
                watch.AnalogDialFace.Hours = watch.AnalogDialFace.Hours == null ? new ClockHand() : watch.AnalogDialFace.Hours;
                watch.AnalogDialFace.Hours.Shape = arrowPaintForm.shape;
                AddArrowHoursButton.Text = "Edit arrow";
                propertiesHoursGroup.Enabled = true;
            }
            else if (arrowPaintForm.Save && arrowPaintForm.shape.Count == 0)
            {
                watch.AnalogDialFace.Hours = null;
                AddArrowHoursButton.Text = "Add arrow";
                propertiesHoursGroup.Enabled = false;
            }

            Render(state);
        }

        private Color convertColorFromString(string _color) => Color.FromArgb(Convert.ToInt16(_color.Substring(2, 2), 16), Convert.ToInt16(_color.Substring(4, 2), 16), Convert.ToInt16(_color.Substring(6, 2), 16));

        private void AddCenterImageMinutesButton_Click(object sender, EventArgs e)
        {
            watch.AnalogDialFace.Minutes.CenterImage = watch.AnalogDialFace.Minutes.CenterImage == null ? new ImageBasic() : watch.AnalogDialFace.Minutes.CenterImage;
            ImageBasicForm ibForm = new ImageBasicForm(watch, watch.AnalogDialFace.Minutes.CenterImage, watch.imagesBuff.DeepCopy(), state);
            ibForm.ShowDialog();

            if (ibForm.saved)
            {
                AddCenterImageMinutesButton.Text = "Edit image center";
                watch.AnalogDialFace.Minutes.CenterImage = ibForm.imageBasic;
                watch.imagesBuff = ibForm.watch.imagesBuff;
            }
            else
            {
                AddCenterImageMinutesButton.Text = "Add image center";
                watch.AnalogDialFace.Minutes.CenterImage = null;
                watch.imagesBuff = ibForm.watch.imagesBuff;
            }
            Render(state);
        }

        private void AddColorMinutesButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
            {
                AddColorButtonHours.BackColor = color.Color;
                watch.AnalogDialFace.Minutes.Color = $"0x{color.Color.R.ToString("X2")}{color.Color.G.ToString("X2")}{color.Color.B.ToString("X2")}";
            }
            Render(state);
        }

        private void changePos(object sender, EventArgs e)
        {
            string name = ((NumericUpDown)sender).Name;

            if (name == "posXMinutes")
            {
                watch.AnalogDialFace.Minutes.Center.X = (int)posXMinutes.Value;
            }
            else if (name == "posYMinutes")
            {
                watch.AnalogDialFace.Minutes.Center.Y = (int)posYMinutes.Value;
            }
            else if (name == "posXHours")
            {
                watch.AnalogDialFace.Hours.Center.X = (int)posXHours.Value;
            }
            else if (name == "posYHours")
            {
                watch.AnalogDialFace.Hours.Center.Y = (int)posYHours.Value;
            }
            Render(state);
        }

        private void AddCenterImageHoursButton_Click(object sender, EventArgs e)
        {
            watch.AnalogDialFace.Hours.CenterImage = watch.AnalogDialFace.Hours.CenterImage == null ? new ImageBasic() : watch.AnalogDialFace.Hours.CenterImage;
            ImageBasicForm ibForm = new ImageBasicForm(watch, watch.AnalogDialFace.Hours.CenterImage, watch.imagesBuff.DeepCopy(), state);
            ibForm.ShowDialog();

            if (ibForm.saved)
            {
                AddCenterImageHoursButton.Text = "Edit image center";
                watch.AnalogDialFace.Hours.CenterImage = ibForm.imageBasic;
                watch.imagesBuff = ibForm.watch.imagesBuff;
            }
            else
            {
                AddCenterImageHoursButton.Text = "Add image center";
                watch.AnalogDialFace.Hours.CenterImage = null;
                watch.imagesBuff = ibForm.watch.imagesBuff;
            }
            Render(state);
        }

        private void AddColorButtonHours_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
            {
                AddColorButtonHours.BackColor = color.Color;
                watch.AnalogDialFace.Hours.Color = $"0x{color.Color.R.ToString("X2")}{color.Color.G.ToString("X2")}{color.Color.B.ToString("X2")}";
            }
            Render(state);
        }

        private void OnlyborderHours_CheckedChanged(object sender, EventArgs e)
        {
            watch.AnalogDialFace.Hours.OnlyBorder = OnlyborderHours.Checked;
            Render(state);
        }

        private void OnlyborderMinutes_CheckedChanged(object sender, EventArgs e)
        {
            watch.AnalogDialFace.Minutes.OnlyBorder = OnlyborderMinutes.Checked;
            Render(state);
        }

        private void AddArrowMinutesButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.AnalogDialFace.Minutes = watchface.AnalogDialFace.Minutes == null ? new ClockHand() : watchface.AnalogDialFace.Minutes;
            ArrowPaintForm arrowPaintForm = new ArrowPaintForm(watchface.AnalogDialFace.Minutes.Shape);
            arrowPaintForm.ShowDialog();

            if (arrowPaintForm.Save && arrowPaintForm.shape.Count > 0)
            {
                watch.AnalogDialFace.Minutes = watch.AnalogDialFace.Minutes == null ? new ClockHand() : watch.AnalogDialFace.Minutes;
                watch.AnalogDialFace.Minutes.Shape = arrowPaintForm.shape;
                AddArrowMinutesButton.Text = "Edit arrow";
                PropertiesMinutesGroupBox.Enabled = true;
            }
            else if (arrowPaintForm.Save && arrowPaintForm.shape.Count == 0)
            {
                watch.AnalogDialFace.Minutes = null;
                AddArrowMinutesButton.Text = "Add arrow";
                PropertiesMinutesGroupBox.Enabled = false;
            }

            Render(state);
        }

        private void tabCheckState(object sender, EventArgs e)
        {
            groupBox3.Enabled = hoursCheckbox.Checked;
            groupBox1.Enabled = minutesCheckbox.Checked; 
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save = true;
            if (hoursCheckbox.Checked == false || watch.AnalogDialFace?.Hours?.Shape == null)
                watch.AnalogDialFace.Hours = null;
            if (minutesCheckbox.Checked == false || watch.AnalogDialFace?.Minutes?.Shape == null)
                watch.AnalogDialFace.Minutes = null;

            if (watch.AnalogDialFace.Minutes == null && watch.AnalogDialFace.Hours == null)
                watch.AnalogDialFace = null;
            this.Close();
        }

        private void AnalogDialFaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show("Do you want to get out without saving?", "Don't Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (hoursCheckbox.Checked == false || watch.AnalogDialFace?.Hours?.Shape == null)
                    watch.AnalogDialFace.Hours = null;
                if (minutesCheckbox.Checked == false || watch.AnalogDialFace?.Minutes?.Shape == null)
                    watch.AnalogDialFace.Minutes = null;

                if (watch.AnalogDialFace.Minutes == null && watch.AnalogDialFace.Hours == null)
                    watch.AnalogDialFace = null;
            }
        }
    }
}
