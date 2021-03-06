using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
        public List<AnimationState> animationStates;
        public DayOfWeek DayOfWeek = DateTime.Now.DayOfWeek;

        public bool notGen = false;

        public void updateTime()
        {
            Time = DateTime.Now;
            alarm = DateTime.Now;
            TimeZone = DateTime.Now;
        }

        public class AnimationState
        {
            public int animationShot = 0;
            public int count;
        }
    }

    public class VisualRender
    {
        public WatchFaceLibrary watchface;
        Graphics watchfacePreview;
        StateWatchface watchFaceState;
        Image Preview = (Image)new Bitmap(126, 294);

        public VisualRender(WatchFaceLibrary watchface, StateWatchface state = null)
        {
            this.watchface = watchface;
            watchfacePreview = Graphics.FromImage(Preview);
            watchFaceState = state == null ? new StateWatchface() : state;
        }

        public VisualRender(DefaultDictionary<int, Image> Images, StateWatchface state = null)
        {
            this.watchface = new WatchFaceLibrary();
            watchfacePreview = Graphics.FromImage(Preview);
            watchFaceState = state == null ? new StateWatchface() : state;
            watchface.imagesBuff = Images;
        }

        public Image genPreview() => (Image)ResizeImage(GenWatchface(), 90, 210);

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
            watchfacePreview.Dispose();
            return Preview;
        }

        public Image GetLayout(object element)
        {
            if (element == null) return null;

            Preview = (Image)new Bitmap(126, 294);
            watchfacePreview = Graphics.FromImage(Preview);
            watchFaceState = new StateWatchface();

            if (element.GetType() == typeof(ImageBasic))
            {
                Preview = (Image)new Bitmap(90, 210);
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
            watchfacePreview.Dispose();
            return Preview;
        }

        private void drawPreview(ImageBasic preview)
        {
            if (preview != null)
                drawImage(watchface.imagesBuff[preview.ImageIndex], 0, 0);
        }

        private void drawBackground(Background _background = null)
        {
            Background background = _background != null ? _background : watchface.Background;

            if (background.BackgroundColor != null || background.Image != null)
            {
                if (background.BackgroundColor != null)
                    watchfacePreview.FillRectangle(new SolidBrush(convertColorFromString(background.BackgroundColor)), new Rectangle(0, 0, 126, 294));

                if (background.Image != null)
                    drawImage(watchface.imagesBuff[background.Image.ImageIndex], background.Image.getPoint());
            }
            else watchfacePreview.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, 126, 294));
        }

        private void drawTime(Time _time = null)
        {
            Time time = _time != null ? _time : watchface.Time;

            //hours
            if (time.Hours != null)
            {
                if (time.Hours.Tens != null) drawImage(watchface.imagesBuff[time.Hours.Tens.ImageIndex + (int)watchFaceState.Time.Hour / 10], time.Hours.Tens.getPoint());
                if (time.Hours.Ones != null) drawImage(watchface.imagesBuff[time.Hours.Ones.ImageIndex + (int)watchFaceState.Time.Hour % 10], time.Hours.Ones.getPoint());
            }

            //minutes
            if (time.Minutes != null)
            {
                if (time.Minutes.Tens != null) drawImage(watchface.imagesBuff[time.Minutes.Tens.ImageIndex + (int)watchFaceState.Time.Minute / 10], time.Minutes.Tens.getPoint());
                if (time.Minutes.Ones != null) drawImage(watchface.imagesBuff[time.Minutes.Ones.ImageIndex + (int)watchFaceState.Time.Minute % 10], time.Minutes.Ones.getPoint());
            }

            //DelimeterImage

            if (time.DelimiterImage != null)
                drawImage(watchface.imagesBuff[time.DelimiterImage.ImageIndex], time.DelimiterImage.getPoint());


            if (watchFaceState.NoTimeZone)
            {
                if (time.TimeZone1NoTime != null) drawImage(watchface.imagesBuff[time.TimeZone1NoTime.ImageIndex], time.TimeZone1NoTime.getPoint());
                if (time.TimeZone2NoTime != null) drawImage(watchface.imagesBuff[time.TimeZone2NoTime.ImageIndex], time.TimeZone2NoTime.getPoint());
            }
            else
            {
                //TimeZone1
                if (time.TimeZone1 != null)
                {
                    List<Image> timezone = new List<Image>();
                    timezone.Add(watchface.imagesBuff[time.TimeZone1.ImageIndex + (int)watchFaceState.TimeZone.Hour / 10]);
                    timezone.Add(watchface.imagesBuff[time.TimeZone1.ImageIndex + (int)watchFaceState.TimeZone.Hour % 10]);
                    timezone.Add(watchface.imagesBuff[time.TimeZone1DelimiterImage]);
                    timezone.Add(watchface.imagesBuff[time.TimeZone1.ImageIndex + (int)watchFaceState.TimeZone.Minute / 10]);
                    timezone.Add(watchface.imagesBuff[time.TimeZone1.ImageIndex + (int)watchFaceState.TimeZone.Minute % 10]);

                    drawNumber(time.TimeZone1, timezone);
                }

                //TimeZone2
                if (time.TimeZone2 != null)
                {
                    List<Image> timezone = new List<Image>();
                    timezone.Add(watchface.imagesBuff[time.TimeZone2.ImageIndex + (int)watchFaceState.TimeZone.Hour / 10]);
                    timezone.Add(watchface.imagesBuff[time.TimeZone2.ImageIndex + (int)watchFaceState.TimeZone.Hour % 10]);
                    timezone.Add(watchface.imagesBuff[time.TimeZone2DelimiterImage]);
                    timezone.Add(watchface.imagesBuff[time.TimeZone2.ImageIndex + (int)watchFaceState.TimeZone.Minute / 10]);
                    timezone.Add(watchface.imagesBuff[time.TimeZone2.ImageIndex + (int)watchFaceState.TimeZone.Minute % 10]);

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
                if (activity.Steps.PrefixImageIndex != -10000) images.Add(watchface.imagesBuff[activity.Steps.PrefixImageIndex]);

                for (int i = 0; i < watchFaceState.Steps.ToString().Length; i++)
                    images.Add(watchface.imagesBuff[activity.Steps.Number.ImageIndex + Convert.ToInt16(watchFaceState.Steps.ToString()[i].ToString())]);

                if (activity.Steps.SuffixImageIndex != -10000) images.Add(watchface.imagesBuff[activity.Steps.SuffixImageIndex]);
                drawNumber(activity.Steps.Number, images);
            }

            if (activity.Calories != null)
            {
                List<Image> images = new List<Image>();
                if (activity.Calories.PrefixImageIndex != -10000) images.Add(watchface.imagesBuff[activity.Calories.PrefixImageIndex]);

                for (int i = 0; i < watchFaceState.Calories.ToString().Length; i++)
                    images.Add(watchface.imagesBuff[activity.Calories.Text.ImageIndex + Convert.ToInt16(watchFaceState.Calories.ToString()[i].ToString())]);

                if (activity.Calories.SuffixImageIndex != -10000) images.Add(watchface.imagesBuff[activity.Calories.SuffixImageIndex]);
                drawNumber(activity.Calories.Text, images);
            }

            if (activity.Pulse != null)
            {
                List<Image> images = new List<Image>();

                if (watchFaceState.Pulse == 0)
                {
                    images.Add(watchface.imagesBuff[activity.Pulse.NoDataImageIndex]);
                }
                else
                {
                    if (activity.Pulse.PrefixImageIndex != -10000) images.Add(watchface.imagesBuff[activity.Pulse.PrefixImageIndex]);

                    for (int i = 0; i < watchFaceState.Pulse.ToString().Length; i++)
                        images.Add(watchface.imagesBuff[activity.Pulse.Number.ImageIndex + Convert.ToInt16(watchFaceState.Pulse.ToString()[i].ToString())]);

                    if (activity.Pulse.SuffixImageIndex != -10000) images.Add(watchface.imagesBuff[activity.Pulse.SuffixImageIndex]);
                }
                drawNumber(activity.Pulse.Number, images);
            }

            if (activity.Distance != null)
            {
                List<Image> images = new List<Image>();

                for (int i = 0; i < watchFaceState.Distance.ToString("000").Length; i++)
                    images.Add(watchface.imagesBuff[activity.Distance.Number.ImageIndex + Convert.ToInt16(watchFaceState.Distance.ToString("000")[i].ToString())]);

                images.Insert(watchFaceState.Distance.ToString("000").Length == 3 ? 1 : 2, watchface.imagesBuff[activity.Distance.DecimalPointImageIndex]);

                if (watchFaceState.MiKm)
                {
                    if (activity.Distance.KmSuffixImageIndex != -10000) images.Add(watchface.imagesBuff[activity.Distance.KmSuffixImageIndex]);
                }
                else
                {
                    if (activity.Distance.MilesSuffixImageIndex != -10000) images.Add(watchface.imagesBuff[activity.Distance.MilesSuffixImageIndex]);
                }

                drawNumber(activity.Distance.Number, images);

                if (watchFaceState.MiKm)
                {
                    if (activity.Distance.KmImageIndex != null)
                        drawImage(watchface.imagesBuff[activity.Distance.KmImageIndex.ImageIndex], activity.Distance.KmImageIndex.getPoint());
                }
                else
                {
                    if (activity.Distance.MilesImageIndex != null)
                        drawImage(watchface.imagesBuff[activity.Distance.MilesImageIndex.ImageIndex], activity.Distance.MilesImageIndex.getPoint());
                }
            }

            if (activity.PAI != null)
            {
                List<Image> images = new List<Image>();

                for (int i = 0; i < watchFaceState.PAIIndex.ToString().Length; i++)
                    images.Add(watchface.imagesBuff[activity.PAI.Number.ImageIndex + Convert.ToInt16(watchFaceState.PAIIndex.ToString()[i].ToString())]);

                drawNumber(activity.PAI.Number, images);
            }
        }

        private void drawDate(Date _date = null)
        {
            Date date = _date != null ? _date : watchface.Date;

            if (date.MonthAndDayAndYear != null)
            {
                if (date.MonthAndDayAndYear.OneLine != null || date.MonthAndDayAndYear.OneLineWithYear != null)
                {
                    List<Image> images = new List<Image>();
                    Number dateNumber = date.MonthAndDayAndYear.OneLine == null ? date.MonthAndDayAndYear.OneLineWithYear.Number : date.MonthAndDayAndYear.OneLine.Number;

                    if (date.MonthAndDayAndYear.OneLineWithYear != null)
                    {
                        images.Add(watchface.imagesBuff[dateNumber.ImageIndex + watchFaceState.Time.Year / 1000]);
                        images.Add(watchface.imagesBuff[dateNumber.ImageIndex + watchFaceState.Time.Year / 100 % 10]);
                        images.Add(watchface.imagesBuff[dateNumber.ImageIndex + watchFaceState.Time.Year / 10 % 10]);
                        images.Add(watchface.imagesBuff[dateNumber.ImageIndex + watchFaceState.Time.Year % 10]);
                        images.Add(watchface.imagesBuff[date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex]);
                    }

                    if (date.MonthAndDayAndYear.TwoDigitsMonth || watchFaceState.Time.Month > 9)
                    {
                        images.Add(watchface.imagesBuff[dateNumber.ImageIndex + watchFaceState.Time.Month / 10]);
                        images.Add(watchface.imagesBuff[dateNumber.ImageIndex + watchFaceState.Time.Month % 10]);
                    }
                    else images.Add(watchface.imagesBuff[dateNumber.ImageIndex + watchFaceState.Time.Month]);
                    images.Add(watchface.imagesBuff[date.MonthAndDayAndYear.OneLine == null ? date.MonthAndDayAndYear.OneLineWithYear.DelimiterImageIndex : date.MonthAndDayAndYear.OneLine.DelimiterImageIndex]);
                    if (date.MonthAndDayAndYear.TwoDigitsDay || watchFaceState.Time.Day > 9)
                    {
                        images.Add(watchface.imagesBuff[dateNumber.ImageIndex + watchFaceState.Time.Day / 10]);
                        images.Add(watchface.imagesBuff[dateNumber.ImageIndex + watchFaceState.Time.Day % 10]);
                    }
                    else images.Add(watchface.imagesBuff[dateNumber.ImageIndex + watchFaceState.Time.Day]);
                    drawNumber(date.MonthAndDayAndYear.OneLine == null ? date.MonthAndDayAndYear.OneLineWithYear.Number : date.MonthAndDayAndYear.OneLine.Number, images);
                }
                
                if (date.MonthAndDayAndYear.Separate != null)
                {
                    if (date.MonthAndDayAndYear.Separate.MonthsEN != null)
                        drawImage(watchface.imagesBuff[date.MonthAndDayAndYear.Separate.MonthsEN.ImageIndex + watchFaceState.Time.Month - 1], date.MonthAndDayAndYear.Separate.MonthsEN.getPoint());

                    if (date.MonthAndDayAndYear.Separate.Day != null)
                    {
                        List<Image> images = new List<Image>();

                        if (watchFaceState.Time.Day > 9 || date.MonthAndDayAndYear.TwoDigitsDay)
                        {
                            images.Add(watchface.imagesBuff[date.MonthAndDayAndYear.Separate.Day.ImageIndex + watchFaceState.Time.Day / 10]);
                            images.Add(watchface.imagesBuff[date.MonthAndDayAndYear.Separate.Day.ImageIndex + watchFaceState.Time.Day % 10]);
                        }
                        else
                        {
                            images.Add(watchface.imagesBuff[date.MonthAndDayAndYear.Separate.Day.ImageIndex + watchFaceState.Time.Day]);
                        }

                        drawNumber(date.MonthAndDayAndYear.Separate.Day, images);
                    }

                    if (date.MonthAndDayAndYear.Separate.Month != null)
                    {
                        List<Image> images = new List<Image>();
                        if ((watchFaceState.Time.Month > 9 || date.MonthAndDayAndYear.TwoDigitsMonth) && date.MonthAndDayAndYear.Separate.Month.ImagesCount > 1)
                        {
                            images.Add(watchface.imagesBuff[date.MonthAndDayAndYear.Separate.Month.ImageIndex + watchFaceState.Time.Month / 10]);
                            images.Add(watchface.imagesBuff[date.MonthAndDayAndYear.Separate.Month.ImageIndex + watchFaceState.Time.Month % 10]);
                        }
                        else
                        {
                            images.Add(watchface.imagesBuff[date.MonthAndDayAndYear.Separate.Month.ImageIndex + watchFaceState.Time.Month]);
                        }

                        drawNumber(date.MonthAndDayAndYear.Separate.Month, images);
                    }
                }
            }

            if (date.DayAmPm != null)
            {
                if (date.DayAmPm.ImageIndexAMEN != -10000 && watchFaceState.Time.Hour < 12)
                    drawImage(watchface.imagesBuff[date.DayAmPm.ImageIndexAMEN], date.DayAmPm.X, date.DayAmPm.Y);

                if (date.DayAmPm.ImageIndexPMEN != -10000 && !(watchFaceState.Time.Hour < 12))
                    drawImage(watchface.imagesBuff[date.DayAmPm.ImageIndexPMEN], date.DayAmPm.X, date.DayAmPm.Y);
            }

            if (date.ENWeekDays != null)
            {
                drawImage(watchface.imagesBuff[date.ENWeekDays.ImageIndex + getTrueDayOfWeek(watchFaceState.Time)], date.ENWeekDays.getPoint());
            }
        }

        private static int getTrueDayOfWeek(DateTime time)
        {
            int dayofweek = 0;
            if (CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek != DayOfWeek.Sunday)
            {
                switch (time.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        dayofweek = 6;
                        break;
                    case DayOfWeek.Monday:
                        dayofweek = 0;
                        break;
                    case DayOfWeek.Tuesday:
                        dayofweek = 1; 
                        break;
                    case DayOfWeek.Wednesday:
                        dayofweek = 2;
                        break;
                    case DayOfWeek.Thursday:
                        dayofweek = 3;
                        break;
                    case DayOfWeek.Friday:
                        dayofweek = 4;
                        break;
                    case DayOfWeek.Saturday:
                        dayofweek = 5;
                        break;
                    default:
                        break;
                }
            }
            else dayofweek = (int)time.DayOfWeek;

            return dayofweek;
        }

        private void drawWeather(Weather _weather = null)
        {
            Weather weather = _weather != null ? _weather : watchface.Weather;

            if (weather.Icon != null)
            {
                drawImage(watchface.imagesBuff[weather.Icon.CustomIcon.ImageIndex + watchFaceState.CurrentWeather], weather.Icon.CustomIcon.getPoint());
            }

            if (weather.Temperature != null)
            {
                if (weather.Temperature.Current != null)
                {
                    List<Image> images = new List<Image>();

                    if (watchFaceState.CurrentTemperature < 0) images.Add(watchface.imagesBuff[weather.Temperature.Current.MinusImageIndex]);
                    for (int i = 0; i < Math.Abs(watchFaceState.CurrentTemperature).ToString().Length; i++)
                        images.Add(watchface.imagesBuff[weather.Temperature.Current.Number.ImageIndex + Convert.ToInt16(Math.Abs(watchFaceState.CurrentTemperature).ToString()[i].ToString())]);
                    if (weather.Temperature.Current.DegreesImageIndex != -10000) images.Add(watchface.imagesBuff[weather.Temperature.Current.DegreesImageIndex]);

                    drawNumber(weather.Temperature.Current.Number, images);
                }


                if (weather.Temperature.Today != null)
                {
                    if (weather.Temperature.Today.OneLine != null)
                    {
                        List<Image> images = new List<Image>();

                        if (watchFaceState.NightTemperature < 0) images.Add(watchface.imagesBuff[weather.Temperature.Today.OneLine.MinusSignImageIndex]);
                        for (int i = 0; i < Math.Abs(watchFaceState.NightTemperature).ToString().Length; i++)
                            images.Add(watchface.imagesBuff[weather.Temperature.Today.OneLine.Number.ImageIndex + Convert.ToInt16(Math.Abs(watchFaceState.NightTemperature).ToString()[i].ToString())]);

                        if (weather.Temperature.Today.OneLine.AppendDegreesForBoth) images.Add(watchface.imagesBuff[weather.Temperature.Today.OneLine.DegreesImageIndex]);
                        images.Add(watchface.imagesBuff[weather.Temperature.Today.OneLine.DelimiterImageIndex]);
                        if (watchFaceState.DayTemperature < 0) images.Add(watchface.imagesBuff[weather.Temperature.Today.OneLine.MinusSignImageIndex]);
                        for (int i = 0; i < Math.Abs(watchFaceState.DayTemperature).ToString().Length; i++)
                            images.Add(watchface.imagesBuff[weather.Temperature.Today.OneLine.Number.ImageIndex + Convert.ToInt16(Math.Abs(watchFaceState.DayTemperature).ToString()[i].ToString())]);
                        images.Add(watchface.imagesBuff[weather.Temperature.Today.OneLine.DegreesImageIndex]);

                        drawNumber(weather.Temperature.Today.OneLine.Number, images);
                    }

                    if (weather.Temperature.Today.Separate != null)
                    {
                        if (weather.Temperature.Today.Separate.Day != null)
                        {
                            List<Image> images = new List<Image>();

                            if (watchFaceState.DayTemperature < 0) images.Add(watchface.imagesBuff[weather.Temperature.Today.Separate.Day.MinusImageIndex]);
                            for (int i = 0; i < Math.Abs(watchFaceState.DayTemperature).ToString().Length; i++)
                                images.Add(watchface.imagesBuff[weather.Temperature.Today.Separate.Night.Number.ImageIndex + Convert.ToInt16(Math.Abs(watchFaceState.DayTemperature).ToString()[i].ToString())]);
                            images.Add(watchface.imagesBuff[weather.Temperature.Today.Separate.Day.DegreesImageIndex]);

                            drawNumber(weather.Temperature.Today.Separate.Day.Number, images);
                        }

                        if (weather.Temperature.Today.Separate.Night != null)
                        {
                            List<Image> images = new List<Image>();

                            if (watchFaceState.NightTemperature < 0) images.Add(watchface.imagesBuff[weather.Temperature.Today.Separate.Night.MinusImageIndex]);
                            for (int i = 0; i < Math.Abs(watchFaceState.NightTemperature).ToString().Length; i++)
                                images.Add(watchface.imagesBuff[weather.Temperature.Today.Separate.Night.Number.ImageIndex + Convert.ToInt16(Math.Abs(watchFaceState.NightTemperature).ToString()[i].ToString())]);
                            images.Add(watchface.imagesBuff[weather.Temperature.Today.Separate.Night.DegreesImageIndex]);

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

                    for (int i = 0; i < watchFaceState.AirQualityIndex.ToString().Length; i++)
                        images.Add(watchface.imagesBuff[air.ImageIndex + Convert.ToInt16(watchFaceState.AirQualityIndex.ToString()[i].ToString())]);

                    drawNumber(air, images);
                }

                if (weather.AirPollution.Icon != null)
                    drawImage(watchface.imagesBuff[weather.AirPollution.Icon.ImageIndex + map(watchFaceState.AirQualityIndex, 0, 10, 0, weather.AirPollution.Icon.ImagesCount - 1)], weather.AirPollution.Icon.getPoint());
            }

            if (weather.Humidity != null)
            {
                if (weather.Humidity.Text != null)
                {
                    List<Image> images = new List<Image>();

                    for (int i = 0; i < watchFaceState.Humidity.ToString().Length; i++)
                        images.Add(watchface.imagesBuff[weather.Humidity.Text.ImageIndex + Convert.ToInt16(watchFaceState.Humidity.ToString()[i].ToString())]);

                    if (weather.Humidity.SuffixImageIndex != -10000)
                        images.Add(watchface.imagesBuff[weather.Humidity.SuffixImageIndex]);

                    drawNumber(weather.Humidity.Text, images);
                }

                if (weather.Humidity.ImageSuffix != null)
                    drawImage(watchface.imagesBuff[weather.Humidity.ImageSuffix.ImageIndex], weather.Humidity.ImageSuffix.getPoint());
            }

            if (weather.Wind != null)
            {
                if (weather.Wind.Text != null)
                {
                    List<Image> images = new List<Image>();

                    for (int i = 0; i < watchFaceState.Wind.ToString().Length; i++)
                        images.Add(watchface.imagesBuff[weather.Wind.Text.ImageIndex + Convert.ToInt16(watchFaceState.Wind.ToString()[i].ToString())]);

                    if (weather.Wind.ImageSuffixEN != -10000)
                        images.Add(watchface.imagesBuff[weather.Wind.ImageSuffixEN]);

                    drawNumber(weather.Wind.Text, images);
                }
            }

            if (weather.UVIndex != null)
            {
                if (weather.UVIndex.UV != null)
                {
                    List<Image> images = new List<Image>();

                    for (int i = 0; i < watchFaceState.UVIndex.ToString().Length; i++)
                        images.Add(watchface.imagesBuff[weather.UVIndex.UV.Text.ImageIndex + Convert.ToInt16(watchFaceState.UVIndex.ToString()[i].ToString())]);

                    if (weather.UVIndex.UV.SuffixImageIndex != -10000)
                        images.Add(watchface.imagesBuff[weather.UVIndex.UV.SuffixImageIndex]);

                    drawNumber(weather.UVIndex.UV.Text, images);
                }
            }
        }

        private void drawStepsProgress(StepsProgress _stepsProgress = null)
        {
            StepsProgress progress = _stepsProgress != null ? _stepsProgress : watchface.StepsProgress;

            if (progress.GoalImage != null)
                drawImage(watchface.imagesBuff[progress.GoalImage.ImageIndex], progress.GoalImage.getPoint());


            if (progress.LineScale != null)
                if (watchFaceState.Steps > 0)
                    drawImage(watchface.imagesBuff[progress.LineScale.ImageIndex + map(watchFaceState.Steps, 0, watchFaceState.Goal, 0, progress.LineScale.ImagesCount - 1)], progress.LineScale.getPoint());

            if (progress.Linear != null)
                for (int i = 0; i < map(watchFaceState.Steps, 0, watchFaceState.Goal, 0, progress.Linear.Segments.Count); i++)
                    drawImage(watchface.imagesBuff[progress.Linear.StartImageIndex + i], progress.Linear.Segments[i].getPoint());

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
                if (watchFaceState.DoNotDisturb && status.DoNotDisturb.ImageIndexOn > 0) drawImage(watchface.imagesBuff[status.DoNotDisturb.ImageIndexOn], status.DoNotDisturb.Coordinates.getPoint());
                else if (status.DoNotDisturb.ImageIndexOff > 0 && !(watchFaceState.DoNotDisturb)) drawImage(watchface.imagesBuff[status.DoNotDisturb.ImageIndexOff], status.DoNotDisturb.Coordinates.getPoint());

            if (status.Lock != null)
                if (watchFaceState.Unlocked && status.Lock.ImageIndexOn > 0) drawImage(watchface.imagesBuff[status.Lock.ImageIndexOn], status.Lock.Coordinates.getPoint());
                else if (status.Lock.ImageIndexOff > 0 && !(watchFaceState.Unlocked)) drawImage(watchface.imagesBuff[status.Lock.ImageIndexOff], status.Lock.Coordinates.getPoint());

            if (status.Bluetooth != null)
                if (watchFaceState.Bluetooth && status.Bluetooth.ImageIndexOn > 0) drawImage(watchface.imagesBuff[status.Bluetooth.ImageIndexOn], status.Bluetooth.Coordinates.getPoint());
                else if (status.Bluetooth.ImageIndexOff > 0 && !(watchFaceState.Bluetooth)) drawImage(watchface.imagesBuff[status.Bluetooth.ImageIndexOff], status.Bluetooth.Coordinates.getPoint());
        }

        private void drawBattery(Battery _battery = null)
        {
            Battery battery = _battery != null ? _battery : watchface.Battery;

            if (battery.BatteryText != null)
            {
                List<Image> images = new List<Image>();

                if (battery.BatteryText.PrefixImageIndex != -10000) images.Add(watchface.imagesBuff[battery.BatteryText.PrefixImageIndex]);
                for (int i = 0; i < watchFaceState.BatteryLevel.ToString().Length; i++)
                    images.Add(watchface.imagesBuff[battery.BatteryText.Coordinates.ImageIndex + Convert.ToInt16(watchFaceState.BatteryLevel.ToString()[i].ToString())]);
                if (battery.BatteryText.SuffixImageIndex != -10000) images.Add(watchface.imagesBuff[battery.BatteryText.SuffixImageIndex]);

                drawNumber(battery.BatteryText.Coordinates, images);
            }

            if (battery.BatteryIcon != null)
                drawImage(watchface.imagesBuff[battery.BatteryIcon.ImageIndex + map(watchFaceState.BatteryLevel, 0, 100, 0, battery.BatteryIcon.ImagesCount - 1)], battery.BatteryIcon.getPoint());

            if (battery.Linear != null)
                for (int i = 0; i < map(watchFaceState.BatteryLevel, 0, 100, 0, battery.Linear.Segments.Count); i++)
                    drawImage(watchface.imagesBuff[battery.Linear.StartImageIndex + i], battery.Linear.Segments[i].getPoint());
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
                    drawImage(watchface.imagesBuff[analogDialFace.Hours.CenterImage.ImageIndex], analogDialFace.Hours.CenterImage.getPoint());
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
                    drawImage(watchface.imagesBuff[analogDialFace.Minutes.CenterImage.ImageIndex], analogDialFace.Minutes.CenterImage.getPoint());
            }
        }

        private void drawAnimation(Other _other = null)
        {
            Other other = _other != null ? _other : watchface.Other;

            if (other.Animation != null)
            {
                foreach (Animation animation in other.Animation)
                    drawImage(watchface.imagesBuff[animation.AnimationImages.ImageIndex + watchFaceState.animation], animation.AnimationImages.getPoint());
            }
        }

        private void drawHeartProgress(HeartProgress _heartprog = null)
        {
            HeartProgress heartProgress = _heartprog != null ? _heartprog : watchface.HeartProgress;

            if (heartProgress.Scale != null)
                drawImage(watchface.imagesBuff[heartProgress.Scale.StartImageIndex + map(watchFaceState.Pulse, 0, watchFaceState.PulseGoal, 0, heartProgress.Scale.Segments.Count - 1)], heartProgress.Scale.Segments[map(watchFaceState.Pulse, 0, 140, 0, heartProgress.Scale.Segments.Count - 1)].getPoint());

            if (heartProgress.LineScale != null)
                drawImage(watchface.imagesBuff[heartProgress.LineScale.ImageIndex + map(watchFaceState.Pulse, 0, watchFaceState.PulseGoal, 0, heartProgress.LineScale.ImagesCount - 1)], heartProgress.LineScale.getPoint());

            if (heartProgress.Linear != null)
                for (int i = 0; i < map(watchFaceState.Pulse, 0, watchFaceState.PulseGoal, 0, heartProgress.Linear.Segments.Count); i++)
                    drawImage(watchface.imagesBuff[heartProgress.Linear.StartImageIndex + i], heartProgress.Linear.Segments[i].getPoint());
        }

        private void drawWeekDaysIcons(WeekDaysIcons _weekicons = null)
        {
            WeekDaysIcons icons = _weekicons != null ? _weekicons : watchface.WeekDaysIcons;

            if (icons.Monday != null && watchFaceState.DayOfWeek == DayOfWeek.Monday) drawImage(watchface.imagesBuff[icons.Monday.ImageIndex], icons.Monday.getPoint());
            if (icons.Tuesday != null && watchFaceState.DayOfWeek == DayOfWeek.Tuesday) drawImage(watchface.imagesBuff[icons.Tuesday.ImageIndex], icons.Tuesday.getPoint());
            if (icons.Wednesday != null && watchFaceState.DayOfWeek == DayOfWeek.Wednesday) drawImage(watchface.imagesBuff[icons.Wednesday.ImageIndex], icons.Wednesday.getPoint());
            if (icons.Thursday != null && watchFaceState.DayOfWeek == DayOfWeek.Thursday) drawImage(watchface.imagesBuff[icons.Thursday.ImageIndex], icons.Thursday.getPoint());
            if (icons.Friday != null && watchFaceState.DayOfWeek == DayOfWeek.Friday) drawImage(watchface.imagesBuff[icons.Friday.ImageIndex], icons.Friday.getPoint());
            if (icons.Saturday != null && watchFaceState.DayOfWeek == DayOfWeek.Saturday) drawImage(watchface.imagesBuff[icons.Saturday.ImageIndex], icons.Saturday.getPoint());
            if (icons.Sunday != null && watchFaceState.DayOfWeek == DayOfWeek.Sunday) drawImage(watchface.imagesBuff[icons.Sunday.ImageIndex], icons.Sunday.getPoint());
        }

        private void drawCaloriesProgress(CaloriesProgress _calprog = null)
        {
            CaloriesProgress calories = _calprog == null ? watchface.CaloriesProgress : _calprog;

            if (calories.GoalImage != null)
                drawImage(watchface.imagesBuff[calories.GoalImage.ImageIndex], calories.GoalImage.getPoint());


            if (calories.LineScale != null)
                if (watchFaceState.Calories > 0)
                    drawImage(watchface.imagesBuff[calories.LineScale.ImageIndex + map(watchFaceState.Calories, 0, watchFaceState.CaloriesGoal, 0, calories.LineScale.ImagesCount - 1)], calories.LineScale.getPoint());

            if (calories.Linear != null)
                for (int i = 0; i < map(watchFaceState.Calories, 0, watchFaceState.CaloriesGoal, 0, calories.Linear.Segments.Count); i++)
                    drawImage(watchface.imagesBuff[calories.Linear.StartImageIndex + i], calories.Linear.Segments[i].getPoint());

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
                drawImage(watchface.imagesBuff[alarm.ImageNoAlarm.ImageIndex], alarm.ImageNoAlarm.getPoint());
            }
            else
            {

                if (alarm.ImageOff != null)
                    if (watchFaceState.AlarmIsSet == false)
                        drawImage(watchface.imagesBuff[alarm.ImageOff.ImageIndex], alarm.ImageOff.getPoint());


                //if (alarm.ImageNoAlarm != null && watchFaceState.AlarmIsSet == false)
                //    drawImage(watchface.imagesBuff[alarm.ImageNoAlarm.ImageIndex], alarm.ImageNoAlarm.getPoint());

                if (watchFaceState.AlarmIsSet)
                {
                    if (alarm.ImageOn != null)
                        if (watchFaceState.AlarmIsSet)
                            drawImage(watchface.imagesBuff[alarm.ImageOn.ImageIndex], alarm.ImageOn.getPoint());

                    if (alarm.Text != null)
                    {
                        List<Image> images = new List<Image>();

                        images.Add(watchface.imagesBuff[alarm.Text.ImageIndex + watchFaceState.alarm.Hour / 10]);
                        images.Add(watchface.imagesBuff[alarm.Text.ImageIndex + watchFaceState.alarm.Hour % 10]);
                        images.Add(watchface.imagesBuff[alarm.DelimiterImageIndex]);
                        images.Add(watchface.imagesBuff[alarm.Text.ImageIndex + watchFaceState.alarm.Minute / 10]);
                        images.Add(watchface.imagesBuff[alarm.Text.ImageIndex + watchFaceState.alarm.Minute % 10]);

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
                        drawImage(watchface.imagesBuff[simple.DoNotDisturb.ImageIndexOn], simple.DoNotDisturb.StatusImage.getPoint());
                    else if (simple.DoNotDisturb.ImageIndexOff != -10000)
                        drawImage(watchface.imagesBuff[simple.DoNotDisturb.ImageIndexOff], simple.DoNotDisturb.StatusImage.getPoint());

            if (simple.Bluetooth != null)
                if (watchFaceState.Bluetooth)
                    if (simple.Bluetooth.ImageIndexOn != -10000)
                        drawImage(watchface.imagesBuff[simple.Bluetooth.ImageIndexOn], simple.Bluetooth.StatusImage.getPoint());
                    else if (simple.Bluetooth.ImageIndexOff != -10000)
                        drawImage(watchface.imagesBuff[simple.Bluetooth.ImageIndexOff], simple.Bluetooth.StatusImage.getPoint());

            if (simple.Lock != null)
                if (watchFaceState.Unlocked == false)
                    if (simple.Lock.ImageIndexOn != -10000)
                        drawImage(watchface.imagesBuff[simple.Lock.ImageIndexOn], simple.Lock.StatusImage.getPoint());
                    else if (simple.Lock.ImageIndexOff != -10000)
                        drawImage(watchface.imagesBuff[simple.Lock.ImageIndexOff], simple.Lock.StatusImage.getPoint());
        }

        private void drawNumber(Number number, List<Image> images)
        {
            int rectX = number.TopLeftX, rectY = number.TopLeftY;
            Point size = new Point(Math.Abs(number.BottomRightX - number.TopLeftX), Math.Abs(number.BottomRightY - number.TopLeftY));

            int fullWidth = 0;
            int fullHeight = 0;

            foreach (Image image in images)
                fullWidth += image.Width + number.SpacingX;
            fullWidth -= number.SpacingX;

            foreach (Image image in images)
                fullHeight = fullHeight > image.Height ? fullHeight : image.Height;


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

            if (x < box.Left) x = box.Left;
            if (y < box.Top) y = box.Top;
            //if (x + fullWidth > 126) x = x + (126 - x - fullWidth);

            foreach (Image image in images)
            {
                watchfacePreview.DrawImage((Bitmap)image, x, y);
                x += image.Width + incX;
                y += incY;
            }

            if (number.drawBorder)
                watchfacePreview.DrawPolygon(new Pen(Color.Red), new Point[] { new Point(rectX-1, rectY-1), new Point(rectX + size.X+1, rectY-1), new Point(rectX + size.X+1, rectY + size.Y+1), new Point(rectX-1, rectY + size.Y+1) });
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
}
