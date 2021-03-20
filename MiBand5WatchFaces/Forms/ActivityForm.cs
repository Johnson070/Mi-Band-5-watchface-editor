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
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

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
            this.watch.imagesBuff = Images;
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
                addStepsButton.Text = res.GetString("EditSteps");
                addPreffixStepsButton.Enabled = true;
                addSuffixStepsButton.Enabled = true;
                if (watch.Activity.Steps.PrefixImageIndex >= 0) addPreffixStepsButton.Text = res.GetString("EditPrefix");
                if (watch.Activity.Steps.SuffixImageIndex >= 0) addSuffixStepsButton.Text = res.GetString("EditSuffix");
            }
            if (watch.Activity?.Calories?.Text != null)
            {
                addCaloriesButton.Text = res.GetString("EditCalories");
                addPreffixCaloriesButton.Enabled = true;
                addSuffixCaloriesButton.Enabled = true;
                if (watch.Activity.Calories.PrefixImageIndex >= 0) addPreffixCaloriesButton.Text = res.GetString("EditPrefix");
                if (watch.Activity.Calories.SuffixImageIndex >= 0) addSuffixCaloriesButton.Text = res.GetString("EditSuffix");
            }
            if (watch.Activity?.Pulse?.Number != null)
            {
                addPulseButton.Text = res.GetString("EditPulse");
                addPreffixPulseButton.Enabled = true;
                addSuffixPulseButton.Enabled = true;
                addNoDataPulseButton.Enabled = true;
                if (watch.Activity.Pulse.PrefixImageIndex >= 0) addPreffixPulseButton.Text = res.GetString("EditPrefix");
                if (watch.Activity.Pulse.SuffixImageIndex >= 0) addSuffixPulseButton.Text = res.GetString("EditSuffix");
                if (watch.Activity.Pulse.NoDataImageIndex >= 0) addNoDataPulseButton.Text = res.GetString("EditNoData");
            }
            if (watch.Activity?.Distance?.Number != null)
            {
                addDistanceButton.Text = res.GetString("EditDistance");
                addKmDistanceSuffixButton.Enabled = true;
                addDecimalDistanceButton.Enabled = true;
                addMiDistanceSuffixButton.Enabled = true;
                addKmImageButton.Enabled = true;
                addMiImageButton.Enabled = true;
                if (watch.Activity.Distance.KmSuffixImageIndex >= 0) addKmDistanceSuffixButton.Text = res.GetString("EditKMSuffix");
                if (watch.Activity.Distance.DecimalPointImageIndex>= 0) addDecimalDistanceButton.Text = res.GetString("EditDecimalPoint");
                if (watch.Activity.Distance.MilesSuffixImageIndex >= 0) addMiDistanceSuffixButton.Text = res.GetString("EditMISuffix");
                if (watch.Activity.Distance.MilesImageIndex != null) addMiImageButton.Text = res.GetString("EditMIImage");
                if (watch.Activity.Distance.KmImageIndex != null) addKmImageButton.Text = res.GetString("EditKMImage");
            }
            if (watch.Activity?.PAI?.Number != null)
            {
                addPAIButton.Text = res.GetString("EditPAI");
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

            if (btn.Name == addStepsButton.Name)
            {
                watchface.Activity.Steps = watchface.Activity?.Steps == null ? new Steps() : watchface.Activity.Steps;
                watchface.Activity.Steps.Number = watchface.Activity?.Steps?.Number?.ImageIndex >= 0 ? watchface.Activity.Steps.Number : new Number() { notDraw = true };
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Activity.Steps.Number, watch.imagesBuff.DeepCopy(), state,10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Activity.Steps = numForm.watch.Activity.Steps;
                    watch.Activity.Steps.Number = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addStepsButton.Text = res.GetString("EditSteps");
                    addPreffixStepsButton.Enabled = true;
                    addSuffixStepsButton.Enabled = true;
                }
                else if (numForm.delete)
                {
                    watch.Activity.Steps = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addStepsButton.Text = res.GetString("AddSteps");
                    addPreffixStepsButton.Text = res.GetString("AddPrefix");
                    addSuffixStepsButton.Text = res.GetString("AddSuffix");
                    addPreffixStepsButton.Enabled = false;
                    addSuffixStepsButton.Enabled = false;
                }
            }
            else if (btn.Name == addCaloriesButton.Name)
            {
                watchface.Activity.Calories = watchface.Activity?.Calories == null ? new Calories() : watchface.Activity.Calories;
                watchface.Activity.Calories.Text = watchface.Activity?.Calories?.Text?.ImageIndex >= 0 ? watchface.Activity.Calories.Text: new Number() { notDraw = true };
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Activity.Calories.Text, watch.imagesBuff,state,10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Activity.Calories = numForm.watch.Activity.Calories;
                    watch.Activity.Calories.Text = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addCaloriesButton.Text = res.GetString("EditCalories");
                    addPreffixCaloriesButton.Enabled = true;
                    addSuffixCaloriesButton.Enabled = true;
                }
                else if (numForm.delete)
                {
                    watch.Activity.Calories = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addCaloriesButton.Text = res.GetString("AddCalories");
                    addPreffixCaloriesButton.Text = res.GetString("AddPrefix");
                    addSuffixCaloriesButton.Text = res.GetString("AddSuffix");
                    addPreffixCaloriesButton.Enabled = false;
                    addSuffixCaloriesButton.Enabled = false;
                }
            }
            else if (btn.Name == addPulseButton.Name)
            {
                watchface.Activity.Pulse = watchface.Activity?.Pulse == null ? new Pulse() : watchface.Activity.Pulse;
                watchface.Activity.Pulse.Number = watchface.Activity?.Pulse?.Number?.ImageIndex >= 0 ? watchface.Activity.Pulse.Number : new Number() { notDraw = true };
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Activity.Pulse.Number, watch.imagesBuff.DeepCopy(), state,10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Activity.Pulse = numForm.watch.Activity.Pulse;
                    watch.Activity.Pulse.Number = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addPulseButton.Text = res.GetString("EditPulse");
                    addPreffixPulseButton.Enabled = true;
                    addSuffixPulseButton.Enabled = true;
                    addNoDataPulseButton.Enabled = true;
                }
                else if (numForm.delete)
                {
                    watch.Activity.Pulse = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addPulseButton.Text = res.GetString("AddPulse");
                    addPreffixPulseButton.Text = res.GetString("AddPrefix");
                    addSuffixPulseButton.Text = res.GetString("AddSuffix");
                    addPreffixPulseButton.Enabled = false;
                    addSuffixPulseButton.Enabled = false;
                    addNoDataPulseButton.Enabled = false;
                }
            }
            else if (btn.Name == addPAIButton.Name)
            {
                watchface.Activity.PAI = watchface.Activity?.PAI == null ? new PAI() : watchface.Activity.PAI;
                watchface.Activity.PAI.Number = watchface.Activity?.PAI?.Number?.ImageIndex >= 0 ? watchface.Activity.PAI.Number : new Number() { notDraw = true };
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Activity.PAI.Number, watch.imagesBuff.DeepCopy(), state,10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Activity.PAI = numForm.watch.Activity.PAI;
                    watch.Activity.PAI.Number = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addPAIButton.Text = res.GetString("EditPAI");
                }
                else if (numForm.delete)
                {
                    watch.Activity.PAI = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addPAIButton.Text = res.GetString("AddPAI");
                }
            }
            else if (btn.Name == addDistanceButton.Name)
            {
                watchface.Activity.Distance = watchface.Activity?.Distance == null ? new Distance() : watchface.Activity.Distance;
                watchface.Activity.Distance.Number = watchface.Activity?.Distance?.Number?.ImageIndex >= 0 ? watchface.Activity.Distance.Number : new Number() { notDraw = true };
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Activity.Distance.Number, watch.imagesBuff.DeepCopy(), state,10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Activity.Distance = numForm.watch.Activity.Distance;
                    watch.Activity.Distance.Number = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addDistanceButton.Text = res.GetString("EditDistance");
                    addKmDistanceSuffixButton.Enabled = true;
                    addDecimalDistanceButton.Enabled = true;
                    addMiDistanceSuffixButton.Enabled = true;
                    addKmImageButton.Enabled = true;
                    addMiImageButton.Enabled = true;
                }
                else if (numForm.delete)
                {
                    watch.Activity.Distance = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addDistanceButton.Text = res.GetString("AddDistance");
                    addKmDistanceSuffixButton.Text = res.GetString("AddKMSuffix");
                    addDecimalDistanceButton.Text = res.GetString("AddDecimalPoint");
                    addMiDistanceSuffixButton.Text = res.GetString("AddMISuffix");
                    addKmImageButton.Text = res.GetString("AddKMImage");
                    addMiImageButton.Text = res.GetString("AddMIImage");
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

            if (btn.Name == addPreffixStepsButton.Name)
            {
                if (watch.Activity.Steps.PrefixImageIndex >= 0) selImg = new List<int>() { watch.Activity.Steps.PrefixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Steps.PrefixImageIndex = imgForm.selectedImages[0];
                    addPreffixStepsButton.Text = res.GetString("EditPrefix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Steps.PrefixImageIndex = -10000;
                    addPreffixStepsButton.Text = res.GetString("AddPrefix");
                }
            }
            else if (btn.Name == addPreffixCaloriesButton.Name)
            {
                if (watch.Activity.Calories.PrefixImageIndex >= 0) selImg = new List<int>() { watch.Activity.Calories.PrefixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Calories.PrefixImageIndex = imgForm.selectedImages[0];
                    addPreffixCaloriesButton.Text = res.GetString("EditPrefix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Calories.PrefixImageIndex = -10000;
                    addPreffixCaloriesButton.Text = res.GetString("AddPrefix");
                }
            }
            else if (btn.Name == addPreffixPulseButton.Name)
            {
                if (watch.Activity.Pulse.PrefixImageIndex >= 0) selImg = new List<int>() { watch.Activity.Pulse.PrefixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.PrefixImageIndex = imgForm.selectedImages[0];
                    addPreffixPulseButton.Text = res.GetString("EditPrefix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.PrefixImageIndex = -10000;
                    addPreffixPulseButton.Text = res.GetString("AddPrefix");
                }
            }

            Render(state);
        }

        private void addSuffixButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            List<int> selImg = null;
            ImagesForm imgForm;

            if (btn.Name == addSuffixStepsButton.Name)
            {
                if (watch.Activity.Steps.SuffixImageIndex >= 0) selImg = new List<int>() { watch.Activity.Steps.SuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Steps.SuffixImageIndex = imgForm.selectedImages[0];
                    addSuffixStepsButton.Text = res.GetString("EditSuffix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Steps.SuffixImageIndex = -10000;
                    addSuffixStepsButton.Text = res.GetString("AddSuffix");
                }
            }
            else if (btn.Name == addSuffixCaloriesButton.Name)
            {
                if (watch.Activity.Calories.SuffixImageIndex >= 0) selImg = new List<int>() { watch.Activity.Calories.SuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Calories.SuffixImageIndex = imgForm.selectedImages[0];
                    addSuffixCaloriesButton.Text = res.GetString("EditSuffix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Calories.SuffixImageIndex = -10000;
                    addSuffixCaloriesButton.Text = res.GetString("AddSuffix");
                }
            }
            else if (btn.Name == addSuffixPulseButton.Name)
            {
                if (watch.Activity.Pulse.SuffixImageIndex >= 0) selImg = new List<int>() { watch.Activity.Pulse.SuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.SuffixImageIndex = imgForm.selectedImages[0];
                    addSuffixPulseButton.Text = res.GetString("EditSuffix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.SuffixImageIndex = -10000;
                    addSuffixPulseButton.Text = res.GetString("AddSuffix");
                }
            }
            else if (btn.Name == addNoDataPulseButton.Name)
            {
                if (watch.Activity.Pulse.NoDataImageIndex >= 0) selImg = new List<int>() { watch.Activity.Pulse.NoDataImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.NoDataImageIndex = imgForm.selectedImages[0];
                    addNoDataPulseButton.Text = res.GetString("EditNoData");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Pulse.NoDataImageIndex = -10000;
                    addNoDataPulseButton.Text = res.GetString("AddNoData");
                }
            }
            else if (btn.Name == addKmDistanceSuffixButton.Name)
            {
                if (watch.Activity.Distance.KmSuffixImageIndex >= 0) selImg = new List<int>() { watch.Activity.Distance.KmSuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.KmSuffixImageIndex = imgForm.selectedImages[0];
                    addKmDistanceSuffixButton.Text = res.GetString("EditKMSuffix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.KmSuffixImageIndex = -10000;
                    addKmDistanceSuffixButton.Text = res.GetString("AddKMSuffix");
                }
            }
            else if (btn.Name == addMiDistanceSuffixButton.Name)
            {
                if (watch.Activity.Distance.MilesSuffixImageIndex >= 0) selImg = new List<int>() { watch.Activity.Distance.MilesSuffixImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.MilesSuffixImageIndex = imgForm.selectedImages[0];
                    addMiDistanceSuffixButton.Text = res.GetString("EditMISuffix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.MilesSuffixImageIndex = -10000;
                    addMiDistanceSuffixButton.Text = res.GetString("AddMISuffix");
                }
            }
            else if (btn.Name == addDecimalDistanceButton.Name)
            {
                if (watch.Activity.Distance.DecimalPointImageIndex >= 0) selImg = new List<int>() { watch.Activity.Distance.DecimalPointImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.DecimalPointImageIndex = imgForm.selectedImages[0];
                    addDecimalDistanceButton.Text = res.GetString("EditDecimalPoint");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Activity.Distance.DecimalPointImageIndex = -10000;
                    addDecimalDistanceButton.Text = res.GetString("AddDecimalPoint");
                }
            }

            Render(state);
        }

        private void addImageDistance(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name == addKmImageButton.Name)
            {
                watch.Activity.Distance.KmImageIndex = watch.Activity.Distance.KmImageIndex == null ? new ImageBasic() : watch.Activity.Distance.KmImageIndex;
                StateWatchface stateDist = state;
                stateDist.MiKm = true;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Activity.Distance.KmImageIndex, watch.imagesBuff.DeepCopy(), stateDist);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    addKmImageButton.Text = res.GetString("EditKMImage");
                    watch.Activity.Distance.KmImageIndex = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    addKmImageButton.Text = res.GetString("AddKMImage");
                    watch.Activity.Distance.KmImageIndex = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (btn.Name == addMiImageButton.Name)
            {
                watch.Activity.Distance.MilesImageIndex = watch.Activity.Distance.MilesImageIndex == null ? new ImageBasic() : watch.Activity.Distance.MilesImageIndex;
                StateWatchface stateDist = state;
                stateDist.MiKm = false;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Activity.Distance.MilesImageIndex, watch.imagesBuff.DeepCopy(), stateDist);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    addMiImageButton.Text = res.GetString("EditMIImage");
                    watch.Activity.Distance.MilesImageIndex = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    addMiImageButton.Text = res.GetString("AddMIImage");
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
            if (Save == false && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
