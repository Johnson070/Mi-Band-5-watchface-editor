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
    public partial class DateForm : Form
    {
        public WatchFaceLibrary watch;

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

        public DateForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            watch.imagesBuff = Images;
            this.state = state;

            this.watch.Date = watch.Date == null ? new Date() : watch.Date;
            Render(state);

            if (watch.Date?.MonthAndDayAndYear?.Separate != null)
            {
                SeparateMonthDayCheckbox.Checked = true;
                if (watch.Date.MonthAndDayAndYear.Separate.Month != null) AddMonthSeparateButton.Text = "Edit month";
                if (watch.Date.MonthAndDayAndYear.Separate.MonthsEN != null) AddMonthImagesSeparateButton.Text = "Edit month images";
                if (watch.Date.MonthAndDayAndYear.Separate.Day != null) AddDaySeparateButton.Text = "Edit day";
            }
            if (watch.Date?.MonthAndDayAndYear?.OneLine != null)
            {
                OnelineMonthDayCheckbox.Checked = true;
                if (watch.Date.MonthAndDayAndYear.OneLine.Number != null)
                {
                    AddMonthAndDayOnelineButton.Text = "Edit month and day";
                    AddOnelineDelimeterImageButton.Enabled = true;
                    AddOnelineDelimeterImageButton.Text = watch.Date.MonthAndDayAndYear.OneLine.DelimiterImageIndex >= 0 ? "Edit delimeter image" : AddOnelineDelimeterImageButton.Text;
                }
            }
            if (watch.Date?.MonthAndDayAndYear?.OneLineWithYear != null)
            {
                OnelineWithYearCheckbox.Checked = true;
                if (watch.Date.MonthAndDayAndYear.OneLineWithYear.Number != null)
                {
                    addOnelineWithYearMonthDayYearButton.Text = "Edit month and day";
                    addOnelineWithYearDelimeterImageButton.Enabled = true;
                    addOnelineWithYearDelimeterImageButton.Text = watch.Date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex >= 0 ? "Edit delimeter image" : addOnelineWithYearDelimeterImageButton.Text;
                }
            }
            if (watch.Date?.MonthAndDayAndYear?.Separate != null || watch.Date?.MonthAndDayAndYear?.OneLine != null || watch.Date?.MonthAndDayAndYear?.OneLineWithYear != null)
            {
                TwoDigitsMonthCheckbox.Enabled = true;
                TwoDigitsDayCheckbox.Enabled = true;
                TwoDigitsMonthCheckbox.Checked = watch.Date.MonthAndDayAndYear.TwoDigitsMonth;
                TwoDigitsDayCheckbox.Checked = watch.Date.MonthAndDayAndYear.TwoDigitsDay;
            }

            if (watch.Date?.DayAmPm != null)
            {
                if (watch.Date.DayAmPm.ImageIndexAMEN >= 0) AddAMImageButton.Text = "Edit AM image";
                if (watch.Date.DayAmPm.ImageIndexPMEN >= 0) AddPMImageButton.Text = "Edit PM image";
                posXNumAMPM.Value = watch.Date.DayAmPm.X;
                posYNumAMPM.Value = watch.Date.DayAmPm.Y;
                posXNumAMPM.Enabled = true;
                posYNumAMPM.Enabled = true;
                AmPmCheckbox.Checked = true;
            }

            if (watch.Date?.ENWeekDays != null)
            {
                weekdaysCheckbox.Checked = true;
                if (watch.Date.ENWeekDays.ImageIndex >= 0) addWeekDays.Text = "Edit week day images";
            }

            checkStateChanged(null, null);
        }

        private void AddNumberClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            WatchFaceLibrary watchface = DeepCopy(watch);

            if (btn.Name == AddMonthSeparateButton.Name)
            {
                watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
                watchface.Date.MonthAndDayAndYear.Separate = watchface.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                watchface.Date.MonthAndDayAndYear.Separate.Month = watchface.Date.MonthAndDayAndYear.Separate.Month == null ? new Number() { notDraw = true } : watchface.Date.MonthAndDayAndYear.Separate.Month;
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Date.MonthAndDayAndYear.Separate.Month, watch.imagesBuff.DeepCopy(), state, 10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear.Separate = watch.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watch.Date.MonthAndDayAndYear.Separate;
                    watch.Date.MonthAndDayAndYear.Separate.Month = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    AddMonthSeparateButton.Text = "Edit month";
                }
                else if (numForm.saved)
                {
                    if (watch.Date?.MonthAndDayAndYear?.Separate?.Month != null)
                        watch.Date.MonthAndDayAndYear.Separate.Month = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    AddMonthSeparateButton.Text = "Add month";
                }
            }
            else if (btn.Name == AddMonthImagesSeparateButton.Name)
            {
                watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
                watchface.Date.MonthAndDayAndYear.Separate = watchface.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                watchface.Date.MonthAndDayAndYear.Separate.MonthsEN = watchface.Date.MonthAndDayAndYear.Separate.MonthsEN == null ? new ImageSet() : watchface.Date.MonthAndDayAndYear.Separate.MonthsEN;
                ImageSetForm imageSetForm = new ImageSetForm(watchface, watchface.Date.MonthAndDayAndYear.Separate.MonthsEN, watch.imagesBuff.DeepCopy(), state, 12);
                imageSetForm.ShowDialog();

                if (imageSetForm.saved && imageSetForm.imageSet.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear.Separate = watch.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                    watch.Date.MonthAndDayAndYear.Separate.MonthsEN = imageSetForm.imageSet;
                    watch.imagesBuff = imageSetForm.watch.imagesBuff;
                    AddMonthImagesSeparateButton.Text = "Edit month images";
                }
                else if (imageSetForm.saved)
                {
                    if (watch.Date?.MonthAndDayAndYear?.Separate?.MonthsEN != null)
                        watch.Date.MonthAndDayAndYear.Separate.MonthsEN = null;
                    watch.imagesBuff = imageSetForm.watch.imagesBuff;
                    AddMonthImagesSeparateButton.Text = "Add month images";
                }
            }
            else if (btn.Name == AddDaySeparateButton.Name)
            {
                watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
                watchface.Date.MonthAndDayAndYear.Separate = watchface.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                watchface.Date.MonthAndDayAndYear.Separate.Day = watchface.Date.MonthAndDayAndYear.Separate.Day == null ? new Number() { notDraw = true } : watchface.Date.MonthAndDayAndYear.Separate.Day;
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Date.MonthAndDayAndYear.Separate.Day, watch.imagesBuff.DeepCopy(), state, 10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear.Separate = watch.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                    watch.Date.MonthAndDayAndYear.Separate.Day = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    AddDaySeparateButton.Text = "Edit day";
                }
                else if (numForm.saved)
                {
                    if (watch.Date?.MonthAndDayAndYear?.Separate?.Day != null)
                        watch.Date.MonthAndDayAndYear.Separate.Day = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    AddDaySeparateButton.Text = "Add day";
                }
            }
            else if (btn.Name == AddMonthAndDayOnelineButton.Name)
            {
                watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
                watchface.Date.MonthAndDayAndYear.OneLine = watchface.Date.MonthAndDayAndYear.OneLine == null ? new OneLineMonthAndDay() : watchface.Date.MonthAndDayAndYear.OneLine;
                watchface.Date.MonthAndDayAndYear.OneLine.Number = watchface.Date.MonthAndDayAndYear.OneLine.Number == null ? new Number() { notDraw = true } : watchface.Date.MonthAndDayAndYear.OneLine.Number;
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Date.MonthAndDayAndYear.OneLine.Number, watch.imagesBuff.DeepCopy(), state, 10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear.OneLine = watch.Date.MonthAndDayAndYear.OneLine == null ? watchface.Date.MonthAndDayAndYear.OneLine : new OneLineMonthAndDay();
                    watch.Date.MonthAndDayAndYear.OneLine.Number = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    AddMonthAndDayOnelineButton.Text = "Edit month and day";
                    AddOnelineDelimeterImageButton.Enabled = true;
                }
                else if (numForm.saved)
                {
                    if (watch.Date?.MonthAndDayAndYear?.OneLine != null)
                        watch.Date.MonthAndDayAndYear.OneLine = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    AddMonthAndDayOnelineButton.Text = "Add month and day";
                    AddOnelineDelimeterImageButton.Text = "Add delimeter image";
                    AddOnelineDelimeterImageButton.Enabled = false;
                }
            }
            else if (btn.Name == addOnelineWithYearMonthDayYearButton.Name)
            {
                watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
                watchface.Date.MonthAndDayAndYear.OneLineWithYear = watchface.Date.MonthAndDayAndYear.OneLineWithYear == null ? new OneLineWithYear() : watchface.Date.MonthAndDayAndYear.OneLineWithYear;
                watchface.Date.MonthAndDayAndYear.OneLineWithYear.Number = watchface.Date.MonthAndDayAndYear.OneLineWithYear.Number == null ? new Number() { notDraw = true } : watchface.Date.MonthAndDayAndYear.OneLineWithYear.Number;
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Date.MonthAndDayAndYear.OneLineWithYear.Number, watch.imagesBuff.DeepCopy(), state, 10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear.OneLineWithYear = watch.Date.MonthAndDayAndYear.OneLineWithYear == null ? new OneLineWithYear() : watchface.Date.MonthAndDayAndYear.OneLineWithYear;
                    watch.Date.MonthAndDayAndYear.OneLineWithYear.Number = numForm.number;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addOnelineWithYearMonthDayYearButton.Text = "Edit month and day and year";
                    addOnelineWithYearDelimeterImageButton.Enabled = true;
                }
                else if (numForm.saved)
                {
                    if (watch.Date?.MonthAndDayAndYear?.OneLineWithYear != null)
                        watch.Date.MonthAndDayAndYear.OneLineWithYear = null;
                    watch.imagesBuff = numForm.watch.imagesBuff;
                    addOnelineWithYearMonthDayYearButton.Text = "Add month and day and year";
                    addOnelineWithYearDelimeterImageButton.Text = "Add delimeter image";
                    addOnelineWithYearDelimeterImageButton.Enabled = false;
                }
            }

            if (watch.Date?.MonthAndDayAndYear?.Separate != null || watch.Date?.MonthAndDayAndYear?.OneLine != null || watch.Date?.MonthAndDayAndYear?.OneLineWithYear != null)
            {
                TwoDigitsMonthCheckbox.Enabled = true;
                TwoDigitsDayCheckbox.Enabled = true;
            }

            Render(state);
        }

        private void AddImagesClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ImagesForm imgForm;
            List<int> selImg = null;

            if (btn.Name == AddOnelineDelimeterImageButton.Name)
            {
                if (watch.Date.MonthAndDayAndYear?.OneLine?.DelimiterImageIndex >= 0) selImg = new List<int>() { watch.Date.MonthAndDayAndYear.OneLine.DelimiterImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Date.MonthAndDayAndYear.OneLine.DelimiterImageIndex = imgForm.selectedImages[0];
                    AddOnelineDelimeterImageButton.Text = "Edit delimeter image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Date.MonthAndDayAndYear.OneLine.DelimiterImageIndex = -10000;
                    AddOnelineDelimeterImageButton.Text = "Add delimeter image";
                }
            }
            else if (btn.Name == addOnelineWithYearDelimeterImageButton.Name)
            {
                if (watch.Date.MonthAndDayAndYear?.OneLineWithYear?.DelimiterImageIndex >= 0) selImg = new List<int>() { watch.Date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex = imgForm.selectedImages[0];
                    addOnelineWithYearDelimeterImageButton.Text = "Edit delimeter image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex = -10000;
                    addOnelineWithYearDelimeterImageButton.Text = "Add delimeter image";
                }
            }
            else if (btn.Name == AddAMImageButton.Name)
            {
                if (watch.Date?.DayAmPm?.ImageIndexAMEN >= 0) selImg = new List<int>() { watch.Date.DayAmPm.ImageIndexAMEN };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Date.DayAmPm = watch.Date.DayAmPm == null ? new DayAmPm() : watch.Date.DayAmPm;
                    watch.Date.DayAmPm.ImageIndexAMEN = imgForm.selectedImages[0];
                    AddAMImageButton.Text = "Edit AM image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Date.DayAmPm.ImageIndexAMEN = -10000;
                    AddAMImageButton.Text = "Add AM image";
                }
            }
            else if (btn.Name == AddPMImageButton.Name)
            {
                if (watch.Date?.DayAmPm?.ImageIndexPMEN >= 0) selImg = new List<int>() { watch.Date.DayAmPm.ImageIndexPMEN };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Date.DayAmPm = watch.Date.DayAmPm == null ? new DayAmPm() : watch.Date.DayAmPm;
                    watch.Date.DayAmPm.ImageIndexPMEN = imgForm.selectedImages[0];
                    AddPMImageButton.Text = "Edit PM image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Date.DayAmPm.ImageIndexPMEN = -10000;
                    AddPMImageButton.Text = "Add PM image";
                }
            }

            if (AddPMImageButton.Text == "Edit PM image" || AddAMImageButton.Text == "Edit AM image")
            {
                posXNumAMPM.Enabled = true;
                posYNumAMPM.Enabled = true;
            }
            else
            {
                posXNumAMPM.Enabled = false;
                posYNumAMPM.Enabled = false;
            }

            Render(state);
        }

        private void AMPMPosChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;

            if (numeric.Name == posXNumAMPM.Name)
            {
                watch.Date.DayAmPm.X = (int)posXNumAMPM.Value;
            }
            else if (numeric.Name == posYNumAMPM.Name)
            {
                watch.Date.DayAmPm.Y = (int)posYNumAMPM.Value;
            }

            Render(state);
        }

        private void addWeekdayClick(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.Date.ENWeekDays = watchface.Date.ENWeekDays == null ? new ImageSet() : watchface.Date.ENWeekDays;
            ImageSetForm setForm = new ImageSetForm(watchface, watchface.Date.ENWeekDays, watch.imagesBuff.DeepCopy(), state, 7);
            setForm.ShowDialog();

            if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
            {
                watch.imagesBuff = setForm.watch.imagesBuff;
                watch.Date.ENWeekDays = setForm.imageSet;
                addWeekDays.Text = "Edit week days images";
            }
            else if (setForm.saved)
            {
                watch.imagesBuff = setForm.watch.imagesBuff;
                watch.Date.ENWeekDays = null;
                addWeekDays.Text = "Add week days images";
            }

            Render(state);
        }

        private void checkStateChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = SeparateMonthDayCheckbox.Checked;
            groupBox2.Enabled = OnelineMonthDayCheckbox.Checked;
            groupBox3.Enabled = OnelineWithYearCheckbox.Checked;
            groupBox4.Enabled = AmPmCheckbox.Checked;
            groupBox5.Enabled = weekdaysCheckbox.Checked;
        }

        private void TwoDigitsChanged(object sender, EventArgs e)
        {
            if (watch.Date?.MonthAndDayAndYear != null)
            {
                watch.Date.MonthAndDayAndYear.TwoDigitsDay = TwoDigitsDayCheckbox.Checked;
                watch.Date.MonthAndDayAndYear.TwoDigitsMonth = TwoDigitsMonthCheckbox.Checked;

                Render(state);
            }
        }

        private void DateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show("Do you want to get out without saving?", "Don't Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (watch.Date.MonthAndDayAndYear != null)
                {
                    if (SeparateMonthDayCheckbox.Checked == false) watch.Date.MonthAndDayAndYear.Separate = null;
                    if (OnelineMonthDayCheckbox.Checked == false) watch.Date.MonthAndDayAndYear.OneLine = null;
                    if (OnelineWithYearCheckbox.Checked == false) watch.Date.MonthAndDayAndYear.OneLineWithYear = null;
                    if (SeparateMonthDayCheckbox.Checked == false && OnelineMonthDayCheckbox.Checked == false && OnelineWithYearCheckbox.Checked == false)
                        watch.Date.MonthAndDayAndYear = null;
                }
                if (AmPmCheckbox.Checked == false) watch.Date.DayAmPm = null;
                if (weekdaysCheckbox.Checked == false) watch.Date.ENWeekDays = null;
                if (watch.Date.DayAmPm == null && watch.Date.ENWeekDays == null && watch.Date.MonthAndDayAndYear == null)
                    watch.Date = null;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save = true;
            if (watch.Date.MonthAndDayAndYear != null)
            {
                if (SeparateMonthDayCheckbox.Checked == false) watch.Date.MonthAndDayAndYear.Separate = null;
                if (OnelineMonthDayCheckbox.Checked == false) watch.Date.MonthAndDayAndYear.OneLine = null;
                if (OnelineWithYearCheckbox.Checked == false) watch.Date.MonthAndDayAndYear.OneLineWithYear = null;
                if (SeparateMonthDayCheckbox.Checked == false && OnelineMonthDayCheckbox.Checked == false && OnelineWithYearCheckbox.Checked == false)
                    watch.Date.MonthAndDayAndYear = null;
                if (watch.Date?.MonthAndDayAndYear?.Separate?.Day == null && watch.Date?.MonthAndDayAndYear?.Separate?.Month == null && watch.Date?.MonthAndDayAndYear?.Separate?.MonthsEN == null)
                    watch.Date.MonthAndDayAndYear.Separate = null;
            }
            if (watch.Date.DayAmPm != null)
                if (watch.Date.DayAmPm.ImageIndexAMEN == -10000 && watch.Date.DayAmPm.ImageIndexPMEN == -10000)
                    watch.Date.DayAmPm = null;
            if (AmPmCheckbox.Checked == false) watch.Date.DayAmPm = null;
            if (weekdaysCheckbox.Checked == false) watch.Date.ENWeekDays = null;
            if (watch.Date.DayAmPm == null && watch.Date.ENWeekDays == null && watch.Date.MonthAndDayAndYear == null)
                watch.Date = null;
            this.Close();
        }
    }
}
