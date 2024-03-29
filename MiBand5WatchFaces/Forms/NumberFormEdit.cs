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

namespace MiBand5WatchFaces
{
    public partial class NumberFormEdit : Form
    {
        public WatchFaceLibrary watch;
        public Number number;
        StateWatchface state;
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));
        string oldNumber;

        int countImages = -1;
        bool startForm = true;
        bool moving;

        public bool saved = false;
        public bool delete = false; // height = 635 675 up

        public NumberFormEdit(WatchFaceLibrary watch, Number number, DefaultDictionary<int, Image> images, StateWatchface state, int countImages = -1)
        {
            InitializeComponent();
            this.watch = watch;
            this.number = number;
            this.watch.images = images;
            this.state = state;
            this.countImages = countImages;

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
                PropertiesGroupBox.Size += new Size(0, watch.SizeMiBand6Rasn.Height);
                deleteButton.Location += new Size(0, watch.SizeMiBand6Rasn.Height);
            }

            if (number != null && number.notDraw == false)
            {
                PropertiesGroupBox.Enabled = true;

                spacingXNum.Value = number.SpacingX;
                spaсingYNum.Value = number.SpacingY;
                AligmentComboBox.Text = number.parseAligment();
                sizeXNum.Value = Math.Abs(number.BottomRightX - number.TopLeftX);
                sizeYNum.Value = Math.Abs(number.BottomRightY - number.TopLeftY);
                posXNum.Value = number.TopLeftX;
                posYNum.Value = number.TopLeftY;
                //number.BottomRightX = number.BottomRightX;
                //number.BottomRightY = number.BottomRightY;
                this.number.drawBorder = true;
                this.Size += new Size(0, 40);


                Render();
            }

            oldNumber = JsonConvert.SerializeObject(number, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

            startForm = false;
        }

        private void selectImages_Click(object sender, EventArgs e)
        {
            List<int> selImg = null;
            if (number != null && number.ImageIndex >= 0 && number.ImagesCount != 0)
            {
                selImg = new List<int>();

                for (int i = number.ImageIndex; i < number.ImageIndex + number.ImagesCount; i++)
                    selImg.Add(i);
            }
            ImagesForm imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, true, true, countImages);
            imgForm.ShowDialog();

            if (imgForm.saveImages == true && imgForm.selectedImages != null)
            {
                number.notDraw = false;
                number.ImageIndex = imgForm.selectedImages[0];
                number.ImagesCount = imgForm.selectedImages.Count;
                watch.images = imgForm.Images;

                //number.BottomRightX = number.getSize(watch.imagesBuff).Width;
                //number.BottomRightY = number.getSize(watch.imagesBuff).Height;
                AligmentComboBox.Text = number.parseAligment();

                sizeXNum.Value = Math.Abs(number.BottomRightX-number.TopLeftX);
                sizeYNum.Value = Math.Abs(number.BottomRightY - number.TopLeftY);

                PropertiesGroupBox.Enabled = true;
                this.number.drawBorder = true;

                Render();
            }
            else if (imgForm.saveImages == true)
            {
                number.notDraw = false;
                number.ImageIndex = -10000;
                number.ImagesCount = 0;
                watch.images = imgForm.Images;

                //number.BottomRightX = number.getSize(watch.imagesBuff).Width;
                //number.BottomRightY = number.getSize(watch.imagesBuff).Height;

                //sizeXNum.Value = number.BottomRightX;
                //sizeYNum.Value = number.BottomRightY;

                PropertiesGroupBox.Enabled = false;
                this.number.drawBorder = true;

                saveBtn.Text = "Delete";
                delete = true;
                this.Close();
            }
        }

        private void spacingChange(object sender, EventArgs e)
        {
            if (startForm == false)
            {
                NumericUpDown num = (NumericUpDown)sender;

                if (num.Name == spacingXNum.Name) number.SpacingX = Convert.ToInt16(spacingXNum.Value);
                else number.SpacingY = Convert.ToInt16(spaсingYNum.Value);

                Render();
            }
        }

        private void sizeValueChanged(object sender, EventArgs e)
        {
            if (startForm == false)
            {
                NumericUpDown num = (NumericUpDown)sender;

                if (num.Name == sizeXNum.Name) number.BottomRightX = number.TopLeftX + (int)sizeXNum.Value;
                else if (num.Name == sizeYNum.Name) number.BottomRightY = number.TopLeftY + (int)sizeYNum.Value;

                Render();
            }
        }

        private void Render()
        {
            VisualRender visual = new VisualRender(watch, state);
            previewImage.BackgroundImage = visual.GenWatchface();
        }

        private void posValueChanged(object sender, EventArgs e)
        {
            if (startForm == false)
            {
                NumericUpDown num = (NumericUpDown)sender;

                if (num.Name == posXNum.Name)
                {
                    number.TopLeftX = (int)posXNum.Value;
                    number.BottomRightX = number.TopLeftX + (int)sizeXNum.Value;
                }
                else if (num.Name == posYNum.Name)
                {
                    number.TopLeftY = (int)posYNum.Value;
                    number.BottomRightY = number.TopLeftY + (int)sizeYNum.Value;
                }

                Render();
            }
        }

        private void NumberFormEdit_Shown(object sender, EventArgs e)
        {
            Render();
        }

        private void alignChanged(object sender, EventArgs e)
        {
            if (startForm == false)
            {
                ComboBox cb = (ComboBox)sender;

                number.Alignment = cb.Text;

                Render();
            }
        }

        private void NumberFormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (number.BottomRightX == number.TopLeftX) number.BottomRightX++;
            if (number.BottomRightY == number.TopLeftY) number.BottomRightY++;

            if (PropertiesGroupBox.Enabled)
                if (saved == false && oldNumber != JsonConvert.SerializeObject(number, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }) && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    saved = true;
                    delete = false;
                }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (number.BottomRightX == number.TopLeftX) number.BottomRightX++;
            if (number.BottomRightY == number.TopLeftY) number.BottomRightY++;

            saved = true;
            number.drawBorder = false;
            this.Close();
        }

        private void NumberFormEdit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //int x = 0, y = 0;

            //switch (e.KeyCode)
            //{
            //    case Keys.W:
            //    case Keys.Up:
            //        y -= 1;
            //        break;
            //    case Keys.S:
            //    case Keys.Down:
            //        y += 1;
            //        break;
            //    case Keys.D:
            //    case Keys.Right:
            //        x += 1;
            //        break;
            //    case Keys.A:
            //    case Keys.Left:
            //        x -= 1;
            //        break;
            //    default:
            //        break;
            //}

            //if (PropertiesGroupBox.Enabled)
            //{
            //    number.TopLeftX += x;
            //    number.TopLeftY += y;
            //    number.BottomRightX += x;
            //    number.BottomRightY += y;

            //    Render();
            //}
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
                Size box = new Size(number.BottomRightX - number.TopLeftX, number.BottomRightY - number.TopLeftY);

                number.TopLeftX = e.X;
                number.TopLeftY = e.Y;
                number.BottomRightX = box.Width + e.X;
                number.BottomRightY = box.Height + e.Y;
                posXNum.Value = number.TopLeftX;
                posYNum.Value = number.TopLeftY;

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
