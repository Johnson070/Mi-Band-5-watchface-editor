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
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

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
            this.watch.images = Images;

            this.watch.AnalogDialFace = this.watch.AnalogDialFace == null ? new AnalogDialFace() : this.watch.AnalogDialFace;

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
            }

            Render(state);

            if (watch.AnalogDialFace.Hours != null)
            {
                hoursCheckbox.Checked = true;
                propertiesHoursGroup.Enabled = true;
                AddArrowHoursButton.Text = res.GetString("EditArrow");
                if (watch.AnalogDialFace.Hours.CenterImage != null)
                    AddCenterImageHoursButton.Text = res.GetString("EditCenterImage");
                AddColorButtonHours.BackColor = convertColorFromString(watch.AnalogDialFace.Hours.Color);
                posXHours.Value = watch.AnalogDialFace.Hours.Center.X;
                posYHours.Value = watch.AnalogDialFace.Hours.Center.Y;
                OnlyborderHours.Checked = watch.AnalogDialFace.Hours.OnlyBorder;
            }
            if (watch.AnalogDialFace.Minutes != null)
            {
                minutesCheckbox.Checked = true;
                PropertiesMinutesGroupBox.Enabled = true;
                AddArrowMinutesButton.Text = res.GetString("EditArrow");
                if (watch.AnalogDialFace.Minutes.CenterImage != null)
                    AddCenterImageMinutesButton.Text = res.GetString("EditCenterImage");
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
                AddArrowHoursButton.Text = res.GetString("EditArrow");
                propertiesHoursGroup.Enabled = true;
            }
            else if (arrowPaintForm.delete)
            {
                watch.AnalogDialFace.Hours = null;
                AddArrowHoursButton.Text = res.GetString("AddArrow");
                propertiesHoursGroup.Enabled = false;
            }

            Render(state);
        }

        private Color convertColorFromString(string _color) => Color.FromArgb(Convert.ToInt16(_color.Substring(2, 2), 16), Convert.ToInt16(_color.Substring(4, 2), 16), Convert.ToInt16(_color.Substring(6, 2), 16));

        private void AddCenterImageMinutesButton_Click(object sender, EventArgs e)
        {
            watch.AnalogDialFace.Minutes.CenterImage = watch.AnalogDialFace.Minutes.CenterImage == null ? new ImageBasic() : watch.AnalogDialFace.Minutes.CenterImage;
            ImageBasicForm ibForm = new ImageBasicForm(watch, watch.AnalogDialFace.Minutes.CenterImage, watch.images.DeepCopy(), state);
            ibForm.ShowDialog();

            if (ibForm.saved)
            {
                AddCenterImageMinutesButton.Text = res.GetString("EditCenterImage");
                watch.AnalogDialFace.Minutes.CenterImage = ibForm.imageBasic;
                watch.images = ibForm.watch.images;
            }
            else if (ibForm.delete)
            {
                AddCenterImageMinutesButton.Text = res.GetString("AddCenterImage");
                watch.AnalogDialFace.Minutes.CenterImage = null;
                watch.images = ibForm.watch.images;
            }
            Render(state);
        }

        private void AddColorMinutesButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
            {
                AddColorMinutesButton.BackColor = color.Color;
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
            ImageBasicForm ibForm = new ImageBasicForm(watch, watch.AnalogDialFace.Hours.CenterImage, watch.images.DeepCopy(), state);
            ibForm.ShowDialog();

            if (ibForm.saved)
            {
                AddCenterImageHoursButton.Text = res.GetString("EditCenterImage");
                watch.AnalogDialFace.Hours.CenterImage = ibForm.imageBasic;
                watch.images = ibForm.watch.images;
            }
            else if (ibForm.delete)
            {
                AddCenterImageHoursButton.Text = res.GetString("AddCenterImage");
                watch.AnalogDialFace.Hours.CenterImage = null;
                watch.images = ibForm.watch.images;
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
                AddArrowMinutesButton.Text = res.GetString("EditArrow");
                PropertiesMinutesGroupBox.Enabled = true;
            }
            else if (arrowPaintForm.delete)
            {
                watch.AnalogDialFace.Minutes = null;
                AddArrowMinutesButton.Text = res.GetString("AddArrow");
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
            if (Save == false && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
