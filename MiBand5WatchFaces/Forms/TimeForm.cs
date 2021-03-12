using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MiBand5WatchFaces.Forms
{
    public partial class TimeForm : Form
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

        public TimeForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            watch.imagesBuff = Images;
            this.state = state;

            this.watch.Time = watch.Time == null ? new Time() : watch.Time;
            this.watch.Time.UnknownV11 = 0;
            Render(state);


            if (watch.Time != null)
            {
                if (watch.Time.Hours != null && watch.Time.Hours.Ones != null) AddOnesHourBtn.Text = res.GetString("EditOnes");
                if (watch.Time.Hours != null && watch.Time.Hours.Tens != null) AddTensHourBtn.Text = res.GetString("EditTens");
                if (watch.Time.Minutes != null && watch.Time.Minutes.Ones != null) AddOnesMinuteBtn.Text = res.GetString("EditOnes");
                if (watch.Time.Minutes != null && watch.Time.Minutes.Tens != null) AddTensMinuteBtn.Text = res.GetString("EditTens");

                if (watch.Time.TimeZone1 != null)
                {
                    timeZone1ButtonEdit.Text = res.GetString("EditNumber");
                    TZ1groupBox.Enabled = true;
                    timeZone1Check.Checked = true;
                }
                if (watch.Time.TimeZone2 != null)
                {
                    timeZone2ButtonEdit.Text = res.GetString("EditNumber");
                    TZ2groupBox.Enabled = true;
                    timeZone2Check.Checked = true;
                }
                if (watch.Time?.TimeZone1NoTime != null)
                {
                    TZ1NoTime.Text = res.GetString("EditNoTime");
                }
                if (watch.Time?.TimeZone2NoTime != null)
                {
                    TZ2NoTime.Text = res.GetString("EditNoTime");
                }
                TZ1DelimeterBtn.Text = watch.Time.TimeZone1DelimiterImage >= 0 ? res.GetString("EditDelimeter") : TZ1DelimeterBtn.Text;
                TZ2DelimeterBtn.Text = watch.Time.TimeZone2DelimiterImage >= 0 ? res.GetString("EditDelimeter") : TZ2DelimeterBtn.Text;
            }
        }

        private void EditTwoDigits(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            WatchFaceLibrary watchface = DeepCopy(watch);

            if (btn.Name == AddOnesHourBtn.Name)
            {
                watchface.Time.Hours = watchface.Time.Hours == null ? new TwoDigits() : watchface.Time.Hours;
                watchface.Time.Hours.Ones = watchface.Time.Hours.Ones == null ? new ImageSet() : watchface.Time.Hours.Ones;
                ImageSetForm setForm = new ImageSetForm(watchface, watchface.Time.Hours.Ones, watch.imagesBuff.DeepCopy(), state, 10);
                setForm.ShowDialog();

                if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
                {
                    watch.imagesBuff = setForm.watch.imagesBuff;
                    watch.Time.Hours = watch.Time.Hours == null ? new TwoDigits() : watch.Time.Hours;
                    watch.Time.Hours.Ones = setForm.imageSet;
                    AddOnesHourBtn.Text = res.GetString("EditOnes");
                }
            }
            else if (btn.Name == AddTensHourBtn.Name)
            {
                watchface.Time.Hours = watchface.Time.Hours == null ? new TwoDigits() : watchface.Time.Hours;
                watchface.Time.Hours.Tens = watchface.Time.Hours.Tens == null ? new ImageSet() : watchface.Time.Hours.Tens;
                ImageSetForm setForm = new ImageSetForm(watchface, watchface.Time.Hours.Tens, watch.imagesBuff.DeepCopy(), state, 10);
                setForm.ShowDialog();

                if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
                {
                    watch.imagesBuff = setForm.watch.imagesBuff;
                    watch.Time.Hours = watch.Time.Hours == null ? new TwoDigits() : watch.Time.Hours;
                    watch.Time.Hours.Tens = setForm.imageSet;
                    AddTensHourBtn.Text = res.GetString("EditTens");
                }
            }
            else if (btn.Name == AddOnesMinuteBtn.Name)
            {
                watchface.Time.Minutes = watchface.Time.Minutes == null ? new TwoDigits() : watchface.Time.Minutes;
                watchface.Time.Minutes.Ones = watchface.Time.Minutes.Ones == null ? new ImageSet() : watchface.Time.Minutes.Ones;
                ImageSetForm setForm = new ImageSetForm(watchface, watchface.Time.Minutes.Ones, watch.imagesBuff.DeepCopy(), state, 10);
                setForm.ShowDialog();

                if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
                {
                    watch.imagesBuff = setForm.watch.imagesBuff;
                    watch.Time.Minutes = watch.Time.Minutes == null ? new TwoDigits() : watch.Time.Minutes;
                    watch.Time.Minutes.Ones = setForm.imageSet;
                    AddOnesMinuteBtn.Text = res.GetString("EditOnes");
                }
            }
            else if (btn.Name == AddTensMinuteBtn.Name)
            {
                watchface.Time.Minutes = watchface.Time.Minutes == null ? new TwoDigits() : watchface.Time.Minutes;
                watchface.Time.Minutes.Tens = watchface.Time.Minutes.Ones == null ? new ImageSet() : watchface.Time.Minutes.Tens;
                ImageSetForm setForm = new ImageSetForm(watchface, watchface.Time.Minutes.Tens, watch.imagesBuff.DeepCopy(), state, 10);
                setForm.ShowDialog();

                if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
                {
                    watch.imagesBuff = setForm.watch.imagesBuff;
                    watch.Time.Minutes = watch.Time.Minutes == null ? new TwoDigits() : watch.Time.Minutes;
                    watch.Time.Minutes.Tens = setForm.imageSet;
                    AddTensMinuteBtn.Text = res.GetString("EditTens");
                }
            }

            Render(state);
        }

        private void timeZoneChanged(object sender, EventArgs e)
        {
            TZ1groupBox.Enabled = timeZone1Check.Checked;
            TZ2groupBox.Enabled = timeZone2Check.Checked;
        }

        private void timeZone1ButtonEdit_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);

            watchface.Time.TimeZone1 = watchface.Time.TimeZone1 == null ? new Number() { notDraw = true } : watchface.Time.TimeZone1;
            NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Time.TimeZone1, watch.imagesBuff.DeepCopy(), state, 10);
            numberForm.ShowDialog();

            if (numberForm.saved && numberForm.number.ImageIndex >= 0)
            {
                watch.imagesBuff = numberForm.watch.imagesBuff;
                watch.Time.TimeZone1 = numberForm.number;
                timeZone1ButtonEdit.Text = res.GetString("EditNumber");
                TZ1DelimeterBtn.Enabled = true;
                TZ1NoTime.Enabled = true;
            }
            else if (numberForm.delete)
            {
                watch.imagesBuff = numberForm.watch.imagesBuff;
                watch.Time.TimeZone1 = null;
                timeZone1ButtonEdit.Text = res.GetString("AddNumber");
                TZ1DelimeterBtn.Enabled = false;
                TZ1NoTime.Enabled = false;
            }


            Render(state);
        }

        private void timeZone2ButtonEdit_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);

            watchface.Time.TimeZone2 = watchface.Time.TimeZone2 == null ? new Number() { notDraw = true } : watchface.Time.TimeZone2;
            NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Time.TimeZone2, watch.imagesBuff.DeepCopy(), state, 10);
            numberForm.ShowDialog();

            if (numberForm.saved && numberForm.number.ImageIndex >= 0)
            {
                watch.imagesBuff = numberForm.watch.imagesBuff;
                watch.Time.TimeZone2 = numberForm.number;
                timeZone2ButtonEdit.Text = res.GetString("EditNumber");
                TZ2DelimeterBtn.Enabled = true;
                TZ2NoTime.Enabled = true;
            }
            else if (numberForm.delete)
            {
                watch.imagesBuff = numberForm.watch.imagesBuff;
                watch.Time.TimeZone2 = null;
                timeZone2ButtonEdit.Text = res.GetString("AddNumber");
                TZ2DelimeterBtn.Enabled = false;
                TZ2NoTime.Enabled = false;
            }


            Render(state);
        }

        private void addDelimeter(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            List<int> selImg = null;
            ImagesForm imgForm;

            if (name == TZ1DelimeterBtn.Name)
            {
                if (watch.Time.TimeZone1DelimiterImage >= 0) selImg = new List<int>() { watch.Time.TimeZone1DelimiterImage };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.TimeZone1DelimiterImage = imgForm.selectedImages[0];
                    TZ1DelimeterBtn.Text = res.GetString("EditDelimeter");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.TimeZone1DelimiterImage = -10000;
                    TZ1DelimeterBtn.Text = res.GetString("AddDelimeter");
                }
            }
            else if (name == TZ2DelimeterBtn.Name)
            {
                if (watch.Time.TimeZone2DelimiterImage >= 0) selImg = new List<int>() { watch.Time.TimeZone2DelimiterImage };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.TimeZone2DelimiterImage = imgForm.selectedImages[0];
                    TZ2DelimeterBtn.Text = res.GetString("EditDelimeter");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.TimeZone2DelimiterImage = -10000;
                    TZ2DelimeterBtn.Text = res.GetString("AddDelimeter");
                }
            }

            Render(state);
        }

        private void TZNoTime_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;

            if (name == TZ1NoTime.Name)
            {
                watch.Time.TimeZone1NoTime = watch.Time.TimeZone1NoTime == null ? new ImageBasic() : watch.Time.TimeZone1NoTime;
                StateWatchface newState = DeepCopy(state);
                newState.NoTimeZone = true;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Time.TimeZone1NoTime, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    TZ1NoTime.Text = res.GetString("EditNoTime");
                    watch.Time.TimeZone1NoTime = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    TZ1NoTime.Text = res.GetString("AddNoTime");
                    watch.Time.TimeZone1NoTime = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (name == TZ2NoTime.Name)
            {
                watch.Time.TimeZone2NoTime = watch.Time.TimeZone2NoTime == null ? new ImageBasic() : watch.Time.TimeZone2NoTime;
                StateWatchface newState = DeepCopy(state);
                newState.NoTimeZone = true;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Time.TimeZone2NoTime, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    TZ2NoTime.Text = res.GetString("EditNoTime");
                    watch.Time.TimeZone1NoTime = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    TZ2NoTime.Text = res.GetString("AddNoTime");
                    watch.Time.TimeZone1NoTime = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }

            Render(state);
        }

        private void TimeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                if (watch.Time?.Hours?.Ones == null || watch.Time?.Hours?.Tens == null || watch.Time?.Minutes?.Tens == null || watch.Time?.Minutes?.Ones == null)
                {
                    if (MessageBox.Show(res.GetString("TimeFormError"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else return;
                }

                if (timeZone1Check.Checked == false || watch.Time.TimeZone1 == null)
                {
                    watch.Time.TimeZone1 = null;
                    watch.Time.TimeZone1DelimiterImage = -10000;
                    watch.Time.TimeZone1NoTime = null;
                }
                if (timeZone2Check.Checked == false || watch.Time.TimeZone2 == null)
                {
                    watch.Time.TimeZone2 = null;
                    watch.Time.TimeZone2DelimiterImage = -10000;
                    watch.Time.TimeZone2NoTime = null;
                }
                if (watch.Time.Hours == null && watch.Time.Minutes == null)
                    watch.Time = null;

                Save = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (watch.Time?.Hours?.Ones == null || watch.Time?.Hours?.Tens == null || watch.Time?.Minutes?.Tens == null || watch.Time?.Minutes?.Ones == null)
            {
                if (MessageBox.Show(res.GetString("TimeFormError"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
                else return;
            }

            if (timeZone1Check.Checked == false || watch.Time.TimeZone1 == null)
            {
                watch.Time.TimeZone1 = null;
                watch.Time.TimeZone1DelimiterImage = -10000;
                watch.Time.TimeZone1NoTime = null;
            }
            if (timeZone2Check.Checked == false || watch.Time.TimeZone2 == null)
            {
                watch.Time.TimeZone2 = null;
                watch.Time.TimeZone2DelimiterImage = -10000;
                watch.Time.TimeZone2NoTime = null;
            }
            if (watch.Time.Hours == null && watch.Time.Minutes == null)
                watch.Time = null;


            Save = true;
            this.Close();
        }

        private void Render(StateWatchface state)
        {
            render = new VisualRender(watch, state);
            ImagePic.BackgroundImage = render.GenWatchface();
        }
    }
}
