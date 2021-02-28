using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBand5WatchFaces
{
    public class WatchFaceLibrary
    {
        public Background Background;
        public Time Time;
        public Activity Activity;
        public Date Date;
        public Weather Weather;
        public StepsProgress StepsProgress;
        public Status Status;
        public Battery Battery;
        public AnalogDialFace AnalogDialFace;
        public Other Other;
        public HeartProgress HeartProgress;
        //public UnknownTest Unknown13;
        public WeekDaysIcons WeekDaysIcons;
        public CaloriesProgress CaloriesProgress;
        public Alarm Alarm;
        public StatusSimple StatusSimplified;
        //public LunarDate LunarDateCN;

        [JsonIgnore]
        public string FilePath;
        [JsonIgnore]
        public List<Image> images = new List<Image>();
        [JsonIgnore]
        public DefaultDictionary<int, Image> imagesBuff = new DefaultDictionary<int, Image>(() => new Bitmap(1,1));

        public void LoadImages()
        {
            for (int pos = 0; pos < 10000; pos++)
                if (File.Exists(Path.Combine(FilePath, $"{pos:0000}.png")))
                    imagesBuff.Add(pos,Image.FromFile(Path.Combine(FilePath, $"{pos:0000}.png")));
        }

        public List<object> getElements() => new List<object>() { Background, Time, Activity, Date, Weather, StepsProgress, Status, Battery, AnalogDialFace, Other, HeartProgress, WeekDaysIcons, CaloriesProgress, Alarm, StatusSimplified};
   
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

    public class Activity
    {
        public Steps Steps;
        //public StepsGoal StepsGoal;
        public Calories Calories;
        public Pulse Pulse;
        public Distance Distance;
        public PAI PAI;
        public int UnknownV7 = 0;
    }

    public class Steps
    {
        public Number Number;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int PrefixImageIndex = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;
    }

    public class StepsGoal
    {
        public Number Number;
    }

    public class Calories
    {
        public Number Text;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int PrefixImageIndex = -10000;
    }

    public class Pulse
    {
        public Number Number;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int PrefixImageIndex = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int NoDataImageIndex = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;
    }

    public class Distance
    {
        public Number Number;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int KmSuffixImageIndex = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DecimalPointImageIndex = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int MilesSuffixImageIndex = -10000;
        public ImageBasic KmImageIndex;
        public ImageBasic MilesImageIndex;
    }

    public class PAI
    {
        public Number Number;
    }

    //===========================ACTIVITY=============================
    //===========================AirPollution=========================

    public class AirPollution
    {
        public Number Index;
        public ImageSet Icon;
    }

    //===========================ALARM=================================

    public class Alarm
    {
        public Number Text;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DelimiterImageIndex = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ImageBasic ImageOn;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ImageBasic ImageOff;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ImageBasic ImageNoAlarm;
        public int UnknownTF6 = 1;
        public int UnknownTF7 = 1;
    }

    //===========================ALARM=================================
    //===========================ANALOGDIALFACE========================

    public class AnalogDialFace
    {
        public ClockHand Hours;
        public ClockHand Minutes;
        public ClockHand Seconds;
    }

    public class ClockHand
    {
        public bool OnlyBorder;
        public string Color;
        public XY Center;
        public List<XY> Shape;
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

            return new Point(Convert.ToInt32(Math.Round(x+Center.X)), Convert.ToInt32(Math.Round(y+Center.Y)));
        }
    }

    //===========================ANALOGDIALFACE========================
    //===========================ANIMATION=============================

    public class Animation
    {
        public ImageSet AnimationImages;
        public int Speed;
        public int RepeatCount;
        public int UnknownTF4 = 1;
    }

    //===========================ANIMATION=============================
    //===========================BACKGROUND============================

    public class Background
    {
        public ImageBasic Image;
        public string BackgroundColor = null;
        public ImageBasic Preview1;
        public ImageBasic Preview2;
        public ImageBasic Preview3;
    }

    //===========================BACKGROUND============================
    //===========================BATTERY===============================

    public class Battery
    {
        public BatteryText BatteryText;
        public ImageSet BatteryIcon;
        public Scale Linear;
        public UnknownTest BUnknown4;
        public ImageBasic BUnknown5;
        public UnknownTest BUnknown6;
    }

    public class BatteryText
    {
        public Number Coordinates;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int PrefixImageIndex = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;
    }

    //===========================BATTERY===============================
    //===========================CIRCLESCALE===========================

    public class CircleScale
    {
        public int CenterX;
        public int CenterY;
        public int RadiusX = 1;
        public int RadiusY = 1;
        public int StartAngle;
        public int EndAngle;
        public int Width;
        public string Color = "0x000000";
    }

    //===========================CIRCLESCALE===========================
    //===========================DATE==================================

    public class Date
    {
        public MonthAndDayAndYear MonthAndDayAndYear;
        public DayAmPm DayAmPm;
        //public ImageSet WeekDay;
        public ImageSet ENWeekDays;
        public ImageSet CNWeekDays;
        public ImageSet CN2WeekDays;
        public XY Unknown7;
    }

    public class DayAmPm
    {
        public int X;
        public int Y;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexAMCN = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexPMCN = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexAMEN = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexPMEN = -10000;
        //public int Unknown7;
        //public int Unknown8;
    }

    public class MonthAndDayAndYear
    {
        public SeparateMonthAndDay Separate;
        public OneLineMonthAndDay OneLine;
        public OneLineWithYear OneLineWithYear;
        public bool TwoDigitsMonth = true;
        public bool TwoDigitsDay = true;
    }

    public class SeparateMonthAndDay
    {
        public Number Month;
        public ImageSet MonthsEN;
        public ImageSet MonthsCN;
        public Number Day;
        //public Number Year;
    }

    public class OneLineMonthAndDay
    {
        public Number Number;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DelimiterImageIndex = -10000;
    }

    public class OneLineWithYear
    {
        public Number Number;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DelimiterImageIndex = -10000;
    }

    public class WeekDaysIcons
    {
        public ImageBasic Monday;
        public ImageBasic Tuesday;
        public ImageBasic Wednesday;
        public ImageBasic Thursday;
        public ImageBasic Friday;
        public ImageBasic Saturday;
        public ImageBasic Sunday;
    }

    //===========================DATA==================================
    //===========================HEARTPROGRESS=========================

    public class HeartProgress
    {
        public Scale Scale;
        public LineScale LineScale;
        public Scale Linear;
    }

    //===========================HEARTPROGRESS=========================
    //===========================HUMIDITY==============================

    public class Humidity
    {
        public Number Text;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;
        public ImageBasic ImageSuffix;
    }

    //===========================HUMIDITY==============================
    //===========================LUNARDATE=============================

    public class LunarDate
    {
        public Number LunarMonth;
        public Number LunarDay;
        public int LunarDayOf0X;
        public int LunarDayOf2X;
        public int LunarDayOf10;
        public int LunarDayOf20;
        public int LunarDayOf30;
    }

    //===========================LUNARDATE=============================
    //===========================OTHER=================================

    public class Other
    {
        public List<Animation> Animation;
    }

    //===========================OTHER=================================
    //===========================STATUS================================

    public class Status
    {
        public Switch DoNotDisturb;
        public Switch Lock;
        public Switch Bluetooth;
        //public Battery Battery;
    }

    //===========================STATUS================================
    //===========================TEMPERATURE===========================

    public class Temperature
    {
        public TemperatureNumber Current;
        public TodayTemperature Today;
    }

    public class TodayTemperature
    {
        public SeparateTemperature Separate;
        public OneLineTemperature OneLine;
    }

    public class SeparateTemperature
    {
        public TemperatureNumber Day;
        public TemperatureNumber Night;
        //public Coordinates DayAlt;
        //public Coordinates NightAlt;
        public Coordinates Unknown3;
        public Coordinates Unknown4;
    }

    public class TemperatureNumber
    {
        public Number Number;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int MinusImageIndex = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DegreesImageIndex = -10000;
    }

    public class OneLineTemperature
    {
        public Number Number;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int MinusSignImageIndex = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DelimiterImageIndex = -10000;
        public bool AppendDegreesForBoth = true;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int DegreesImageIndex = -10000;
    }

    //===========================TEMPERATURE===========================
    //===========================TIME==================================

    public class Time
    {
        public TwoDigits Hours;
        public TwoDigits Minutes;
        public TwoDigits Seconds;
        //public DayAmPm AmPm;
        public ImageBasic DelimiterImage;
        //public ImageBasic TimeDelimiterImage;
        public Number TimeZone1;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int TimeZone1DelimiterImage = -10000;
        public Number TimeZone2;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int TimeZone2DelimiterImage = -10000;
        public int UnknownV11 = 0;
        public ImageBasic TimeZone1NoTime;
        public ImageBasic TimeZone2NoTime;
        public ImageBasic TimeDelimiter2Image;
    }

    public class TwoDigits
    {
        public ImageSet Tens;
        public ImageSet Ones;
    }

    //===========================TIME==================================
    //===========================UVINDEX===============================

    public class UVIndex
    {
        public Number Text;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int SuffixImageIndex = -10000;
    }

    //===========================UVINDEX===============================
    //===========================UVWRAPPER=============================

    public class UVWrapper
    {
        public UVIndex UV;
        public ImageSet UVCN;
        public ImageSet UVCN2;
    }

    //===========================UVWRAPPER=============================
    //===========================WEATHER===============================

    public class Weather
    {
        public WeatherIcon Icon;
        public Temperature Temperature;
        public AirPollution AirPollution;
        public Humidity Humidity;
        public Wind Wind;
        public UVWrapper UVIndex;
    }

    public class Wind
    {
        public Number Text;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageSuffixEN = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageSuffixCN1 = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageSufficCN2 = -10000;
        public ImageBasic ImagePosSuffixEN;
        public ImageBasic ImagePosSuffixCN1;
        public ImageBasic ImagePosSuffixCN2;
    }

    public class WeatherIcon
    {
        public Coordinates Coordinates;
        public ImageSet CustomIcon;
        public XY Unknown3;
        public XY Unknown4;
    }

    //===========================WEATHER===============================
    //===========================HELP==================================

    public class CaloriesProgress
    {
        public ImageBasic GoalImage;
        public LineScale LineScale;
        public Scale Linear;
        public CircleScale CircleScale;
    }

    public class StepsProgress
    {
        public ImageBasic GoalImage;
        public LineScale LineScale;
        public Scale Linear;
        public CircleScale CircleScale;
    }

    public class StatusSimple
    {
        public StatusSimpleSpecial DoNotDisturb;
        public StatusSimpleSpecial Lock;
        public StatusSimpleSpecial Bluetooth;
    }

    public class StatusSimpleSpecial
    {
        public StatusNumber StatusImage;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexOn = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexOff = -10000;
    }

    public class StatusNumber
    {
        public int X;
        public int Y;
        public string Alignment = "TopLeft";
        public int Unknown4 = 2;
        public int Unknown5 = 6;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class Switch
    {
        public Coordinates Coordinates;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexOn = -10000;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-10000)]
        public int ImageIndexOff = -10000;
    }

    public class LineScale
    {
        public int X;
        public int Y;
        public int ImageIndex = -10000;
        public int ImagesCount;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class CustomWeatherIcon
    {
        public int X;
        public int Y;
        public int ImageIndex = -10000;
        public int ImagesCount;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class Coordinates
    {
        public int X;
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
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;
        public int Unknown7;
        public int Unknown8;
        public int Unknown9;
    }

    public class Scale
    {
        public int StartImageIndex = -10000;
        public List<XY> Segments = new List<XY>();
    }

    public class XY
    {
        public int X;
        public int Y;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class ImageSet
    {
        public int X;
        public int Y;
        public int ImageIndex = -10000;
        public int ImagesCount;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class ImageBasic
    {
        public int X;
        public int Y;
        public int ImageIndex = -10000;

        public Point getPoint()
        {
            return new Point(X, Y);
        }
    }

    public class Text
    {
        public Number Number;
    }

    public class Number
    {
        public int TopLeftX;
        public int TopLeftY;
        public int BottomRightX;
        public int BottomRightY;
        public string Alignment = "LeftTop";
        public int SpacingX;
        public int SpacingY;
        public int ImageIndex = -10000;
        public int ImagesCount;

        [JsonIgnore]
        public bool drawBorder;
        [JsonIgnore]
        public bool notDraw = false;

        public string parseAligment()
        {
            string fixedAligment = "";

            if (Alignment.IndexOf("Left") != -1) fixedAligment += "Left";
            else if (Alignment.IndexOf("Right") != -1) fixedAligment += "Right";
            else if (Alignment.IndexOf("Center") != -1) fixedAligment += "Center";

            if (Alignment.IndexOf("Top") != -1) fixedAligment += "Top";
            else if (Alignment.IndexOf("Bottom") != -1) fixedAligment += "Bottom";
            else if (Alignment.IndexOf("Center") != -1 && fixedAligment.IndexOf("Center") == -1) fixedAligment += "Center";

            Alignment = fixedAligment;
            return Alignment;
        }

        public Size getSize(DefaultDictionary<int,Image> imagesBuff)
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

            Size size = new Size(fullWidth,fullHeight);
            return size;
        }
    }
}
