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
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

        StateWatchface state;
        VisualRender render;
        public bool Save;
        string oldDate;

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
            watch.images = Images;
            this.state = state;

            this.watch.Date = watch.Date == null ? new Date() : watch.Date;

            if (this.watch.Date?.MonthAndDayAndYear?.OneLine?.NumberCN != null)
            {
                this.watch.Date.MonthAndDayAndYear.OneLine.Number = this.watch.Date.MonthAndDayAndYear.OneLine.NumberCN;
                this.watch.Date.MonthAndDayAndYear.OneLine.NumberCN = null;
            }
            if (this.watch.Date?.MonthAndDayAndYear?.OneLine?.NumberEN != null)
            {
                this.watch.Date.MonthAndDayAndYear.OneLine.Number = this.watch.Date.MonthAndDayAndYear.OneLine.NumberEN;
                this.watch.Date.MonthAndDayAndYear.OneLine.NumberEN = null;
            }

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
            }

            oldDate = JsonConvert.SerializeObject(this.watch.Date, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            Render(state);

            if (watch.Date?.MonthAndDayAndYear?.OneLine?.Number != null && watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                watch.Date.MonthAndDayAndYear.OneLine.NumberEN = watch.Date.MonthAndDayAndYear.OneLine.Number;
                watch.Date.MonthAndDayAndYear.OneLine.Number = null;
            }

           
            


            if (watch.Date?.MonthAndDayAndYear?.Separate != null)
            {
                SeparateMonthDayCheckbox.Checked = true;
                if (watch.Date.MonthAndDayAndYear.Separate.Month != null) AddMonthSeparateButton.Text = res.GetString("EditMonth");
                if (watch.Date.MonthAndDayAndYear.Separate.MonthsEN != null) AddMonthENImagesSeparateButton.Text = res.GetString("EditMonthImagesEN");
                if (watch.Date.MonthAndDayAndYear.Separate.MonthsCN != null) AddMonthCNImagesSeparateButton.Text = res.GetString("EditMonthImagesCN");
                if (watch.Date.MonthAndDayAndYear.Separate.Day != null) AddDaySeparateButton.Text = res.GetString("EditDay");
            }
            if (watch.Date?.MonthAndDayAndYear?.OneLine != null)
            {
                OnelineMonthDayCheckbox.Checked = true;
                //if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 && watch.Date.MonthAndDayAndYear.OneLine.Number != null)
                //{
                    //AddMonthAndDayCNOnelineButton.Visible = false;
                    //AddMonthAndDayENOnelineButton.Visible = false;
                    AddMonthAndDayOnelineButton.Text = res.GetString("EditMonthAndDay");
                    AddOnelineDelimeterImageButton.Enabled = true;
                    AddOnelineDelimeterImageButton.Text = watch.Date.MonthAndDayAndYear.OneLine.DelimiterImageIndex >= 0 ? res.GetString("EditDelimeterImage") : AddOnelineDelimeterImageButton.Text;
                //}
                //else if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 && (watch.Date.MonthAndDayAndYear.OneLine.NumberEN != null || watch.Date.MonthAndDayAndYear.OneLine.NumberCN != null)) 
                //{
                //    AddOnelineDelimeterImageButton.Enabled = true;
                //    AddMonthAndDayOnelineButton.Visible = false;
                //    AddOnelineDelimeterImageButton.Text = watch.Date.MonthAndDayAndYear.OneLine.DelimiterImageIndex >= 0 ? res.GetString("EditDelimeterImage") : AddOnelineDelimeterImageButton.Text;
                //    if (watch.Date.MonthAndDayAndYear.OneLine.NumberEN != null) AddMonthAndDayENOnelineButton.Text = res.GetString("EditMonthAndDayEN");
                //    if (watch.Date.MonthAndDayAndYear.OneLine.NumberCN != null) AddMonthAndDayCNOnelineButton.Text = res.GetString("EditMonthAndDayCN");
                //}
            }
            if (watch.Date?.MonthAndDayAndYear?.OneLineWithYear != null)
            {
                OnelineWithYearCheckbox.Checked = true;
                if (watch.Date.MonthAndDayAndYear.OneLineWithYear.Number != null)
                {
                    addOnelineWithYearMonthDayYearButton.Text = res.GetString("EditMonthAndDayAndYear");
                    addOnelineWithYearDelimeterImageButton.Enabled = true;
                    addOnelineWithYearDelimeterImageButton.Text = watch.Date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex >= 0 ? res.GetString("EditDelimeterImage") : addOnelineWithYearDelimeterImageButton.Text;
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
                if (watch.Date.DayAmPm.ImageIndexAMEN >= 0) AddAMImageButton.Text = res.GetString("EditAMImage");
                if (watch.Date.DayAmPm.ImageIndexPMEN >= 0) AddPMImageButton.Text = res.GetString("EditPMImage");
                if (watch.Date.DayAmPm.ImageIndexAMCN >= 0) AddCNAMImageButton.Text = res.GetString("EditCNAMImage");
                if (watch.Date.DayAmPm.ImageIndexPMCN >= 0) AddCNPMImageButton.Text = res.GetString("EditCNPMImage");
                posXNumAMPM.Value = watch.Date.DayAmPm.X;
                posYNumAMPM.Value = watch.Date.DayAmPm.Y;
                posXNumAMPM.Enabled = true;
                posYNumAMPM.Enabled = true;
                AmPmCheckbox.Checked = true;
            }

            if (watch.Date?.ENWeekDays != null)
            {
                weekdaysCheckbox.Checked = true;
                if (watch.Date.ENWeekDays.ImageIndex >= 0) addWeekDays.Text = res.GetString("EditWeekDaysImages");
            }

            if (watch.Date?.CNWeekDays != null)
            {
                cnWeekDaysCheckbox.Checked = true;
                if (watch.Date.CNWeekDays.ImageIndex >= 0) AddCNWeekDaysButton.Text = res.GetString("EditWeekDaysImages");
            }

            if (watch.Date?.CN2WeekDays != null)
            {
                CN2WeekDaysCheckbox.Checked = true;
                if (watch.Date.CN2WeekDays.ImageIndex >= 0) AddCN2WeekDaysButton.Text = res.GetString("EditWeekDaysImages");
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
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Date.MonthAndDayAndYear.Separate.Month, watch.images.DeepCopy(), state, 10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear = watch.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watch.Date.MonthAndDayAndYear;
                    watch.Date.MonthAndDayAndYear.Separate = watch.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watch.Date.MonthAndDayAndYear.Separate;
                    watch.Date.MonthAndDayAndYear.Separate.Month = numForm.number;
                    watch.images = numForm.watch.images;
                    AddMonthSeparateButton.Text = res.GetString("EditMonth");
                }
                else if (numForm.delete)
                {
                    if (watch.Date?.MonthAndDayAndYear?.Separate?.Month != null)
                        watch.Date.MonthAndDayAndYear.Separate.Month = null;
                    watch.images = numForm.watch.images;
                    AddMonthSeparateButton.Text = res.GetString("AddMonth");
                }
            }
            else if (btn.Name == AddDaySeparateButton.Name)
            {
                watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
                watchface.Date.MonthAndDayAndYear.Separate = watchface.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                watchface.Date.MonthAndDayAndYear.Separate.Day = watchface.Date.MonthAndDayAndYear.Separate.Day == null ? new Number() { notDraw = true } : watchface.Date.MonthAndDayAndYear.Separate.Day;
                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Date.MonthAndDayAndYear.Separate.Day, watch.images.DeepCopy(), state, 10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear = watch.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watch.Date.MonthAndDayAndYear;
                    watch.Date.MonthAndDayAndYear.Separate = watch.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                    watch.Date.MonthAndDayAndYear.Separate.Day = numForm.number;
                    watch.images = numForm.watch.images;
                    AddDaySeparateButton.Text = res.GetString("EditDay");
                }
                else if (numForm.delete)
                {
                    if (watch.Date?.MonthAndDayAndYear?.Separate?.Day != null)
                        watch.Date.MonthAndDayAndYear.Separate.Day = null;
                    watch.images = numForm.watch.images;
                    AddDaySeparateButton.Text = res.GetString("AddDay");
                }
            }
            else if (btn.Name == AddMonthAndDayOnelineButton.Name)
            {
                watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
                watchface.Date.MonthAndDayAndYear.OneLine = watchface.Date.MonthAndDayAndYear.OneLine == null ? new OneLineMonthAndDay() : watchface.Date.MonthAndDayAndYear.OneLine;

                if (watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5)
                {
                    watchface.Date.MonthAndDayAndYear.OneLine.Number = watchface.Date.MonthAndDayAndYear.OneLine.Number == null ? new Number() { notDraw = true } : watchface.Date.MonthAndDayAndYear.OneLine.Number;
                }
                else
                {
                    watchface.Date.MonthAndDayAndYear.OneLine.NumberEN = watchface.Date.MonthAndDayAndYear.OneLine.NumberEN == null ? new Number() { notDraw = true } : (watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 ? watchface.Date.MonthAndDayAndYear.OneLine.NumberEN : watchface.Date.MonthAndDayAndYear.OneLine.Number);
                }

                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 ? watchface.Date.MonthAndDayAndYear.OneLine.NumberEN : watchface.Date.MonthAndDayAndYear.OneLine.Number, watch.images.DeepCopy(), state, 10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear = watch.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watch.Date.MonthAndDayAndYear;
                    watch.Date.MonthAndDayAndYear.OneLine = watch.Date.MonthAndDayAndYear.OneLine == null ? new OneLineMonthAndDay() : watchface.Date.MonthAndDayAndYear.OneLine;

                    if (watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6) watch.Date.MonthAndDayAndYear.OneLine.NumberEN = numForm.number;
                    else watch.Date.MonthAndDayAndYear.OneLine.Number = numForm.number;

                    watch.images = numForm.watch.images;
                    AddMonthAndDayOnelineButton.Text = res.GetString("EditMonthAndDay");
                    AddOnelineDelimeterImageButton.Enabled = true;
                }
                else if (numForm.delete)
                {
                    if (watch.Date?.MonthAndDayAndYear?.OneLine != null)
                        watch.Date.MonthAndDayAndYear.OneLine = null;
                    watch.images = numForm.watch.images;
                    AddMonthAndDayOnelineButton.Text = res.GetString("AddMonthAndDay");
                    AddOnelineDelimeterImageButton.Text = res.GetString("AddDelimeterImage");
                    AddOnelineDelimeterImageButton.Enabled = false;
                }
            }
            //else if (btn.Name == AddMonthAndDayCNOnelineButton.Name)
            //{
            //    watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
            //    watchface.Date.MonthAndDayAndYear.OneLine = watchface.Date.MonthAndDayAndYear.OneLine == null ? new OneLineMonthAndDay() : watchface.Date.MonthAndDayAndYear.OneLine;
            //    watchface.Date.MonthAndDayAndYear.OneLine.NumberCN = watchface.Date.MonthAndDayAndYear.OneLine.NumberCN == null ? new Number() { notDraw = true } : (watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 ? watchface.Date.MonthAndDayAndYear.OneLine.NumberCN : watchface.Date.MonthAndDayAndYear.OneLine.Number);


            //    NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 ? watchface.Date.MonthAndDayAndYear.OneLine.NumberCN : watchface.Date.MonthAndDayAndYear.OneLine.Number, watch.images.DeepCopy(), state, 10);
            //    numForm.ShowDialog();

            //    if (numForm.saved && numForm.number.ImageIndex >= 0)
            //    {
            //        watch.Date.MonthAndDayAndYear = watch.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watch.Date.MonthAndDayAndYear;
            //        watch.Date.MonthAndDayAndYear.OneLine = watch.Date.MonthAndDayAndYear.OneLine == null ? new OneLineMonthAndDay() : watchface.Date.MonthAndDayAndYear.OneLine;

            //        if (watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6) watch.Date.MonthAndDayAndYear.OneLine.NumberCN = numForm.number;
            //        else watch.Date.MonthAndDayAndYear.OneLine.Number = numForm.number;

            //        watch.images = numForm.watch.images;
            //        AddMonthAndDayCNOnelineButton.Text = res.GetString("EditMonthAndDayCN");
            //        AddOnelineDelimeterImageButton.Enabled = true;
            //    }
            //    else if (numForm.delete)
            //    {
            //        if (watch.Date?.MonthAndDayAndYear?.OneLine != null || (watch.Date?.MonthAndDayAndYear?.OneLine != null && watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 && watchface.Date?.MonthAndDayAndYear.OneLine.NumberEN == null))
            //            watch.Date.MonthAndDayAndYear.OneLine = null;
            //        else if (watch.Date?.MonthAndDayAndYear?.OneLine != null && watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6) watch.Date.MonthAndDayAndYear.OneLine.NumberCN = null;
            //        watch.images = numForm.watch.images;
            //        AddMonthAndDayCNOnelineButton.Text = res.GetString("AddMonthAndDayCN");
            //        AddOnelineDelimeterImageButton.Text = res.GetString("AddDelimeterImage");
            //        AddOnelineDelimeterImageButton.Enabled = false;
            //    }
            //}
            //else if (btn.Name == AddMonthAndDayENOnelineButton.Name)
            //{
            //    watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
            //    watchface.Date.MonthAndDayAndYear.OneLine = watchface.Date.MonthAndDayAndYear.OneLine == null ? new OneLineMonthAndDay() : watchface.Date.MonthAndDayAndYear.OneLine;
            //    watchface.Date.MonthAndDayAndYear.OneLine.NumberCN = watchface.Date.MonthAndDayAndYear.OneLine.NumberEN == null ? new Number() { notDraw = true } : (watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 ? watchface.Date.MonthAndDayAndYear.OneLine.NumberEN : watchface.Date.MonthAndDayAndYear.OneLine.Number);


            //    NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 ? watchface.Date.MonthAndDayAndYear.OneLine.NumberEN : watchface.Date.MonthAndDayAndYear.OneLine.Number, watch.images.DeepCopy(), state, 10);
            //    numForm.ShowDialog();

            //    if (numForm.saved && numForm.number.ImageIndex >= 0)
            //    {
            //        watch.Date.MonthAndDayAndYear = watch.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watch.Date.MonthAndDayAndYear;
            //        watch.Date.MonthAndDayAndYear.OneLine = watch.Date.MonthAndDayAndYear.OneLine == null ? new OneLineMonthAndDay() : watchface.Date.MonthAndDayAndYear.OneLine;

            //        if (watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6) watch.Date.MonthAndDayAndYear.OneLine.NumberEN = numForm.number;
            //        else watch.Date.MonthAndDayAndYear.OneLine.Number = numForm.number;

            //        watch.images = numForm.watch.images;
            //        AddMonthAndDayENOnelineButton.Text = res.GetString("EditMonthAndDayEN");
            //        AddOnelineDelimeterImageButton.Enabled = true;
            //    }
            //    else if (numForm.delete)
            //    {
            //        if (watch.Date?.MonthAndDayAndYear?.OneLine != null || (watch.Date?.MonthAndDayAndYear?.OneLine != null && watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 && watchface.Date?.MonthAndDayAndYear.OneLine.NumberCN == null))
            //            watch.Date.MonthAndDayAndYear.OneLine = null;
            //        else if (watch.Date?.MonthAndDayAndYear?.OneLine != null && watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6) watch.Date.MonthAndDayAndYear.OneLine.NumberEN = null;
            //        watch.images = numForm.watch.images;
            //        AddMonthAndDayENOnelineButton.Text = res.GetString("AddMonthAndDayEN");
            //        AddOnelineDelimeterImageButton.Text = res.GetString("AddDelimeterImage");
            //        AddOnelineDelimeterImageButton.Enabled = false;
            //    }
            //}
            else if (btn.Name == addOnelineWithYearMonthDayYearButton.Name)
            {
                watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
                watchface.Date.MonthAndDayAndYear.OneLineWithYear = watchface.Date.MonthAndDayAndYear.OneLineWithYear == null ? new OneLineWithYear() : watchface.Date.MonthAndDayAndYear.OneLineWithYear;
                watchface.Date.MonthAndDayAndYear.OneLineWithYear.Number = watchface.Date.MonthAndDayAndYear.OneLineWithYear.Number == null ? new Number() { notDraw = true } : watchface.Date.MonthAndDayAndYear.OneLineWithYear.Number;

                NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 ? watchface.Date.MonthAndDayAndYear.OneLineWithYear.Number : watchface.Date.MonthAndDayAndYear.OneLineWithYear.Number, watch.images.DeepCopy(), state, 10);
                numForm.ShowDialog();

                if (numForm.saved && numForm.number.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear = watch.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watch.Date.MonthAndDayAndYear;
                    watch.Date.MonthAndDayAndYear.OneLineWithYear = watch.Date.MonthAndDayAndYear.OneLineWithYear == null ? new OneLineWithYear() : watchface.Date.MonthAndDayAndYear.OneLineWithYear;
                    if (watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6) watch.Date.MonthAndDayAndYear.OneLineWithYear.Number = numForm.number;
                    else watch.Date.MonthAndDayAndYear.OneLineWithYear.Number = numForm.number;
                    watch.images = numForm.watch.images;
                    addOnelineWithYearMonthDayYearButton.Text = res.GetString("EditMonthAndDayAndYear");
                    addOnelineWithYearDelimeterImageButton.Enabled = true;
                }
                else if (numForm.delete)
                {
                    if (watch.Date?.MonthAndDayAndYear?.OneLineWithYear != null)
                        watch.Date.MonthAndDayAndYear.OneLineWithYear = null;
                    watch.images = numForm.watch.images;
                    addOnelineWithYearMonthDayYearButton.Text = res.GetString("AddMonthAndDayAndYear");
                    addOnelineWithYearDelimeterImageButton.Text = res.GetString("AddDelimeterImage");
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
            WatchFaceLibrary watchface = DeepCopy(watch);
            ImagesForm imgForm;
            List<int> selImg = null;

            if (btn.Name == AddOnelineDelimeterImageButton.Name)
            {
                if (watch.Date.MonthAndDayAndYear?.OneLine?.DelimiterImageIndex >= 0) selImg = new List<int>() { watch.Date.MonthAndDayAndYear.OneLine.DelimiterImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Date.MonthAndDayAndYear.OneLine.DelimiterImageIndex = imgForm.selectedImages[0];
                    AddOnelineDelimeterImageButton.Text = res.GetString("EditDelimeterImage");
                }
                else if (imgForm.saveImages)
                {
                    watch.images = imgForm.Images;
                    watch.Date.MonthAndDayAndYear.OneLine.DelimiterImageIndex = -10000;
                    AddOnelineDelimeterImageButton.Text = res.GetString("AddDelimeterImage");
                }
            }
            else if (btn.Name == AddCNAMImageButton.Name)
            {
                if (watch.Date?.DayAmPm?.ImageIndexAMCN >= 0) selImg = new List<int>() { watch.Date.DayAmPm.ImageIndexAMCN };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Date.DayAmPm = watch.Date.DayAmPm == null ? new DayAmPm() : watch.Date.DayAmPm;
                    watch.Date.DayAmPm.ImageIndexAMCN = imgForm.selectedImages[0];
                    AddCNAMImageButton.Text = res.GetString("EditCNAMImage");
                }
                else if (imgForm.saveImages && watch.Date.DayAmPm != null)
                {
                    watch.images = imgForm.Images;
                    watch.Date.DayAmPm.ImageIndexAMCN = -10000;
                    AddCNAMImageButton.Text = res.GetString("AddCNAMImage");
                }
            }
            else if (btn.Name == AddCNPMImageButton.Name)
            {
                if (watch.Date?.DayAmPm?.ImageIndexPMCN >= 0) selImg = new List<int>() { watch.Date.DayAmPm.ImageIndexPMCN };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Date.DayAmPm = watch.Date.DayAmPm == null ? new DayAmPm() : watch.Date.DayAmPm;
                    watch.Date.DayAmPm.ImageIndexPMCN = imgForm.selectedImages[0];
                    AddCNPMImageButton.Text = res.GetString("EditCNPMImage");
                }
                else if (imgForm.saveImages && watch.Date.DayAmPm != null)
                {
                    watch.images = imgForm.Images;
                    watch.Date.DayAmPm.ImageIndexPMCN = -10000;
                    AddCNPMImageButton.Text = res.GetString("AddCNPMImage");
                }
            }
            else if (btn.Name == AddMonthENImagesSeparateButton.Name)
            {
                watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
                watchface.Date.MonthAndDayAndYear.Separate = watchface.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                watchface.Date.MonthAndDayAndYear.Separate.MonthsEN = watchface.Date.MonthAndDayAndYear.Separate.MonthsEN == null ? new ImageSet() : watchface.Date.MonthAndDayAndYear.Separate.MonthsEN;
                ImageSetForm imageSetForm = new ImageSetForm(watchface, watchface.Date.MonthAndDayAndYear.Separate.MonthsEN, watch.images.DeepCopy(), state, 12);
                imageSetForm.ShowDialog();

                if (imageSetForm.saved && imageSetForm.imageSet.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear = watch.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watch.Date.MonthAndDayAndYear;
                    watch.Date.MonthAndDayAndYear.Separate = watch.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                    watch.Date.MonthAndDayAndYear.Separate.MonthsEN = imageSetForm.imageSet;
                    watch.images = imageSetForm.watch.images;
                    AddMonthENImagesSeparateButton.Text = res.GetString("EditMonthImagesEN");
                }
                else if (imageSetForm.delete)
                {
                    if (watch.Date?.MonthAndDayAndYear?.Separate?.MonthsEN != null)
                        watch.Date.MonthAndDayAndYear.Separate.MonthsEN = null;
                    watch.images = imageSetForm.watch.images;
                    AddMonthENImagesSeparateButton.Text = res.GetString("AddMonthImagesEN");
                }
            }
            else if (btn.Name == AddMonthCNImagesSeparateButton.Name)
            {
                watchface.Date.MonthAndDayAndYear = watchface.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watchface.Date.MonthAndDayAndYear;
                watchface.Date.MonthAndDayAndYear.Separate = watchface.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                watchface.Date.MonthAndDayAndYear.Separate.MonthsCN = watchface.Date.MonthAndDayAndYear.Separate.MonthsCN == null ? new ImageSet() : watchface.Date.MonthAndDayAndYear.Separate.MonthsCN;
                ImageSetForm imageSetForm = new ImageSetForm(watchface, watchface.Date.MonthAndDayAndYear.Separate.MonthsCN, watch.images.DeepCopy(), state, 12);
                imageSetForm.ShowDialog();

                if (imageSetForm.saved && imageSetForm.imageSet.ImageIndex >= 0)
                {
                    watch.Date.MonthAndDayAndYear = watch.Date.MonthAndDayAndYear == null ? new MonthAndDayAndYear() : watch.Date.MonthAndDayAndYear;
                    watch.Date.MonthAndDayAndYear.Separate = watch.Date.MonthAndDayAndYear.Separate == null ? new SeparateMonthAndDay() : watchface.Date.MonthAndDayAndYear.Separate;
                    watch.Date.MonthAndDayAndYear.Separate.MonthsCN = imageSetForm.imageSet;
                    watch.images = imageSetForm.watch.images;
                    AddMonthCNImagesSeparateButton.Text = res.GetString("EditMonthImagesCN");
                }
                else if (imageSetForm.delete)
                {
                    if (watch.Date?.MonthAndDayAndYear?.Separate?.MonthsEN != null)
                        watch.Date.MonthAndDayAndYear.Separate.MonthsCN = null;
                    watch.images = imageSetForm.watch.images;
                    AddMonthCNImagesSeparateButton.Text = res.GetString("AddMonthImagesCN");
                }
            }
            else if (btn.Name == addOnelineWithYearDelimeterImageButton.Name)
            {
                if (watch.Date.MonthAndDayAndYear?.OneLineWithYear?.DelimiterImageIndex >= 0) selImg = new List<int>() { watch.Date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex = imgForm.selectedImages[0];
                    addOnelineWithYearDelimeterImageButton.Text = res.GetString("EditDelimeterImage");
                }
                else if (imgForm.saveImages)
                {
                    watch.images = imgForm.Images;
                    watch.Date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex = -10000;
                    addOnelineWithYearDelimeterImageButton.Text = res.GetString("AddDelimeterImage");
                }
            }
            else if (btn.Name == AddAMImageButton.Name)
            {
                if (watch.Date?.DayAmPm?.ImageIndexAMEN >= 0) selImg = new List<int>() { watch.Date.DayAmPm.ImageIndexAMEN };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Date.DayAmPm = watch.Date.DayAmPm == null ? new DayAmPm() : watch.Date.DayAmPm;
                    watch.Date.DayAmPm.ImageIndexAMEN = imgForm.selectedImages[0];
                    AddAMImageButton.Text = res.GetString("EditAMImage");
                }
                else if (imgForm.saveImages && watch.Date.DayAmPm != null)
                {
                    watch.images = imgForm.Images;
                    watch.Date.DayAmPm.ImageIndexAMEN = -10000;
                    AddAMImageButton.Text = res.GetString("AddAMImage");
                }
            }
            else if (btn.Name == AddPMImageButton.Name)
            {
                if (watch.Date?.DayAmPm?.ImageIndexPMEN >= 0) selImg = new List<int>() { watch.Date.DayAmPm.ImageIndexPMEN };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Date.DayAmPm = watch.Date.DayAmPm == null ? new DayAmPm() : watch.Date.DayAmPm;
                    watch.Date.DayAmPm.ImageIndexPMEN = imgForm.selectedImages[0];
                    AddPMImageButton.Text = res.GetString("EditPMImage");
                }
                else if (imgForm.saveImages && watch.Date.DayAmPm != null)
                {
                    watch.images = imgForm.Images;
                    watch.Date.DayAmPm.ImageIndexPMEN = -10000;
                    AddPMImageButton.Text = res.GetString("AddPMImage");
                }
            }

            if (AddPMImageButton.Text == res.GetString("EditPMImage") || AddAMImageButton.Text == res.GetString("EditAMImage"))
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
            string name = ((Button)sender).Name;


            if (name == addWeekDays.Name)
            {
                watchface.Date.ENWeekDays = watchface.Date.ENWeekDays == null ? new ImageSet() : watchface.Date.ENWeekDays;
                ImageSetForm setForm = new ImageSetForm(watchface, watchface.Date.ENWeekDays, watch.images.DeepCopy(), state, 7);
                setForm.ShowDialog();

                if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
                {
                    watch.images = setForm.watch.images;
                    watch.Date.ENWeekDays = setForm.imageSet;
                    addWeekDays.Text = res.GetString("EditWeekDaysImages");
                }
                else if (setForm.delete)
                {
                    watch.images = setForm.watch.images;
                    watch.Date.ENWeekDays = null;
                    addWeekDays.Text = res.GetString("AddWeekDaysImages");
                }
            }
            else if (name == AddCNWeekDaysButton.Name)
            {
                watchface.Date.CNWeekDays = watchface.Date.CNWeekDays == null ? new ImageSet() : watchface.Date.CNWeekDays;
                ImageSetForm setForm = new ImageSetForm(watchface, watchface.Date.CNWeekDays, watch.images.DeepCopy(), state, 7);
                setForm.ShowDialog();

                if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
                {
                    watch.images = setForm.watch.images;
                    watch.Date.CNWeekDays = setForm.imageSet;
                    addWeekDays.Text = res.GetString("EditWeekDaysImages");
                }
                else if (setForm.delete)
                {
                    watch.images = setForm.watch.images;
                    watch.Date.CNWeekDays = null;
                    addWeekDays.Text = res.GetString("AddWeekDaysImages");
                }
            }
            else if (name == AddCN2WeekDaysButton.Name)
            {
                watchface.Date.CN2WeekDays = watchface.Date.CN2WeekDays == null ? new ImageSet() : watchface.Date.CN2WeekDays;
                ImageSetForm setForm = new ImageSetForm(watchface, watchface.Date.CN2WeekDays, watch.images.DeepCopy(), state, 7);
                setForm.ShowDialog();

                if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
                {
                    watch.images = setForm.watch.images;
                    watch.Date.CN2WeekDays = setForm.imageSet;
                    addWeekDays.Text = res.GetString("EditWeekDaysImages");
                }
                else if (setForm.delete)
                {
                    watch.images = setForm.watch.images;
                    watch.Date.CN2WeekDays = null;
                    addWeekDays.Text = res.GetString("AddWeekDaysImages");
                }
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
            groupBox6.Enabled = cnWeekDaysCheckbox.Checked;
            groupBox7.Enabled = CN2WeekDaysCheckbox.Checked;
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
            if (Save == false && oldDate != JsonConvert.SerializeObject(this.watch.Date, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }) && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (watch.Date.MonthAndDayAndYear != null)
                {
                    if (SeparateMonthDayCheckbox.Checked == false) watch.Date.MonthAndDayAndYear.Separate = null;
                    if (OnelineMonthDayCheckbox.Checked == false) watch.Date.MonthAndDayAndYear.OneLine = null;
                    if (OnelineWithYearCheckbox.Checked == false) watch.Date.MonthAndDayAndYear.OneLineWithYear = null;

                    if (watch.Date?.MonthAndDayAndYear?.Separate?.Day == null && watch.Date?.MonthAndDayAndYear?.Separate?.Month == null && watch.Date?.MonthAndDayAndYear?.Separate?.MonthsEN == null && watch.Date?.MonthAndDayAndYear?.Separate?.MonthsCN == null)
                        watch.Date.MonthAndDayAndYear.Separate = null;
                    if (watch.Date?.MonthAndDayAndYear?.OneLine?.Number == null && watch.Date?.MonthAndDayAndYear?.OneLine?.NumberEN == null && watch.Date?.MonthAndDayAndYear?.OneLine?.NumberCN == null)
                        watch.Date.MonthAndDayAndYear.OneLine = null;
                    if (watch.Date?.MonthAndDayAndYear?.OneLineWithYear == null && watch.Date?.MonthAndDayAndYear?.OneLine == null && watch.Date?.MonthAndDayAndYear?.Separate == null)
                        watch.Date.MonthAndDayAndYear = null;
                    if (SeparateMonthDayCheckbox.Checked == false && OnelineMonthDayCheckbox.Checked == false && OnelineWithYearCheckbox.Checked == false)
                        watch.Date.MonthAndDayAndYear = null;
                }
                if (watch.Date.DayAmPm != null)
                    if (watch.Date.DayAmPm.ImageIndexAMEN == -10000 && watch.Date.DayAmPm.ImageIndexPMEN == -10000)
                        watch.Date.DayAmPm = null;
                if (AmPmCheckbox.Checked == false) watch.Date.DayAmPm = null;
                if (weekdaysCheckbox.Checked == false) watch.Date.ENWeekDays = null;
                if (cnWeekDaysCheckbox.Checked == false) watch.Date.CNWeekDays = null;
                if (CN2WeekDaysCheckbox.Checked == false) watch.Date.CN2WeekDays = null;
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
                
                if (watch.Date?.MonthAndDayAndYear?.Separate?.Day == null && watch.Date?.MonthAndDayAndYear?.Separate?.Month == null && watch.Date?.MonthAndDayAndYear?.Separate?.MonthsEN == null && watch.Date?.MonthAndDayAndYear?.Separate?.MonthsCN == null)
                    watch.Date.MonthAndDayAndYear.Separate = null;
                if (watch.Date?.MonthAndDayAndYear?.OneLine?.Number == null && watch.Date?.MonthAndDayAndYear?.OneLine?.NumberEN == null && watch.Date?.MonthAndDayAndYear?.OneLine?.NumberCN == null)
                    watch.Date.MonthAndDayAndYear.OneLine = null;
                if (watch.Date?.MonthAndDayAndYear?.OneLineWithYear == null && watch.Date?.MonthAndDayAndYear?.OneLine == null && watch.Date?.MonthAndDayAndYear?.Separate == null)
                    watch.Date.MonthAndDayAndYear = null;
                if (SeparateMonthDayCheckbox.Checked == false && OnelineMonthDayCheckbox.Checked == false && OnelineWithYearCheckbox.Checked == false)
                    watch.Date.MonthAndDayAndYear = null;
            }
            if (watch.Date.DayAmPm != null)
                if (watch.Date.DayAmPm.ImageIndexAMEN == -10000 && watch.Date.DayAmPm.ImageIndexPMEN == -10000)
                    watch.Date.DayAmPm = null;
            if (AmPmCheckbox.Checked == false) watch.Date.DayAmPm = null;
            if (weekdaysCheckbox.Checked == false) watch.Date.ENWeekDays = null;
            if (cnWeekDaysCheckbox.Checked == false) watch.Date.CNWeekDays = null;
            if (CN2WeekDaysCheckbox.Checked == false) watch.Date.CN2WeekDays = null;
            if (watch.Date.DayAmPm == null && watch.Date.ENWeekDays == null && watch.Date.MonthAndDayAndYear == null)
                watch.Date = null;
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
