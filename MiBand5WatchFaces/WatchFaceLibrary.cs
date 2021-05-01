using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;

namespace MiBand5WatchFaces
{
    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class WatchFaceLibrary
    {
        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("Background")]
        public Background Background;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("Time")]
        public Time Time;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("Activity")]
        public Activity Activity;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("Date")]
        public Date Date;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("Weather")]
        public Weather Weather;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("StepsProgress")]
        public StepsProgress StepsProgress;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("Status")]
        public Status Status;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("Battery")]
        public Battery Battery;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("AnalogDialFace")]
        public AnalogDialFace AnalogDialFace;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("Other")]
        public Other Other;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("HeartProgress")]
        public HeartProgress HeartProgress;
        //public UnknownTest Unknown13;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("WeekDaysIcons")]
        public WeekDaysIcons WeekDaysIcons;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("CaloriesProgress")]
        public CaloriesProgress CaloriesProgress;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("Alarm")]
        public Alarm Alarm;

        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("StatusSimplified")]
        public StatusSimple StatusSimplified;
        //public LunarDate LunarDateCN;

        //[JsonIgnore]
        [Obfuscation(Exclude = false, Feature = "-rename")]
        [JsonProperty("formEdit")]
        public StepsProgress formEdit;

        [JsonIgnore]
        public readonly Size SizeMiBand5 = new Size(126, 294);
        [JsonIgnore]
        public readonly Size SizeMiBand6 = new Size(152, 486);
        [JsonIgnore]
        public readonly Size SizeMiBand6Rasn = new Size(26, 192);
        [JsonIgnore]
        public readonly Size SizePreviewMiBand6 = new Size(110, 352);

        [JsonProperty("TypeWatch", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(typeWatch.None)]
        public typeWatch TypeWatch = typeWatch.MiBand5;


        public enum typeWatch
        {
            MiBand5,
            MiBand6,
            None
        };

        [JsonIgnore]
        public string FilePath;
        [JsonIgnore]
        public List<Image> AnimationImages = new List<Image>();
        [JsonIgnore]
        public DefaultDictionary<int, Image> images = new DefaultDictionary<int, Image>(() => new Bitmap(1, 1));

        public typeWatch LoadImages()
        {
            for (int pos = 0; pos < 10000; pos++)
                if (File.Exists(Path.Combine(FilePath, $"{pos:0000}.png")))
                {
                    FileStream stream = new FileStream(Path.Combine(FilePath, $"{pos:0000}.png"), FileMode.Open, FileAccess.Read);
                    Bitmap temp = new Bitmap(stream);

                    if (temp.Height > SizeMiBand5.Height)
                        TypeWatch = typeWatch.MiBand6;

                    temp.SetResolution(96f, 96f);
                    images.Add(pos, temp);
                    stream.Close();
                }
                else if (File.Exists(Path.Combine(FilePath, $"{pos}.png")))
                {
                    FileStream stream = new FileStream(Path.Combine(FilePath, $"{pos}.png"), FileMode.Open, FileAccess.Read);
                    Bitmap temp = new Bitmap(stream);

                    if (temp.Height > SizeMiBand5.Height)
                        TypeWatch = typeWatch.MiBand6;

                    temp.SetResolution(96f, 96f);
                    images.Add(pos, temp);
                    stream.Close();
                }

            return TypeWatch;
        }

        public List<int> UsedImages()
        {
            List<int> usedImg = new List<int>();

            if (Background != null)
            {
                if (Background.Image != null) usedImg.Add(Background.Image.ImageIndex);
                if (Background.Preview1 != null) usedImg.Add(Background.Preview1.ImageIndex);
                if (Background.Preview2 != null) usedImg.Add(Background.Preview2.ImageIndex);
                if (Background.Preview3 != null) usedImg.Add(Background.Preview3.ImageIndex);
            }
            if (Time != null)
            {
                if (Time.DelimiterImage != null) usedImg.Add(Time.DelimiterImage.ImageIndex);
                if (Time.Hours?.Ones != null) for (int i = Time.Hours.Ones.ImageIndex; i < Time.Hours.Ones.ImagesCount + Time.Hours.Ones.ImageIndex; i++) usedImg.Add(Time.Hours.Ones.ImageIndex + i);
            }

            return usedImg;
        }

        [Obfuscation(Exclude = false, Feature = "-rename")]
        public List<object> getElements() => new List<object>() { Background, Time, Activity, Date, Weather, StepsProgress, Status, Battery, AnalogDialFace, Other, HeartProgress, WeekDaysIcons, CaloriesProgress, Alarm, StatusSimplified };
    }

    public class DefaultDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
        Func<TValue> _init;
        public DefaultDictionary(Func<TValue> init)
        {
            _init = init;
        }

        public DefaultDictionary(Func<TValue> init, DefaultDictionary<TKey, TValue> dict)
        {
            _init = init;
            foreach (var item in dict)
                Add(item.Key, item.Value);
        }

        public new TValue this[TKey k]
        {
            get
            {
                if (!ContainsKey(k)) return _init();
                return base[k];
            }
            set => base[k] = value;
        }

        public DefaultDictionary<TKey, TValue> DeepCopy() => new DefaultDictionary<TKey, TValue>(_init, this);
    }

    //===========================ACTIVITY=============================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class Activity
    {
        [JsonProperty("Steps")]
        public Steps Steps;

        [JsonProperty("StepsGoal")]
        public StepsGoal StepsGoal;

        [JsonProperty("Calories")]
        public Calories Calories;

        [JsonProperty("Pulse")]
        public Pulse Pulse;

        [JsonProperty("Distance")]
        public Distance Distance;

        [JsonProperty("PAI")]
        public PAI PAI;

        [JsonProperty("UnknownV7")]
        public int UnknownV7 = 0;
    }

    public class Steps
    {
        [JsonProperty("Number")]
        public Number Number;

        [JsonProperty("PrefixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int PrefixImageIndex = -10000;

        [JsonProperty("SuffixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;
    }

    public class StepsGoal
    {
        [JsonProperty("Number")]
        public Number Number;
    }

    public class Calories
    {
        [JsonProperty("Text")]
        public Number Text;

        [JsonProperty("SuffixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;

        [JsonProperty("PrefixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int PrefixImageIndex = -10000;
    }

    public class Pulse
    {
        [JsonProperty("Number")]
        public Number Number;

        [JsonProperty("PrefixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int PrefixImageIndex = -10000;

        [JsonProperty("NoDataImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int NoDataImageIndex = -10000;

        [JsonProperty("SuffixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;
    }

    public class Distance
    {
        [JsonProperty("Number")]
        public Number Number;

        [JsonProperty("KmSuffixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int KmSuffixImageIndex = -10000;

        [JsonProperty("DecimalPointImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DecimalPointImageIndex = -10000;

        [JsonProperty("MilesSuffixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int MilesSuffixImageIndex = -10000;

        [JsonProperty("KmImageIndex")]
        public ImageBasic KmImageIndex;

        [JsonProperty("MilesImageIndex")]
        public ImageBasic MilesImageIndex;
    }

    public class PAI
    {
        [JsonProperty("Number")]
        public Number Number;
    }

    //===========================ACTIVITY=============================
    //===========================AirPollution=========================

    public class AirPollution
    {
        [JsonProperty("Index")]
        public Number Index;

        [JsonProperty("Icon")]
        public ImageSet Icon;
    }

    //===========================ALARM=================================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class Alarm
    {
        [JsonProperty("Text")]
        public Number Text;

        [JsonProperty("DelimiterImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DelimiterImageIndex = -10000;

        [JsonProperty("ImageOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ImageBasic ImageOn;

        [JsonProperty("ImageOff", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ImageBasic ImageOff;

        [JsonProperty("ImageNoAlarm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ImageBasic ImageNoAlarm;

        [JsonProperty("UnknownTF6")]
        public int UnknownTF6 = 1;

        [JsonProperty("UnknownTF7")]
        public int UnknownTF7 = 1;
    }

    //===========================ALARM=================================
    //===========================ANALOGDIALFACE========================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class AnalogDialFace
    {
        [JsonProperty("Hours")]
        public ClockHand Hours;

        [JsonProperty("Minutes")]
        public ClockHand Minutes;

        [JsonProperty("Seconds")]
        public ClockHand Seconds;
    }

    public class ClockHand
    {
        [JsonProperty("OnlyBorder")]
        public bool OnlyBorder = true;

        [JsonProperty("Color")]
        public string Color = "0x000000";

        [JsonProperty("Center")]
        public XY Center = new XY() { X = 0, Y = 0 };

        [JsonProperty("Shape")]
        public List<XY> Shape;

        [JsonProperty("CenterImage")]
        public ImageBasic CenterImage;

        public Point[] RotateArrowAtCenter(float angle)
        {
            List<XY> points = Shape;

            List<Point> outPoints = new List<Point>();

            foreach (XY point in points)
            {
                outPoints.Add(getRotatePoint(point.X, point.Y, angle - 90f));
            };

            return outPoints.ToArray();
        }

        private Point getRotatePoint(float x0, float y0, float angle)
        {
            double R = Math.Sqrt(Math.Pow(x0, 2.0f) + Math.Pow(y0, 2.0f));
            double angle0 = Math.Asin((y0 / R));
            //if (angle0 < 0) angle0 += Math.PI * 2.0f;
            if (x0 < 0) angle0 = Math.PI - angle0;
            double x = Math.Cos((angle * Math.PI) / 180f + angle0) * R;
            double y = Math.Sin((angle * Math.PI) / 180f + angle0) * R;

            try
            {
                return new Point(Convert.ToInt32(Math.Round(x + Center.X)), Convert.ToInt32(Math.Round(y + Center.Y)));
            }
            catch
            {
                return new Point(Center.X, Center.Y);
            }
        }
    }

    //===========================ANALOGDIALFACE========================
    //===========================ANIMATION=============================

    public class Animation
    {
        [JsonProperty("AnimationImages")]
        public ImageSet AnimationImages;

        [JsonProperty("Speed")]
        public int Speed;

        [JsonProperty("RepeatCount")]
        public int RepeatCount;

        [JsonProperty("UnknownTF4")]
        public int UnknownTF4 = 1;

        [JsonIgnore]
        public int Step = 0;
    }

    //===========================ANIMATION=============================
    //===========================BACKGROUND============================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class Background
    {
        [JsonProperty("Image")]
        public ImageBasic Image;

        [JsonProperty("BackgroundColor")]
        public string BackgroundColor = null;

        [JsonProperty("Preview1")]
        public ImageBasic Preview1;

        [JsonProperty("Preview2")]
        public ImageBasic Preview2;

        [JsonProperty("Preview3")]
        public ImageBasic Preview3;
    }

    //===========================BACKGROUND============================
    //===========================BATTERY===============================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class Battery
    {
        [JsonProperty("BatteryText")]
        public BatteryText BatteryText;

        [JsonProperty("BatteryIcon")]
        public ImageSet BatteryIcon;

        [JsonProperty("Linear")]
        public Scale Linear;

        [JsonProperty("BUnknown4")]
        public UnknownTest BUnknown4;

        [JsonProperty("BUnknown5")]
        public ImageBasic BUnknown5;

        [JsonProperty("BUnknown6")]
        public UnknownTest BUnknown6;
    }

    public class BatteryText
    {
        [JsonProperty("Coordinates")]
        public Number Coordinates;

        [JsonProperty("PrefixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int PrefixImageIndex = -10000;

        [JsonProperty("SuffixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;
    }

    //===========================BATTERY===============================
    //===========================CIRCLESCALE===========================

    public class CircleScale
    {
        [JsonProperty("CenterX")]
        public int CenterX;

        [JsonProperty("CenterY")]
        public int CenterY;

        [JsonProperty("RadiusX")]
        public int RadiusX = 1;

        [JsonProperty("RadiusY")]
        public int RadiusY = 1;

        [JsonProperty("StartAngle")]
        public int StartAngle;

        [JsonProperty("EndAngle")]
        public int EndAngle;

        [JsonProperty("Width")]
        public int Width;

        [JsonProperty("Color")]
        public string Color = "0x000000";
    }

    //===========================CIRCLESCALE===========================
    //===========================DATE==================================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class Date
    {
        [JsonProperty("MonthAndDayAndYear")]
        public MonthAndDayAndYear MonthAndDayAndYear;

        [JsonProperty("DayAmPm")]
        public DayAmPm DayAmPm;
        //public ImageSet WeekDay;

        [JsonProperty("ENWeekDays")]
        public ImageSet ENWeekDays;

        [JsonProperty("CNWeekDays")]
        public ImageSet CNWeekDays;

        [JsonProperty("CN2WeekDays")]
        public ImageSet CN2WeekDays;

        [JsonProperty("Unknown7")]
        public XY Unknown7;
    }

    public class DayAmPm
    {
        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;

        [JsonProperty("ImageIndexAMCN", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexAMCN = -10000;

        [JsonProperty("ImageIndexPMCN", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexPMCN = -10000;

        [JsonProperty("ImageIndexAMEN", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexAMEN = -10000;

        [JsonProperty("ImageIndexPMEN", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexPMEN = -10000;
        //public int Unknown7;
        //public int Unknown8;
    }

    public class MonthAndDayAndYear
    {
        [JsonProperty("Separate")]
        public SeparateMonthAndDay Separate;

        [JsonProperty("OneLine")]
        public OneLineMonthAndDay OneLine;

        [JsonProperty("OneLineWithYear")]
        public OneLineWithYear OneLineWithYear;

        [JsonProperty("TwoDigitsMonth")]
        public bool TwoDigitsMonth = true;

        [JsonProperty("TwoDigitsDay")]
        public bool TwoDigitsDay = true;
    }

    public class SeparateMonthAndDay
    {
        [JsonProperty("Month")]
        public Number Month;

        [JsonProperty("MonthsEN")]
        public ImageSet MonthsEN;

        [JsonProperty("MonthsCN")]
        public ImageSet MonthsCN;

        [JsonProperty("Day")]
        public Number Day;
        //public Number Year;
    }

    public class OneLineMonthAndDay
    {
        [JsonProperty("Number")]
        public Number Number;

        [JsonProperty("NumberCN")]
        public Number NumberCN;
        //{
        //    get { return numberCN; }
        //    set { NumberEN = numberCN != null ? value : NumberEN; numberCN = value; }
        //}

        [JsonProperty("NumberEN")]
        public Number NumberEN;

        [JsonProperty("DelimiterImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DelimiterImageIndex = -10000;

        //public OneLineMonthAndDay()
        //{
        //    if (NumberCN != null && NumberEN == null)
        //    {
        //        NumberEN = NumberCN;
        //    }
        //}
    }

    public class OneLineWithYear
    {
        [JsonProperty("Number")]
        public Number Number;

        [JsonProperty("NumberCN")]
        public Number NumberCN;
        //{
        //    get { return numberCN; }
        //    set { NumberEN = numberCN != null ? value : NumberEN; numberCN = value; }
        //}

        [JsonProperty("NumberEN")]
        public Number NumberEN;

        [JsonProperty("DelimiterImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DelimiterImageIndex = -10000;

        //public OneLineWithYear()
        //{
        //    if (NumberCN != null && NumberEN == null)
        //    {
        //        NumberEN = NumberCN;
        //    }
        //}
    }

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class WeekDaysIcons
    {
        [JsonProperty("Monday")]
        public ImageBasic Monday;

        [JsonProperty("Tuesday")]
        public ImageBasic Tuesday;

        [JsonProperty("Wednesday")]
        public ImageBasic Wednesday;

        [JsonProperty("Thursday")]
        public ImageBasic Thursday;

        [JsonProperty("Friday")]
        public ImageBasic Friday;

        [JsonProperty("Saturday")]
        public ImageBasic Saturday;

        [JsonProperty("Sunday")]
        public ImageBasic Sunday;
    }

    //===========================DATA==================================
    //===========================HEARTPROGRESS=========================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class HeartProgress
    {
        [JsonProperty("Scale")]
        public Scale Scale;

        [JsonProperty("LineScale")]
        public ImageSet LineScale;

        [JsonProperty("Linear")]
        public Scale Linear;

        [JsonProperty("CircleScale")]
        public CircleScale CircleScale;
    }

    //===========================HEARTPROGRESS=========================
    //===========================HUMIDITY==============================

    public class Humidity
    {
        [JsonProperty("Text")]
        public Number Text;

        [JsonProperty("SuffixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;

        [JsonProperty("ImageSuffix")]
        public ImageBasic ImageSuffix;
    }

    //===========================HUMIDITY==============================
    //===========================LUNARDATE=============================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class LunarDate
    {
        [JsonProperty("LunarMonth")]
        public Number LunarMonth;

        [JsonProperty("LunarDay")]
        public Number LunarDay;

        [JsonProperty("LunarDayOf0X")]
        public int LunarDayOf0X;

        [JsonProperty("LunarDayOf2X")]
        public int LunarDayOf2X;

        [JsonProperty("LunarDayOf10")]
        public int LunarDayOf10;

        [JsonProperty("LunarDayOf20")]
        public int LunarDayOf20;

        [JsonProperty("LunarDayOf30")]
        public int LunarDayOf30;
    }


    //===========================LUNARDATE=============================
    //===========================OTHER=================================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class Other
    {
        [JsonProperty("Animation")]
        public List<Animation> Animation;
    }

    //===========================OTHER=================================
    //===========================STATUS================================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class Status
    {
        [JsonProperty("DoNotDisturb")]
        public Switch DoNotDisturb;

        [JsonProperty("Lock")]
        public Switch Lock;

        [JsonProperty("Bluetooth")]
        public Switch Bluetooth;
        //public Battery Battery;

        public StatusSimple ConvertToStatusSimple()
        {
            StatusSimple status = new StatusSimple();

            if (DoNotDisturb != null)
            {
                status.DoNotDisturb = new StatusSimpleSpecial();
                status.DoNotDisturb.ImageIndexOff = DoNotDisturb.ImageIndexOff;
                status.DoNotDisturb.ImageIndexOn = DoNotDisturb.ImageIndexOn;
                status.DoNotDisturb.StatusImage = new StatusNumber() { X = DoNotDisturb.Coordinates != null ? DoNotDisturb.Coordinates.X : 0, Y = DoNotDisturb.Coordinates != null ? DoNotDisturb.Coordinates.Y : 0 };
            }

            if (Lock != null)
            {
                status.Lock = new StatusSimpleSpecial();
                status.Lock.ImageIndexOff = Lock.ImageIndexOff;
                status.Lock.ImageIndexOn = Lock.ImageIndexOn;
                status.Lock.StatusImage = new StatusNumber() { X = Lock.Coordinates != null ? Lock.Coordinates.X : 0, Y = Lock.Coordinates != null ? Lock.Coordinates.Y : 0 };
            }

            if (Bluetooth != null)
            {
                status.Bluetooth = new StatusSimpleSpecial();
                status.Bluetooth.ImageIndexOff = Bluetooth.ImageIndexOff;
                status.Bluetooth.ImageIndexOn = Bluetooth.ImageIndexOn;
                status.Bluetooth.StatusImage = new StatusNumber() { X = Bluetooth.Coordinates != null ? Bluetooth.Coordinates.X : 0, Y = Bluetooth.Coordinates != null ? Bluetooth.Coordinates.Y : 0 };
            }

            if (status.Bluetooth == null && status.DoNotDisturb == null && status.Lock == null)
                return null;

            return status;
        }
    }

    //===========================STATUS================================
    //===========================TEMPERATURE===========================

    public class Temperature
    {
        [JsonProperty("Current")]
        public TemperatureNumber Current;

        [JsonProperty("Today")]
        public TodayTemperature Today;
    }

    public class TodayTemperature
    {
        [JsonProperty("Separate")]
        public SeparateTemperature Separate;

        [JsonProperty("OneLine")]
        public OneLineTemperature OneLine;
    }

    public class SeparateTemperature
    {
        [JsonProperty("Day")]
        public TemperatureNumber Day;

        [JsonProperty("Night")]
        public TemperatureNumber Night;
        //public Coordinates DayAlt;
        //public Coordinates NightAlt;

        [JsonProperty("Unknown3")]
        public Coordinates Unknown3;

        [JsonProperty("Unknown4")]
        public Coordinates Unknown4;
    }

    public class TemperatureNumber
    {
        [JsonProperty("Number")]
        public Number Number;

        [JsonProperty("MinusImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int MinusImageIndex = -10000;

        [JsonProperty("DegreesImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DegreesImageIndex = -10000;
    }

    public class OneLineTemperature
    {
        [JsonProperty("Number")]
        public Number Number;

        [JsonProperty("MinusSignImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int MinusSignImageIndex = -10000;

        [JsonProperty("DelimiterImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DelimiterImageIndex = -10000;

        [JsonProperty("AppendDegreesForBoth")]
        public bool AppendDegreesForBoth = true;

        [JsonProperty("DegreesImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DegreesImageIndex = -10000;
    }

    //===========================TEMPERATURE===========================
    //===========================TIME==================================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class Time
    {
        [JsonProperty("Hours")]
        public TwoDigits Hours;

        [JsonProperty("Minutes")]
        public TwoDigits Minutes;

        [JsonProperty("Seconds")]
        public TwoDigits Seconds;
        //public DayAmPm AmPm;

        [JsonProperty("DelimiterImage")]
        public ImageBasic DelimiterImage;
        //public ImageBasic TimeDelimiterImage;

        [JsonProperty("TimeZone1")]
        public Number TimeZone1;

        [JsonProperty("TimeZone1DelimiterImage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int TimeZone1DelimiterImage = -10000;

        [JsonProperty("TimeZone2")]
        public Number TimeZone2;

        [JsonProperty("TimeZone2DelimiterImage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int TimeZone2DelimiterImage = -10000;

        [JsonProperty("UnknownV11")]
        public int UnknownV11 = 0;

        [JsonProperty("TimeZone1NoTime")]
        public ImageBasic TimeZone1NoTime;

        [JsonProperty("TimeZone2NoTime")]
        public ImageBasic TimeZone2NoTime;

        [JsonProperty("TimeDelimiter2Image")]
        public ImageBasic TimeDelimiter2Image;
    }

    public class TwoDigits
    {
        [JsonProperty("Tens")]
        public ImageSet Tens;

        [JsonProperty("Ones")]
        public ImageSet Ones;
    }

    //===========================TIME==================================
    //===========================UVINDEX===============================

    public class UVIndex
    {
        [JsonProperty("Text")]
        public Number Text;

        [JsonProperty("SuffixImageIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;
    }

    //===========================UVINDEX===============================
    //===========================UVWRAPPER=============================

    public class UVWrapper
    {
        [JsonProperty("UV")]
        public UVIndex UV;

        [JsonProperty("UVCN")]
        public ImageSet UVCN;

        [JsonProperty("UVCN2")]
        public ImageSet UVCN2;
    }

    //===========================UVWRAPPER=============================
    //===========================WEATHER===============================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class Weather
    {
        [JsonProperty("Icon")]
        public WeatherIcon Icon;

        [JsonProperty("Temperature")]
        public Temperature Temperature;

        [JsonProperty("AirPollution")]
        public AirPollution AirPollution;

        [JsonProperty("Humidity")]
        public Humidity Humidity;

        [JsonProperty("Wind")]
        public Wind Wind;

        [JsonProperty("UVIndex")]
        public UVWrapper UVIndex;
    }

    public class Wind
    {
        [JsonProperty("Text")]
        public Number Text;

        [JsonProperty("ImageSuffixEN", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageSuffixEN = -10000;

        [JsonProperty("ImageSuffixCN1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageSuffixCN1 = -10000;

        [JsonProperty("ImageSufficCN2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageSufficCN2 = -10000;

        [JsonProperty("ImagePosSuffixEN")]
        public ImageBasic ImagePosSuffixEN;

        [JsonProperty("ImagePosSuffixCN1")]
        public ImageBasic ImagePosSuffixCN1;

        [JsonProperty("ImagePosSuffixCN2")]
        public ImageBasic ImagePosSuffixCN2;
    }

    public class WeatherIcon
    {
        [JsonProperty("Coordinates")]
        public Coordinates Coordinates;

        [JsonProperty("CustomIcon")]
        public ImageSet CustomIcon;

        [JsonProperty("Unknown3")]
        public XY Unknown3;

        [JsonProperty("Unknown4")]
        public XY Unknown4;
    }

    //===========================WEATHER===============================
    //===========================HELP==================================

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class CaloriesProgress
    {
        [JsonProperty("GoalImage")]
        public ImageBasic GoalImage;

        [JsonProperty("LineScale")]
        public ImageSet LineScale;

        [JsonProperty("Linear")]
        public Scale Linear;

        [JsonProperty("CircleScale")]
        public CircleScale CircleScale;

        public StepsProgress ConvertToSP() => new StepsProgress() { GoalImage = GoalImage, CircleScale = CircleScale, Linear = Linear, LineScale = LineScale };
    }

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class StepsProgress
    {
        [JsonProperty("GoalImage")]
        public ImageBasic GoalImage;

        [JsonProperty("LineScale")]
        public ImageSet LineScale;

        [JsonProperty("Linear")]
        public Scale Linear;

        [JsonProperty("CircleScale")]
        public CircleScale CircleScale;

        public CaloriesProgress ConvertToSP() => new CaloriesProgress() { GoalImage = GoalImage, CircleScale = CircleScale, Linear = Linear, LineScale = LineScale };
    }

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public class StatusSimple
    {
        [JsonProperty("DoNotDisturb")]
        public StatusSimpleSpecial DoNotDisturb;

        [JsonProperty("Lock")]
        public StatusSimpleSpecial Lock;

        [JsonProperty("Bluetooth")]
        public StatusSimpleSpecial Bluetooth;

        public Status ConvertToStatus()
        {
            Status status = (DoNotDisturb != null || Lock != null || Bluetooth != null) ? new Status() : null;

            if (DoNotDisturb != null)
            {
                status.DoNotDisturb = new Switch();
                status.DoNotDisturb.Coordinates = new Coordinates() { X = DoNotDisturb.StatusImage != null ? DoNotDisturb.StatusImage.X : 0, Y = DoNotDisturb.StatusImage != null ? DoNotDisturb.StatusImage.Y : 0 };
                status.DoNotDisturb.ImageIndexOff = DoNotDisturb.ImageIndexOff;
                status.DoNotDisturb.ImageIndexOn = DoNotDisturb.ImageIndexOn;
            }
            if (Lock != null)
            {
                status.Lock = new Switch();
                status.Lock.Coordinates = new Coordinates() { X = Lock.StatusImage != null ? Lock.StatusImage.X : 0, Y = Lock.StatusImage != null ? Lock.StatusImage.Y : 0 };
                status.Lock.ImageIndexOff = Lock.ImageIndexOff;
                status.Lock.ImageIndexOn = Lock.ImageIndexOn;
            }
            if (Bluetooth != null)
            {
                status.Bluetooth = new Switch();
                status.Bluetooth.Coordinates = new Coordinates() { X = Bluetooth.StatusImage != null ? Bluetooth.StatusImage.X : 0, Y = Bluetooth.StatusImage != null ? Bluetooth.StatusImage.Y : 0 };
                status.Bluetooth.ImageIndexOff = Bluetooth.ImageIndexOff;
                status.Bluetooth.ImageIndexOn = Bluetooth.ImageIndexOn;
            }

            return status;
        }
    }

    public class StatusSimpleSpecial
    {
        [JsonProperty("StatusImage")]
        public StatusNumber StatusImage;

        [JsonProperty("ImageIndexOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexOn = -10000;

        [JsonProperty("ImageIndexOff", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexOff = -10000;
    }

    public class StatusNumber
    {
        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;

        [JsonProperty("Alignment")]
        public string Alignment = "TopLeft";

        [JsonProperty("Unknown4")]
        public int Unknown4 = 2;

        [JsonProperty("Unknown5")]
        public int Unknown5 = 6;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class Switch
    {
        [JsonProperty("Coordinates")]
        public Coordinates Coordinates;

        [JsonProperty("ImageIndexOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexOn = -10000;

        [JsonProperty("ImageIndexOff", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexOff = -10000;
    }

    public class LineScale
    {
        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;

        [JsonProperty("ImageIndex")]
        public int ImageIndex = -10000;

        [JsonProperty("ImagesCount")]
        public int ImagesCount;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class CustomWeatherIcon
    {
        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;

        [JsonProperty("ImageIndex")]
        public int ImageIndex = -10000;

        [JsonProperty("ImagesCount")]
        public int ImagesCount;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class Coordinates
    {
        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;
        //public int BoxWidth;
        //public int Alignment;
        //public int Order;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class UnknownTest
    {
        [JsonProperty("Unknown1")]
        public int Unknown1;

        [JsonProperty("Unknown2")]
        public int Unknown2;

        [JsonProperty("Unknown3")]
        public int Unknown3;

        [JsonProperty("Unknown4")]
        public int Unknown4;

        [JsonProperty("Unknown5")]
        public int Unknown5;

        [JsonProperty("Unknown6")]
        public int Unknown6;

        [JsonProperty("Unknown7")]
        public int Unknown7;

        [JsonProperty("Unknown8")]
        public int Unknown8;

        [JsonProperty("Unknown9")]
        public int Unknown9;
    }

    public class Scale
    {
        [JsonProperty("StartImageIndex")]
        public int StartImageIndex = -10000;

        [JsonProperty("Segments")]
        public List<XY> Segments = new List<XY>();
    }

    public class XY
    {
        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class ImageSet
    {
        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;

        [JsonProperty("ImageIndex")]
        public int ImageIndex = -10000;

        [JsonProperty("ImagesCount")]
        public int ImagesCount;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class ImageBasic
    {
        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;

        [JsonProperty("ImageIndex")]
        public int ImageIndex = -10000;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class Text
    {
        [JsonProperty("Number")]
        public Number Number;
    }

    public class Number
    {
        [JsonProperty("TopLeftX")]
        public int TopLeftX;

        [JsonProperty("TopLeftY")]
        public int TopLeftY;

        [JsonProperty("BottomRightX")]
        public int BottomRightX;

        [JsonProperty("BottomRightY")]
        public int BottomRightY;

        [JsonProperty("Alignment")]
        public string Alignment = "TopLeft";

        [JsonProperty("SpacingX")]
        public int SpacingX;

        [JsonProperty("SpacingY")]
        public int SpacingY;

        [JsonProperty("ImageIndex")]
        public int ImageIndex = -10000;

        [JsonProperty("ImagesCount")]
        public int ImagesCount;

        [JsonIgnore]
        public bool drawBorder;
        [JsonIgnore]
        public bool notDraw = false;

        public Number() { Alignment = parseAligment(); }

        public string parseAligment()
        {
            string fixedAligment = "";

            if (Alignment.IndexOf("Top") != -1) fixedAligment += "Top";
            else if (Alignment.IndexOf("Bottom") != -1) fixedAligment += "Bottom";
            else if (Alignment.IndexOf("Center") != -1) fixedAligment += "Center";

            if (Alignment.IndexOf("Left") != -1) fixedAligment += "Left";
            else if (Alignment.IndexOf("Right") != -1) fixedAligment += "Right";
            else if (Alignment.IndexOf("Center") != -1 && fixedAligment.IndexOf("Center") == -1) fixedAligment += "Center";

            Alignment = fixedAligment;
            return Alignment;
        }

        public Size getSize(DefaultDictionary<int, Image> imagesBuff)
        {
            List<Image> images = new List<Image>();
            for (int i = ImageIndex; i < ImageIndex + ImagesCount; i++)
                images.Add(imagesBuff[i]);

            int fullWidth = 0;
            int fullHeight = 0;

            foreach (Image image in images)
                fullWidth += image.Width + SpacingX;
            fullWidth -= SpacingX;

            foreach (Image image in images)
                fullHeight = fullHeight > image.Height ? fullHeight : image.Height;

            foreach (Image image in images)
                fullHeight += SpacingY;
            fullHeight -= SpacingY;

            Size size = new Size(fullWidth, fullHeight);
            return size;
        }
    }

    public static class FindUsageImage
    {
        public class IndexImage
        {
            public string node = "";
            public List<int> indexes = new List<int>();
        }

        static List<IndexImage> AddNode(JToken token, List<IndexImage> indexImages, string node = "Watchface")
        {
            if (token == null)
                return indexImages;

            if (token is JObject)
            {
                int imgCount = -1;
                int startIndex = -1;
                var obj = (JObject)token;
                foreach (var property in obj.Properties())
                {
                    var childNode = property.Name;
                    //Console.Write(childNode.ToString()+".");
                    if (childNode.IndexOf("ImagesCount") != -1)
                        imgCount = property.Value.Value<int>();

                    if (childNode.ToLower().IndexOf("index") != -1 && childNode.ToLower().IndexOf("uv") == -1)
                        startIndex = property.Value.Value<int>();

                    if (childNode.ToLower().IndexOf("segments") != -1)
                        imgCount = property.Value.Value<JArray>().Count();

                    indexImages = AddNode(property.Value, indexImages, $"{node}.{childNode.ToString()}");
                }

                if (imgCount != -1 || startIndex != -1)
                {
                    //Console.WriteLine($"IMGCount: {imgCount} StartIndex: {startIndex} \nNode: {node} \n");
                    List<int> indexes = new List<int>();
                    for (int i = startIndex; i < startIndex + imgCount; i++) indexes.Add(i);
                    indexImages.Add(new IndexImage() { indexes = indexes, node = node });
                }
            }
            else if (token is JArray)
            {
                var array = (JArray)token;
                for (int i = 0; i < array.Count; i++)
                {
                    var childNode = i.ToString();
                    //Console.Write(array[i]);
                    indexImages = AddNode(array[i], indexImages);
                }
            }

            return indexImages;
        }

        public static List<IndexImage> FindUsage(this WatchFaceLibrary watch) => AddNode(JToken.Parse(JsonConvert.SerializeObject(watch, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore })), new List<IndexImage>());

        public static string FindUsage(this WatchFaceLibrary watch,int numImg)
        {
            string match = "";

            foreach (IndexImage indexImage in AddNode(JToken.Parse(JsonConvert.SerializeObject(watch, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore })), new List<IndexImage>()))
                foreach (int index in indexImage.indexes)
                    if (index == numImg)
                        match += $"{indexImage.node}\n";

            return match;
        }
}
}
