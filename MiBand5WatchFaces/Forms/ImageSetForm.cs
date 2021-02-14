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
        StateWatchface state;
        bool startForm = true;
        bool moving;
        int countImages = -1;
        public bool saved = false;

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
            this.watch.imagesBuff = images;
            this.state = state;
            this.countImages = countImages;

            if (imageSet.ImageIndex != -10000)
            {
                PropertiesGroupBox.Enabled = true;

                posXNum.Value = imageSet.X;
                posYNum.Value = imageSet.Y;

                Render();
            }

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

            ImagesForm imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, true, true, countImages);
            imgForm.ShowDialog();

            if (imgForm.saveImages == true && imgForm.selectedImages != null)
            {
                watch.imagesBuff = imgForm.Images;
                imageSet.ImageIndex = imgForm.selectedImages[0];
                imageSet.ImagesCount = imgForm.selectedImages.Count();

                PropertiesGroupBox.Enabled = true;

                Render();
            }
            else if (imgForm.saveImages == true)
            {
                watch.imagesBuff = imgForm.Images;
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
                if (saved == false && MessageBox.Show("Do you want to get out without saving?", "Don't Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    saved = true;
                }
        }

        private void posChanged(object sender, EventArgs e)
        {
            if (startForm == false)
            {
                NumericUpDown num = (NumericUpDown)sender;

                if (num.Name == "posXNum")
                {
                    imageSet.X = (int)posXNum.Value;
                }
                else if (num.Name == "posYNum")
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
    }
}
