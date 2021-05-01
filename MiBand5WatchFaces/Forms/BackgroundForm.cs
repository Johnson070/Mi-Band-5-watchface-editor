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
    public partial class BackgroundForm : Form
    {
        public Background background;
        public DefaultDictionary<int, Image> images;
        public bool Save;
        WatchFaceLibrary.typeWatch typeWatch;
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));
        string oldBackground = "";

        VisualRender visual;
        Image prev;

        public BackgroundForm(Background background, DefaultDictionary<int, Image> images, Image prev, WatchFaceLibrary.typeWatch typeWatch)
        {
            InitializeComponent();
            this.images = images;
            this.typeWatch = typeWatch;
            this.background = background == null ? new Background() : background;
            this.prev = prev;
            oldBackground = JsonConvert.SerializeObject(background, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore});
            visual = new VisualRender(images, typeWatch);

            if (typeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size MiBand6 = (new WatchFaceLibrary()).SizeMiBand6;
                Size MiBand6Rasn = (new WatchFaceLibrary()).SizeMiBand6Rasn;
                Size MiBand6Preview = (new WatchFaceLibrary()).SizePreviewMiBand6;
                Size += new Size(MiBand6Rasn.Width + ((MiBand6Preview.Width - Preview1Pic.Width) * 3), MiBand6Rasn.Height);
                genPreviews.Location += new Size(MiBand6Rasn.Width, 45);
                genPreviews.Size -= new Size(MiBand6Rasn.Width,0);
                saveButton.Location += new Size(0, MiBand6Rasn.Height);
                BackgroundImages.Size += MiBand6Rasn;
                ImagePic.Size = MiBand6;
                label2.Location += new Size(MiBand6Rasn.Width, 0);
                label3.Location += new Size(MiBand6Rasn.Width + (MiBand6Preview.Width - Preview1Pic.Width), 0);
                label4.Location += new Size(MiBand6Rasn.Width + (MiBand6Preview.Width - Preview2Pic.Width)*2, 0);
                Preview1Pic.Location += new Size(MiBand6Rasn.Width, 0);
                Preview2Pic.Location += new Size(MiBand6Rasn.Width+(MiBand6Preview.Width - Preview2Pic.Width), 0);
                Preview3Pic.Location += new Size(MiBand6Rasn.Width+(MiBand6Preview.Width - Preview3Pic.Width)*2, 0);
                Preview1Pic.Size = MiBand6Preview;
                Preview2Pic.Size = MiBand6Preview;
                Preview3Pic.Size = MiBand6Preview;
                label5.Location += new Size(0, MiBand6Rasn.Height);
                label6.Location += new Size(0, MiBand6Rasn.Height);
                backgroundXPos.Location += new Size(0, MiBand6Rasn.Height);
                backgroundYPos.Location += new Size(0, MiBand6Rasn.Height);
            }

            if (background != null && background.Image != null)
            {
                UseBackgroundColor.Checked = background.BackgroundColor != null ? true : false;
                backgroundXPos.Value = background.Image.X;
                backgroundYPos.Value = background.Image.Y;

                UseBackgroundColor_CheckStateChanged(null, null);
            }

            if (background != null)
            {
                UseBackgroundColor.Checked = background.BackgroundColor != null ? true : false;
                UseBackgroundColor_CheckStateChanged(null, null);
            }

            updateForm();
        }

        private void updateForm()
        {
            visual = new VisualRender(images, typeWatch);

            try
            {
                if (background != null)
                {
                    if (background.BackgroundColor != null) panel1.BackColor = convertColorFromString(background.BackgroundColor);
                    if (background.Image != null) ImagePic.BackgroundImage = visual.GetLayout(background,typeWatch);
                    if (background.Preview1 != null) Preview1Pic.BackgroundImage = visual.GetLayout(background.Preview1, typeWatch);
                    if (background.Preview2 != null) Preview2Pic.BackgroundImage = visual.GetLayout(background.Preview2, typeWatch);
                    if (background.Preview3 != null) Preview3Pic.BackgroundImage = visual.GetLayout(background.Preview3, typeWatch);
                }
            }
            catch
            {
                string missingKey = "";
                missingKey += background.Image != null ? (images.ContainsKey(background.Image.ImageIndex) ? "" : background.Image.ImageIndex.ToString() + " ") : "";
                missingKey += background.Preview1 != null ? (images.ContainsKey(background.Preview1.ImageIndex) ? "" : background.Preview1.ImageIndex.ToString() + " ") : "";
                missingKey += background.Preview2 != null ? (images.ContainsKey(background.Preview2.ImageIndex) ? "" : background.Preview2.ImageIndex.ToString() + " ") : "";
                missingKey += background.Preview3 != null ? (images.ContainsKey(background.Preview3.ImageIndex) ? "" : background.Preview3.ImageIndex.ToString() + " ") : "";
                MessageBox.Show($"Image number {missingKey}not exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog() { Color = convertColorFromString(background.BackgroundColor)};

            if (color.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = color.Color;
                background.BackgroundColor = $"0x{color.Color.R.ToString("X2")}{color.Color.G.ToString("X2")}{color.Color.B.ToString("X2")}";
            }
        }

        private void UseBackgroundColor_CheckStateChanged(object sender, EventArgs e)
        {
            if (UseBackgroundColor.Checked)
            {
                BackgroundColorGroup.Enabled = true;
                BackgroundImages.Enabled = false;
                background.BackgroundColor = background != null ? (background.BackgroundColor != null ? background.BackgroundColor : "0x000000") : null;
            }
            else
            {
                BackgroundColorGroup.Enabled = false;
                BackgroundImages.Enabled = true;
            }
        }

        private Color convertColorFromString(string _color) => Color.FromArgb(Convert.ToInt16(_color.Substring(2, 2), 16), Convert.ToInt16(_color.Substring(4, 2), 16), Convert.ToInt16(_color.Substring(6, 2), 16));

        private void dragEnterPic(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void dragDropPic(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            Panel picPanel = (System.Windows.Forms.Panel)sender;

            ImageWorker img = new ImageWorker(images);
            images = img.addImage(files[0]);
            ImageBasic pic = new ImageBasic();
            pic.ImageIndex = images.Keys.Count == 0 ? images.Count : images.Keys.Max() + 1;

            if (typeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                pic.X = picPanel.Name == ImagePic.Name ? 0 : 21;
                pic.Y = picPanel.Name == ImagePic.Name ? 0 : 30;
            }
            else
            {
                pic.X = picPanel.Name == ImagePic.Name ? 0 : 18;
                pic.Y = picPanel.Name == ImagePic.Name ? 0 : 17;
            }

            if (images.ContainsKey(pic.ImageIndex))
            {
                if (picPanel.Name == ImagePic.Name) background.Image = pic;
                else if (picPanel.Name == Preview1Pic.Name) background.Preview1 = pic;
                else if (picPanel.Name == Preview2Pic.Name) background.Preview2 = pic;
                else if (picPanel.Name == Preview3Pic.Name) background.Preview3 = pic;
            }
            else
            {
                MessageBox.Show($"Image number {pic.ImageIndex} not exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            updateForm();
        }

        private void clickPic(object sender, EventArgs e)
        {
            Panel picPanel = (System.Windows.Forms.Panel)sender;
            int index = 0;
            if (background != null)
                if (background.Image != null && picPanel.Name == ImagePic.Name) index = background.Image.ImageIndex;
                else if (background.Preview1 != null && picPanel.Name == Preview1Pic.Name) index = background.Preview1.ImageIndex;
                else if (background.Preview2 != null && picPanel.Name == Preview2Pic.Name) index = background.Preview2.ImageIndex;
                else if (background.Preview3 != null && picPanel.Name == Preview3Pic.Name) index = background.Preview3.ImageIndex;


            ImagesForm imgForm = new ImagesForm(new DefaultDictionary<int, Image>(() => new Bitmap(1, 1), images), false, true, false, index);
            imgForm.ShowDialog();
            if (imgForm.saveImages) images = imgForm.Images;

            if (imgForm.selectedImages != null)
            {
                visual = new VisualRender(images, typeWatch);

                ImageBasic pic = new ImageBasic();
                pic.ImageIndex = imgForm.selectedImages[0];
                
                if (typeWatch == WatchFaceLibrary.typeWatch.MiBand6)
                {
                    pic.X = picPanel.Name == ImagePic.Name ? 0 : 21;
                    pic.Y = picPanel.Name == ImagePic.Name ? 0 : 30;
                }
                else
                {
                    pic.X = picPanel.Name == ImagePic.Name ? 0 : 18;
                    pic.Y = picPanel.Name == ImagePic.Name ? 0 : 17;
                }

                if (images.ContainsKey(pic.ImageIndex))
                {
                    if (picPanel.Name == ImagePic.Name) background.Image = pic;
                    else if (picPanel.Name == Preview1Pic.Name) background.Preview1 = pic;
                    else if (picPanel.Name == Preview2Pic.Name) background.Preview2 = pic;
                    else if (picPanel.Name == Preview3Pic.Name) background.Preview3 = pic;
                }
                else
                {
                    MessageBox.Show($"Image number {pic.ImageIndex} not exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                updateForm();
            }

            imgForm.Dispose();
        }

        private void genPreviews_Click(object sender, EventArgs e)
        {
            images.Add(images.Keys.Count == 0 ? images.Count : images.Keys.Max() + 1, prev);
            ImageBasic pic = new ImageBasic();
            pic.ImageIndex = images.Keys.Count == 0 ? images.Count : images.Keys.Max();

            if (typeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                pic.X = 21;
                pic.Y = 30;
            }
            else
            {
                pic.X = 18;
                pic.Y = 17;
            }
            
            background.Preview1 = pic;
            background.Preview2 = pic;
            background.Preview3 = pic;

            updateForm();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save = true;
            if (UseBackgroundColor.Checked) background.Image = null;
            else background.BackgroundColor = null;
            if (background.Image == null && background.BackgroundColor == null)
            {
                background = null;
            }
            this.Close();
        }

        private void BackgroundForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string newJson = JsonConvert.SerializeObject(background, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            if (Save == false && oldBackground != newJson && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (UseBackgroundColor.Checked) background.Image = null;
                else background.BackgroundColor = null;
                if (background.Image == null && background.BackgroundColor == null)
                {
                    background = null;
                }
            }
        }

        private void posValueChanged(object sender, EventArgs e)
        {
            NumericUpDown pos = (NumericUpDown)sender;

            if (pos.Name == backgroundXPos.Name)
                if (background.Image != null)
                    background.Image.X = (int)pos.Value;

            if (pos.Name == backgroundYPos.Name)
                if (background.Image != null)
                    background.Image.Y = (int)pos.Value;

            updateForm();
        }
    }
}
