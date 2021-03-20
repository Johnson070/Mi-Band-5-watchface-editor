using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBand5WatchFaces
{
    public partial class ImagesForm : Form
    {
        public DefaultDictionary<int, Image> Images;
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));
        
        
        bool selectImages = false;
        public bool saveImages = true;
        bool editImages = false;
        public List<int> selectedImages;
        int toolTipIndex;
        bool multiSelect = true;
        bool selectAndAdd;
        bool countImages = false;
        int countImagesSelect = -1;

        public ImagesForm(DefaultDictionary<int, Image> Images, bool selectImages = false, bool selectAndAdd = false, bool multiSelect = true, int indexSelect = -1, int countImagesSelect = -1)
        {
            InitializeComponent();
            this.Images = Images;
            this.selectImages = selectImages || selectAndAdd;
            AddImagesToElement.Enabled = selectImages || selectAndAdd;
            toolStrip.Enabled = !selectImages;
            imageBox.AllowDrop = !selectImages;
            //saveImagesButton.Enabled = !selectAndAdd;
            //deleteImageToolButton.Enabled = !selectAndAdd;
            //DeleteImagesButton.Enabled = !selectAndAdd;
            this.multiSelect = multiSelect;
            this.selectAndAdd = selectAndAdd;
            this.countImagesSelect = countImagesSelect;
            saveImagesButton.Enabled = !selectAndAdd;

            fillListBox();
            SelectIndex(indexSelect);
            setTextToElement();
        }

        public ImagesForm(DefaultDictionary<int, Image> Images, List<int> selectedImages, bool selectAndAdd = false, bool multiSelect = true, bool countImages = false, int countImagesSelect = -1)
        {
            InitializeComponent();
            this.Images = Images;
            this.countImages = countImages;
            //this.selectImages = selectImages || selectAndAdd;
            //AddImagesToElement.Enabled = selectImages || selectAndAdd;
            //toolStrip.Enabled = !selectImages;
            //imageBox.AllowDrop = !selectImages;
            //saveImagesButton.Enabled = !selectAndAdd;
            //deleteImageToolButton.Enabled = !selectAndAdd;
            //DeleteImagesButton.Enabled = !selectAndAdd;
            //this.multiSelect = multiSelect;
            //this.selectAndAdd = selectAndAdd;
            this.multiSelect = multiSelect;
            this.selectAndAdd = selectAndAdd;
            this.countImagesSelect = countImagesSelect;
            this.selectedImages = selectedImages;
            saveImagesButton.Enabled = !selectAndAdd;
            fillListBox();

            if (selectedImages != null)
                foreach (int selItem in selectedImages)
                    if (selItem >= 0)
                        ImagesListBox.SetItemChecked(selItem, true);
            setTextToElement();
        }

        private void SelectIndex(int index)
        {
            if (index != -1 && ImagesListBox.Items.Count - 1 >= index)
                ImagesListBox.SetItemChecked(index, true);
        }

        private void AddImagesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageFiles = new OpenFileDialog();
            ImageFiles.RestoreDirectory = true;
            ImageFiles.Multiselect = true;
            ImageFiles.Filter = "png images (*.png)|*.png";

            if (ImageFiles.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ImageFiles.FileNames)
                {
                    FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    Bitmap temp = new Bitmap(stream);
                    temp.SetResolution(96f, 96f);
                    Image openpng = temp;
                    stream.Close();
                    float dpi = openpng.HorizontalResolution;

                    if (Math.Round(dpi) == 96)
                        Images.Add(Images.Keys.Count == 0 ? Images.Count : Images.Keys.Max() + 1, openpng);
                    else MessageBox.Show(res.GetString("ImageDPI"), $"File: {Path.GetFileName(ImageFiles.FileName)}");
                };
                editImages = true;

                List<string> selItems = new List<string>();
                for (int i = 0; i < ImagesListBox.Items.Count; i++)
                    if (ImagesListBox.GetItemChecked(i))
                        selItems.Add(ImagesListBox.GetItemText(ImagesListBox.Items[i]));

                fillListBox();

                for (int i = 0; i < ImagesListBox.Items.Count; i++)
                    foreach (string name in selItems)
                        if (ImagesListBox.GetItemText(ImagesListBox.Items[i]) == name)
                            ImagesListBox.SetItemChecked(i, true);
            }
        }

        private void fillListBox()
        {
            ImagesListBox.Items.Clear();

            foreach (KeyValuePair<int, Image> image in Images)
                if (image.Key < 10000)
                    ImagesListBox.Items.Add($"{image.Key:0000}.png");
        }

        private void ImagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ImagesListBox.SelectedIndex != -1)
                {
                    imageBox.BackgroundImage = Images[ImagesListBox.SelectedIndex];
                    imageBox.Tag = Images.ElementAt(ImagesListBox.SelectedIndex);
                    if (!(selectImages) || selectAndAdd)
                        ChangeImageButton.Enabled = true;

                }
            }
            catch
            {
                imageBox.BackgroundImage = null;
            }

            setTextToElement();
        }

        private void ChangeImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (imageBox.Tag != null)
                {
                    OpenFileDialog ImageFiles = new OpenFileDialog();
                    ImageFiles.RestoreDirectory = true;
                    ImageFiles.Filter = "png images (*.png)|*.png";

                    if (ImageFiles.ShowDialog() == DialogResult.OK)
                    {
                        FileStream stream = new FileStream(ImageFiles.FileName, FileMode.Open, FileAccess.Read);
                        Bitmap temp = new Bitmap(stream);
                        temp.SetResolution(96f, 96f);
                        Image openpng = temp;
                        stream.Close();
                        float dpi = openpng.HorizontalResolution;

                        if (Math.Round(dpi) == 96)
                        {
                            Images[((KeyValuePair<int, Image>)imageBox.Tag).Key] = openpng;
                            imageBox.BackgroundImage = openpng;
                        }
                        else MessageBox.Show(res.GetString("ImageDPI"), $"File: {Path.GetFileName(ImageFiles.FileName)}");

                        int sel = ImagesListBox.SelectedIndex;
                        editImages = true;
                        fillListBox();
                        ImagesListBox.SelectedIndex = sel;
                    }
                }
            }
            catch { }
        }

        private void DeleteImagesButton_Click(object sender, EventArgs e)
        {
            try
            {
                editImages = true;
                List<int> deleteImg = new List<int>();
                for (int i = ImagesListBox.Items.Count - 1; i >= 0; i--)
                    if (ImagesListBox.GetItemChecked(i))
                        deleteImg.Add(Convert.ToInt32(ImagesListBox.Items[i].ToString().Replace(".png", string.Empty)));
                deleteImg.Reverse();

                int count = Images.Count;
                foreach (int delImg in deleteImg)
                    Images.Remove(delImg);

                List<Image> buffImg = new List<Image>();
                for (int i = 0; i < count; i++)
                    if (Images.ContainsKey(i))
                        buffImg.Add(Images[i]);

                Images = new DefaultDictionary<int, Image>((() => new Bitmap(1, 1)));
                for (int i = 0; i < buffImg.Count; i++)
                    Images.Add(i, buffImg[i]);

                fillListBox();
            }
            catch { }

        }

        private void saveImages_Click(object sender, EventArgs e)
        {
            int countItems = 0;
            for (int i = 0; i < ImagesListBox.Items.Count; i++)
                if (ImagesListBox.GetItemChecked(i))
                    countItems++;

            selectedImages = countItems == 0 ? null : new List<int>();

            for (int i = 0; i < ImagesListBox.Items.Count; i++)
                if (ImagesListBox.GetItemChecked(i))
                    selectedImages.Add(Convert.ToInt32(ImagesListBox.Items[i].ToString().Replace(".png", string.Empty)));

            saveImages = true;
            editImages = false;
            this.Close();
        }

        private void ImagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editImages)
            {
                if (MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    saveImages = true;
                else
                    saveImages = false;
            }

            if (selectedImages != null && selectedImages.Count == 0)
                selectedImages = null;

            //if (ImagesListBox.SelectedIndex != -1) selectedImages.Add(ImagesListBox.SelectedIndex);
            //else selectedImages = null;
        }

        private void AddImagesToElement_Click(object sender, EventArgs e)
        {
            int countItems = 0;
            for (int i = 0; i < ImagesListBox.Items.Count; i++)
                if (ImagesListBox.GetItemChecked(i))
                    countItems++;

            selectedImages = countItems == 0 ? null : new List<int>();

            for (int i = 0; i < ImagesListBox.Items.Count; i++)
                if (ImagesListBox.GetItemChecked(i))
                    selectedImages.Add(Convert.ToInt32(ImagesListBox.Items[i].ToString().Replace(".png", string.Empty)));

            if (selectedImages != null)
            {
                saveImages = true;
                editImages = false;
            }
            this.Close();
        }

        private void imageBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            try
            {
                if (!(selectImages) || selectAndAdd)
                    if (imageBox.Tag != null && Path.GetExtension(files[0]) == ".png")
                    {
                        //FileStream stream = new FileStream(image.FileName, FileMode.Open, FileAccess.Read);Image openpng = Image.FromFile(files[0]);
                        FileStream stream = new FileStream(files[0], FileMode.Open, FileAccess.Read);
                        Bitmap temp = new Bitmap(stream);
                        temp.SetResolution(96f, 96f);
                        Image openpng = temp;
                        stream.Close();
                        float dpi = openpng.HorizontalResolution;

                        if (Math.Round(dpi) == 96)
                        {
                            Images[((KeyValuePair<int, Image>)imageBox.Tag).Key] = openpng;
                            imageBox.BackgroundImage = openpng;
                        }
                        else MessageBox.Show(res.GetString("ImageDPI"), $"File: {Path.GetFileName(files[0])}");

                        int sel = ImagesListBox.SelectedIndex;
                        editImages = true;
                        fillListBox();
                        ImagesListBox.SelectedIndex = sel;
                    }
            }
            catch { }
        }

        private void imageBox_DragEnter(object sender, DragEventArgs e)
        {
            if (!(selectImages) || selectAndAdd)
                if (imageBox.Tag != null && e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void ImagesListBox_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Point pt = new Point((Size)e.Location);
                //Retrieve the index of the ListBox item at the current location. 
                int lastIndex = toolTipIndex;
                toolTipIndex = ImagesListBox.IndexFromPoint(pt);

                imageBox.BackgroundImage = Images[Convert.ToInt32(ImagesListBox.Items[toolTipIndex].ToString().Replace(".png", string.Empty))];
            }
            catch { }
        }

        private void ImagesListBox_MouseLeave(object sender, EventArgs e)
        {
            ImagesListBox_SelectedIndexChanged(null, null);
        }

        private void addImageWithNumberToolButton_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.ShowDialog();

            if (inputForm.value != -1)
            {
                foreach (KeyValuePair<int, Image> item in Images)
                    if (item.Key == inputForm.value)
                        return;

                Images.Add(inputForm.value, (Image)new Bitmap(40, 40));
                fillListBox();
                ImagesListBox_SelectedIndexChanged(null, null);
            }
        }

        private void deleteImageToolButton_Click(object sender, EventArgs e)
        {
            editImages = true;
            if (ImagesListBox.SelectedIndex != -1)
            {
                int start = Convert.ToInt32(ImagesListBox.SelectedItem.ToString().Replace(".png", string.Empty));

                Images.Remove(start);
                ImagesListBox.Items.RemoveAt(ImagesListBox.SelectedIndex);

                int count = Images.Count;
                for (int i = start; i <= count; i++)
                    if (Images.ContainsKey(i))
                    {
                        Images.Add(i - 1, Images[i]);
                        Images.Remove(i);
                    }
                fillListBox();

                ImagesListBox_SelectedIndexChanged(null, null);
            }

            setTextToElement();
        }

        private void ImagesListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!(multiSelect))
            {
                for (int ix = 0; ix < ImagesListBox.Items.Count; ++ix)
                    if (ix != e.Index)
                        ImagesListBox.SetItemChecked(ix, false);
            }

            if (countImages)
            {
                int count = 0;
                for (int i = 0; i < ImagesListBox.Items.Count; i++)
                    count += ImagesListBox.GetItemChecked(i) ? 1 : 0;

                if (ImagesListBox.Items.Count > 1 && count > 0)
                    if (e.Index == 0 && ImagesListBox.GetItemChecked(e.Index + 1) == false) e.NewValue = CheckState.Unchecked;
                    else if (e.Index == ImagesListBox.Items.Count - 1 && ImagesListBox.GetItemChecked(e.Index - 1) == false) e.NewValue = CheckState.Unchecked;
                    else if (ImagesListBox.Items.Count > e.Index + 1 && (ImagesListBox.GetItemChecked(e.Index + 1) == false && ImagesListBox.GetItemChecked(e.Index - 1) == false) && count > 0) e.NewValue = CheckState.Unchecked;


                if (countImagesSelect != -1)
                {
                    int countSel = e.NewValue == CheckState.Checked ? 1 : 0;
                    for (int i = 0; i < ImagesListBox.Items.Count; i++)
                        if (ImagesListBox.GetItemChecked(i))
                            countSel++;

                    if (countSel > countImagesSelect)
                        e.NewValue = CheckState.Unchecked;

                }

                //if (foundCheck != -1)
                //{
                //    foundCheck = 0;
                //    for (int i = e.Index + 1; i >= 0; i--)
                //        if (ImagesListBox.GetItemChecked(i)) foundCheck = 1;
                //        else if (foundCheck != 0 && e.Index != i) e.NewValue = CheckState.Unchecked;
                //}
            }
        }

        private void setTextToElement()
        {
            int countCheckItems = 0;
            for (int i = 0; i < ImagesListBox.Items.Count; i++)
                if (ImagesListBox.GetItemCheckState(i) == CheckState.Checked) countCheckItems++;

            if (countCheckItems > 0 && selectedImages != null) AddImagesToElement.Text = res.GetString("EditImagesToElement");
            else if (countCheckItems == 0 && selectedImages != null) AddImagesToElement.Text = res.GetString("DeleteImages");
            else if (countCheckItems > 0) AddImagesToElement.Text = res.GetString("AddImagesToElement");
            else AddImagesToElement.Text = res.GetString("AddImagesToElement");
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ImagesListBox.Items.Count; i++)
                ImagesListBox.SetItemChecked(i, false);

            setTextToElement();
        }

        private void ImagesForm_Shown(object sender, EventArgs e)
        {
            if (selectedImages != null) AddImagesToElement.Text = res.GetString("EditImagesToElement");
            else AddImagesToElement.Text = res.GetString("AddImagesToElement");
        }

        private void ImagesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            setTextToElement();
        }
    }
}
