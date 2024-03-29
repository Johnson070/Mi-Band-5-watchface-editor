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
    public partial class HeartProgressForm : Form
    {
        public WatchFaceLibrary watch;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Resources.Resource1));

        StateWatchface state;
        VisualRender render;
        public bool Save;
        string oldHeart;

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

        public HeartProgressForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.watch.images = Images;
            this.state = state;
            this.watch.HeartProgress = this.watch.HeartProgress == null ? new HeartProgress() : this.watch.HeartProgress;

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
            }
            else tabControl1.TabPages.Remove(tabControl1.TabPages["CircleScale"]);

            oldHeart = JsonConvert.SerializeObject(this.watch.HeartProgress, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            Render(state);


            if (watch.HeartProgress.Scale != null)
            {
                AddScaleButton.Text = resources.GetString("EditImages");
                ScaleImageCheckbox.Checked = true;
            }
            if (watch.HeartProgress.LineScale != null)
            {
                AddLineScaleButton.Text = resources.GetString("EditImages");
                LineScaleCheckbox.Checked = true;
            }
            if (watch.HeartProgress.Linear != null)
            {
                AddLinearImages.Text = resources.GetString("EditImages");
                LinearCheckBox.Checked = true;
            }
        }

        private void AddLineScaleImages_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.HeartProgress.Linear = watchface.HeartProgress.Linear == null ? new Scale() : watchface.HeartProgress.Linear;
            StateWatchface heartState= DeepCopy(state);
            heartState.Pulse = 150;
            ScaleForm scaleForm = new ScaleForm(watchface, watchface.HeartProgress.Linear, watch.images.DeepCopy(), heartState);
            scaleForm.ShowDialog();

            if (scaleForm.saved == true && scaleForm.scale.StartImageIndex >= 0)
            {
                watch.HeartProgress.Linear = scaleForm.scale;
                watch.images = scaleForm.watch.images;

                AddLinearImages.Text = resources.GetString("EditImages");
            }
            else if (scaleForm.delete)
            {
                watch.HeartProgress.Linear = null;
                watch.images = scaleForm.watch.images;

                AddLinearImages.Text = resources.GetString("AddImages");
            }

            Render(state);
        }

        private void AddScaleButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.HeartProgress.Scale = watchface.HeartProgress.Scale == null ? new Scale() : watchface.HeartProgress.Scale;
            StateWatchface heartState = DeepCopy(state);
            heartState.Pulse = 150;
            ScaleForm scaleForm = new ScaleForm(watchface, watchface.HeartProgress.Scale, watch.images.DeepCopy(), heartState);
            scaleForm.ShowDialog();

            if (scaleForm.saved == true && scaleForm.scale.StartImageIndex >= 0)
            {
                watch.HeartProgress.Scale = scaleForm.scale;
                watch.images = scaleForm.watch.images;

                AddScaleButton.Text = resources.GetString("EditImages");
            }
            else if (scaleForm.delete)
            {
                watch.HeartProgress.Scale = null;
                watch.images = scaleForm.watch.images;

                AddScaleButton.Text = resources.GetString("AddImages");
            }

            Render(state);
        }

        private void AddLineScaleButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.HeartProgress.LineScale = watchface.HeartProgress.LineScale == null ? new ImageSet() : watchface.HeartProgress.LineScale;
            ImageSetForm setForm = new ImageSetForm(watchface, watchface.HeartProgress.LineScale, watch.images.DeepCopy(), state);
            setForm.ShowDialog();

            if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
            {
                watch.images = setForm.watch.images;
                watch.HeartProgress.LineScale = watch.HeartProgress.LineScale == null ? new ImageSet() : watch.HeartProgress.LineScale;
                watch.HeartProgress.LineScale = setForm.imageSet;
                AddLineScaleButton.Text = resources.GetString("EditImages");
            }
            else if (setForm.delete)
            {
                watch.images = setForm.watch.images;
                watch.HeartProgress.LineScale = null;
                AddLineScaleButton.Text = resources.GetString("AddImages");
            }

            Render(state);
        }

        private void ChangeCheck(object sender, EventArgs e)
        {
            groupBox1.Enabled = ScaleImageCheckbox.Checked;
            groupBox3.Enabled = LineScaleCheckbox.Checked;
            groupBox2.Enabled = LinearCheckBox.Checked;
        }

        private void NumberFormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && oldHeart != JsonConvert.SerializeObject(this.watch.HeartProgress, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }) && MessageBox.Show(resources.GetString("ExitMessage"), resources.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;

                if (LinearCheckBox.Checked == false) watch.HeartProgress.Linear = null;
                if (LineScaleCheckbox.Checked == false) watch.HeartProgress.LineScale = null;
                if (ScaleImageCheckbox.Checked == false) watch.HeartProgress.Scale = null;

                if (watch.HeartProgress.Linear == null && watch.HeartProgress.LineScale == null && watch.HeartProgress.Scale == null)
                    watch.HeartProgress = null;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save = true;
            if (LinearCheckBox.Checked == false) watch.HeartProgress.Linear = null;
            if (LineScaleCheckbox.Checked == false) watch.HeartProgress.LineScale = null;
            if (ScaleImageCheckbox.Checked == false) watch.HeartProgress.Scale = null;
            if (CircleScaleCheckbox.Checked == false) watch.HeartProgress.CircleScale = null;

            if (watch.HeartProgress.Linear == null && watch.HeartProgress.LineScale == null && watch.HeartProgress.Scale == null && watch.HeartProgress.CircleScale == null)
                watch.HeartProgress = null;
            this.Close();
        }

        private void AddCircleScale_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.HeartProgress.CircleScale = watchface.HeartProgress.CircleScale == null ? new CircleScale() : watchface.HeartProgress.CircleScale;

            CircleScaleForm scaleForm = new CircleScaleForm(watchface, watchface.HeartProgress.CircleScale, watch.images.DeepCopy(), state);
            scaleForm.ShowDialog();

            if (scaleForm.saved)
            {
                watch.HeartProgress.CircleScale = scaleForm.circleScale;
                watch.images = scaleForm.watch.images;

                AddCircleScale.Text = resources.GetString("EditCircleScale");
            }
            else if (scaleForm.delete)
            {
                watch.HeartProgress.CircleScale = null;
                watch.images = scaleForm.watch.images;

                AddCircleScale.Text = resources.GetString("AddCircleScale");
            }

            Render(state);
        }
    }
}
