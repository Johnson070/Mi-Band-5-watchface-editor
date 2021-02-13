using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBand5WatchFaces
{
    public class WatchFaceClass
    {
        public background Background;
        public time Time;
        public activity Activity;
        public date Date;
        public weather Weather;
        public stepsprogress StepsProgress;
        public status Status;
        public battery Battery;
        public other Other;
        public alarm Alarm;
        public analogdialface AnalogDialFace;
        public statussimplified StatusSimplified;

        public struct background
        {
            public image Image;
            public preview1 Preview1;
            public preview2 Preview2;
            public preview3 Preview3;

            public struct image
            {
                public int X;
                public int Y;
                public int ImageIndex;
            }

            public struct preview1
            {
                public int X;
                public int Y;
                public int ImageIndex;
            }

            public struct preview2
            {
                public int X;
                public int Y;
                public int ImageIndex;
            }

            public struct preview3
            {
                public int X;
                public int Y;
                public int ImageIndex;
            }
        }

        public class time
        {
            public hours Hours;
            public minutes Minutes;
            public int UnknownV11 = 0;


            public class tens
            {
                public int X;
                public int Y;
                public int ImageIndex;
                public int ImagesCount;
            }

            public class ones
            {
                public int X;
                public int Y;
                public int ImageIndex;
                public int ImagesCount;
            }

            public class hours
            {
                public tens Tens;
                public ones Ones;
            }

            public class minutes
            {
                public tens Tens;
                public ones Ones;
            }

            public class ampm
            {
                public int X;
                public int Y;
                public int ImageIndexAMEN;
                public int ImageIndexPCEN;
            }

            public class DelimiterImage
            {
                public int X;
                public int Y;
                public int ImageIndex;
            }
        }

        public class status
        {
            public bluebooth Bluetooth;
            public _lock Lock;
            public donotdisturb DoNotDisturb;

            public class coordinates
            {
                public int X;
                public int Y;
            }

            public class bluebooth
            {
                public coordinates Coordinates;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int ImageIndexOn;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int ImageIndexOff;
            }

            public class _lock
            {
                public coordinates Coordinates;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int ImageIndexOn;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int ImageIndexOff;
            }

            public class donotdisturb
            {
                public coordinates Coordinates;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int ImageIndexOn;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int ImageIndexOff;
            }
        }

        public class battery
        {
            public batterytext BatteryText;
            public batteryicon BatteryIcon;
            public linear Linear;

            public class batterytext
            {
                public coordinates Coordinates;
                public int SuffixImageIndex;

                public class coordinates
                {
                    public int TopLeftX;
                    public int TopLeftY;
                    public int BottomRightX;
                    public int BottomRightY;
                    public string Alignment;
                    public int SpacingX;
                    public int SpacingY;
                    public int ImageIndex;
                    public int ImagesCount;
                }
            }

            public class batteryicon
            {
                public int X;
                public int Y;
                public int ImageIndex;
                public int ImagesCount;
            }

            public class linear
            {
                public int StartImageIndex;

                public List<coords> Segments;

                public struct coords
                {
                    public int X;
                    public int Y;
                }
            }
        }

        public class activity
        {
            public steps Steps;
            public calories Calories;
            public pulse Pulse;
            public distance Distance;
            public pai PAI;
            public int UnknownV7 = 0;

            public class steps
            {
                public number Number;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int SuffixImageIndex;

                public class number
                {
                    public int TopLeftX;
                    public int TopLeftY;
                    public int BottomRightX;
                    public int BottomRightY;
                    public string Alignment;
                    public int SpacingX;
                    public int SpacingY;
                    public int ImageIndex;
                    public int ImagesCount;
                }
            }

            public class calories
            {
                public text Text;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int SuffixImageIndex;

                public class text
                {
                    public int TopLeftX;
                    public int TopLeftY;
                    public int BottomRightX;
                    public int BottomRightY;
                    public string Alignment;
                    public int SpacingX;
                    public int SpacingY;
                    public int ImageIndex;
                    public int ImagesCount;
                }
            }

            public class pulse
            {
                public number Number;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int NoDataImageIndex;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int SuffixImageIndex;

                public class number
                {
                    public int TopLeftX;
                    public int TopLeftY;
                    public int BottomRightX;
                    public int BottomRightY;
                    public string Alignment;
                    public int SpacingX;
                    public int SpacingY;
                    public int ImageIndex;
                    public int ImagesCount;
                }
            }

            public class distance
            {
                public number Number;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int KmSuffixImageIndex;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int MilesSuffixImageIndex;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int DecimalPointImageIndex;

                public class number
                {
                    public int TopLeftX;
                    public int TopLeftY;
                    public int BottomRightX;
                    public int BottomRightY;
                    public string Alignment;
                    public int SpacingX;
                    public int SpacingY;
                    public int ImageIndex;
                    public int ImagesCount;
                }
            }

            public class pai
            {
                public number Number;

                public class number
                {
                    public int TopLeftX;
                    public int TopLeftY;
                    public int BottomRightX;
                    public int BottomRightY;
                    public string Alignment;
                    public int SpacingX;
                    public int SpacingY;
                    public int ImageIndex;
                    public int ImagesCount;
                }
            }
        }

        public class date
        {
            public monthanddayandyear MonthAndDayAndYear;
            public dayampm DayAmPm;
            public enweekdays ENWeekDays;

            public class monthanddayandyear
            {
                public oneline OneLine;
                public separate Separate;
                public bool TwoDigitsMonth = true;
                public bool TwoDigitsDay = true;

                public class oneline
                {
                    public number Number;
                    public int DelimiterImageIndex;

                    public class number
                    {
                        public int TopLeftX;
                        public int TopLeftY;
                        public int BottomRightX;
                        public int BottomRightY;
                        public string Alignment;
                        public int SpacingX;
                        public int SpacingY;
                        public int ImageIndex;
                        public int ImagesCount;
                    }
                }

                public class separate
                {
                    public number Month;
                    public number Day;

                    public class number
                    {
                        public int TopLeftX;
                        public int TopLeftY;
                        public int BottomRightX;
                        public int BottomRightY;
                        public string Alignment;
                        public int SpacingX;
                        public int SpacingY;
                        public int ImageIndex;
                        public int ImagesCount;
                    }
                }
            }

            public class dayampm
            {
                public int X;
                public int Y;
                public int ImageIndexAMEN;
                public int ImageIndexPMEN;
            }

            public class enweekdays
            {
                public int X;
                public int Y;
                public int ImageIndex;
                public int ImagesCount;
            }
        }

        public class weather
        {
            public icon Icon;
            public temperature Temperature;
            public humidity Humidity;
            public wind Wind;
            public uvindex UVIndex;

            public class icon
            {
                public customicon CustomIcon;
                public unknown Unknown3;
                public unknown Unknown4;

                public class customicon
                {
                    public int X;
                    public int Y;
                    public int ImageIndex;
                    public int ImagesCount;
                }

                public class unknown
                {
                    public int X;
                    public int Y;
                }
            }

            public class temperature
            {
                public current Current;
                public today Today;

                public class current
                {
                    public number Number;
                    public int MinusImageIndex;
                    public int DegreesImageIndex;

                    public class number
                    {
                        public int TopLeftX;
                        public int TopLeftY;
                        public int BottomRightX;
                        public int BottomRightY;
                        public string Alignment;
                        public int SpacingX;
                        public int SpacingY;
                        public int ImageIndex;
                        public int ImagesCount;
                    }
                }

                public class today
                {
                    public oneline OneLine;
                    public separate Separate;

                    public class oneline
                    {
                        public number Number;
                        public int MinusImageIndex;
                        public int DelimiterImageIndex;
                        public bool AppendDegreesForBoth = true;
                        public int DegreesImageIndex;

                        public class number
                        {
                            public int TopLeftX;
                            public int TopLeftY;
                            public int BottomRightX;
                            public int BottomRightY;
                            public string Alignment;
                            public int SpacingX;
                            public int SpacingY;
                            public int ImageIndex;
                            public int ImagesCount;
                        }
                    }

                    public class separate
                    {
                        public day Day;
                        public day Night;

                        public class day
                        {
                            public number Number;
                            public int MinusImageIndex;
                            public int DegreesImageIndex;
                        }

                        public class number
                        {
                            public int TopLeftX;
                            public int TopLeftY;
                            public int BottomRightX;
                            public int BottomRightY;
                            public string Alignment;
                            public int SpacingX;
                            public int SpacingY;
                            public int ImageIndex;
                            public int ImagesCount;
                        }
                    }
                }
            }
        
            public class humidity
            {
                public text Text;
                public int SuffixImageIndex;

                public class text
                {
                    public int TopLeftX;
                    public int TopLeftY;
                    public int BottomRightX;
                    public int BottomRightY;
                    public string Alignment;
                    public int SpacingX;
                    public int SpacingY;
                    public int ImageIndex;
                    public int ImagesCount;
                }
            }

            public class wind
            {
                public text Text;
                public int ImageSuffixEN;

                public class text
                {
                    public int TopLeftX;
                    public int TopLeftY;
                    public int BottomRightX;
                    public int BottomRightY;
                    public string Alignment;
                    public int SpacingX;
                    public int SpacingY;
                    public int ImageIndex;
                    public int ImagesCount;
                }
            }

            public class uvindex
            {
                public uv UV;

                public class uv
                {
                    public text Text;

                    public class text
                    {
                        public int TopLeftX;
                        public int TopLeftY;
                        public int BottomRightX;
                        public int BottomRightY;
                        public string Alignment;
                        public int SpacingX;
                        public int SpacingY;
                        public int ImageIndex;
                        public int ImagesCount;
                    }
                }
            }
        }
    
        public class stepsprogress
        {
            public linescale LineScale;
            public linear Linear;
            public circlescale CircleScale;

            public class linescale
            {
                public int X;
                public int Y;
                public int ImageIndex;
                public int ImagesCount;
            }

            public class linear
            {
                public int StartImageIndex;

                public List<coords> Segments;

                public struct coords
                {
                    public int X;
                    public int Y;
                }
            }

            public class circlescale
            {
                public int CenterX;
                public int CenterY;
                public int RadiusX;
                public int RadiusY;
                public int StartAngle;
                public int EndAngle;
                public int Width;
                public string Color;
            }
        }
    
        public class alarm
        {
            public text Text;
            public int DelimiterImageIndex;
            public imagealarm ImageOn;
            public imagealarm ImageOff;
            public imagealarm ImageNoAlarm;
            public int UnknownTF6 = 1;
            public int UnknownTF7 = 1;

            public class text
            {
                public int TopLeftX;
                public int TopLeftY;
                public int BottomRightX;
                public int BottomRightY;
                public string Alignment;
                public int SpacingX;
                public int SpacingY;
                public int ImageIndex;
                public int ImagesCount;
            }

            public class imagealarm
            {
                public int X;
                public int Y;
                public int ImageIndex;
            }
        }
    
        public class analogdialface
        {
            public arrowhour Hours;
            public arrowmin Minutes;

            public class arrowhour
            {
                public bool OnlyBorder;
                public string color;
                public coords Center;
                public List<coords> Shape;


                public class coords
                {
                    public int X;
                    public int Y;
                }
            }
            public class arrowmin
            {
                public bool OnlyBorder;
                public string color;
                public coords Center;
                public List<coords> Shape;
                public centerimage CenterImage;

                public class centerimage
                {
                    public int X;
                    public int Y;
                    public int ImageIndex;
                }

                public class coords
                {
                    public int X;
                    public int Y;
                }
            }
        }

        public class other
        {
            public List<animation> Animation;

            public class animation
            {
                public images AnimationImages;
                public int Speed = 1;
                public int RepeatCount = 255;
                public int UnknownTF4 = 1;

                public class images
                {
                    public int X;
                    public int Y;
                    public int ImageIndex;
                    public int ImagesCount;
                }
            }
        }
    
        public class statussimplified
        {
            public widget Lock;

            public class widget
            {
                public statusimage StatusImage;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int ImageIndexOff;

                [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
                [DefaultValue(-1)]
                public int imageIndexOn;

                public class statusimage
                {
                    public int X;
                    public int Y;
                    public string Alignment = "TopLeft";
                    public int Unknown4 = 2;
                    public int Unknown5 = 6;
                }
            }
        }
    }
}
