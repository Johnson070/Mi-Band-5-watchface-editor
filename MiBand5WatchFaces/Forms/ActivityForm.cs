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
    public partial class ActivityForm : Form
    {
        public WatchFaceLibrary watch;

        StateWatchface state;
        VisualRender render;
        public bool Save;

        public static T DeepCopy<T>(T other)
        {
            if (other == null) return default(T);

            string clone = JsonConvert.SerializeObject(other);
            return JsonConvert.DeserializeObject<T>(clone);
        }

        public void Render(StateWatchface state = null)
        {
            render = new VisualRender(watch, state);
            ImagePic.BackgroundImage = render.GenWatchface();
        }

        public ActivityForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            watch.imagesBuff = Images;
            this.state = state;

            this.watch.Activity = watch.Activity == null ? new Activity() : watch.Activity;
            Render(state);

            stepsCheckBox.Checked = watch.Activity?.Steps != null ? true : false;
            caloriesCheckBox.Checked = watch.Activity.Calories != null ? true : false;
            pulseCheckBox.Checked = watch.Activity?.Pulse != null ? true : false;
            distanceCheckBox.Checked = watch.Activity?.Distance != null ? true : false;
            paiCheckBox.Checked = watch.Activity?.PAI != null ? true : false;

            if (watch.Activity?.Steps?.Number != null)
            {
                addStepsButton.Text = "Edit steps";
                addPreffixStepsButton.Enabled = true;
                addSuffixStepsButton.Enabled = true;
                if (watch.Activity.Steps.PrefixImageIndex != -10000) addPreffixStepsButton.Text = "Edit preffix";
                if (watch.Activity.Steps.SuffixImageIndex != -10000) addSuffixStepsButton.Text = "Edit suffix";
            }
            if (watch.Activity?.Calories?.Text != null)
            {
                addCaloriesButton.Text = "Edit calories";
                addPreffixCaloriesButton.Enabled = true;
                addSuffixCaloriesButton.Enabled = true;
                if (watch.Activity.Calories.PrefixImageIndex != -10000) addPreffixCaloriesButton.Text = "Edit preffix";
                if (watch.Activity.Calories.SuffixImageIndex != -10000) addSuffixCaloriesButton.Text = "Edit suffix";
            }
            if (watch.Activity?.Pulse?.Number != null)
            {
                addPulseButton.Text = "Edit pulse";
                addPreffixPulseButton.Enabled = true;
                addSuffixPulseButton.Enabled = true;
                addNoDataPulseButton.Enabled = true;
                if (watch.Activity.Pulse.PrefixImageIndex != -10000) addPreffixPulseButton.Text = "Edit preffix";
                if (watch.Activity.Pulse.SuffixImageIndex != -10000) addSuffixPulseButton.Text = "Edit suffix";
                if (watch.Activity.Pulse.NoDataImageIndex != -10000) addNoDataPulseButton.Text = "Edit no data";
            }
            if (watch.Activity?.Distance?.Number != null)
            {
                addDistanceButton.Text = "Edit distance";
                addKmDistanceSuffixButton.Enabled = true;
                addDecimalDistanceButton.Enabled = true;
                addMiDistanceSuffixButton.Enabled = true;
                addKmImageButton.Enabled = true;
                addMiImageButton.Enabled = true;
                if (watch.Activity.Distance.KmSuffixImageIndex != -10000) addKmDistanceSuffixButton.Text = "Edit KM suffix";
                if (watch.Activity.Distance.DecimalPointImageIndex!= -10000) addDecimalDistanceButton.Text = "Edit decimal point";
                if (watch.Activity.Distance.MilesSuffixImageIndex != -10000) addMiDistanceSuffixButton.Text = "Edit MI suffix";
                if (watch.Activity.Distance.MilesImageIndex != null) addMiImageButton.Text = "Edit MI image";
                if (watch.Activity.Distance.KmImageIndex != null) addKmImageButton.Text = "Edit KM image";
            }
            if (watch.Activity?.PAI?.Number != null)
            {
                addPAIButton.Text = "Edit PAI";
            }
        }

        private void updateGroupBox(object sender, EventArgs e)
        {
            groupBox1.Enabled = stepsCheckBox.Checked;
            groupBox2.Enabled = caloriesCheckBox.Checked;
            groupBox3.Enabled = pulseCheckBox.Checked;
            groupBox5.Enabled = distanceCheckBox.Checked;
            groupBox4.Enabled = paiCheckBox.Checked;
        }

        private void addNumberButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            WatchFaceLibrary watchface = DeepCopy(watch);

            if (btn.Name == "addStepsButton")
            {
                watchface.Activity.Steps = watchface.Activity?.Steps == null ? new Steps() : watchface.Activity.Steps;
                watchface.Activity.Steps.Number = watchface.Activity?.Steps?.Number?.ImageIndex >= 0 ? watchface.Activity.Steps.Number : new Number() { notDraw = true };
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Activity.Steps.Number, watch.imagesBuff.DeepCopy(), state,10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex != -10000)
                {
                    watch.Activity.Steps = numForm.watch.Activity.Steps;
                    watch.Activity.Steps.Number = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addStepsButton.Text = "Edit steps";
                    addPreffixStepsButton.Enabled = true;
                    addSuffixStepsButton.Enabled = true;
                }
                else if (numForm.saved)
                {
                    watch.Activity.Steps = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addStepsButton.Text = "Add steps";
                    addPreffixStepsButton.Text = "Add preffix";
                    addSuffixStepsButton.Text = "Add suffix";
                    addPreffixStepsButton.Enabled = false;
                    addSuffixStepsButton.Enabled = false;
                }
            }
            else if (btn.Name == "addCaloriesButton")
            {
                watchface.Activity.Calories = watchface.Activity?.Calories == null ? new Calories() : watchface.Activity.Calories;
                watchface.Activity.Calories.Text = watchface.Activity?.Calories?.Text?.ImageIndex >= 0 ? watchface.Activity.Calories.Text: new Number() { notDraw = true };
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Activity.Calories.Text, watch.imagesBuff,state,10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex != -10000)
                {
                    watch.Activity.Calories = numForm.watch.Activity.Calories;
                    watch.Activity.Calories.Text = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addCaloriesButton.Text = "Edit calories";
                    addPreffixCaloriesButton.Enabled = true;
                    addSuffixCaloriesButton.Enabled = true;
                }
                else if (numForm.saved)
                {
                    watch.Activity.Calories = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addCaloriesButton.Text = "Add calories";
                    addPreffixCaloriesButton.Text = "Add preffix";
                    addSuffixCaloriesButton.Text = "Add suffix";
                    addPreffixCaloriesButton.Enabled = false;
                    addSuffixCaloriesButton.Enabled = false;
                }
            }
            else if (btn.Name == "addPulseButton")
            {
                watchface.Activity.Pulse = watchface.Activity?.Pulse == null ? new Pulse() : watchface.Activity.Pulse;
                watchface.Activity.Pulse.Number = watchface.Activity?.Pulse?.Number?.ImageIndex >= 0 ? watchface.Activity.Pulse.Number : new Number() { notDraw = true };
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Activity.Pulse.Number, watch.imagesBuff.DeepCopy(), state,10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex != -10000)
                {
                    watch.Activity.Pulse = numForm.watch.Activity.Pulse;
                    watch.Activity.Pulse.Number = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addPulseButton.Text = "Edit pulse";
                    addPreffixPulseButton.Enabled = true;
                    addSuffixPulseButton.Enabled = true;
                    addNoDataPulseButton.Enabled = true;
                }
                else if (numForm.saved)
                {
                    watch.Activity.Pulse = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addPulseButton.Text = "Add pulse";
                    addPreffixPulseButton.Text = "Add preffix";
                    addSuffixPulseButton.Text = "Add suffix";
                    addPreffixPulseButton.Enabled = false;
                    addSuffixPulseButton.Enabled = false;
                    addNoDataPulseButton.Enabled = false;
                }
            }
            else if (btn.Name == "addPAIButton")
            {
                watchface.Activity.PAI = watchface.Activity?.PAI == null ? new PAI() : watchface.Activity.PAI;
                watchface.Activity.PAI.Number = watchface.Activity?.PAI?.Number?.ImageIndex >= 0 ? watchface.Activity.PAI.Number : new Number() { notDraw = true };
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Activity.PAI.Number, watch.imagesBuff.DeepCopy(), state,10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex != -10000)
                {
                    watch.Activity.PAI = numForm.watch.Activity.PAI;
                    watch.Activity.PAI.Number = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addPAIButton.Text = "Edit PAI";
                }
                else if (numForm.saved)
                {
                    watch.Activity.PAI = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addPAIButton.Text = "Add PAI";
                }
            }
            else if (btn.Name == "addDistanceButton")
            {
                watchface.Activity.Distance = watchface.Activity?.Distance == null ? new Distance() : watchface.Activity.Distance;
                watchface.Activity.Distance.Number = watchface.Activity?.Distance?.Number?.ImageIndex >= 0 ? watchface.Activity.Distance.Number : new Number() { notDraw = true };
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Activity.Distance.Number, watch.imagesBuff.DeepCopy(), state,10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex != -10000)
                {
                    watch.Activity.Distance = numForm.watch.Activity.Distance;
                    watch.Activity.Distance.Number = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addDistanceButton.Text = "Edit distance";
                    addKmDistanceSuffixButton.Enabled = true;
                    addDecimalDistanceButton.Enabled = true;
                    addMiDistanceSuffixButton.Enabled = true;
                    addKmImageButton.Enabled = true;
                    addMiImageButton.Enabled = true;
                }
                else if (numForm.saved)
                {
                    watch.Activity.Distance = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addDistanceButton.Text = "Add distance";
                    addKmDistanceSuffixButton.Text = "Add KM suffix";
                    addDecimalDistanceButton.Text = "Add decimal point";
                    addMiDistanceSuffixButton.Text = "Add MI suffix";
                    addKmImageButton.Text = "Add KM image";
                    addMiImageButton.Text = "Add MI image";
                    addKmDistanceSuffixButton.Enabled = false;
                    addDecimalDistanceButton.Enabled = false;
                    addMiDistanceSuffixButton.Enabled = false;
                    addKmImageButton.Enabled = false;
                    addMiImageButton.Enabled = false;
                }
            }

            Render(state);
        }

        private void addPreffixButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            List<int> selImg = null;
            ImagesForm imgForm;

            if (btn.Name == "addPreffixStepsButton")
            {
                if (watch.Activity.Steps.PrefixImageIndex != -10000) selImg = new List<int>() { watch.Activity.Steps.PrefixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Steps.PrefixImageIndex = imgForm.selectedImages[0];
                    addPreffixStepsButton.Text = "Edit preffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Steps.PrefixImageIndex = -10000;
                    addPreffixStepsButton.Text = "Add preffix";
                }
            }
            else if (btn.Name == "addPreffixCaloriesButton")
            {
                if (watch.Activity.Calories.PrefixImageIndex != -10000) selImg = new List<int>() { watch.Activity.Calories.PrefixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Calories.PrefixImageIndex = imgForm.selectedImages[0];
                    addPreffixCaloriesButton.Text = "Edit preffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Calories.PrefixImageIndex = -10000;
                    addPreffixCaloriesButton.Text = "Add preffix";
                }
            }
            else if (btn.Name == "addPreffixPulseButton")
            {
                if (watch.Activity.Pulse.PrefixImageIndex != -10000) selImg = new List<int>() { watch.Activity.Pulse.PrefixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.PrefixImageIndex = imgForm.selectedImages[0];
                    addPreffixPulseButton.Text = "Edit preffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.PrefixImageIndex = -10000;
                    addPreffixPulseButton.Text = "Add preffix";
                }
            }

            Render(state);
        }

        private void addSuffixButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            List<int> selImg = null;
            ImagesForm imgForm;

            if (btn.Name == "addSuffixStepsButton")
            {
                if (watch.Activity.Steps.SuffixImageIndex != -10000) selImg = new List<int>() { watch.Activity.Steps.SuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Steps.SuffixImageIndex = imgForm.selectedImages[0];
                    addSuffixCaloriesButton.Text = "Edit suffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Steps.SuffixImageIndex = -10000;
                    addSuffixCaloriesButton.Text = "Add suffix";
                }
            }
            else if (btn.Name == "addSuffixCaloriesButton")
            {
                if (watch.Activity.Calories.SuffixImageIndex != -10000) selImg = new List<int>() { watch.Activity.Calories.SuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Calories.SuffixImageIndex = imgForm.selectedImages[0];
                    addSuffixCaloriesButton.Text = "Edit suffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Calories.SuffixImageIndex = -10000;
                    addSuffixCaloriesButton.Text = "Add suffix";
                }
            }
            else if (btn.Name == "addSuffixPulseButton")
            {
                if (watch.Activity.Pulse.SuffixImageIndex != -10000) selImg = new List<int>() { watch.Activity.Pulse.SuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.SuffixImageIndex = imgForm.selectedImages[0];
                    addSuffixPulseButton.Text = "Edit suffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.SuffixImageIndex = -10000;
                    addSuffixPulseButton.Text = "Add suffix";
                }
            }
            else if (btn.Name == "addNoDataPulseButton")
            {
                if (watch.Activity.Pulse.NoDataImageIndex != -10000) selImg = new List<int>() { watch.Activity.Pulse.NoDataImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.NoDataImageIndex = imgForm.selectedImages[0];
                    addNoDataPulseButton.Text = "Edit no data";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.NoDataImageIndex = -10000;
                    addNoDataPulseButton.Text = "Add no data";
                }
            }
            else if (btn.Name == "addKmDistanceSuffixButton")
            {
                if (watch.Activity.Distance.KmSuffixImageIndex != -10000) selImg = new List<int>() { watch.Activity.Distance.KmSuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.KmSuffixImageIndex = imgForm.selectedImages[0];
                    addKmDistanceSuffixButton.Text = "Edit KM Suffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.KmSuffixImageIndex = -10000;
                    addKmDistanceSuffixButton.Text = "Add KM Suffix";
                }
            }
            else if (btn.Name == "addMiDistanceSuffixButton")
            {
                if (watch.Activity.Distance.MilesSuffixImageIndex != -10000) selImg = new List<int>() { watch.Activity.Distance.MilesSuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.MilesSuffixImageIndex = imgForm.selectedImages[0];
                    addMiDistanceSuffixButton.Text = "Edit MI Suffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.MilesSuffixImageIndex = -10000;
                    addMiDistanceSuffixButton.Text = "Add MI Suffix";
                }
            }
            else if (btn.Name == "addDecimalDistanceButton")
            {
                if (watch.Activity.Distance.DecimalPointImageIndex != -10000) selImg = new List<int>() { watch.Activity.Distance.DecimalPointImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.DecimalPointImageIndex = imgForm.selectedImages[0];
                    addDecimalDistanceButton.Text = "Edit decimal point";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.DecimalPointImageIndex = -10000;
                    addDecimalDistanceButton.Text = "Add decimal point";
                }
            }

            Render(state);
        }

        private void addImageDistance(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name == "addKmImageButton")
            {
                watch.Activity.Distance.KmImageIndex = watch.Activity.Distance.KmImageIndex == null ? new ImageBasic() : watch.Activity.Distance.KmImageIndex;
                StateWatchface stateDist = state;
                stateDist.MiKm = true;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Activity.Distance.KmImageIndex, watch.imagesBuff.DeepCopy(), stateDist);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    addKmImageButton.Text = "Edit KM image";
                    watch.Activity.Distance.KmImageIndex = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else
                {
                    addKmImageButton.Text = "Add KM image";
                    watch.Activity.Distance.KmImageIndex = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (btn.Name == "addMiImageButton")
            {
                watch.Activity.Distance.MilesImageIndex = watch.Activity.Distance.MilesImageIndex == null ? new ImageBasic() : watch.Activity.Distance.MilesImageIndex;
                StateWatchface stateDist = state;
                stateDist.MiKm = false;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Activity.Distance.MilesImageIndex, watch.imagesBuff.DeepCopy(), stateDist);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    addMiImageButton.Text = "Edit MI image";
                    watch.Activity.Distance.MilesImageIndex = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else
                {
                    addMiImageButton.Text = "Add MI image";
                    watch.Activity.Distance.MilesImageIndex = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }

            Render(state);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save = true;
            if (stepsCheckBox.Checked == false || (watch.Activity.Steps == null)) watch.Activity.Steps = null;
            if (caloriesCheckBox.Checked == false) watch.Activity.Calories = null;
            if (pulseCheckBox.Checked == false) watch.Activity.Pulse = null;
            if (distanceCheckBox.Checked == false) watch.Activity.Distance = null;
            if (paiCheckBox.Checked == false) watch.Activity.PAI = null;
            if (watch.Activity.Steps == null && watch.Activity.Calories == null && watch.Activity.Pulse == null && watch.Activity.Distance == null && watch.Activity.PAI == null)
                watch.Activity = null;
            this.Close();
        }

        private void ActivityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show("Do you want to get out without saving?", "Don't Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (stepsCheckBox.Checked == false) watch.Activity.Steps = null;
                if (caloriesCheckBox.Checked == false) watch.Activity.Calories = null;
                if (pulseCheckBox.Checked == false) watch.Activity.Pulse = null;
                if (distanceCheckBox.Checked == false) watch.Activity.Distance = null;
                if (paiCheckBox.Checked == false) watch.Activity.PAI = null;
                if (watch.Activity.Steps == null && watch.Activity.Calories == null && watch.Activity.Pulse == null && watch.Activity.Distance == null && watch.Activity.PAI == null)
                    watch.Activity = null;
            }
        }
    }
}
