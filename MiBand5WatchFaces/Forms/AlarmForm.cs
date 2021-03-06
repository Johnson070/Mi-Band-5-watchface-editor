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
    public partial class AlarmForm : Form
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

        public AlarmForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.watch.imagesBuff = Images;
            this.state = state;
            this.watch.Alarm = this.watch.Alarm == null ? new Alarm() : this.watch.Alarm;
            Render(state);

            if (watch.Alarm.Text != null)
            {
                AddNumberButton.Text = "Edit number";
                groupBox1.Enabled = true;
                if (watch.Alarm.DelimiterImageIndex >= 0) AddDelimeterButton.Text = "Edit delimeter";
                if (watch.Alarm.ImageOn != null) AddImageOnButton.Text = "Edit image ON";
                if (watch.Alarm.ImageOff != null) AddImageOFFButton.Text = "Edit image OFF";
                if (watch.Alarm.ImageNoAlarm != null) AddImageNoAlarmButton.Text = "Edit image no alarm";
            }
        }

        private void AddNumberButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.Alarm.Text = watchface.Alarm.Text == null ? new Number() { notDraw = true } : watchface.Alarm.Text;
            StateWatchface newState = DeepCopy(state);
            newState.AlarmIsSet = true;
            newState.AlarmNoTime = false;
            NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Alarm.Text, watch.imagesBuff.DeepCopy(), newState);
            numForm.ShowDialog();

            if (numForm.saved && numForm.number.ImageIndex >= 0)
            {
                watch.Alarm.Text = numForm.number;
                watch.imagesBuff = numForm.watch.imagesBuff;
                AddNumberButton.Text = "Edit number";
                groupBox1.Enabled = true;
            }
            else if (numForm.saved)
            {
                watch.imagesBuff = numForm.watch.imagesBuff;
                watch.Alarm.Text = null;
                AddNumberButton.Text = "Add number";
            }

            Render(state);
        }

        private void AddImageClick(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;

            if (name == AddDelimeterButton.Name)
            {
                List<int> selImg = null;
                ImagesForm imgForm;
                if (watch.Alarm.DelimiterImageIndex >= 0) selImg = new List<int>() { watch.Alarm.DelimiterImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Alarm.DelimiterImageIndex = imgForm.selectedImages[0];
                    AddDelimeterButton.Text = "Edit delimeter";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Alarm.DelimiterImageIndex = -10000;
                    AddDelimeterButton.Text = "Add delimeter";
                }
            }
            else if (name == AddImageOnButton.Name)
            {
                watch.Alarm.ImageOn = watch.Alarm.ImageOn == null ? new ImageBasic() : watch.Alarm.ImageOn;
                StateWatchface newState = DeepCopy(state);
                newState.AlarmIsSet = true;
                newState.AlarmNoTime = false;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Alarm.ImageOn, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    AddImageOnButton.Text = "Edit image ON";
                    watch.Alarm.ImageOn = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else
                {
                    AddImageOnButton.Text = "Add image ON";
                    watch.Alarm.ImageOn = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (name == AddImageOFFButton.Name)
            {
                watch.Alarm.ImageOff = watch.Alarm.ImageOff == null ? new ImageBasic() : watch.Alarm.ImageOff;
                StateWatchface newState = DeepCopy(state);
                newState.AlarmIsSet = false;
                newState.AlarmNoTime = false;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Alarm.ImageOff, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    AddImageOFFButton.Text = "Edit image OFF";
                    watch.Alarm.ImageOn = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else
                {
                    AddImageOFFButton.Text = "Add image OFF";
                    watch.Alarm.ImageOn = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (name == AddImageNoAlarmButton.Name)
            {
                watch.Alarm.ImageOff = watch.Alarm.ImageOff == null ? new ImageBasic() : watch.Alarm.ImageOff;
                StateWatchface newState = DeepCopy(state);
                newState.AlarmNoTime = true;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Alarm.ImageNoAlarm, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    AddImageNoAlarmButton.Text = "Edit image no alarm";
                    watch.Alarm.ImageNoAlarm = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else
                {
                    AddImageNoAlarmButton.Text = "Add image no alarm";
                    watch.Alarm.ImageNoAlarm = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }

            Render(state);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save = true;
            if (watch.Alarm.Text == null)
                watch.Alarm = null;
            this.Close();
        }

        private void AlarmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show("Do you want to get out without saving?", "Don't Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (watch.Alarm.Text == null)
                    watch.Alarm = null;
            }
        }
    }
}
