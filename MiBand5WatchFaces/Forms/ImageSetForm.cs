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
    public partial class ImageSetForm : Form
    {
        public WatchFaceLibrary watch;
        public ImageSet imageSet;
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));
        string oldImageSet;

        StateWatchface state;
        bool startForm = true;
        bool moving;
        int countImages = -1;
        public bool saved = false;
        public bool delete = false; // height = 505 550 up

        private void Render()
        {
            VisualRender visual = new VisualRender(watch, state);
            previewImage.BackgroundImage = visual.GenWatchface();
        }


        public ImageSetForm(WatchFaceLibrary watch, ImageSet imageSet, DefaultDictionary<int, Image> images, StateWatchface state = null, int countImages = -1)
        {
            InitializeComponent();
            this.watch = watch;
            this.imageSet = imageSet;
            this.watch.images = images;
            this.state = state;
            this.countImages = countImages;

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
                PropertiesGroupBox.Size += new Size(0, watch.SizeMiBand6Rasn.Height);
                deleteButton.Location += new Size(0, watch.SizeMiBand6Rasn.Height);
            }

            if (imageSet.ImageIndex != -10000)
            {
                PropertiesGroupBox.Enabled = true;

                posXNum.Value = imageSet.X;
                posYNum.Value = imageSet.Y;

                this.Size += new Size(0, 45);

                Render();
            }

            oldImageSet = JsonConvert.SerializeObject(imageSet, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

            startForm = false;
        }

        private void selectImages_Click(object sender, EventArgs e)
        {
            List<int> selImg = null;
            if (imageSet.ImageIndex != -10000)
            {
                selImg = new List<int>();
                for (int i = imageSet.ImageIndex; i < imageSet.ImageIndex + imageSet.ImagesCount; i++)
                    selImg.Add(i);
            }

            ImagesForm imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, true, true, countImages);
            imgForm.ShowDialog();

            if (imgForm.saveImages == true && imgForm.selectedImages != null)
            {
                watch.images = imgForm.Images;
                imageSet.ImageIndex = imgForm.selectedImages[0];
                imageSet.ImagesCount = imgForm.selectedImages.Count();

                PropertiesGroupBox.Enabled = true;

                Render();
            }
            else if (imgForm.saveImages == true)
            {
                watch.images = imgForm.Images;
                imageSet.ImageIndex = -10000;
                imageSet.ImagesCount = 0;

                PropertiesGroupBox.Enabled = false;

                saveBtn.Text = "Delete";
                saved = true;
                this.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saved = true;
            this.Close();
        }

        private void ImageSetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PropertiesGroupBox.Enabled)
                if (saved == false && oldImageSet != JsonConvert.SerializeObject(imageSet, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }) && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    saved = true;
                    delete = false;
                }
        }

        private void posChanged(object sender, EventArgs e)
        {
            if (startForm == false)
            {
                NumericUpDown num = (NumericUpDown)sender;

                if (num.Name == posXNum.Name)
                {
                    imageSet.X = (int)posXNum.Value;
                }
                else if (num.Name == posYNum.Name)
                {
                    imageSet.Y = (int)posYNum.Value;
                }

                Render();
            }
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
                imageSet.X = e.X;
                imageSet.Y = e.Y;
                posXNum.Value = imageSet.X;
                posYNum.Value = imageSet.Y;

                Render();
            }
        }

        private void posXNum_ValueChanged(object sender, EventArgs e)
        {
            if (startForm == false)
            {
                imageSet.X = (int)posXNum.Value;

                Render();
            }
        }

        private void posYNum_ValueChanged(object sender, EventArgs e)
        {
            if (startForm == false)
            {
                imageSet.Y = (int)posYNum.Value;

                Render();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete = true;
            saved = false;
            this.Close();
        }
    }
}
