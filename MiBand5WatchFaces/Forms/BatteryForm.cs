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
    public partial class BatteryForm : Form
    {
        public WatchFaceLibrary watch;
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

        StateWatchface state;
        VisualRender render;
        public bool Save;

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

        public BatteryForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.state = state;
            this.watch.imagesBuff = Images;

            this.watch.Battery = this.watch.Battery == null ? new Battery() : this.watch.Battery;
            Render(state);

            if (watch.Battery.BatteryText != null)
            {
                textBatteryCheckbox.Checked = true;
                AddNumberBatteryTextButton.Text = res.GetString("EditNumber");
                if (watch.Battery.BatteryText.PrefixImageIndex >= 0)
                {
                    AddPreffixButton.Enabled = true;
                    AddPreffixButton.Text = res.GetString("EditPrefix");
                }
                if (watch.Battery.BatteryText.SuffixImageIndex >= 0)
                {
                    AddSuffixButton.Enabled = true;
                    AddSuffixButton.Text = res.GetString("EditSuffix");
                }
            }
            if (watch.Battery.BatteryIcon != null)
            {
                IconBatteryCheckbox.Checked = true;
                AddImagesBatteryIconButton.Text = res.GetString("EditImages");
            }
            if (watch.Battery.Linear != null)
            {
                LinearCheckbox.Checked = true;
                AddImagesLinearButton.Text = res.GetString("EditImages");
            }
        }

        private void ChangeCheckValue(object sender, EventArgs e)
        {
            groupBox3.Enabled = textBatteryCheckbox.Checked;
            groupBox1.Enabled = IconBatteryCheckbox.Checked;
            groupBox2.Enabled = LinearCheckbox.Checked;
        }

        private void AddImagesBatteryIconButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.Battery.BatteryIcon = watchface.Battery.BatteryIcon == null ? new ImageSet() : watchface.Battery.BatteryIcon;
            ImageSetForm setForm = new ImageSetForm(watchface, watchface.Battery.BatteryIcon, watch.imagesBuff.DeepCopy(), state);
            setForm.ShowDialog();

            if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
            {
                watch.imagesBuff = setForm.watch.imagesBuff;
                watch.Battery.BatteryIcon = setForm.imageSet;
                AddImagesBatteryIconButton.Text = res.GetString("EditImages");
            }
            else if (setForm.delete)
            {
                watch.imagesBuff = setForm.watch.imagesBuff;
                watch.Battery.BatteryIcon = null;
                AddImagesBatteryIconButton.Text = res.GetString("AddImages");
            }

            Render(state);
        }

        private void AddNumberBatteryTextButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.Battery.BatteryText = watchface.Battery.BatteryText == null ? new BatteryText() : watchface.Battery.BatteryText;
            watchface.Battery.BatteryText.Coordinates = watchface.Battery.BatteryText.Coordinates == null ? new Number() { notDraw = true } : watchface.Battery.BatteryText.Coordinates;
            NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Battery.BatteryText.Coordinates, watch.imagesBuff.DeepCopy(), state);
            numForm.ShowDialog();

            if (numForm.saved && numForm.number.ImageIndex >= 0)
            {
                watch.Battery.BatteryText = watch.Battery.BatteryText == null ? new BatteryText() : watch.Battery.BatteryText;
                watch.Battery.BatteryText.Coordinates = numForm.number;
                watch.imagesBuff = numForm.watch.imagesBuff;
                AddPreffixButton.Enabled = true;
                AddSuffixButton.Enabled = true;
                AddNumberBatteryTextButton.Text = res.GetString("EditNumber");
            }
            else if (numForm.delete)
            {
                watch.imagesBuff = numForm.watch.imagesBuff;
                watch.Battery.BatteryText.Coordinates = null;
                AddPreffixButton.Enabled = false;
                AddSuffixButton.Enabled = false;
                AddNumberBatteryTextButton.Text = res.GetString("AddNumber");
            }

            Render(state);
        }

        private void AddImageClick(object sender, EventArgs e)
        {
            List<int> selImg = null;
            ImagesForm imgForm;
            string name = ((Button)sender).Name;

            if (name == AddPreffixButton.Name)
            {
                if (watch.Battery.BatteryText.PrefixImageIndex >= 0) selImg = new List<int>() { watch.Battery.BatteryText.PrefixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Battery.BatteryText.PrefixImageIndex = imgForm.selectedImages[0];
                    AddPreffixButton.Text = res.GetString("EditPrefix");
                }
                else if (imgForm.saveImages)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Battery.BatteryText.PrefixImageIndex = -10000;
                    AddPreffixButton.Text = res.GetString("AddPrefix");
                }
            }
            else if (name == AddSuffixButton.Name)
            {
                if (watch.Battery.BatteryText.SuffixImageIndex >= 0) selImg = new List<int>() { watch.Battery.BatteryText.SuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Battery.BatteryText.SuffixImageIndex = imgForm.selectedImages[0];
                    AddSuffixButton.Text = res.GetString("EditSuffix");
                }
                else if (imgForm.saveImages)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Battery.BatteryText.SuffixImageIndex = -10000;
                    AddSuffixButton.Text = res.GetString("AddSuffix");
                }
            }

            Render(state);
        }

        private void AddImagesLinearButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.Battery.Linear = watchface.Battery.Linear == null ? new Scale() : watchface.Battery.Linear;
            StateWatchface stateNew = DeepCopy(state);
            stateNew.BatteryLevel = 100;
            ScaleForm scaleForm = new ScaleForm(watchface, watchface.Battery.Linear, watch.imagesBuff.DeepCopy(), stateNew);
            scaleForm.ShowDialog();

            if (scaleForm.saved && scaleForm.scale.StartImageIndex >= 0)
            {
                watch.Battery.Linear = scaleForm.scale;
                watch.imagesBuff = scaleForm.watch.imagesBuff;

                AddImagesLinearButton.Text = res.GetString("EditImages");
            }
            else if (scaleForm.delete)
            {
                watch.Battery.Linear = null;
                watch.imagesBuff = scaleForm.watch.imagesBuff;

                AddImagesLinearButton.Text = res.GetString("AddImages");
            }

            Render(state);
        }

        private void NumberFormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if ((watch.Battery?.BatteryText != null && watch.Battery.BatteryText.Coordinates == null) || textBatteryCheckbox.Checked == false)
                    watch.Battery.BatteryText = null;
                if (IconBatteryCheckbox.Checked == false)
                    watch.Battery.BatteryIcon = null;
                if (LinearCheckbox.Checked == false)
                    watch.Battery.Linear = null;
                if (watch.Battery.Linear == null && watch.Battery.BatteryText == null && watch.Battery.BatteryIcon == null)
                    watch.Battery = null;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save = true;
            if ((watch.Battery?.BatteryText != null && watch.Battery.BatteryText.Coordinates == null) || textBatteryCheckbox.Checked == false)
                watch.Battery.BatteryText = null;
            if (IconBatteryCheckbox.Checked == false)
                watch.Battery.BatteryIcon = null;
            if (LinearCheckbox.Checked == false)
                watch.Battery.Linear = null;
            if (watch.Battery.Linear == null && watch.Battery.BatteryText == null && watch.Battery.BatteryIcon == null)
                watch.Battery = null;
            this.Close();
        }
    }
}
