﻿using Newtonsoft.Json;
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
    public partial class WeatherForm : Form
    {
        public WatchFaceLibrary watch;
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

        StateWatchface state;
        VisualRender render;
        public bool Save;
        string oldWeather;

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

        public WeatherForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.watch.images = Images;
            this.state = state;

            this.watch.Weather = watch.Weather == null ? new Weather() : watch.Weather;

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
            }

            oldWeather = JsonConvert.SerializeObject(this.watch.Weather, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            Render(state);

            //form fill data

            if (watch.Weather.Icon != null)
            {
                WeatherIconCheckbox.Checked = watch.Weather.Icon != null;
                AddWeatherCustomIconButton.Text = res.GetString("EditImages");
            }
            if (watch.Weather.Temperature != null)
            {
                if (watch.Weather.Temperature?.Today?.Separate?.Day != null)
                {
                    AddDegreeImageTemperatureTodaySeparateDayButton.Enabled = true;
                    AddMinusImageTemperatureTodaySeparateDayButton.Enabled = true;

                    AddNumberTemperatureTodaySeparateDayButton.Text = res.GetString("EditNumber");

                    if (watch.Weather.Temperature.Today.Separate.Day.DegreesImageIndex >= 0)
                        AddDegreeImageTemperatureTodaySeparateDayButton.Text = res.GetString("EditDegreeImage");

                    if (watch.Weather.Temperature.Today.Separate.Day.MinusImageIndex >= 0)
                        AddMinusImageTemperatureTodaySeparateDayButton.Text = res.GetString("EditMinusImage");

                    TemperatureTodaySeparateDayCheckbox.Checked = watch.Weather.Temperature?.Today?.Separate?.Day != null;
                }
                if (watch.Weather.Temperature?.Today?.Separate?.Night != null)
                {
                    AddDegreeImageTemperatureTodaySeparateNightButton.Enabled = true;
                    AddMinusImageTemperatureTodaySeparateNightButton.Enabled = true;

                    AddNumberTemperatureTodaySeparateNightButton.Text = res.GetString("EditNumber");
                    if (watch.Weather.Temperature.Today.Separate.Night.DegreesImageIndex >= 0)
                        AddDegreeImageTemperatureTodaySeparateNightButton.Text = res.GetString("EditDegreeImage");
                    if (watch.Weather.Temperature.Today.Separate.Night.MinusImageIndex >= 0)
                        AddMinusImageTemperatureTodaySeparateNightButton.Text = res.GetString("EditMinusImage");
                    TemperatureTodaySeparateNightCheckbox.Checked = watch.Weather.Temperature?.Today?.Separate?.Night != null;
                }
                if (watch.Weather.Temperature?.Today?.OneLine != null)
                {
                    TemperatureTodayOnelineCheckbox.Checked = watch.Weather.Temperature?.Today?.OneLine != null;
                    AddMinusImageTemperatureTodayOnelineButton.Enabled = true;
                    AddDelimeterImageTemperatureTodayOnelineButton.Enabled = true;
                    AddDegreeImageTemperatureTodayOnelineButton.Enabled = true;

                    AddNumberTemperatureTodayOnelineButton.Text = res.GetString("EditNumber");
                    if (watch.Weather.Temperature.Today.OneLine.MinusSignImageIndex >= 0)
                        AddMinusImageTemperatureTodayOnelineButton.Text = res.GetString("EditMinusImage");

                    if (watch.Weather.Temperature.Today.OneLine.DelimiterImageIndex >= 0)
                        AddDelimeterImageTemperatureTodayOnelineButton.Text = res.GetString("EditDelimeterImage");

                    if (watch.Weather.Temperature.Today.OneLine.DegreesImageIndex >= 0)
                        AddDegreeImageTemperatureTodayOnelineButton.Text = res.GetString("EditDegreeImage");

                    if (AddDegreeImageTemperatureTodayOnelineButton.Enabled)
                        AddForBothTemperatureTodayOnelineCheckBox.Enabled = true;

                    AddForBothTemperatureTodayOnelineCheckBox.Checked = watch.Weather.Temperature.Today.OneLine.AppendDegreesForBoth;
                }
                if (watch.Weather.Temperature?.Current != null)
                {
                    TemperatureCurrentCheckbox.Checked = watch.Weather.Temperature?.Current != null;
                    AddMinusImageTemperatureCurrentButton.Enabled = true;
                    AddDegreeImageTemperatureCurrentButton.Enabled = true;

                    AddNumberTemperatureCurrentButton.Text = res.GetString("EditNumber");
                    if (watch.Weather.Temperature.Current.MinusImageIndex >= 0)
                        AddMinusImageTemperatureCurrentButton.Text = res.GetString("EditMinusImage");
                    if (watch.Weather.Temperature.Current.DegreesImageIndex >= 0)
                        AddDegreeImageTemperatureCurrentButton.Text = res.GetString("EditDegreeImage");
                }
            }
            if (watch.Weather?.Humidity != null)
            {
                HumidityCheckbox.Checked = watch.Weather?.Humidity != null;
                AddSuffixHumidityButton.Enabled = true;
                AddSuffixImageHumidityButton.Enabled = true;

                AddNumberHumidityButton.Text = res.GetString("EditNumber");
                if (watch.Weather.Humidity.SuffixImageIndex >= 0)
                    AddSuffixHumidityButton.Text = res.GetString("EditSuffix");
                if (watch.Weather.Humidity.ImageSuffix != null)
                    AddSuffixImageHumidityButton.Text = res.GetString("EditSuffixImage");
            }
            if (watch.Weather?.Wind != null)
            {
                WindCheckbox.Checked = watch.Weather?.Wind != null;
                AddSuffixWindButton.Enabled = true;
                AddSuffixCN1WindButton.Enabled = true;
                AddSuffixCN2WindButton.Enabled = true;

                AddNumberWindButton.Text = res.GetString("EditNumber");
                if (watch.Weather.Wind.ImageSuffixEN >= 0)
                    AddSuffixWindButton.Text = res.GetString("EditSuffix");
                if (watch.Weather.Wind.ImageSuffixCN1 >= 0)
                    AddSuffixCN1WindButton.Text = res.GetString("EditSuffix") + " CN 1";
                if (watch.Weather.Wind.ImageSuffixCN2 >= 0)
                    AddSuffixCN2WindButton.Text = res.GetString("EditSuffix") + " CN 2";
            }
            if (watch.Weather?.AirPollution != null)
            {
                AirCheckbox.Checked = watch.Weather?.AirPollution != null;
                AddAirIcons.Enabled = true;

                AddAirNumber.Text = res.GetString("EditNumber");
                if (watch.Weather.AirPollution.Icon != null)
                    AddAirIcons.Text = res.GetString("EditImages");
            }
            if (watch.Weather?.UVIndex != null)
            {
                UVIndexCheckbox.Checked = watch.Weather?.UVIndex?.UV != null;
                if (watch.Weather.UVIndex.UV != null)
                {
                    AddSuffixUVButton.Enabled = true;

                    AddNumberUVButton.Text = res.GetString("EditNumber");
                    if (watch.Weather.UVIndex.UV.SuffixImageIndex >= 0)
                        AddSuffixUVButton.Text = res.GetString("EditSuffix");
                }
                if (watch.Weather.UVIndex.UVCN != null)
                {
                    AddUVCN.Text = res.GetString("EditUVCN");
                }
                if (watch.Weather.UVIndex.UVCN2 != null)
                {
                    AddUVCN2.Text = res.GetString("EditUVCN")+" 2";
                }
            }
        }

        private void AddWeatherCustomIconButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);

            watchface.Weather.Icon = watchface.Weather.Icon == null ? new WeatherIcon() : watchface.Weather.Icon;
            watchface.Weather.Icon.CustomIcon = watchface.Weather.Icon.CustomIcon == null ? new ImageSet() : watchface.Weather.Icon.CustomIcon;
            ImageSetForm imgSetForm = new ImageSetForm(watchface, watchface.Weather.Icon.CustomIcon, watch.images.DeepCopy(), state, 26);
            imgSetForm.ShowDialog();

            if (imgSetForm.saved == true && imgSetForm.imageSet.ImageIndex >= 0)
            {
                watch.Weather.Icon = watch.Weather.Icon == null ? new WeatherIcon() : watch.Weather.Icon;
                watch.Weather.Icon.CustomIcon = imgSetForm.imageSet;
                watch.images = imgSetForm.watch.images;
                watch.Weather.Icon.Unknown3 = new XY() { X = imgSetForm.imageSet.X, Y = imgSetForm.imageSet.Y };
                watch.Weather.Icon.Unknown4 = new XY() { X = imgSetForm.imageSet.X, Y = imgSetForm.imageSet.Y };

                AddWeatherCustomIconButton.Text = res.GetString("EditImages");
            }
            else if (imgSetForm.delete)
            {
                watch.Weather.Icon = null;
                watch.images = imgSetForm.watch.images;
                AddWeatherCustomIconButton.Text = res.GetString("AddImages");
            }

            Render(state);
        }

        private void AddNumberClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            WatchFaceLibrary watchface = DeepCopy(watch);

            if (btn.Name == AddNumberTemperatureTodaySeparateDayButton.Name)
            {
                watchface.Weather.Temperature = watchface.Weather.Temperature == null ? new Temperature() : watchface.Weather.Temperature;
                watchface.Weather.Temperature.Today = watchface.Weather.Temperature.Today == null ? new TodayTemperature() : watchface.Weather.Temperature.Today;
                watchface.Weather.Temperature.Today.Separate = watchface.Weather.Temperature.Today.Separate == null ? new SeparateTemperature() : watchface.Weather.Temperature.Today.Separate;
                watchface.Weather.Temperature.Today.Separate.Day = watchface.Weather.Temperature.Today.Separate.Day == null ? new TemperatureNumber() : watchface.Weather.Temperature.Today.Separate.Day;
                watchface.Weather.Temperature.Today.Separate.Day.Number = watchface.Weather.Temperature.Today.Separate.Day.Number == null ? new Number() { notDraw = true } : watchface.Weather.Temperature.Today.Separate.Day.Number;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Temperature.Today.Separate.Day.Number, watch.images.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex >= 0)
                {
                    watch.Weather.Temperature = watch.Weather.Temperature == null ? new Temperature() : watch.Weather.Temperature;
                    watch.Weather.Temperature.Today = watch.Weather.Temperature.Today == null ? new TodayTemperature() : watch.Weather.Temperature.Today;
                    watch.Weather.Temperature.Today.Separate = watch.Weather.Temperature.Today.Separate == null ? new SeparateTemperature() : watch.Weather.Temperature.Today.Separate;
                    watch.Weather.Temperature.Today.Separate.Day = watch.Weather.Temperature.Today.Separate.Day == null ? new TemperatureNumber() : watch.Weather.Temperature.Today.Separate.Day;
                    watch.Weather.Temperature.Today.Separate.Day.Number = numberForm.number;
                    watch.images = numberForm.watch.images;
                    AddNumberTemperatureTodaySeparateDayButton.Text = res.GetString("EditNumber");
                    AddMinusImageTemperatureTodaySeparateDayButton.Enabled = true;
                    AddDegreeImageTemperatureTodaySeparateDayButton.Enabled = true;
                }
                else if (numberForm.delete)
                {
                    if (watch.Weather?.Temperature?.Today?.Separate?.Day != null)
                        watch.Weather.Temperature.Today.Separate.Day = null;
                    watch.images = numberForm.watch.images;
                    AddNumberTemperatureTodaySeparateDayButton.Text = res.GetString("AddNumber");
                    AddMinusImageTemperatureTodaySeparateDayButton.Enabled = false;
                    AddDegreeImageTemperatureTodaySeparateDayButton.Enabled = false;
                }
            }
            else if (btn.Name == AddNumberTemperatureTodaySeparateNightButton.Name)
            {
                watchface.Weather.Temperature = watchface.Weather.Temperature == null ? new Temperature() : watchface.Weather.Temperature;
                watchface.Weather.Temperature.Today = watchface.Weather.Temperature.Today == null ? new TodayTemperature() : watchface.Weather.Temperature.Today;
                watchface.Weather.Temperature.Today.Separate = watchface.Weather.Temperature.Today.Separate == null ? new SeparateTemperature() : watchface.Weather.Temperature.Today.Separate;
                watchface.Weather.Temperature.Today.Separate.Night = watchface.Weather.Temperature.Today.Separate.Night == null ? new TemperatureNumber() : watchface.Weather.Temperature.Today.Separate.Night;
                watchface.Weather.Temperature.Today.Separate.Night.Number = watchface.Weather.Temperature.Today.Separate.Night.Number == null ? new Number() { notDraw = true } : watchface.Weather.Temperature.Today.Separate.Night.Number;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Temperature.Today.Separate.Night.Number, watch.images.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex >= 0)
                {
                    watch.Weather.Temperature = watch.Weather.Temperature == null ? new Temperature() : watch.Weather.Temperature;
                    watch.Weather.Temperature.Today = watch.Weather.Temperature.Today == null ? new TodayTemperature() : watch.Weather.Temperature.Today;
                    watch.Weather.Temperature.Today.Separate = watch.Weather.Temperature.Today.Separate == null ? new SeparateTemperature() : watch.Weather.Temperature.Today.Separate;
                    watch.Weather.Temperature.Today.Separate.Night = watch.Weather.Temperature.Today.Separate.Night == null ? new TemperatureNumber() : watch.Weather.Temperature.Today.Separate.Night;
                    watch.Weather.Temperature.Today.Separate.Night.Number = numberForm.number;
                    watch.images = numberForm.watch.images;
                    AddNumberTemperatureTodaySeparateNightButton.Text = res.GetString("EditNumber");
                    AddMinusImageTemperatureTodaySeparateNightButton.Enabled = true;
                    AddDegreeImageTemperatureTodaySeparateNightButton.Enabled = true;
                }
                else if (numberForm.delete)
                {
                    if (watch.Weather?.Temperature?.Today?.Separate?.Night != null)
                        watch.Weather.Temperature.Today.Separate.Night = null;
                    watch.images = numberForm.watch.images;
                    AddNumberTemperatureTodaySeparateNightButton.Text = res.GetString("AddNumber");
                    AddMinusImageTemperatureTodaySeparateNightButton.Enabled = false;
                    AddDegreeImageTemperatureTodaySeparateNightButton.Enabled = false;
                }
            }
            else if (btn.Name == AddNumberTemperatureTodayOnelineButton.Name)
            {
                watchface.Weather.Temperature = watchface.Weather.Temperature == null ? new Temperature() : watchface.Weather.Temperature;
                watchface.Weather.Temperature.Today = watchface.Weather.Temperature.Today == null ? new TodayTemperature() : watchface.Weather.Temperature.Today;
                watchface.Weather.Temperature.Today.OneLine = watchface.Weather.Temperature.Today.OneLine == null ? new OneLineTemperature() : watchface.Weather.Temperature.Today.OneLine;
                watchface.Weather.Temperature.Today.OneLine.Number = watchface.Weather.Temperature.Today.OneLine.Number == null ? new Number() { notDraw = true } : watchface.Weather.Temperature.Today.OneLine.Number;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Temperature.Today.OneLine.Number, watch.images.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex >= 0)
                {
                    watch.Weather.Temperature = watch.Weather.Temperature == null ? new Temperature() : watch.Weather.Temperature;
                    watch.Weather.Temperature.Today = watch.Weather.Temperature.Today == null ? new TodayTemperature() : watch.Weather.Temperature.Today;
                    watch.Weather.Temperature.Today.OneLine = watch.Weather.Temperature.Today.OneLine == null ? new OneLineTemperature() : watch.Weather.Temperature.Today.OneLine;
                    watch.Weather.Temperature.Today.OneLine.Number = numberForm.number;
                    watch.images = numberForm.watch.images;
                    AddNumberTemperatureTodayOnelineButton.Text = res.GetString("EditNumber");
                    AddMinusImageTemperatureTodayOnelineButton.Enabled = true;
                    AddDegreeImageTemperatureTodayOnelineButton.Enabled = true;
                    AddDelimeterImageTemperatureTodayOnelineButton.Enabled = true;
                    AddForBothTemperatureTodayOnelineCheckBox.Enabled = true;
                }
                else if (numberForm.delete)
                {
                    if (watch.Weather?.Temperature?.Today?.OneLine != null)
                        watch.Weather.Temperature.Today.OneLine = null;
                    watch.images = numberForm.watch.images;
                    AddNumberTemperatureTodayOnelineButton.Text = res.GetString("AddNumber");
                    AddMinusImageTemperatureTodayOnelineButton.Enabled = false;
                    AddDegreeImageTemperatureTodayOnelineButton.Enabled = false;
                    AddDelimeterImageTemperatureTodayOnelineButton.Enabled = false;
                    AddForBothTemperatureTodayOnelineCheckBox.Enabled = false;
                }
            }
            else if (btn.Name == AddNumberTemperatureCurrentButton.Name)
            {
                watchface.Weather.Temperature = watchface.Weather.Temperature == null ? new Temperature() : watchface.Weather.Temperature;
                watchface.Weather.Temperature.Current = watchface.Weather.Temperature.Current == null ? new TemperatureNumber() : watchface.Weather.Temperature.Current;
                watchface.Weather.Temperature.Current.Number = watchface.Weather.Temperature.Current.Number == null ? new Number() { notDraw = true } : watchface.Weather.Temperature.Current.Number;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Temperature.Current.Number, watch.images.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex >= 0)
                {
                    watch.Weather.Temperature = watch.Weather.Temperature == null ? new Temperature() : watch.Weather.Temperature;
                    watch.Weather.Temperature.Current = watch.Weather.Temperature.Current == null ? new TemperatureNumber() : watch.Weather.Temperature.Current;
                    watch.Weather.Temperature.Current.Number = numberForm.number;
                    watch.images = numberForm.watch.images;
                    AddNumberTemperatureCurrentButton.Text = res.GetString("EditNumber");
                    AddMinusImageTemperatureCurrentButton.Enabled = true;
                    AddDegreeImageTemperatureCurrentButton.Enabled = true;
                }
                else if (numberForm.delete)
                {
                    if (watch.Weather?.Temperature?.Current != null)
                        watch.Weather.Temperature.Current = null;
                    watch.images = numberForm.watch.images;
                    AddNumberTemperatureCurrentButton.Text = res.GetString("AddNumber");
                    AddMinusImageTemperatureCurrentButton.Enabled = true;
                    AddDegreeImageTemperatureCurrentButton.Enabled = true;
                }
            }
            else if (btn.Name == AddNumberHumidityButton.Name)
            {
                watchface.Weather.Humidity = watchface.Weather.Humidity == null ? new Humidity() : watchface.Weather.Humidity;
                watchface.Weather.Humidity.Text = watchface.Weather.Humidity.Text == null ? new Number() { notDraw = true } : watchface.Weather.Humidity.Text;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Humidity.Text, watch.images.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex >= 0)
                {
                    watch.Weather.Humidity = watch.Weather.Humidity == null ? new Humidity() : watch.Weather.Humidity;
                    watch.Weather.Humidity.Text = numberForm.number;
                    watch.images = numberForm.watch.images;
                    AddNumberHumidityButton.Text = res.GetString("EditNumber");
                    AddSuffixHumidityButton.Enabled = true;
                    AddSuffixImageHumidityButton.Enabled = true;
                }
                else if (numberForm.delete)
                {
                    watch.Weather.Humidity = null;
                    watch.images = numberForm.watch.images;
                    AddNumberHumidityButton.Text = res.GetString("AddNumber");
                    AddSuffixHumidityButton.Enabled = false;
                    AddSuffixImageHumidityButton.Enabled = false;
                }
            }
            else if (btn.Name == AddNumberWindButton.Name)
            {
                watchface.Weather.Wind = watchface.Weather.Wind == null ? new Wind() : watchface.Weather.Wind;
                watchface.Weather.Wind.Text = watchface.Weather.Wind.Text == null ? new Number() { notDraw = true } : watchface.Weather.Wind.Text;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Wind.Text, watch.images.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex >= 0)
                {
                    watch.Weather.Wind = watch.Weather.Wind == null ? new Wind() : watch.Weather.Wind;
                    watch.Weather.Wind.Text = numberForm.number;
                    watch.images = numberForm.watch.images;
                    AddNumberWindButton.Text = res.GetString("EditNumber");
                    AddSuffixWindButton.Enabled = true;
                    AddSuffixCN1WindButton.Enabled = true;
                    AddSuffixCN2WindButton.Enabled = true;
                }
                else if (numberForm.delete)
                {
                    watch.Weather.Wind = null;
                    watch.images = numberForm.watch.images;
                    AddNumberWindButton.Text = res.GetString("AddNumber");
                    AddSuffixWindButton.Enabled = false;
                    AddSuffixCN1WindButton.Enabled = false;
                    AddSuffixCN2WindButton.Enabled = false;
                }
            }
            else if (btn.Name == AddNumberUVButton.Name)
            {
                watchface.Weather.UVIndex = watchface.Weather.UVIndex == null ? new UVWrapper() : watchface.Weather.UVIndex;
                watchface.Weather.UVIndex.UV = watchface.Weather.UVIndex.UV == null ? new UVIndex() : watchface.Weather.UVIndex.UV;
                watchface.Weather.UVIndex.UV.Text = watchface.Weather.UVIndex.UV.Text == null ? new Number() { notDraw = true } : watchface.Weather.UVIndex.UV.Text;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.UVIndex.UV.Text, watch.images.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex >= 0)
                {
                    watch.Weather.UVIndex = watch.Weather.UVIndex == null ? new UVWrapper() : watch.Weather.UVIndex;
                    watch.Weather.UVIndex.UV = watch.Weather.UVIndex.UV == null ? new UVIndex() : watch.Weather.UVIndex.UV;
                    watch.Weather.UVIndex.UV.Text = numberForm.number;
                    watch.images = numberForm.watch.images;
                    AddNumberUVButton.Text = res.GetString("EditNumber");
                    AddSuffixUVButton.Enabled = true;
                }
                else if (numberForm.delete)
                {
                    watch.Weather.UVIndex = null;
                    watch.images = numberForm.watch.images;
                    AddNumberUVButton.Text = res.GetString("AddNumber");
                    AddSuffixUVButton.Enabled = false;
                }
            }
            else if (btn.Name == AddAirNumber.Name)
            {
                watchface.Weather.AirPollution = watchface.Weather.AirPollution == null ? new AirPollution() : watchface.Weather.AirPollution;
                watchface.Weather.AirPollution.Index = watchface.Weather.AirPollution.Index == null ? new Number() { notDraw = true } : watchface.Weather.AirPollution.Index;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.AirPollution.Index, watch.images.DeepCopy(), state);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex >= 0)
                {
                    watch.Weather.AirPollution = watch.Weather.AirPollution == null ? new AirPollution() : watch.Weather.AirPollution;
                    watch.Weather.AirPollution.Index = numberForm.number;
                    watch.images = numberForm.watch.images;
                    AddAirNumber.Text = res.GetString("EditNumber");
                }
                else if (numberForm.delete)
                {
                    if (watch.Weather.AirPollution != null) watch.Weather.AirPollution.Index = null;
                    watch.images = numberForm.watch.images;
                    AddAirNumber.Text = res.GetString("AddNumber");
                }
            }

            Render(state);
        }

        private void AddImageClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            List<int> selImg = null;
            ImagesForm imgForm;

            if (btn.Name == AddMinusImageTemperatureTodaySeparateDayButton.Name)
            {
                if (watch.Weather.Temperature.Today.Separate.Day.MinusImageIndex >= 0) selImg = new List<int>() { watch.Weather.Temperature.Today.Separate.Day.MinusImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Day.MinusImageIndex = imgForm.selectedImages[0];
                    AddMinusImageTemperatureTodaySeparateDayButton.Text = res.GetString("EditMinusImage");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Day.MinusImageIndex = -10000;
                    AddMinusImageTemperatureTodaySeparateDayButton.Text = res.GetString("AddMinusImage");
                }
            }
            else if (btn.Name == AddUVCN.Name)
            {
                WatchFaceLibrary watchface = DeepCopy(watch);
                watchface.Weather.UVIndex = watchface.Weather.UVIndex == null ? new UVWrapper() : watchface.Weather.UVIndex;
                watchface.Weather.UVIndex.UVCN = watchface.Weather.UVIndex.UVCN == null ? new ImageSet() : watchface.Weather.UVIndex.UVCN;
                ImageSetForm setForm = new ImageSetForm(watchface, watchface.Weather.UVIndex.UVCN, watch.images.DeepCopy(), state);
                setForm.ShowDialog();

                if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
                {
                    watch.images = setForm.watch.images;
                    watchface.Weather.UVIndex.UVCN = setForm.imageSet;
                    AddUVCN.Text = res.GetString("EditUVCN");
                }
                else if (setForm.delete)
                {
                    watch.images = setForm.watch.images;
                    watchface.Weather.UVIndex.UVCN = null;
                    AddUVCN.Text = res.GetString("AddUVCN");
                }

                Render(state);
            }
            else if (btn.Name == AddUVCN2.Name)
            {
                WatchFaceLibrary watchface = DeepCopy(watch);
                watchface.Weather.UVIndex = watchface.Weather.UVIndex == null ? new UVWrapper() : watchface.Weather.UVIndex;
                watchface.Weather.UVIndex.UVCN2 = watchface.Weather.UVIndex.UVCN2 == null ? new ImageSet() : watchface.Weather.UVIndex.UVCN2;
                ImageSetForm setForm = new ImageSetForm(watchface, watchface.Weather.UVIndex.UVCN2, watch.images.DeepCopy(), state);
                setForm.ShowDialog();

                if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
                {
                    watch.images = setForm.watch.images;
                    watchface.Weather.UVIndex.UVCN2 = setForm.imageSet;
                    AddUVCN2.Text = res.GetString("EditUVCN")+" 2";
                }
                else if (setForm.delete)
                {
                    watch.images = setForm.watch.images;
                    watchface.Weather.UVIndex.UVCN2 = null;
                    AddUVCN2.Text = res.GetString("AddUVCN") + " 2";
                }

                Render(state);
            }
            else if (btn.Name == AddMinusImageTemperatureTodaySeparateNightButton.Name)
            {
                if (watch.Weather.Temperature.Today.Separate.Night.MinusImageIndex >= 0) selImg = new List<int>() { watch.Weather.Temperature.Today.Separate.Night.MinusImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Night.MinusImageIndex = imgForm.selectedImages[0];
                    AddMinusImageTemperatureTodaySeparateNightButton.Text = res.GetString("EditMinusImage");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Night.MinusImageIndex = -10000;
                    AddMinusImageTemperatureTodaySeparateNightButton.Text = res.GetString("AddMinusImage");
                }
            }
            else if (btn.Name == AddDegreeImageTemperatureTodaySeparateDayButton.Name)
            {
                if (watch.Weather.Temperature.Today.Separate.Day.DegreesImageIndex >= 0) selImg = new List<int>() { watch.Weather.Temperature.Today.Separate.Day.DegreesImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Day.DegreesImageIndex = imgForm.selectedImages[0];
                    AddDegreeImageTemperatureTodaySeparateDayButton.Text = res.GetString("EditDegreeImage");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Day.DegreesImageIndex = -10000;
                    AddDegreeImageTemperatureTodaySeparateDayButton.Text = res.GetString("AddDegreeImage");
                }
            }
            else if (btn.Name == AddDegreeImageTemperatureTodaySeparateNightButton.Name)
            {
                if (watch.Weather.Temperature.Today.Separate.Night.DegreesImageIndex >= 0) selImg = new List<int>() { watch.Weather.Temperature.Today.Separate.Night.DegreesImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Night.DegreesImageIndex = imgForm.selectedImages[0];
                    AddDegreeImageTemperatureTodaySeparateNightButton.Text = res.GetString("EditDegreeImage");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Night.DegreesImageIndex = -10000;
                    AddDegreeImageTemperatureTodaySeparateNightButton.Text = res.GetString("AddDegreeImage");
                }
            }
            else if (btn.Name == AddMinusImageTemperatureTodayOnelineButton.Name)
            {
                if (watch.Weather.Temperature.Today.OneLine.MinusSignImageIndex >= 0) selImg = new List<int>() { watch.Weather.Temperature.Today.OneLine.MinusSignImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.MinusSignImageIndex = imgForm.selectedImages[0];
                    AddMinusImageTemperatureTodayOnelineButton.Text = res.GetString("EditMinusImage");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.MinusSignImageIndex = -10000;
                    AddMinusImageTemperatureTodayOnelineButton.Text = res.GetString("AddMinusImage");
                }
            }
            else if (btn.Name == AddDelimeterImageTemperatureTodayOnelineButton.Name)
            {
                if (watch.Weather.Temperature.Today.OneLine.DelimiterImageIndex >= 0) selImg = new List<int>() { watch.Weather.Temperature.Today.OneLine.DelimiterImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.DelimiterImageIndex = imgForm.selectedImages[0];
                    AddDelimeterImageTemperatureTodayOnelineButton.Text = res.GetString("EditDelimeterImage");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.DelimiterImageIndex = -10000;
                    AddDelimeterImageTemperatureTodayOnelineButton.Text = res.GetString("AddDelimeterImage");
                }
            }
            else if (btn.Name == AddDegreeImageTemperatureTodayOnelineButton.Name)
            {
                if (watch.Weather.Temperature.Today.OneLine.DegreesImageIndex >= 0) selImg = new List<int>() { watch.Weather.Temperature.Today.OneLine.DegreesImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.DegreesImageIndex = imgForm.selectedImages[0];
                    AddDegreeImageTemperatureTodayOnelineButton.Text = res.GetString("EditDegreeImage");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.DegreesImageIndex = -10000;
                    AddDegreeImageTemperatureTodayOnelineButton.Text = res.GetString("AddDegreeImage");
                }
            }
            else if (btn.Name == AddMinusImageTemperatureCurrentButton.Name)
            {
                if (watch.Weather.Temperature.Current.MinusImageIndex >= 0) selImg = new List<int>() { watch.Weather.Temperature.Current.MinusImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Current.MinusImageIndex = imgForm.selectedImages[0];
                    AddMinusImageTemperatureCurrentButton.Text = res.GetString("EditMinusImage");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Current.MinusImageIndex = -10000;
                    AddMinusImageTemperatureCurrentButton.Text = res.GetString("AddMinusImage");
                }
            }
            else if (btn.Name == AddDegreeImageTemperatureCurrentButton.Name)
            {
                if (watch.Weather.Temperature.Current.DegreesImageIndex >= 0) selImg = new List<int>() { watch.Weather.Temperature.Current.DegreesImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Current.DegreesImageIndex = imgForm.selectedImages[0];
                    AddDegreeImageTemperatureCurrentButton.Text = res.GetString("EditDegreeImage");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Temperature.Current.DegreesImageIndex = -10000;
                    AddDegreeImageTemperatureCurrentButton.Text = res.GetString("AddDegreeImage");
                }
            }
            else if (btn.Name == AddSuffixHumidityButton.Name)
            {
                if (watch.Weather.Humidity.SuffixImageIndex >= 0) selImg = new List<int>() { watch.Weather.Humidity.SuffixImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Humidity.SuffixImageIndex = imgForm.selectedImages[0];
                    AddSuffixHumidityButton.Text = res.GetString("EditSuffix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Humidity.SuffixImageIndex = -10000;
                    AddSuffixHumidityButton.Text = res.GetString("AddSuffix");
                }
            }
            else if (btn.Name == AddSuffixWindButton.Name)
            {
                if (watch.Weather.Wind.ImageSuffixEN >= 0) selImg = new List<int>() { watch.Weather.Wind.ImageSuffixEN };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Wind.ImageSuffixEN = imgForm.selectedImages[0];
                    AddSuffixWindButton.Text = res.GetString("EditSuffix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Wind.ImageSuffixEN = -10000;
                    AddSuffixWindButton.Text = res.GetString("AddSuffix");
                }
            }
            else if (btn.Name == AddSuffixCN1WindButton.Name)
            {
                if (watch.Weather.Wind.ImageSuffixEN >= 0) selImg = new List<int>() { watch.Weather.Wind.ImageSuffixCN1 };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Wind.ImageSuffixCN1 = imgForm.selectedImages[0];
                    AddSuffixCN1WindButton.Text = res.GetString("EditSuffix") + " CN 1";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Wind.ImageSuffixCN1 = -10000;
                    AddSuffixCN1WindButton.Text = res.GetString("AddSuffix") + " CN 2";
                }
            }
            else if (btn.Name == AddSuffixCN2WindButton.Name)
            {
                if (watch.Weather.Wind.ImageSuffixEN >= 0) selImg = new List<int>() { watch.Weather.Wind.ImageSuffixCN2 };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Wind.ImageSuffixCN2 = imgForm.selectedImages[0];
                    AddSuffixCN2WindButton.Text = res.GetString("EditSuffix") + " CN 2";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.Wind.ImageSuffixCN2 = -10000;
                    AddSuffixCN2WindButton.Text = res.GetString("AddSuffix") + " CN 2";
                }
            }
            else if (btn.Name == AddSuffixUVButton.Name)
            {
                if (watch.Weather.UVIndex.UV.SuffixImageIndex >= 0) selImg = new List<int>() { watch.Weather.UVIndex.UV.SuffixImageIndex };

                imgForm = new ImagesForm(watch, watch.images.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.UVIndex.UV.SuffixImageIndex = imgForm.selectedImages[0];
                    AddSuffixUVButton.Text = res.GetString("EditSuffix");
                }
                else if (imgForm.saveImages == true)
                {
                    watch.images = imgForm.Images;
                    watch.Weather.UVIndex.UV.SuffixImageIndex = -10000;
                    AddSuffixUVButton.Text = res.GetString("AddSuffix");
                }
            }

            Render(state);
        }

        private void AddForBothTemperatureTodayOnelineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (watch.Weather?.Temperature?.Today?.OneLine != null)
                watch.Weather.Temperature.Today.OneLine.AppendDegreesForBoth = AddForBothTemperatureTodayOnelineCheckBox.Checked;
        }

        private void AddSuffixImageHumidityButton_Click(object sender, EventArgs e)
        {
            watch.Weather.Humidity.ImageSuffix = watch.Weather.Humidity.ImageSuffix == null ? new ImageBasic() : watch.Weather.Humidity.ImageSuffix;
            ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Weather.Humidity.ImageSuffix, watch.images.DeepCopy(), state);
            ibForm.ShowDialog();

            if (ibForm.saved)
            {
                AddSuffixImageHumidityButton.Text = res.GetString("EditSuffixImage");
                watch.Weather.Humidity.ImageSuffix = ibForm.imageBasic;
                watch.images = ibForm.watch.images;
            }
            else if (ibForm.delete)
            {
                AddSuffixImageHumidityButton.Text = res.GetString("AddSuffixImage");
                watch.Weather.Humidity.ImageSuffix = null;
                watch.images = ibForm.watch.images;
            }

            Render(state);
        }

        private void AddImageSet(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.Weather.AirPollution = watchface.Weather.AirPollution == null ? new AirPollution() : watchface.Weather.AirPollution;
            watchface.Weather.AirPollution.Icon = watchface.Weather.AirPollution.Icon == null ? new ImageSet() : watchface.Weather.AirPollution.Icon;
            ImageSetForm setForm = new ImageSetForm(watchface, watchface.Weather.AirPollution.Icon, watch.images.DeepCopy(), state,10);
            setForm.ShowDialog();

            if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
            {
                watch.images = setForm.watch.images;
                watch.Weather.AirPollution = watch.Weather.AirPollution == null ? new AirPollution() : watch.Weather.AirPollution;
                watch.Weather.AirPollution.Icon = setForm.imageSet;
                AddAirIcons.Text = res.GetString("EditImages");
            }
            else if (setForm.delete)
            {
                watch.images = setForm.watch.images;
                if (watch.Weather.AirPollution != null) watch.Weather.AirPollution.Icon = null;
                AddAirIcons.Text = res.GetString("AddImages");
            }

            Render(state);
        }

        private void GroupBoxChangeCheck(object sender, EventArgs e)
        {
            groupBox1.Enabled = WeatherIconCheckbox.Checked;
            groupBox2.Enabled = TemperatureTodaySeparateDayCheckbox.Checked;
            groupBox3.Enabled = TemperatureCurrentCheckbox.Checked;
            groupBox4.Enabled = TemperatureTodaySeparateNightCheckbox.Checked;
            groupBox5.Enabled = TemperatureTodayOnelineCheckbox.Checked;
            groupBox6.Enabled = HumidityCheckbox.Checked;
            groupBox7.Enabled = WindCheckbox.Checked;
            groupBox8.Enabled = UVIndexCheckbox.Checked;
            groupBox9.Enabled = AirCheckbox.Checked;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save = true;
            if (watch.Weather.Icon == null || WeatherIconCheckbox.Checked == false)
                watch.Weather.Icon = null;

            if (watch.Weather.Temperature != null)
            {
                if ((watch.Weather?.Temperature?.Today?.Separate?.Day == null && watch.Weather?.Temperature?.Today?.Separate?.Night == null) || (TemperatureTodaySeparateDayCheckbox.Checked == false && TemperatureTodaySeparateNightCheckbox.Checked == false))
                    if (watch.Weather?.Temperature?.Today != null)
                        watch.Weather.Temperature.Today.Separate = null;
                if (watch.Weather?.Temperature?.Today?.OneLine == null || AddForBothTemperatureTodayOnelineCheckBox.Checked == false)
                    if (watch.Weather?.Temperature?.Today != null)
                        watch.Weather.Temperature.Today.OneLine = null;
                if ((watch.Weather?.Temperature?.Today?.OneLine == null && watch.Weather?.Temperature?.Today?.Separate == null))
                    watch.Weather.Temperature.Today = null;

                if (watch.Weather?.Temperature?.Current == null || TemperatureCurrentCheckbox.Checked == false)
                    watch.Weather.Temperature.Current = null;

                if (watch.Weather?.Temperature?.Current == null && watch.Weather?.Temperature?.Today == null)
                    watch.Weather.Temperature = null;
            }

            if (HumidityCheckbox.Checked == false)
                watch.Weather.Humidity = null;

            if (WindCheckbox.Checked == false)
                watch.Weather.Wind = null;

            if (UVIndexCheckbox.Checked == false)
                watch.Weather.UVIndex = null;

            if (AirCheckbox.Checked == false || (watch.Weather?.AirPollution?.Icon == null && watch.Weather?.AirPollution?.Index == null))
                watch.Weather.AirPollution = null;

            if (watch.Weather.UVIndex == null && watch.Weather.Wind == null && watch.Weather.Temperature == null && watch.Weather.Icon == null && watch.Weather.Humidity == null)
                watch.Weather = null;
            this.Close();
        }

        private void WeatherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && oldWeather != JsonConvert.SerializeObject(this.watch.Weather, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })  && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (watch.Weather.Icon == null || WeatherIconCheckbox.Checked == false)
                    watch.Weather.Icon = null;

                if (watch.Weather.Temperature != null)
                {
                    if ((watch.Weather?.Temperature?.Today?.Separate?.Day == null && watch.Weather?.Temperature?.Today?.Separate?.Night == null) || (TemperatureTodaySeparateDayCheckbox.Checked == false && TemperatureTodaySeparateNightCheckbox.Checked == false))
                        if (watch.Weather?.Temperature?.Today != null)
                            watch.Weather.Temperature.Today.Separate = null;
                    if (watch.Weather?.Temperature?.Today?.OneLine == null || AddForBothTemperatureTodayOnelineCheckBox.Checked == false)
                        if (watch.Weather?.Temperature?.Today != null)
                            watch.Weather.Temperature.Today.OneLine = null;
                    if ((watch.Weather?.Temperature?.Today?.OneLine == null && watch.Weather?.Temperature?.Today?.Separate == null))
                        watch.Weather.Temperature.Today = null;

                    if (watch.Weather?.Temperature?.Current == null || TemperatureCurrentCheckbox.Checked == false)
                        watch.Weather.Temperature.Current = null;

                    if (watch.Weather?.Temperature?.Current == null && watch.Weather?.Temperature?.Today == null)
                        watch.Weather.Temperature = null;
                }

                if (HumidityCheckbox.Checked == false)
                    watch.Weather.Humidity = null;

                if (WindCheckbox.Checked == false)
                    watch.Weather.Wind = null;

                if (UVIndexCheckbox.Checked == false || (watch.Weather?.UVIndex?.UV == null && watch.Weather?.UVIndex?.UVCN == null && watch.Weather?.UVIndex?.UVCN2 == null))
                    watch.Weather.UVIndex = null;

                if (AirCheckbox.Checked == false || (watch.Weather?.AirPollution?.Icon == null && watch.Weather?.AirPollution?.Index == null))
                    watch.Weather.AirPollution = null;

                if (watch.Weather.UVIndex == null && watch.Weather.Wind == null && watch.Weather.Temperature == null && watch.Weather.Icon == null && watch.Weather.Humidity == null)
                    watch.Weather = null;
            }
        }
    }
}
