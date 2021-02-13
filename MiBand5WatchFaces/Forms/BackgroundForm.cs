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
        VisualRender visual;
        Image prev;

        public BackgroundForm(Background background, DefaultDictionary<int, Image> images, Image prev)
        {
            InitializeComponent();
            this.images = images;
            this.background = background == null ? new Background() : background;
            this.prev = prev;
            visual = new VisualRender(images);

            if (background != null && background.Image != null)
            {
                UseBackgroundColor.Checked = background.BackgroundColor != null ? true : false;
                backgroundXPos.Value = background.Image.X;
                backgroundYPos.Value = background.Image.Y;

                UseBackgroundColor_CheckStateChanged(null,null);
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
            visual = new VisualRender(images);

            try
            {
                if (background != null)
                {
                    if (background.BackgroundColor != null) panel1.BackColor = convertColorFromString(background.BackgroundColor);
                    if (background.Image != null) ImagePic.BackgroundImage = visual.GetLayout(background);
                    if (background.Preview1 != null) Preview1Pic.BackgroundImage = visual.GetLayout(background.Preview1);
                    if (background.Preview2 != null) Preview2Pic.BackgroundImage = visual.GetLayout(background.Preview2);
                    if (background.Preview3 != null) Preview3Pic.BackgroundImage = visual.GetLayout(background.Preview3);
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
            ColorDialog color = new ColorDialog();

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
            pic.X = picPanel.Name == "ImagePic" ? 0 : 18;
            pic.Y = picPanel.Name == "ImagePic" ? 0 : 17;

            if (images.ContainsKey(pic.ImageIndex))
            {
                if (picPanel.Name == "ImagePic") background.Image = pic;
                else if (picPanel.Name == "Preview1Pic") background.Preview1 = pic;
                else if (picPanel.Name == "Preview2Pic") background.Preview2 = pic;
                else if (picPanel.Name == "Preview3Pic") background.Preview3 = pic;
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
                    if (background.Image != null && picPanel.Name == "ImagePic") index = background.Image.ImageIndex;
                    else if (background.Preview1 != null && picPanel.Name == "Preview1Pic") index = background.Preview1.ImageIndex;
                    else if (background.Preview2 != null && picPanel.Name == "Preview2Pic") index = background.Preview2.ImageIndex;
                    else if (background.Preview3 != null && picPanel.Name == "Preview3Pic") index = background.Preview3.ImageIndex;


            ImagesForm imgForm = new ImagesForm(new DefaultDictionary<int, Image>(() => new Bitmap(1, 1), images), false, true, false, index);
            imgForm.ShowDialog();
            if (imgForm.saveImages) images = imgForm.Images;

            if (imgForm.selectedImages != null)
            {
                visual = new VisualRender(images);

                ImageBasic pic = new ImageBasic();
                pic.ImageIndex = imgForm.selectedImages[0];
                pic.X = picPanel.Name == "ImagePic" ? 0 : 18;
                pic.Y = picPanel.Name == "ImagePic" ? 0 : 17;

                if (images.ContainsKey(pic.ImageIndex))
                {
                    if (picPanel.Name == "ImagePic") background.Image = pic;
                    else if (picPanel.Name == "Preview1Pic") background.Preview1 = pic;
                    else if (picPanel.Name == "Preview2Pic") background.Preview2 = pic;
                    else if (picPanel.Name == "Preview3Pic") background.Preview3 = pic;
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
            pic.X = 18;
            pic.Y = 17;

            background.Preview1 = pic;
            background.Preview2 = pic;
            background.Preview3 = pic;

            updateForm();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save = true;
            this.Close();
        }

        private void BackgroundForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show("Do you want to get out without saving?", "Dont't save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
            }

            if (UseBackgroundColor.Checked) background.Image = null;
            else background.BackgroundColor = null;
        }

        private void posValueChanged(object sender, EventArgs e)
        {
            NumericUpDown pos = (NumericUpDown)sender;

            if (pos.Name == "backgroundXPos")
                if (background.Image != null)
                    background.Image.X = (int)pos.Value;

            if (pos.Name == "backgroundYPos")
                if (background.Image != null)
                    background.Image.Y = (int)pos.Value;

            updateForm();
        }
    }
}
