
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace MiBand5WatchFaces
{

    public class StateWatchface
    {
        static Random rnd = new Random();

        public DateTime Time = DateTime.Now;
        public DateTime alarm = DateTime.Now;
        public int Steps = rnd.Next(0, 11) * 1000;
        public int Goal = 10000;
        public int PulseGoal = 150;
        public int CaloriesGoal = 9000;
        public int Calories = rnd.Next(0, 10) * 1000;
        public int Distance = rnd.Next(0, 101) * 10;
        public int Pulse = rnd.Next(0, 151);
        public int PAIIndex = rnd.Next(0, 101);
        public int CurrentWeather = rnd.Next(0, 26);
        public int CurrentTemperature = rnd.Next(-20, 20);
        public int DayTemperature = rnd.Next(-20, 20);
        public int NightTemperature = rnd.Next(-20, 20);
        public int AirQuality = rnd.Next(0, 11);
        public int AirQualityIndex = rnd.Next(0, 11);
        public int BatteryLevel = rnd.Next(0, 101);
        public bool Bluetooth = rnd.Next(0, 2) == 1 ? true : false;
        public bool Unlocked = rnd.Next(0, 2) == 1 ? true : false;
        public bool DoNotDisturb = rnd.Next(0, 2) == 1 ? true : false;
        public bool AlarmIsSet = rnd.Next(0, 2) == 1 ? true : false;
        public bool AlarmNoTime = rnd.Next(0, 2) == 1 ? true : false;
        public bool MiKm = rnd.Next(0, 2) == 1 ? true : false;
        public string AlarmTime = rnd.Next(0, 2359).ToString("0000");
        public int UVIndex = rnd.Next(0, 11);
        public int Wind = rnd.Next(0, 15);
        public int Humidity = rnd.Next(0, 101);
        public DateTime TimeZone = DateTime.Now;
        public bool NoTimeZone = false;
        public int animation = 0;
        public DayOfWeek DayOfWeek = DateTime.Now.DayOfWeek;

        public bool notGen = false;

        public void updateTime()
        {
            Time = DateTime.Now;
            alarm = DateTime.Now;
            TimeZone = DateTime.Now;
        }

    }

    public class VisualRender
    {
        public WatchFaceLibrary watchface;
        Graphics watchfacePreview;
        StateWatchface watchFaceState;
        Image Preview;
        WatchFaceLibrary.typeWatch type = WatchFaceLibrary.typeWatch.MiBand5;


        public VisualRender(WatchFaceLibrary watchface, StateWatchface state = null)
        {
            type = watchface.TypeWatch;
            Bitmap previewSet = new Bitmap(watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 126 : 152, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 294 : 486, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            previewSet.MakeTransparent();
            Preview = previewSet;
            this.watchface = watchface;
            watchfacePreview = Graphics.FromImage(Preview);
            watchFaceState = state == null ? new StateWatchface() : state;
        }

        public VisualRender(DefaultDictionary<int, Image> Images, WatchFaceLibrary.typeWatch typeWatch, StateWatchface state = null)
        {
            type = typeWatch;
            Bitmap previewSet = new Bitmap(typeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 126 : 152, typeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 294 : 486, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            previewSet.MakeTransparent();
            Preview = previewSet;
            this.watchface = new WatchFaceLibrary();
            watchfacePreview = Graphics.FromImage(Preview);
            watchFaceState = state == null ? new StateWatchface() : state;
            watchface.images = Images;
        }

        public Image GenAnimationStep(bool state)
        {
            if (state)
            {
                if (watchface.Other != null && watchface.Other.Animation != null)
                {
                    Preview = (Image)new Bitmap(watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 126 : 152, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 294 : 486, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    watchfacePreview = Graphics.FromImage(Preview);

                    foreach (Animation animation in watchface.Other.Animation)
                        animation.Step = (animation.Step + 1 >= (animation.AnimationImages.ImagesCount == 0 ? -1 : animation.AnimationImages.ImagesCount)) ? 0 : animation.Step + 1;

                    return GenWatchface();
                }
                else return null;
            }
            else
            {
                if (watchface.Other != null && watchface.Other.Animation != null)
                {
                    foreach (Animation animation in watchface.Other.Animation)
                        animation.Step = 0;
                }

                Preview = (Image)new Bitmap(watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 126 : 152, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 294 : 486, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                watchfacePreview = Graphics.FromImage(Preview);

                return GenWatchface();
            }
        }

        public Image genPreview() => (Image)ResizeImage(GenWatchface(), watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 90 : 110, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 210 : 352);

        public Image GenWatchface()
        {
            if (watchface.Background != null) drawBackground();
            if (watchface.Time != null) drawTime();
            if (watchface.Activity != null) drawActivity();
            if (watchface.Date != null) drawDate();
            if (watchface.Weather != null) drawWeather();
            if (watchface.StepsProgress != null) drawStepsProgress();
            if (watchface.Status != null) drawStatus();
            if (watchface.Battery != null) drawBattery();
            if (watchface.AnalogDialFace != null) drawAnalogDialFace();
            if (watchface.Other != null) drawAnimation();
            if (watchface.HeartProgress != null) drawHeartProgress();
            if (watchface.WeekDaysIcons != null) drawWeekDaysIcons();
            if (watchface.CaloriesProgress != null) drawCaloriesProgress();
            if (watchface.Alarm != null) drawAlarm();
            if (watchface.StatusSimplified != null) drawStatusSimplified();

            if (watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
                setMiBand6Corners();

            watchfacePreview.Dispose();
            Bitmap PreviewFix = new Bitmap(Preview);
            PreviewFix.SetResolution(96f, 96f);
            return (Image)PreviewFix;
        }

        private void setMiBand6Corners()
        {
            GraphicsPath pth = new GraphicsPath();
            pth.AddArc(0, -1, 152, 152, -180, 180);
            pth.AddArc(0, 334, 152, 152, 0, 180);
            pth.CloseAllFigures();
            watchfacePreview.SetClip(pth, CombineMode.Exclude);
            watchfacePreview.Clear(Color.Transparent);
        }

        public Image GetLayout(object element, WatchFaceLibrary.typeWatch TypeWatch)
        {
            if (element == null) return null;

            type = TypeWatch;

            Preview = (Image)new Bitmap(TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 126 : 152, TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 294 : 486);
            watchfacePreview = Graphics.FromImage(Preview);
            watchFaceState = new StateWatchface();

            if (element.GetType() == typeof(ImageBasic))
            {
                Preview = (Image)ResizeImage(GenWatchface(), TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 90 : 110, TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 210 : 352);
                watchfacePreview = Graphics.FromImage(Preview);
                drawPreview((ImageBasic)element);
            }
            if (element.GetType() == typeof(Background)) drawBackground((Background)element);
            if (element.GetType() == typeof(Time)) drawTime((Time)element);
            if (element.GetType() == typeof(Activity)) drawActivity((Activity)element);
            if (element.GetType() == typeof(Date)) drawDate((Date)element);
            if (element.GetType() == typeof(Weather)) drawWeather((Weather)element);
            if (element.GetType() == typeof(StepsProgress)) drawStepsProgress((StepsProgress)element);
            if (element.GetType() == typeof(Status)) drawStatus((Status)element);
            if (element.GetType() == typeof(Battery)) drawBattery((Battery)element);
            if (element.GetType() == typeof(AnalogDialFace)) drawAnalogDialFace((AnalogDialFace)element);
            if (element.GetType() == typeof(Other)) drawAnimation((Other)element);
            if (element.GetType() == typeof(HeartProgress)) drawHeartProgress((HeartProgress)element);
            if (element.GetType() == typeof(WeekDaysIcons)) drawWeekDaysIcons((WeekDaysIcons)element);
            if (element.GetType() == typeof(CaloriesProgress)) drawCaloriesProgress((CaloriesProgress)element);
            if (element.GetType() == typeof(Alarm)) drawAlarm((Alarm)element);
            if (element.GetType() == typeof(StatusSimple)) drawStatusSimplified((StatusSimple)element);

            if (TypeWatch == WatchFaceLibrary.typeWatch.MiBand6 && element.GetType() != typeof(ImageBasic))
                setMiBand6Corners();

            watchfacePreview.Dispose();
            long totalMemory = GC.GetTotalMemory(false);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Bitmap PreviewFix = new Bitmap(Preview);
            PreviewFix.SetResolution(96f, 96f);
            return (Image)PreviewFix;
        }

        private void drawPreview(ImageBasic preview)
        {
            if (preview != null)
                drawImage(watchface.images[preview.ImageIndex], 0, 0);
        }

        private void drawBackground(Background _background = null)
        {
            Background background = _background != null ? _background : watchface.Background;

            if (background.BackgroundColor != null || background.Image != null)
            {
                if (background.BackgroundColor != null)
                    watchfacePreview.FillRectangle(new SolidBrush(convertColorFromString(background.BackgroundColor)), new Rectangle(0, 0, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 126 : 152, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 294 : 486));

                if (background.Image != null)
                    drawImage(watchface.images[background.Image.ImageIndex], background.Image.getPoint());
            }
            else watchfacePreview.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 126 : 152, watchface.TypeWatch == WatchFaceLibrary.typeWatch.MiBand5 ? 294 : 486));
        }

        private void drawTime(Time _time = null)
        {
            Time time = _time != null ? _time : watchface.Time;

            //hours
            if (time.Hours != null)
            {
                if (time.Hours.Tens != null) drawImage(watchface.images[time.Hours.Tens.ImageIndex + (int)watchFaceState.Time.Hour / 10], time.Hours.Tens.getPoint());
                if (time.Hours.Ones != null) drawImage(watchface.images[time.Hours.Ones.ImageIndex + (int)watchFaceState.Time.Hour % 10], time.Hours.Ones.getPoint());
            }

            //minutes
            if (time.Minutes != null)
            {
                if (time.Minutes.Tens != null) drawImage(watchface.images[time.Minutes.Tens.ImageIndex + (int)watchFaceState.Time.Minute / 10], time.Minutes.Tens.getPoint());
                if (time.Minutes.Ones != null) drawImage(watchface.images[time.Minutes.Ones.ImageIndex + (int)watchFaceState.Time.Minute % 10], time.Minutes.Ones.getPoint());
            }

            if (time.Seconds != null)
            {
                if (time.Seconds.Tens != null) drawImage(watchface.images[time.Seconds.Tens.ImageIndex + (int)watchFaceState.Time.Second / 10], time.Seconds.Tens.getPoint());
                if (time.Seconds.Ones != null) drawImage(watchface.images[time.Seconds.Ones.ImageIndex + (int)watchFaceState.Time.Second % 10], time.Seconds.Ones.getPoint());
            }

            //DelimeterImage

            if (time.DelimiterImage != null)
                drawImage(watchface.images[time.DelimiterImage.ImageIndex], time.DelimiterImage.getPoint());


            if (watchFaceState.NoTimeZone)
            {
                if (time.TimeZone1NoTime != null) drawImage(watchface.images[time.TimeZone1NoTime.ImageIndex], time.TimeZone1NoTime.getPoint());
                if (time.TimeZone2NoTime != null) drawImage(watchface.images[time.TimeZone2NoTime.ImageIndex], time.TimeZone2NoTime.getPoint());
            }
            else
            {
                //TimeZone1
                if (time.TimeZone1 != null)
                {
                    List<Image> timezone = new List<Image>();
                    timezone.Add(watchface.images[time.TimeZone1.ImageIndex + (int)watchFaceState.TimeZone.Hour / 10]);
                    timezone.Add(watchface.images[time.TimeZone1.ImageIndex + (int)watchFaceState.TimeZone.Hour % 10]);
                    timezone.Add(watchface.images[time.TimeZone1DelimiterImage]);
                    timezone.Add(watchface.images[time.TimeZone1.ImageIndex + (int)watchFaceState.TimeZone.Minute / 10]);
                    timezone.Add(watchface.images[time.TimeZone1.ImageIndex + (int)watchFaceState.TimeZone.Minute % 10]);

                    drawNumber(time.TimeZone1, timezone);
                }

                //TimeZone2
                if (time.TimeZone2 != null)
                {
                    List<Image> timezone = new List<Image>();
                    timezone.Add(watchface.images[time.TimeZone2.ImageIndex + (int)watchFaceState.TimeZone.Hour / 10]);
                    timezone.Add(watchface.images[time.TimeZone2.ImageIndex + (int)watchFaceState.TimeZone.Hour % 10]);
                    timezone.Add(watchface.images[time.TimeZone2DelimiterImage]);
                    timezone.Add(watchface.images[time.TimeZone2.ImageIndex + (int)watchFaceState.TimeZone.Minute / 10]);
                    timezone.Add(watchface.images[time.TimeZone2.ImageIndex + (int)watchFaceState.TimeZone.Minute % 10]);

                    drawNumber(time.TimeZone2, timezone);
                }
            }
        }

        private void drawActivity(Activity _activity = null)
        {
            Activity activity = _activity != null ? _activity : watchface.Activity;

            if (activity.Steps != null)
            {
                List<Image> images = new List<Image>();
                if (activity.Steps.PrefixImageIndex != -10000) images.Add(watchface.images[activity.Steps.PrefixImageIndex]);

                for (int i = 0; i < watchFaceState.Steps.ToString().Length; i++)
                    images.Add(watchface.images[activity.Steps.Number.ImageIndex + Convert.ToInt16(watchFaceState.Steps.ToString()[i].ToString())]);

                if (activity.Steps.SuffixImageIndex != -10000) images.Add(watchface.images[activity.Steps.SuffixImageIndex]);
                drawNumber(activity.Steps.Number, images);
            }

            if (activity.Calories != null)
            {
                List<Image> images = new List<Image>();
                if (activity.Calories.PrefixImageIndex != -10000) images.Add(watchface.images[activity.Calories.PrefixImageIndex]);

                for (int i = 0; i < watchFaceState.Calories.ToString().Length; i++)
                    images.Add(watchface.images[activity.Calories.Text.ImageIndex + Convert.ToInt16(watchFaceState.Calories.ToString()[i].ToString())]);

                if (activity.Calories.SuffixImageIndex != -10000) images.Add(watchface.images[activity.Calories.SuffixImageIndex]);
                drawNumber(activity.Calories.Text, images);
            }

            if (activity.Pulse != null)
            {
                List<Image> images = new List<Image>();

                if (watchFaceState.Pulse == 0)
                {
                    images.Add(watchface.images[activity.Pulse.NoDataImageIndex]);
                }
                else
                {
                    if (activity.Pulse.PrefixImageIndex != -10000) images.Add(watchface.images[activity.Pulse.PrefixImageIndex]);

                    for (int i = 0; i < watchFaceState.Pulse.ToString().Length; i++)
                        images.Add(watchface.images[activity.Pulse.Number.ImageIndex + Convert.ToInt16(watchFaceState.Pulse.ToString()[i].ToString())]);

                    if (activity.Pulse.SuffixImageIndex != -10000) images.Add(watchface.images[activity.Pulse.SuffixImageIndex]);
                }
                drawNumber(activity.Pulse.Number, images);
            }

            if (activity.Distance != null)
            {
                List<Image> images = new List<Image>();

                for (int i = 0; i < watchFaceState.Distance.ToString("000").Length; i++)
                    images.Add(watchface.images[activity.Distance.Number.ImageIndex + Convert.ToInt16(watchFaceState.Distance.ToString("000")[i].ToString())]);

                images.Insert(watchFaceState.Distance.ToString("000").Length == 3 ? 1 : 2, watchface.images[activity.Distance.DecimalPointImageIndex]);

                if (watchFaceState.MiKm)
                {
                    if (activity.Distance.KmSuffixImageIndex != -10000) images.Add(watchface.images[activity.Distance.KmSuffixImageIndex]);
                }
                else
                {
                    if (activity.Distance.MilesSuffixImageIndex != -10000) images.Add(watchface.images[activity.Distance.MilesSuffixImageIndex]);
                }

                drawNumber(activity.Distance.Number, images);

                if (watchFaceState.MiKm)
                {
                    if (activity.Distance.KmImageIndex != null)
                        drawImage(watchface.images[activity.Distance.KmImageIndex.ImageIndex], activity.Distance.KmImageIndex.getPoint());
                }
                else
                {
                    if (activity.Distance.MilesImageIndex != null)
                        drawImage(watchface.images[activity.Distance.MilesImageIndex.ImageIndex], activity.Distance.MilesImageIndex.getPoint());
                }
            }

            if (activity.PAI != null)
            {
                List<Image> images = new List<Image>();

                for (int i = 0; i < watchFaceState.PAIIndex.ToString().Length; i++)
                    images.Add(watchface.images[activity.PAI.Number.ImageIndex + Convert.ToInt16(watchFaceState.PAIIndex.ToString()[i].ToString())]);

                drawNumber(activity.PAI.Number, images);
            }
        }

        private void drawDate(Date _date = null)
        {
            Date date = _date != null ? _date : watchface.Date;

            if (date.MonthAndDayAndYear != null)
            {
                if (date.MonthAndDayAndYear.OneLine != null && date.MonthAndDayAndYear.OneLine.NumberCN != null)
                {
                    List<Image> images = new List<Image>();
                    Number dateNumber = date.MonthAndDayAndYear.OneLine.NumberCN;

                    if (date.MonthAndDayAndYear.TwoDigitsMonth || watchFaceState.Time.Month > 9)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month / 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month % 10]);
                    }
                    else images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month]);
                    images.Add(watchface.images[date.MonthAndDayAndYear.OneLine == null ? date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex : date.MonthAndDayAndYear.OneLine.DelimiterImageIndex]);
                    if (date.MonthAndDayAndYear.TwoDigitsDay || watchFaceState.Time.Day > 9)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day / 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day % 10]);
                    }
                    else images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day]);
                    drawNumber(dateNumber, images);
                }

                if (date.MonthAndDayAndYear.OneLine != null && (date.MonthAndDayAndYear.OneLine.Number != null || date.MonthAndDayAndYear.OneLine.NumberEN != null))
                {
                    List<Image> images = new List<Image>();
                    Number dateNumber = date.MonthAndDayAndYear.OneLine.Number != null ? date.MonthAndDayAndYear.OneLine.Number : date.MonthAndDayAndYear.OneLine.NumberEN;

                    if (date.MonthAndDayAndYear.TwoDigitsMonth || watchFaceState.Time.Month > 9)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month / 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month % 10]);
                    }
                    else images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month]);
                    images.Add(watchface.images[date.MonthAndDayAndYear.OneLine == null ? date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex : date.MonthAndDayAndYear.OneLine.DelimiterImageIndex]);
                    if (date.MonthAndDayAndYear.TwoDigitsDay || watchFaceState.Time.Day > 9)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day / 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day % 10]);
                    }
                    else images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day]);
                    drawNumber(dateNumber, images);
                }

                if (date.MonthAndDayAndYear.OneLineWithYear != null && date.MonthAndDayAndYear.OneLineWithYear.NumberCN != null)
                {
                    List<Image> images = new List<Image>();
                    Number dateNumber = date.MonthAndDayAndYear.OneLineWithYear.NumberCN;

                    if (date.MonthAndDayAndYear.OneLineWithYear != null)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year / 1000]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year / 100 % 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year / 10 % 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year % 10]);
                        images.Add(watchface.images[date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex]);
                    }

                    if (date.MonthAndDayAndYear.TwoDigitsMonth || watchFaceState.Time.Month > 9)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month / 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month % 10]);
                    }
                    else images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month]);
                    images.Add(watchface.images[date.MonthAndDayAndYear.OneLine.DelimiterImageIndex]);
                    if (date.MonthAndDayAndYear.TwoDigitsDay || watchFaceState.Time.Day > 9)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day / 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day % 10]);
                    }
                    else images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day]);
                    drawNumber(dateNumber, images);
                }

                if (date.MonthAndDayAndYear.OneLineWithYear != null && (date.MonthAndDayAndYear.OneLineWithYear.Number != null || date.MonthAndDayAndYear.OneLineWithYear.NumberEN != null))
                {
                    List<Image> images = new List<Image>();
                    Number dateNumber = date.MonthAndDayAndYear.OneLineWithYear.Number != null ? date.MonthAndDayAndYear.OneLineWithYear.Number : date.MonthAndDayAndYear.OneLineWithYear.NumberEN;

                    if (date.MonthAndDayAndYear.OneLineWithYear != null)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year / 1000]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year / 100 % 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year / 10 % 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year % 10]);
                        images.Add(watchface.images[date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex]);
                    }

                    if (date.MonthAndDayAndYear.TwoDigitsMonth || watchFaceState.Time.Month > 9)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month / 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month % 10]);
                    }
                    else images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month]);
                    images.Add(watchface.images[date.MonthAndDayAndYear.OneLine.DelimiterImageIndex]);
                    if (date.MonthAndDayAndYear.TwoDigitsDay || watchFaceState.Time.Day > 9)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day / 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day % 10]);
                    }
                    else images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day]);
                    drawNumber(dateNumber, images);
                }

                if (date.MonthAndDayAndYear.OneLineWithYear != null && date.MonthAndDayAndYear.OneLineWithYear.NumberCN != null)
                {
                    List<Image> images = new List<Image>();
                    Number dateNumber = date.MonthAndDayAndYear.OneLineWithYear.NumberCN;

                    if (date.MonthAndDayAndYear.OneLineWithYear != null)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year / 1000]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year / 100 % 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year / 10 % 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Year % 10]);
                        images.Add(watchface.images[date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex]);
                    }

                    if (date.MonthAndDayAndYear.TwoDigitsMonth || watchFaceState.Time.Month > 9)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month / 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month % 10]);
                    }
                    else images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Month]);
                    images.Add(watchface.images[date.MonthAndDayAndYear.OneLine.DelimiterImageIndex]);
                    if (date.MonthAndDayAndYear.TwoDigitsDay || watchFaceState.Time.Day > 9)
                    {
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day / 10]);
                        images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day % 10]);
                    }
                    else images.Add(watchface.images[dateNumber.ImageIndex + watchFaceState.Time.Day]);
                    drawNumber(dateNumber, images);
                }

                if (date.MonthAndDayAndYear.Separate != null)
                {
                    if (date.MonthAndDayAndYear.Separate.MonthsEN != null)
                        drawImage(watchface.images[date.MonthAndDayAndYear.Separate.MonthsEN.ImageIndex + watchFaceState.Time.Month - 1], date.MonthAndDayAndYear.Separate.MonthsEN.getPoint());

                    if (date.MonthAndDayAndYear.Separate.Day != null)
                    {
                        List<Image> images = new List<Image>();

                        if (watchFaceState.Time.Day > 9 || date.MonthAndDayAndYear.TwoDigitsDay)
                        {
                            images.Add(watchface.images[date.MonthAndDayAndYear.Separate.Day.ImageIndex + watchFaceState.Time.Day / 10]);
                            images.Add(watchface.images[date.MonthAndDayAndYear.Separate.Day.ImageIndex + watchFaceState.Time.Day % 10]);
                        }
                        else
                        {
                            images.Add(watchface.images[date.MonthAndDayAndYear.Separate.Day.ImageIndex + watchFaceState.Time.Day]);
                        }

                        drawNumber(date.MonthAndDayAndYear.Separate.Day, images);
                    }

                    if (date.MonthAndDayAndYear.Separate.Month != null)
                    {
                        List<Image> images = new List<Image>();
                        if ((watchFaceState.Time.Month > 9 || date.MonthAndDayAndYear.TwoDigitsMonth) && date.MonthAndDayAndYear.Separate.Month.ImagesCount > 1)
                        {
                            images.Add(watchface.images[date.MonthAndDayAndYear.Separate.Month.ImageIndex + watchFaceState.Time.Month / 10]);
                            images.Add(watchface.images[date.MonthAndDayAndYear.Separate.Month.ImageIndex + watchFaceState.Time.Month % 10]);
                        }
                        else
                        {
                            images.Add(watchface.images[date.MonthAndDayAndYear.Separate.Month.ImageIndex + watchFaceState.Time.Month]);
                        }

                        drawNumber(date.MonthAndDayAndYear.Separate.Month, images);
                    }
                }
            }

            if (date.DayAmPm != null)
            {
                if (date.DayAmPm.ImageIndexAMEN != -10000 && watchFaceState.Time.Hour < 12)
                    drawImage(watchface.images[date.DayAmPm.ImageIndexAMEN], date.DayAmPm.X, date.DayAmPm.Y);

                if (date.DayAmPm.ImageIndexPMEN != -10000 && !(watchFaceState.Time.Hour < 12))
                    drawImage(watchface.images[date.DayAmPm.ImageIndexPMEN], date.DayAmPm.X, date.DayAmPm.Y);
            }

            if (date.ENWeekDays != null)
            {
                drawImage(watchface.images[date.ENWeekDays.ImageIndex + (int)watchFaceState.Time.DayOfWeek], date.ENWeekDays.getPoint());
            }
        }

        //private static int getTrueDayOfWeek(DateTime time)
        //{
        //    int dayofweek = 0;
        //    if (CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek != DayOfWeek.Sunday)
        //    {
        //        switch (time.DayOfWeek)
        //        {
        //            case DayOfWeek.Sunday:
        //                dayofweek = 6;
        //                break;
        //            case DayOfWeek.Monday:
        //                dayofweek = 0;
        //                break;
        //            case DayOfWeek.Tuesday:
        //                dayofweek = 1;
        //                break;
        //            case DayOfWeek.Wednesday:
        //                dayofweek = 2;
        //                break;
        //            case DayOfWeek.Thursday:
        //                dayofweek = 3;
        //                break;
        //            case DayOfWeek.Friday:
        //                dayofweek = 4;
        //                break;
        //            case DayOfWeek.Saturday:
        //                dayofweek = 5;
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    else dayofweek = (int)time.DayOfWeek;

        //    return dayofweek;
        //}

        private void drawWeather(Weather _weather = null)
        {
            Weather weather = _weather != null ? _weather : watchface.Weather;

            if (weather.Icon != null)
            {
                drawImage(watchface.images[weather.Icon.CustomIcon.ImageIndex + watchFaceState.CurrentWeather], weather.Icon.CustomIcon.getPoint());
            }

            if (weather.Temperature != null)
            {
                if (weather.Temperature.Current != null)
                {
                    List<Image> images = new List<Image>();

                    if (watchFaceState.CurrentTemperature < 0) images.Add(watchface.images[weather.Temperature.Current.MinusImageIndex]);
                    for (int i = 0; i < Math.Abs(watchFaceState.CurrentTemperature).ToString().Length.Constrain(0, weather.Temperature.Current.Number.ImagesCount); i++)
                        images.Add(watchface.images[weather.Temperature.Current.Number.ImageIndex + Convert.ToInt16(Math.Abs(watchFaceState.CurrentTemperature).ToString()[i].ToString())]);
                    if (weather.Temperature.Current.DegreesImageIndex != -10000) images.Add(watchface.images[weather.Temperature.Current.DegreesImageIndex]);

                    drawNumber(weather.Temperature.Current.Number, images);
                }


                if (weather.Temperature.Today != null)
                {
                    if (weather.Temperature.Today.OneLine != null)
                    {
                        List<Image> images = new List<Image>();

                        if (watchFaceState.NightTemperature < 0) images.Add(watchface.images[weather.Temperature.Today.OneLine.MinusSignImageIndex]);
                        for (int i = 0; i < Math.Abs(watchFaceState.NightTemperature).ToString().Length.Constrain(0, weather.Temperature.Today.OneLine.Number.ImagesCount); i++)
                            images.Add(watchface.images[weather.Temperature.Today.OneLine.Number.ImageIndex + Convert.ToInt16(Math.Abs(watchFaceState.NightTemperature).ToString()[i].ToString())]);

                        if (weather.Temperature.Today.OneLine.AppendDegreesForBoth) images.Add(watchface.images[weather.Temperature.Today.OneLine.DegreesImageIndex]);
                        images.Add(watchface.images[weather.Temperature.Today.OneLine.DelimiterImageIndex]);
                        if (watchFaceState.DayTemperature < 0) images.Add(watchface.images[weather.Temperature.Today.OneLine.MinusSignImageIndex]);
                        for (int i = 0; i < Math.Abs(watchFaceState.DayTemperature).ToString().Length.Constrain(0, weather.Temperature.Today.OneLine.Number.ImagesCount); i++)
                            images.Add(watchface.images[weather.Temperature.Today.OneLine.Number.ImageIndex + Convert.ToInt16(Math.Abs(watchFaceState.DayTemperature).ToString()[i].ToString())]);
                        images.Add(watchface.images[weather.Temperature.Today.OneLine.DegreesImageIndex]);

                        drawNumber(weather.Temperature.Today.OneLine.Number, images);
                    }

                    if (weather.Temperature.Today.Separate != null)
                    {
                        if (weather.Temperature.Today.Separate.Day != null)
                        {
                            List<Image> images = new List<Image>();

                            if (watchFaceState.DayTemperature < 0) images.Add(watchface.images[weather.Temperature.Today.Separate.Day.MinusImageIndex]);
                            for (int i = 0; i < Math.Abs(watchFaceState.DayTemperature).ToString().Length.Constrain(0, weather.Temperature.Today.Separate.Day.Number.ImagesCount); i++)
                                images.Add(watchface.images[weather.Temperature.Today.Separate.Day.Number.ImageIndex + Convert.ToInt16(Math.Abs(watchFaceState.DayTemperature).ToString()[i].ToString())]);
                            images.Add(watchface.images[weather.Temperature.Today.Separate.Day.DegreesImageIndex]);

                            drawNumber(weather.Temperature.Today.Separate.Day.Number, images);
                        }

                        if (weather.Temperature.Today.Separate.Night != null)
                        {
                            List<Image> images = new List<Image>();

                            if (watchFaceState.NightTemperature < 0) images.Add(watchface.images[weather.Temperature.Today.Separate.Night.MinusImageIndex]);
                            for (int i = 0; i < Math.Abs(watchFaceState.NightTemperature).ToString().Length.Constrain(0, weather.Temperature.Today.Separate.Night.Number.ImagesCount); i++)
                                images.Add(watchface.images[weather.Temperature.Today.Separate.Night.Number.ImageIndex + Convert.ToInt16(Math.Abs(watchFaceState.NightTemperature).ToString()[i].ToString())]);
                            images.Add(watchface.images[weather.Temperature.Today.Separate.Night.DegreesImageIndex]);

                            drawNumber(weather.Temperature.Today.Separate.Night.Number, images);
                        }
                    }
                }
            }

            if (weather.AirPollution != null)
            {
                if (weather.AirPollution.Index != null)
                {
                    List<Image> images = new List<Image>();
                    Number air = weather.AirPollution.Index;

                    for (int i = 0; i < watchFaceState.AirQuality.ToString().Length; i++)
                        images.Add(watchface.images[air.ImageIndex + Convert.ToInt16(watchFaceState.AirQuality.ToString()[i].ToString())]);

                    drawNumber(air, images);
                }

                if (weather.AirPollution.Icon != null)
                    drawImage(watchface.images[weather.AirPollution.Icon.ImageIndex + map(watchFaceState.AirQualityIndex, 0, 10, 0, weather.AirPollution.Icon.ImagesCount - 1)], weather.AirPollution.Icon.getPoint());
            }

            if (weather.Humidity != null)
            {
                if (weather.Humidity.Text != null)
                {
                    List<Image> images = new List<Image>();

                    for (int i = 0; i < watchFaceState.Humidity.ToString().Length; i++)
                        images.Add(watchface.images[weather.Humidity.Text.ImageIndex + Convert.ToInt16(watchFaceState.Humidity.ToString()[i].ToString())]);

                    if (weather.Humidity.SuffixImageIndex != -10000)
                        images.Add(watchface.images[weather.Humidity.SuffixImageIndex]);

                    drawNumber(weather.Humidity.Text, images);
                }

                if (weather.Humidity.ImageSuffix != null)
                    drawImage(watchface.images[weather.Humidity.ImageSuffix.ImageIndex], weather.Humidity.ImageSuffix.getPoint());
            }

            if (weather.Wind != null)
            {
                if (weather.Wind.Text != null)
                {
                    List<Image> images = new List<Image>();

                    for (int i = 0; i < watchFaceState.Wind.ToString().Length; i++)
                        images.Add(watchface.images[weather.Wind.Text.ImageIndex + Convert.ToInt16(watchFaceState.Wind.ToString()[i].ToString())]);

                    if (weather.Wind.ImageSuffixEN != -10000)
                        images.Add(watchface.images[weather.Wind.ImageSuffixEN]);

                    drawNumber(weather.Wind.Text, images);
                }
            }

            if (weather.UVIndex != null)
            {
                if (weather.UVIndex.UV != null)
                {
                    List<Image> images = new List<Image>();

                    for (int i = 0; i < watchFaceState.UVIndex.ToString().Length; i++)
                        images.Add(watchface.images[weather.UVIndex.UV.Text.ImageIndex + Convert.ToInt16(watchFaceState.UVIndex.ToString()[i].ToString())]);

                    if (weather.UVIndex.UV.SuffixImageIndex != -10000)
                        images.Add(watchface.images[weather.UVIndex.UV.SuffixImageIndex]);

                    drawNumber(weather.UVIndex.UV.Text, images);
                }
            }
        }

        private void drawStepsProgress(StepsProgress _stepsProgress = null)
        {
            StepsProgress progress = _stepsProgress != null ? _stepsProgress : watchface.StepsProgress;

            if (progress.GoalImage != null)
                drawImage(watchface.images[progress.GoalImage.ImageIndex], progress.GoalImage.getPoint());


            if (progress.LineScale != null)
                if (watchFaceState.Steps > 0)
                    drawImage(watchface.images[progress.LineScale.ImageIndex + map(watchFaceState.Steps, 0, watchFaceState.Goal, 0, progress.LineScale.ImagesCount - 1)], progress.LineScale.getPoint());

            if (progress.Linear != null && progress.Linear.Segments.Count > 0)
                for (int i = 0; i < map(watchFaceState.Steps, 0, watchFaceState.Goal, 0, progress.Linear.Segments.Count); i++)
                    drawImage(watchface.images[progress.Linear.StartImageIndex + i], progress.Linear.Segments[i].getPoint());

            if (progress.CircleScale != null)
            {
                Color circleColor = convertColorFromString(progress.CircleScale.Color);
                watchfacePreview.DrawArc(
                    new Pen(circleColor, progress.CircleScale.Width + 1),
                    progress.CircleScale.CenterX - progress.CircleScale.RadiusX,
                    progress.CircleScale.CenterY - progress.CircleScale.RadiusY,
                    progress.CircleScale.RadiusX * 2,
                    progress.CircleScale.RadiusY * 2,
                    progress.CircleScale.StartAngle - 90,
                    map(watchFaceState.Steps, 0, watchFaceState.Goal, 0, progress.CircleScale.EndAngle));
            }
        }

        private void drawStatus(Status _Status = null)
        {
            Status status = _Status != null ? _Status : watchface.Status;

            if (status.DoNotDisturb != null)
                if (watchFaceState.DoNotDisturb && status.DoNotDisturb.ImageIndexOn > 0) drawImage(watchface.images[status.DoNotDisturb.ImageIndexOn], status.DoNotDisturb.Coordinates.getPoint());
                else if (status.DoNotDisturb.ImageIndexOff > 0 && !(watchFaceState.DoNotDisturb)) drawImage(watchface.images[status.DoNotDisturb.ImageIndexOff], status.DoNotDisturb.Coordinates.getPoint());

            if (status.Lock != null)
                if (watchFaceState.Unlocked && status.Lock.ImageIndexOn > 0) drawImage(watchface.images[status.Lock.ImageIndexOn], status.Lock.Coordinates.getPoint());
                else if (status.Lock.ImageIndexOff > 0 && !(watchFaceState.Unlocked)) drawImage(watchface.images[status.Lock.ImageIndexOff], status.Lock.Coordinates.getPoint());

            if (status.Bluetooth != null)
                if (watchFaceState.Bluetooth && status.Bluetooth.ImageIndexOn > 0) drawImage(watchface.images[status.Bluetooth.ImageIndexOn], status.Bluetooth.Coordinates.getPoint());
                else if (status.Bluetooth.ImageIndexOff > 0 && !(watchFaceState.Bluetooth)) drawImage(watchface.images[status.Bluetooth.ImageIndexOff], status.Bluetooth.Coordinates.getPoint());
        }

        private void drawBattery(Battery _battery = null)
        {
            Battery battery = _battery != null ? _battery : watchface.Battery;

            if (battery.BatteryText != null)
            {
                List<Image> images = new List<Image>();

                if (battery.BatteryText.PrefixImageIndex != -10000) images.Add(watchface.images[battery.BatteryText.PrefixImageIndex]);
                for (int i = 0; i < watchFaceState.BatteryLevel.ToString().Length; i++)
                    images.Add(watchface.images[battery.BatteryText.Coordinates.ImageIndex + Convert.ToInt16(watchFaceState.BatteryLevel.ToString()[i].ToString())]);
                if (battery.BatteryText.SuffixImageIndex != -10000) images.Add(watchface.images[battery.BatteryText.SuffixImageIndex]);

                drawNumber(battery.BatteryText.Coordinates, images);
            }

            if (battery.BatteryIcon != null)
                drawImage(watchface.images[battery.BatteryIcon.ImageIndex + map(watchFaceState.BatteryLevel, 0, 100, 0, battery.BatteryIcon.ImagesCount - 1)], battery.BatteryIcon.getPoint());

            if (battery.Linear != null && battery.Linear.Segments.Count > 0)
                for (int i = 0; i < map(watchFaceState.BatteryLevel, 0, 100, 0, battery.Linear.Segments.Count); i++)
                    drawImage(watchface.images[battery.Linear.StartImageIndex + i], battery.Linear.Segments[i].getPoint());
        }

        private void drawAnalogDialFace(AnalogDialFace _analog = null)
        {
            AnalogDialFace analogDialFace = _analog != null ? _analog : watchface.AnalogDialFace;

            if (analogDialFace.Hours != null)
            {
                if (analogDialFace.Hours.OnlyBorder)
                    watchfacePreview.DrawPolygon(
                        new Pen(convertColorFromString(analogDialFace.Hours.Color), 1),
                        analogDialFace.Hours.RotateArrowAtCenter(
                            (360f * (watchFaceState.Time.Hour * 60f + watchFaceState.Time.Minute)) / (60f * 12f)));
                else watchfacePreview.FillPolygon(
                        new SolidBrush(convertColorFromString(analogDialFace.Hours.Color)),
                        analogDialFace.Hours.RotateArrowAtCenter(
                            (360f * (watchFaceState.Time.Hour * 60f + watchFaceState.Time.Minute)) / (60f * 12f)));

                if (analogDialFace.Hours.CenterImage != null)
                    drawImage(watchface.images[analogDialFace.Hours.CenterImage.ImageIndex], analogDialFace.Hours.CenterImage.getPoint());
            }

            if (analogDialFace.Minutes != null)
            {
                if (analogDialFace.Minutes.OnlyBorder)
                    watchfacePreview.DrawPolygon(
                        new Pen(convertColorFromString(analogDialFace.Minutes.Color), 1),
                        analogDialFace.Minutes.RotateArrowAtCenter(
                            (360f * watchFaceState.Time.Minute) / 60f));
                else watchfacePreview.FillPolygon(
                        new SolidBrush(convertColorFromString(analogDialFace.Minutes.Color)),
                        analogDialFace.Minutes.RotateArrowAtCenter(
                            (360f * watchFaceState.Time.Minute) / 60f));

                if (analogDialFace.Minutes.CenterImage != null)
                    drawImage(watchface.images[analogDialFace.Minutes.CenterImage.ImageIndex], analogDialFace.Minutes.CenterImage.getPoint());
            }
        }

        private void drawAnimation(Other _other = null)
        {
            Other other = _other != null ? _other : watchface.Other;

            if (other.Animation != null)
            {
                foreach (Animation animation in other.Animation)
                    drawImage(watchface.images[animation.AnimationImages.ImageIndex + (animation.Step != 0 ? animation.Step : watchFaceState.animation)], animation.AnimationImages.getPoint());//(watchFaceState.animation % (animation.AnimationImages.ImagesCount == 0 ? 10000 : animation.AnimationImages.ImagesCount))
            }
        }

        private void drawHeartProgress(HeartProgress _heartprog = null)
        {
            HeartProgress heartProgress = _heartprog != null ? _heartprog : watchface.HeartProgress;

            if (heartProgress.Scale != null && heartProgress.Scale.Segments.Count > 0)
                drawImage(watchface.images[heartProgress.Scale.StartImageIndex + map(watchFaceState.Pulse, 0, watchFaceState.PulseGoal, 0, heartProgress.Scale.Segments.Count - 1)], heartProgress.Scale.Segments[map(watchFaceState.Pulse, 0, 140, 0, heartProgress.Scale.Segments.Count - 1)].getPoint());

            if (heartProgress.LineScale != null)
                drawImage(watchface.images[heartProgress.LineScale.ImageIndex + map(watchFaceState.Pulse, 0, watchFaceState.PulseGoal, 0, heartProgress.LineScale.ImagesCount - 1)], heartProgress.LineScale.getPoint());

            if (heartProgress.Linear != null)
                for (int i = 0; i < map(watchFaceState.Pulse, 0, watchFaceState.PulseGoal, 0, heartProgress.Linear.Segments.Count); i++)
                    drawImage(watchface.images[heartProgress.Linear.StartImageIndex + i], heartProgress.Linear.Segments[i].getPoint());

            if (heartProgress.CircleScale != null)
            {
                Color circleColor = convertColorFromString(heartProgress.CircleScale.Color);
                watchfacePreview.DrawArc(
                    new Pen(circleColor, heartProgress.CircleScale.Width + 1),
                    heartProgress.CircleScale.CenterX - heartProgress.CircleScale.RadiusX,
                    heartProgress.CircleScale.CenterY - heartProgress.CircleScale.RadiusY,
                    heartProgress.CircleScale.RadiusX * 2,
                    heartProgress.CircleScale.RadiusY * 2,
                    heartProgress.CircleScale.StartAngle - 90,
                    map(watchFaceState.Pulse, 0, watchFaceState.PulseGoal, 0, heartProgress.CircleScale.EndAngle));
            }
        }

        private void drawWeekDaysIcons(WeekDaysIcons _weekicons = null)
        {
            WeekDaysIcons icons = _weekicons != null ? _weekicons : watchface.WeekDaysIcons;

            if (icons.Monday != null && watchFaceState.DayOfWeek == DayOfWeek.Monday) drawImage(watchface.images[icons.Monday.ImageIndex], icons.Monday.getPoint());
            if (icons.Tuesday != null && watchFaceState.DayOfWeek == DayOfWeek.Tuesday) drawImage(watchface.images[icons.Tuesday.ImageIndex], icons.Tuesday.getPoint());
            if (icons.Wednesday != null && watchFaceState.DayOfWeek == DayOfWeek.Wednesday) drawImage(watchface.images[icons.Wednesday.ImageIndex], icons.Wednesday.getPoint());
            if (icons.Thursday != null && watchFaceState.DayOfWeek == DayOfWeek.Thursday) drawImage(watchface.images[icons.Thursday.ImageIndex], icons.Thursday.getPoint());
            if (icons.Friday != null && watchFaceState.DayOfWeek == DayOfWeek.Friday) drawImage(watchface.images[icons.Friday.ImageIndex], icons.Friday.getPoint());
            if (icons.Saturday != null && watchFaceState.DayOfWeek == DayOfWeek.Saturday) drawImage(watchface.images[icons.Saturday.ImageIndex], icons.Saturday.getPoint());
            if (icons.Sunday != null && watchFaceState.DayOfWeek == DayOfWeek.Sunday) drawImage(watchface.images[icons.Sunday.ImageIndex], icons.Sunday.getPoint());
        }

        private void drawCaloriesProgress(CaloriesProgress _calprog = null)
        {
            CaloriesProgress calories = _calprog == null ? watchface.CaloriesProgress : _calprog;

            if (calories.GoalImage != null)
                drawImage(watchface.images[calories.GoalImage.ImageIndex], calories.GoalImage.getPoint());


            if (calories.LineScale != null)
                if (watchFaceState.Calories > 0)
                    drawImage(watchface.images[calories.LineScale.ImageIndex + map(watchFaceState.Calories, 0, watchFaceState.CaloriesGoal, 0, calories.LineScale.ImagesCount - 1)], calories.LineScale.getPoint());

            if (calories.Linear != null)
                for (int i = 0; i < map(watchFaceState.Calories, 0, watchFaceState.CaloriesGoal, 0, calories.Linear.Segments.Count); i++)
                    drawImage(watchface.images[calories.Linear.StartImageIndex + i], calories.Linear.Segments[i].getPoint());

            if (calories.CircleScale != null)
            {
                Color circleColor = convertColorFromString(calories.CircleScale.Color);
                watchfacePreview.DrawArc(
                    new Pen(circleColor, calories.CircleScale.Width + 1),
                    calories.CircleScale.CenterX - calories.CircleScale.RadiusX,
                    calories.CircleScale.CenterY - calories.CircleScale.RadiusY,
                    calories.CircleScale.RadiusX * 2,
                    calories.CircleScale.RadiusY * 2,
                    calories.CircleScale.StartAngle - 90,
                    map(watchFaceState.Calories, 0, 9000, 0, calories.CircleScale.EndAngle));
            }
        }

        private void drawAlarm(Alarm _alarm = null)
        {
            Alarm alarm = _alarm != null ? _alarm : watchface.Alarm;

            if (alarm.ImageNoAlarm != null && watchFaceState.AlarmNoTime == true)
            {
                drawImage(watchface.images[alarm.ImageNoAlarm.ImageIndex], alarm.ImageNoAlarm.getPoint());
            }
            else
            {

                if (alarm.ImageOff != null)
                    if (watchFaceState.AlarmIsSet == false)
                        drawImage(watchface.images[alarm.ImageOff.ImageIndex], alarm.ImageOff.getPoint());


                //if (alarm.ImageNoAlarm != null && watchFaceState.AlarmIsSet == false)
                //    drawImage(watchface.imagesBuff[alarm.ImageNoAlarm.ImageIndex], alarm.ImageNoAlarm.getPoint());

                if (watchFaceState.AlarmIsSet)
                {
                    if (alarm.ImageOn != null)
                        if (watchFaceState.AlarmIsSet)
                            drawImage(watchface.images[alarm.ImageOn.ImageIndex], alarm.ImageOn.getPoint());

                    if (alarm.Text != null)
                    {
                        List<Image> images = new List<Image>();

                        images.Add(watchface.images[alarm.Text.ImageIndex + watchFaceState.alarm.Hour / 10]);
                        images.Add(watchface.images[alarm.Text.ImageIndex + watchFaceState.alarm.Hour % 10]);
                        images.Add(watchface.images[alarm.DelimiterImageIndex]);
                        images.Add(watchface.images[alarm.Text.ImageIndex + watchFaceState.alarm.Minute / 10]);
                        images.Add(watchface.images[alarm.Text.ImageIndex + watchFaceState.alarm.Minute % 10]);

                        drawNumber(alarm.Text, images);
                    }
                }
            }
        }

        private void drawStatusSimplified(StatusSimple _statussim = null)
        {
            StatusSimple simple = _statussim != null ? _statussim : watchface.StatusSimplified;

            if (simple.DoNotDisturb != null)
                if (watchFaceState.DoNotDisturb)
                    if (simple.DoNotDisturb.ImageIndexOn != -10000)
                        drawImage(watchface.images[simple.DoNotDisturb.ImageIndexOn], simple.DoNotDisturb.StatusImage.getPoint());
                    else if (simple.DoNotDisturb.ImageIndexOff != -10000)
                        drawImage(watchface.images[simple.DoNotDisturb.ImageIndexOff], simple.DoNotDisturb.StatusImage.getPoint());

            if (simple.Bluetooth != null)
                if (watchFaceState.Bluetooth)
                    if (simple.Bluetooth.ImageIndexOn != -10000)
                        drawImage(watchface.images[simple.Bluetooth.ImageIndexOn], simple.Bluetooth.StatusImage.getPoint());
                    else if (simple.Bluetooth.ImageIndexOff != -10000)
                        drawImage(watchface.images[simple.Bluetooth.ImageIndexOff], simple.Bluetooth.StatusImage.getPoint());

            if (simple.Lock != null)
                if (watchFaceState.Unlocked == false)
                    if (simple.Lock.ImageIndexOn != -10000)
                        drawImage(watchface.images[simple.Lock.ImageIndexOn], simple.Lock.StatusImage.getPoint());
                    else if (simple.Lock.ImageIndexOff != -10000)
                        drawImage(watchface.images[simple.Lock.ImageIndexOff], simple.Lock.StatusImage.getPoint());
        }

        private void drawNumber(Number number, List<Image> images)
        {
            int rectX = number.TopLeftX, rectY = number.TopLeftY;
            Point size = new Point(Math.Abs(number.BottomRightX - number.TopLeftX), Math.Abs(number.BottomRightY - number.TopLeftY));

            int fullWidth = 0;
            int fullHeight = 0;
            int fullHeightInc = 0;

            foreach (Image image in images)
                fullWidth += image.Width + number.SpacingX;
            fullWidth -= number.SpacingX;

            foreach (Image image in images)
            {
                fullHeight = fullHeight > image.Height ? fullHeight : image.Height;
                fullHeightInc += number.SpacingY;
            };
            fullHeightInc -= number.SpacingY;


            int incX = number.SpacingX;
            int incY = number.SpacingY;

            Point pointDraw = new Point(0, 0);

            int x, y;
            Rectangle box = new Rectangle(rectX, rectY, number.BottomRightX - number.TopLeftX, number.BottomRightY - number.TopLeftY);

            if (number.Alignment.IndexOf("Left") != -1)
                x = box.X;
            else if (number.Alignment.IndexOf("Right") != -1)
                x = box.Right - fullWidth + 1;
            else x = (box.Left + box.Right - fullWidth) >> 1;

            if (number.Alignment.IndexOf("Top") != -1)
                y = box.Top;
            else if (number.Alignment.IndexOf("Bottom") != -1)
                y = box.Bottom - fullHeight + 1;
            else y = (box.Top + box.Bottom - fullHeight) >> 1;


            if (type == WatchFaceLibrary.typeWatch.MiBand6)
            {
                if (x < box.Left && number.Alignment.IndexOf("Left") != -1) x = box.Left; // || x+fullWidth-1 > box.Right

                if (x < box.Left && number.Alignment.IndexOf("Right") != -1) x += (fullWidth - box.Width) -1;

                if (x+fullWidth-1 > box.Right) x = box.Left;

                if (number.Alignment.IndexOf("Top") != -1 && number.Alignment.IndexOf("Center") == -1 && number.Alignment != "Top")
                {
                    if (number.SpacingY < 0 && number.Alignment.IndexOf("Right") != -1) y = box.Top + fullHeightInc;
                    else if (number.SpacingY >= 0 && y - fullHeightInc < box.Top && number.Alignment.IndexOf("Left") == -1) y = box.Top + fullHeightInc;
                    
                    if (y < box.Top && number.SpacingY >= 0) y = box.Top;

                }
                else if (number.Alignment.IndexOf("Bottom") != -1)
                {
                    if (number.Alignment.IndexOf("Right") != -1 && y + fullHeightInc >= box.Height) y = box.Bottom - fullHeight + fullHeightInc;
                    else if (number.Alignment.IndexOf("Right") != -1) y += fullHeightInc;
                    if (y < box.Top && (number.Alignment.IndexOf("Center") != -1 || number.Alignment == "Bottom")) y = box.Top;
                    
                    if (fullHeight > box.Height) y = box.Top;
                    if (fullHeight > box.Height && number.Alignment.IndexOf("Right") != -1) y = box.Top + fullHeightInc;
                }
                else
                {
                    if (number.Alignment.IndexOf("Right") != -1 && y - fullHeightInc + fullHeight >= box.Bottom && number.SpacingY < 0) y += fullHeightInc;
                    if (number.Alignment.IndexOf("Right") != -1 && fullHeight > box.Height && number.SpacingY > 0) y = box.Top + fullHeightInc;
                    else if (number.Alignment.IndexOf("Right") != -1 && y + fullHeightInc >= box.Top && number.SpacingY > 0) y = ((box.Top + box.Bottom - fullHeight) >> 1) + fullHeightInc;
                    else if (fullHeight > box.Height) y = box.Top;
                }

                //if (number.Alignment == "Top")
                //{
                //    if (number.SpacingY > 0)
                //        number.SpacingY = -number.SpacingY;
                //}


                foreach (Image image in images)
                {
                    watchfacePreview.DrawImage((Bitmap)image, x, y);
                    //watchfacePreview.DrawRectangle(new Pen(Color.Green), x, y, 2, 2);

                    if ((number.Alignment.IndexOf("Left") == -1 && number.Alignment != "Top" && number.Alignment != "Center" && number.Alignment != "TopCenter" && number.Alignment != "Bottom" && number.Alignment != "BottomCenter") || 
                        (number.Alignment.IndexOf("Bottom") != -1 && number.Alignment.IndexOf("Left") == -1 && number.Alignment.IndexOf("Center") == -1 && number.Alignment != "Bottom" && number.SpacingY > 0)) y -= incY;
                    else y += incY;

                    x += image.Width + number.SpacingX;
                }
            }
            else
            {
                if (x < box.Left) x = box.Left;
                if (y < box.Top) y = box.Top;

                foreach (Image image in images)
                {
                    watchfacePreview.DrawImage((Bitmap)image, x, y);
                    x += image.Width + incX;
                    y += incY;
                }
            }

            if (number.drawBorder)
                watchfacePreview.DrawPolygon(new Pen(Color.Red), new Point[] { new Point(rectX - 1, rectY - 1), new Point(rectX + size.X + 1, rectY - 1), new Point(rectX + size.X + 1, rectY + size.Y + 1), new Point(rectX - 1, rectY + size.Y + 1) });
        }

        private void drawImage(Image image, Point point)
        {
            watchfacePreview.DrawImage(image, point);
        }

        private void drawImage(Image image, int x, int y)
        {
            watchfacePreview.DrawImage(image, x, y);
        }

        private int map(float value, float fromLow, float fromHigh, float toLow, float toHigh) => (int)((value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow);

        private Color convertColorFromString(string _color) => Color.FromArgb(Convert.ToInt16(_color.Substring(2, 2), 16), Convert.ToInt16(_color.Substring(4, 2), 16), Convert.ToInt16(_color.Substring(6, 2), 16));

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }

    public static class ConstrainExt
    {
        public static int Constrain(this int inNum, int outMin, int outMax) => inNum >= outMin && inNum <= outMax ? inNum : (inNum > outMax ? outMax : outMin);
    }
}
