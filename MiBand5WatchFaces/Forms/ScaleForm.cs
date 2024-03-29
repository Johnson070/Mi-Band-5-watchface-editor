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
    public partial class ScaleForm : Form
    {
        public WatchFaceLibrary watch;
        public Scale scale;
        StateWatchface state;
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));
        string oldScale;

        bool startForm = true;
        bool moving;

        public bool saved = false;
        public bool delete = false; // height = 545 585

        private void Render()
        {
            VisualRender visual = new VisualRender(watch, state);
            previewImage.BackgroundImage = visual.GenWatchface();
        }

        public ScaleForm(WatchFaceLibrary watch, Scale scale, DefaultDictionary<int, Image> images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.scale = scale;
            this.watch.images = images;
            this.state = state;

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
                PropertiesGroupBox.Size += new Size(0, watch.SizeMiBand6Rasn.Height);
                deleteButton.Location += new Size(0, watch.SizeMiBand6Rasn.Height);
            }

            if (scale.StartImageIndex >= 0)
            {
                for (int i = 0; i < scale.Segments.Count; i++)
                    ImagesComboBox.Items.Add(i);

                ImagesComboBox.SelectedIndex = 0;

                posXNum.Value = scale.Segments[0].X;
                posYNum.Value = scale.Segments[0].Y;

                PropertiesGroupBox.Enabled = true;

                this.Size += new Size(0, 40);
            }

            oldScale = JsonConvert.SerializeObject(scale, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

            Render();
            startForm = false;
        }

        private void selectImages_Click(object sender, EventArgs e)
        {
            List<int> selImg = null;
            if (scale.StartImageIndex >= 0)
            {
                selImg = new List<int>();

                for (int i = scale.StartImageIndex; i < scale.StartImageIndex + scale.Segments.Count; i++)
                    selImg.Add(i);
            }
            ImagesForm imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, true, true);
            imgForm.ShowDialog();

            if (imgForm.saveImages == true && imgForm.selectedImages != null)
            {
                ImagesComboBox.Items.Clear();
                scale.Segments = scale.Segments == null ? new List<XY>() : scale.Segments;
                List<XY> newSegments = new List<XY>();
                foreach (int img in imgForm.selectedImages)
                {
                    bool match = img >= scale.StartImageIndex && img < scale.Segments.Count ? true : false;

                    newSegments.Add(match ? scale.Segments[img - scale.StartImageIndex] : new XY() { X = 0, Y = 0 });
                };
                scale.Segments = newSegments;
                scale.StartImageIndex = imgForm.selectedImages[0];
                foreach (int img in imgForm.selectedImages)
                {
                    ImagesComboBox.Items.Add(img);
                };
                ImagesComboBox.SelectedIndex = 0;

                watch.images = imgForm.Images;

                PropertiesGroupBox.Enabled = true;

                Render();
            }
            else if (imgForm.saveImages == true)
            {
                scale.StartImageIndex = -10000;
                scale.Segments = null;
                watch.images = imgForm.Images;

                PropertiesGroupBox.Enabled = false;

                saveBtn.Text = "Delete";
                delete = true;
                this.Close();
            }
        }

        private void posValueChanged(object sender, EventArgs e)
        {
            if (startForm == false)
            {
                NumericUpDown num = (NumericUpDown)sender;

                if (num.Name == posXNum.Name)
                {
                    scale.Segments[ImagesComboBox.SelectedIndex].X = (int)posXNum.Value;
                }
                else if (num.Name == posYNum.Name)
                {
                    scale.Segments[ImagesComboBox.SelectedIndex].Y = (int)posYNum.Value;
                }

                Render();
            }
        }

        private void NumberFormEdit_Shown(object sender, EventArgs e)
        {
            Render();
        }

        private void NumberFormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PropertiesGroupBox.Enabled)
                if (saved == false && oldScale != JsonConvert.SerializeObject(scale, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore })&& MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

        private void previewImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (moving == false)
            {

                moving = true;
                startForm = true;
            }
        }

        private void previewImage_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            startForm = false;
        }

        private void previewImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                scale.Segments[ImagesComboBox.SelectedIndex].X = e.X;
                scale.Segments[ImagesComboBox.SelectedIndex].Y = e.Y;
                posXNum.Value = e.X;
                posYNum.Value = e.Y;

                Render();
            }
        }

        private void ImagesComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                posXNum.Value = scale.Segments[ImagesComboBox.SelectedIndex].X;
                posYNum.Value = scale.Segments[ImagesComboBox.SelectedIndex].Y;
            }
            catch { }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete = true;
            saved = false;
            this.Close();
        }
    }
}
