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
    public partial class ImageBasicForm : Form
    {
        public WatchFaceLibrary watch;
        public ImageBasic imageBasic;
        StateWatchface state;
        bool startForm = true;
        bool moving;
        public bool saved = false;

        public ImageBasicForm(WatchFaceLibrary watch, ImageBasic imageBasic, DefaultDictionary<int, Image> images, StateWatchface state = null)
        {
            InitializeComponent();
            this.watch = watch;
            this.imageBasic = imageBasic;
            this.watch.imagesBuff = images;
            this.state = state;

            if (imageBasic.ImageIndex != -10000)
            {
                PropertiesGroupBox.Enabled = true;

                posXNum.Value = imageBasic.X;
                posYNum.Value = imageBasic.Y;

                Render();
            }

            startForm = false;
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            List<int> selImg = null;
            if (imageBasic.ImageIndex != -10000)
            {
                selImg = new List<int>();
                selImg.Add(imageBasic.ImageIndex);
            }

            ImagesForm imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
            imgForm.ShowDialog();

            if (imgForm.saveImages == true && imgForm.selectedImages != null)
            {
                watch.imagesBuff = imgForm.Images;
                imageBasic.ImageIndex = imgForm.selectedImages[0];

                PropertiesGroupBox.Enabled = true;

                Render();
            }
            else if (imgForm.saveImages == true)
            {
                watch.imagesBuff = imgForm.Images;
                imageBasic.ImageIndex = -10000;

                PropertiesGroupBox.Enabled = false;
                saveBtn.Text = "Delete";
                saved = true;
                this.Close();
            }
        }
        private void Render()
        {
            VisualRender visual = new VisualRender(watch, state);
            previewImage.BackgroundImage = visual.GenWatchface();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saved = true;
            this.Close();
        }

        private void ImageBasicForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    imageBasic.X = (int)posXNum.Value;
                }
                else if (num.Name == "posYNum")
                {
                    imageBasic.Y = (int)posYNum.Value;
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
                imageBasic.X = e.X;
                imageBasic.Y = e.Y;
                posXNum.Value = imageBasic.X;
                posYNum.Value = imageBasic.Y;

                Render();
            }
        }
    }
}
