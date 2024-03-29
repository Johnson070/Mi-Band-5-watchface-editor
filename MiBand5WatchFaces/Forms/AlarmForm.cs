﻿using Newtonsoft.Json;
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Resources.Resource1));
        string oldAlarm;

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
            this.watch.images = Images;
            this.state = state;
            this.watch.Alarm = this.watch.Alarm == null ? new Alarm() : this.watch.Alarm;

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
            }

            oldAlarm = JsonConvert.SerializeObject(this.watch.Alarm, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            Render(state);

            if (watch.Alarm.Text != null)
            {
                AddNumberButton.Text = resources.GetString("EditNumber");
                groupBox1.Enabled = true;
                if (watch.Alarm.DelimiterImageIndex >= 0) AddDelimeterButton.Text = resources.GetString("EditDelimeter");
                if (watch.Alarm.ImageOn != null) AddImageOnButton.Text = resources.GetString("EditImageOn");
                if (watch.Alarm.ImageOff != null) AddImageOFFButton.Text = resources.GetString("EditImageOff");
                if (watch.Alarm.ImageNoAlarm != null) AddImageNoAlarmButton.Text = resources.GetString("EditImageNoAlarm");
            }
        }

        private void AddNumberButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.Alarm.Text = watchface.Alarm.Text == null ? new Number() { notDraw = true } : watchface.Alarm.Text;
            StateWatchface newState = DeepCopy(state);
            newState.AlarmIsSet = true;
            newState.AlarmNoTime = false;
            NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Alarm.Text, watch.images.DeepCopy(), newState);
            numForm.ShowDialog();

            if (numForm.saved && numForm.number.ImageIndex >= 0)
            {
                watch.Alarm.Text = numForm.number;
                watch.images = numForm.watch.images;
                AddNumberButton.Text = resources.GetString("EditNumber");
                groupBox1.Enabled = true;
            }
            else if (numForm.delete)
            {
                watch.images = numForm.watch.images;
                watch.Alarm.Text = null;
                AddNumberButton.Text = resources.GetString("AddNumber");
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

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Alarm.DelimiterImageIndex = imgForm.selectedImages[0];
                    AddDelimeterButton.Text = resources.GetString("EditDelimeter");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Alarm.DelimiterImageIndex = -10000;
                    AddDelimeterButton.Text = resources.GetString("AddDelimeter");
                }
            }
            else if (name == AddImageOnButton.Name)
            {
                watch.Alarm.ImageOn = watch.Alarm.ImageOn == null ? new ImageBasic() : watch.Alarm.ImageOn;
                StateWatchface newState = DeepCopy(state);
                newState.AlarmIsSet = true;
                newState.AlarmNoTime = false;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Alarm.ImageOn, watch.images.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    AddImageOnButton.Text = resources.GetString("EditImageOn");
                    watch.Alarm.ImageOn = ibForm.imageBasic;
                    watch.images = ibForm.watch.images;
                }
                else if (ibForm.delete)
                {
                    AddImageOnButton.Text = resources.GetString("AddImageOn");
                    watch.Alarm.ImageOn = null;
                    watch.images = ibForm.watch.images;
                }
            }
            else if (name == AddImageOFFButton.Name)
            {
                watch.Alarm.ImageOff = watch.Alarm.ImageOff == null ? new ImageBasic() : watch.Alarm.ImageOff;
                StateWatchface newState = DeepCopy(state);
                newState.AlarmIsSet = false;
                newState.AlarmNoTime = false;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Alarm.ImageOff, watch.images.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    AddImageOFFButton.Text = resources.GetString("EditImageOff");
                    watch.Alarm.ImageOff = ibForm.imageBasic;
                    watch.images = ibForm.watch.images;
                }
                else if (ibForm.delete)
                {
                    AddImageOFFButton.Text = resources.GetString("AddImageOff");
                    watch.Alarm.ImageOff = null;
                    watch.images = ibForm.watch.images;
                }
            }
            else if (name == AddImageNoAlarmButton.Name)
            {
                watch.Alarm.ImageNoAlarm = watch.Alarm.ImageNoAlarm == null ? new ImageBasic() : watch.Alarm.ImageNoAlarm;
                StateWatchface newState = DeepCopy(state);
                newState.AlarmNoTime = true;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Alarm.ImageNoAlarm, watch.images.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    AddImageNoAlarmButton.Text = resources.GetString("EditImageNoAlarm");
                    watch.Alarm.ImageNoAlarm = ibForm.imageBasic;
                    watch.images = ibForm.watch.images;
                }
                else if (ibForm.delete)
                {
                    AddImageNoAlarmButton.Text = resources.GetString("AddImageNoAlarm");
                    watch.Alarm.ImageNoAlarm = null;
                    watch.images = ibForm.watch.images;
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
            if (Save == false && oldAlarm != JsonConvert.SerializeObject(this.watch.Alarm, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }) && MessageBox.Show(resources.GetString("ExitMessage"), resources.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (watch.Alarm.Text == null)
                    watch.Alarm = null;
            }
        }
    }
}
