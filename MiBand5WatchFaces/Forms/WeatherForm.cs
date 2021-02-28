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
    public partial class WeatherForm : Form
    {
        public WatchFaceLibrary watch;
        public DefaultDictionary<int, Image> Images;

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

        public WeatherForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.watch.imagesBuff = Images;
            this.Images = Images;
            this.state = state;

            this.watch.Weather = watch.Weather == null ? new Weather() : watch.Weather;
            Render(state);

            //form fill data

            if (watch.Weather.Icon != null)
            {
                WeatherIconCheckbox.Checked = watch.Weather.Icon != null;
                AddWeatherCustomIconButton.Text = "Edit images";
            }
            if (watch.Weather.Temperature != null)
            {
                if (watch.Weather.Temperature?.Today?.Separate?.Day != null)
                {
                    AddDegreeImageTemperatureTodaySeparateDayButton.Enabled = true;
                    AddMinusImageTemperatureTodaySeparateDayButton.Enabled = true;

                    AddNumberTemperatureTodaySeparateDayButton.Text = "Edit number";
                    if (watch.Weather.Temperature.Today.Separate.Day.DegreesImageIndex != -10000)
                        AddDegreeImageTemperatureTodaySeparateDayButton.Text = "Edit degree image";
                    if (watch.Weather.Temperature.Today.Separate.Day.MinusImageIndex != -10000)
                        AddMinusImageTemperatureTodaySeparateDayButton.Text = "Edit minus image";
                    TemperatureTodaySeparateDayCheckbox.Checked = watch.Weather.Temperature?.Today?.Separate?.Day != null;
                }
                if (watch.Weather.Temperature?.Today?.Separate?.Night != null)
                {
                    AddDegreeImageTemperatureTodaySeparateNightButton.Enabled = true;
                    AddMinusImageTemperatureTodaySeparateNightButton.Enabled = true;

                    AddNumberTemperatureTodaySeparateNightButton.Text = "Edit Number";
                    if (watch.Weather.Temperature.Today.Separate.Night.DegreesImageIndex != -10000)
                        AddDegreeImageTemperatureTodaySeparateNightButton.Text = "Edit degree image";
                    if (watch.Weather.Temperature.Today.Separate.Night.MinusImageIndex != -10000)
                        AddMinusImageTemperatureTodaySeparateNightButton.Text = "Edit minus image";
                    TemperatureTodaySeparateNightCheckbox.Checked = watch.Weather.Temperature?.Today?.Separate?.Night != null;
                }
                if (watch.Weather.Temperature?.Today?.OneLine != null)
                {
                    TemperatureTodayOnelineCheckbox.Checked = watch.Weather.Temperature?.Today?.OneLine != null;
                    AddMinusImageTemperatureTodayOnelineButton.Enabled = true;
                    AddDelimeterImageTemperatureTodayOnelineButton.Enabled = true;
                    AddDegreeImageTemperatureTodayOnelineButton.Enabled = true;

                    AddNumberTemperatureTodayOnelineButton.Text = "Edit number";
                    if (watch.Weather.Temperature.Today.OneLine.MinusSignImageIndex != -10000)
                        AddMinusImageTemperatureTodayOnelineButton.Text = "Edit minus image";

                    if (watch.Weather.Temperature.Today.OneLine.DelimiterImageIndex != -10000)
                        AddDelimeterImageTemperatureTodayOnelineButton.Text = "Edit delimeter image";

                    if (watch.Weather.Temperature.Today.OneLine.DegreesImageIndex != -10000)
                        AddDegreeImageTemperatureTodayOnelineButton.Text = "Edit degree image";

                    if (AddDegreeImageTemperatureTodayOnelineButton.Enabled)
                        AddForBothTemperatureTodayOnelineCheckBox.Enabled = true;

                    AddForBothTemperatureTodayOnelineCheckBox.Checked = watch.Weather.Temperature.Today.OneLine.AppendDegreesForBoth;
                }
                if (watch.Weather.Temperature?.Current != null)
                {
                    TemperatureCurrentCheckbox.Checked = watch.Weather.Temperature?.Current != null;
                    AddMinusImageTemperatureCurrentButton.Enabled = true;
                    AddDegreeImageTemperatureCurrentButton.Enabled = true;

                    AddNumberTemperatureCurrentButton.Text = "Edit number";
                    if (watch.Weather.Temperature.Current.MinusImageIndex != -10000)
                        AddMinusImageTemperatureCurrentButton.Text = "Edit minus image";
                    if (watch.Weather.Temperature.Current.DegreesImageIndex != -10000)
                        AddDegreeImageTemperatureCurrentButton.Text = "Edit degree image";
                }
                if (watch.Weather?.Humidity != null)
                {
                    HumidityCheckbox.Checked = watch.Weather?.Humidity != null;
                    AddSuffixHumidityButton.Enabled = true;
                    AddSuffixImageHumidityButton.Enabled = true;

                    AddNumberHumidityButton.Text = "Edit number";
                    if (watch.Weather.Humidity.SuffixImageIndex != -10000)
                        AddSuffixHumidityButton.Text = "Edit suffix";
                    if (watch.Weather.Humidity.ImageSuffix != null)
                        AddSuffixImageHumidityButton.Text = "Edit suffix image";
                }
                if (watch.Weather?.Wind != null)
                {
                    WindCheckbox.Checked = watch.Weather?.Wind != null;
                    AddSuffixWindButton.Enabled = true;

                    AddNumberWindButton.Text = "Edit number";
                    if (watch.Weather.Wind.ImageSuffixEN != -10000)
                        AddSuffixWindButton.Text = "Edit suffix";
                }
                if (watch.Weather?.UVIndex?.UV != null)
                {
                    UVIndexCheckbox.Checked = watch.Weather?.UVIndex?.UV != null;
                    AddSuffixUVButton.Enabled = true;

                    AddNumberUVButton.Text = "Edit number";
                    if (watch.Weather.UVIndex.UV.SuffixImageIndex != -10000)
                        AddSuffixUVButton.Text = "Edit suffix";
                }
            }
        }

        private void AddWeatherCustomIconButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);

            watchface.Weather.Icon = watchface.Weather.Icon == null ? new WeatherIcon() : watchface.Weather.Icon;
            ImageSetForm imgSetForm = new ImageSetForm(watchface, watchface.Weather.Icon.CustomIcon, watch.imagesBuff.DeepCopy(), state, 26);
            imgSetForm.ShowDialog();

            if (imgSetForm.saved == true && imgSetForm.imageSet.ImageIndex != -10000)
            {
                watch.Weather.Icon = watch.Weather.Icon == null ? new WeatherIcon() : watch.Weather.Icon;
                watch.Weather.Icon.CustomIcon = imgSetForm.imageSet;
                watch.imagesBuff = imgSetForm.watch.imagesBuff;
                watch.Weather.Icon.Unknown3 = new XY() { X = imgSetForm.imageSet.X, Y = imgSetForm.imageSet.Y };
                watch.Weather.Icon.Unknown4 = new XY() { X = imgSetForm.imageSet.X, Y = imgSetForm.imageSet.Y };

                AddWeatherCustomIconButton.Text = "Edit images";
            }
            else if (imgSetForm.saved)
            {
                watch.Weather.Icon = null;
                watch.imagesBuff = imgSetForm.watch.imagesBuff;
                AddWeatherCustomIconButton.Text = "Add images";
            }

            Render(state);
        }

        private void AddNumberClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            WatchFaceLibrary watchface = DeepCopy(watch);

            if (btn.Name == "AddNumberTemperatureTodaySeparateDayButton")
            {
                watchface.Weather.Temperature = watchface.Weather.Temperature == null ? new Temperature() : watchface.Weather.Temperature;
                watchface.Weather.Temperature.Today = watchface.Weather.Temperature.Today == null ? new TodayTemperature() : watchface.Weather.Temperature.Today;
                watchface.Weather.Temperature.Today.Separate = watchface.Weather.Temperature.Today.Separate == null ? new SeparateTemperature() : watchface.Weather.Temperature.Today.Separate;
                watchface.Weather.Temperature.Today.Separate.Day = watchface.Weather.Temperature.Today.Separate.Day == null ? new TemperatureNumber() : watchface.Weather.Temperature.Today.Separate.Day;
                watchface.Weather.Temperature.Today.Separate.Day.Number = watchface.Weather.Temperature.Today.Separate.Day.Number == null ? new Number() { notDraw = true } : watchface.Weather.Temperature.Today.Separate.Day.Number;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Temperature.Today.Separate.Day.Number, watch.imagesBuff.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex != -10000)
                {
                    watch.Weather.Temperature = watch.Weather.Temperature == null ? new Temperature() : watch.Weather.Temperature;
                    watch.Weather.Temperature.Today = watch.Weather.Temperature.Today == null ? new TodayTemperature() : watch.Weather.Temperature.Today;
                    watch.Weather.Temperature.Today.Separate = watch.Weather.Temperature.Today.Separate == null ? new SeparateTemperature() : watch.Weather.Temperature.Today.Separate;
                    watch.Weather.Temperature.Today.Separate.Day = watch.Weather.Temperature.Today.Separate.Day == null ? new TemperatureNumber() : watch.Weather.Temperature.Today.Separate.Day;
                    watch.Weather.Temperature.Today.Separate.Day.Number = numberForm.number;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberTemperatureTodaySeparateDayButton.Text = "Edit number";
                    AddMinusImageTemperatureTodaySeparateDayButton.Enabled = true;
                    AddDegreeImageTemperatureTodaySeparateDayButton.Enabled = true;
                }
                else if (numberForm.saved)
                {
                    if (watch.Weather?.Temperature?.Today?.Separate?.Day != null)
                        watch.Weather.Temperature.Today.Separate.Day = null;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberTemperatureTodaySeparateDayButton.Text = "Add number";
                    AddMinusImageTemperatureTodaySeparateDayButton.Enabled = false;
                    AddDegreeImageTemperatureTodaySeparateDayButton.Enabled = false;
                }
            }
            else if (btn.Name == "AddNumberTemperatureTodaySeparateNightButton")
            {
                watchface.Weather.Temperature = watchface.Weather.Temperature == null ? new Temperature() : watchface.Weather.Temperature;
                watchface.Weather.Temperature.Today = watchface.Weather.Temperature.Today == null ? new TodayTemperature() : watchface.Weather.Temperature.Today;
                watchface.Weather.Temperature.Today.Separate = watchface.Weather.Temperature.Today.Separate == null ? new SeparateTemperature() : watchface.Weather.Temperature.Today.Separate;
                watchface.Weather.Temperature.Today.Separate.Night = watchface.Weather.Temperature.Today.Separate.Night == null ? new TemperatureNumber() : watchface.Weather.Temperature.Today.Separate.Night;
                watchface.Weather.Temperature.Today.Separate.Night.Number = watchface.Weather.Temperature.Today.Separate.Night.Number == null ? new Number() { notDraw = true } : watchface.Weather.Temperature.Today.Separate.Night.Number;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Temperature.Today.Separate.Night.Number, watch.imagesBuff.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex != -10000)
                {
                    watch.Weather.Temperature = watch.Weather.Temperature == null ? new Temperature() : watch.Weather.Temperature;
                    watch.Weather.Temperature.Today = watch.Weather.Temperature.Today == null ? new TodayTemperature() : watch.Weather.Temperature.Today;
                    watch.Weather.Temperature.Today.Separate = watch.Weather.Temperature.Today.Separate == null ? new SeparateTemperature() : watch.Weather.Temperature.Today.Separate;
                    watch.Weather.Temperature.Today.Separate.Night = watch.Weather.Temperature.Today.Separate.Night == null ? new TemperatureNumber() : watch.Weather.Temperature.Today.Separate.Night;
                    watch.Weather.Temperature.Today.Separate.Night.Number = numberForm.number;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberTemperatureTodaySeparateNightButton.Text = "Edit number";
                    AddMinusImageTemperatureTodaySeparateNightButton.Enabled = true;
                    AddDegreeImageTemperatureTodaySeparateNightButton.Enabled = true;
                }
                else if (numberForm.saved)
                {
                    if (watch.Weather?.Temperature?.Today?.Separate?.Night != null)
                        watch.Weather.Temperature.Today.Separate.Night = null;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberTemperatureTodaySeparateNightButton.Text = "Add number";
                    AddMinusImageTemperatureTodaySeparateNightButton.Enabled = false;
                    AddDegreeImageTemperatureTodaySeparateNightButton.Enabled = false;
                }
            }
            else if (btn.Name == "AddNumberTemperatureTodayOnelineButton")
            {
                watchface.Weather.Temperature = watchface.Weather.Temperature == null ? new Temperature() : watchface.Weather.Temperature;
                watchface.Weather.Temperature.Today = watchface.Weather.Temperature.Today == null ? new TodayTemperature() : watchface.Weather.Temperature.Today;
                watchface.Weather.Temperature.Today.OneLine = watchface.Weather.Temperature.Today.OneLine == null ? new OneLineTemperature() : watchface.Weather.Temperature.Today.OneLine;
                watchface.Weather.Temperature.Today.OneLine.Number = watchface.Weather.Temperature.Today.OneLine.Number == null ? new Number() { notDraw = true } : watchface.Weather.Temperature.Today.OneLine.Number;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Temperature.Today.OneLine.Number, watch.imagesBuff.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex != -10000)
                {
                    watch.Weather.Temperature = watch.Weather.Temperature == null ? new Temperature() : watch.Weather.Temperature;
                    watch.Weather.Temperature.Today = watch.Weather.Temperature.Today == null ? new TodayTemperature() : watch.Weather.Temperature.Today;
                    watch.Weather.Temperature.Today.OneLine = watch.Weather.Temperature.Today.OneLine == null ? new OneLineTemperature() : watch.Weather.Temperature.Today.OneLine;
                    watch.Weather.Temperature.Today.OneLine.Number = numberForm.number;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberTemperatureTodayOnelineButton.Text = "Edit number";
                    AddMinusImageTemperatureTodayOnelineButton.Enabled = true;
                    AddDegreeImageTemperatureTodayOnelineButton.Enabled = true;
                    AddDelimeterImageTemperatureTodayOnelineButton.Enabled = true;
                    AddForBothTemperatureTodayOnelineCheckBox.Enabled = true;
                }
                else if (numberForm.saved)
                {
                    if (watch.Weather?.Temperature?.Today?.OneLine != null)
                        watch.Weather.Temperature.Today.OneLine = null;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberTemperatureTodayOnelineButton.Text = "Add number";
                    AddMinusImageTemperatureTodayOnelineButton.Enabled = false;
                    AddDegreeImageTemperatureTodayOnelineButton.Enabled = false;
                    AddDelimeterImageTemperatureTodayOnelineButton.Enabled = false;
                    AddForBothTemperatureTodayOnelineCheckBox.Enabled = false;
                }
            }
            else if (btn.Name == "AddNumberTemperatureCurrentButton")
            {
                watchface.Weather.Temperature = watchface.Weather.Temperature == null ? new Temperature() : watchface.Weather.Temperature;
                watchface.Weather.Temperature.Current = watchface.Weather.Temperature.Current == null ? new TemperatureNumber() : watchface.Weather.Temperature.Current;
                watchface.Weather.Temperature.Current.Number = watchface.Weather.Temperature.Current.Number == null ? new Number() { notDraw = true } : watchface.Weather.Temperature.Current.Number;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Temperature.Current.Number, watch.imagesBuff.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex != -10000)
                {
                    watch.Weather.Temperature = watch.Weather.Temperature == null ? new Temperature() : watch.Weather.Temperature;
                    watch.Weather.Temperature.Current = watch.Weather.Temperature.Current == null ? new TemperatureNumber() : watch.Weather.Temperature.Current;
                    watch.Weather.Temperature.Current.Number = numberForm.number;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberTemperatureCurrentButton.Text = "Edit number";
                    AddMinusImageTemperatureCurrentButton.Enabled = true;
                    AddDegreeImageTemperatureCurrentButton.Enabled = true;
                }
                else if (numberForm.saved)
                {
                    if (watch.Weather?.Temperature?.Current != null)
                        watch.Weather.Temperature.Current = null;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberTemperatureCurrentButton.Text = "Add number";
                    AddMinusImageTemperatureCurrentButton.Enabled = true;
                    AddDegreeImageTemperatureCurrentButton.Enabled = true;
                }
            }
            else if (btn.Name == "AddNumberHumidityButton")
            {
                watchface.Weather.Humidity = watchface.Weather.Humidity == null ? new Humidity() : watchface.Weather.Humidity;
                watchface.Weather.Humidity.Text = watchface.Weather.Humidity.Text == null ? new Number() { notDraw = true } : watchface.Weather.Humidity.Text;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Humidity.Text, watch.imagesBuff.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex != -10000)
                {
                    watch.Weather.Humidity = watch.Weather.Humidity == null ? new Humidity() : watch.Weather.Humidity;
                    watch.Weather.Humidity.Text = numberForm.number;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberHumidityButton.Text = "Edit number";
                    AddSuffixHumidityButton.Enabled = true;
                    AddSuffixImageHumidityButton.Enabled = true;
                }
                else if (numberForm.saved)
                {
                    watch.Weather.Humidity = null;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberHumidityButton.Text = "Add number";
                    AddSuffixHumidityButton.Enabled = false;
                    AddSuffixImageHumidityButton.Enabled = false;
                }
            }
            else if (btn.Name == "AddNumberWindButton")
            {
                watchface.Weather.Wind = watchface.Weather.Wind == null ? new Wind() : watchface.Weather.Wind;
                watchface.Weather.Wind.Text = watchface.Weather.Wind.Text == null ? new Number() { notDraw = true } : watchface.Weather.Wind.Text;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.Wind.Text, watch.imagesBuff.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex != -10000)
                {
                    watch.Weather.Wind = watch.Weather.Wind == null ? new Wind() : watch.Weather.Wind;
                    watch.Weather.Wind.Text = numberForm.number;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberWindButton.Text = "Edit number";
                    AddSuffixWindButton.Enabled = true;
                }
                else if (numberForm.saved)
                {
                    watch.Weather.Wind = null;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberWindButton.Text = "Add number";
                    AddSuffixWindButton.Enabled = false;
                }
            }
            else if (btn.Name == "AddNumberUVButton")
            {
                watchface.Weather.UVIndex = watchface.Weather.UVIndex == null ? new UVWrapper() : watchface.Weather.UVIndex;
                watchface.Weather.UVIndex.UV = watchface.Weather.UVIndex.UV == null ? new UVIndex() : watchface.Weather.UVIndex.UV;
                watchface.Weather.UVIndex.UV.Text = watchface.Weather.UVIndex.UV.Text == null ? new Number() { notDraw = true } : watchface.Weather.UVIndex.UV.Text;

                NumberFormEdit numberForm = new NumberFormEdit(watchface, watchface.Weather.UVIndex.UV.Text, watch.imagesBuff.DeepCopy(), state, 10);
                numberForm.ShowDialog();

                if (numberForm.saved && numberForm.number.ImageIndex != -10000)
                {
                    watch.Weather.UVIndex = watch.Weather.UVIndex == null ? new UVWrapper() : watch.Weather.UVIndex;
                    watch.Weather.UVIndex.UV = watch.Weather.UVIndex.UV == null ? new UVIndex() : watch.Weather.UVIndex.UV;
                    watch.Weather.UVIndex.UV.Text = numberForm.number;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberUVButton.Text = "Edit number";
                    AddSuffixUVButton.Enabled = true;
                }
                else if (numberForm.saved)
                {
                    watch.Weather.UVIndex = null;
                    watch.imagesBuff = numberForm.watch.imagesBuff;
                    AddNumberUVButton.Text = "Add number";
                    AddSuffixUVButton.Enabled = false;
                }
            }

            Render(state);
        }

        private void AddImageClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            List<int> selImg = null;
            ImagesForm imgForm;

            if (btn.Name == "AddMinusImageTemperatureTodaySeparateDayButton")
            {
                if (watch.Weather.Temperature.Today.Separate.Day.MinusImageIndex != -10000) selImg = new List<int>() { watch.Weather.Temperature.Today.Separate.Day.MinusImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Day.MinusImageIndex = imgForm.selectedImages[0];
                    AddMinusImageTemperatureTodaySeparateDayButton.Text = "Edit minus image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Day.MinusImageIndex = -10000;
                    AddMinusImageTemperatureTodaySeparateDayButton.Text = "Add minus image";
                }
            }
            else if (btn.Name == "AddMinusImageTemperatureTodaySeparateNightButton")
            {
                if (watch.Weather.Temperature.Today.Separate.Night.MinusImageIndex != -10000) selImg = new List<int>() { watch.Weather.Temperature.Today.Separate.Night.MinusImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Night.MinusImageIndex = imgForm.selectedImages[0];
                    AddMinusImageTemperatureTodaySeparateNightButton.Text = "Edit minus image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Night.MinusImageIndex = -10000;
                    AddMinusImageTemperatureTodaySeparateNightButton.Text = "Add minus image";
                }
            }
            else if (btn.Name == "AddDegreeImageTemperatureTodaySeparateDayButton")
            {
                if (watch.Weather.Temperature.Today.Separate.Day.DegreesImageIndex != -10000) selImg = new List<int>() { watch.Weather.Temperature.Today.Separate.Day.DegreesImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Day.DegreesImageIndex = imgForm.selectedImages[0];
                    AddDegreeImageTemperatureTodaySeparateDayButton.Text = "Edit degree image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Day.DegreesImageIndex = -10000;
                    AddDegreeImageTemperatureTodaySeparateDayButton.Text = "Add degree image";
                }
            }
            else if (btn.Name == "AddDegreeImageTemperatureTodaySeparateNightButton")
            {
                if (watch.Weather.Temperature.Today.Separate.Night.DegreesImageIndex != -10000) selImg = new List<int>() { watch.Weather.Temperature.Today.Separate.Night.DegreesImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Night.DegreesImageIndex = imgForm.selectedImages[0];
                    AddDegreeImageTemperatureTodaySeparateNightButton.Text = "Edit degree image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.Separate.Night.DegreesImageIndex = -10000;
                    AddDegreeImageTemperatureTodaySeparateNightButton.Text = "Add degree image";
                }
            }
            else if (btn.Name == "AddMinusImageTemperatureTodayOnelineButton")
            {
                if (watch.Weather.Temperature.Today.OneLine.MinusSignImageIndex != -10000) selImg = new List<int>() { watch.Weather.Temperature.Today.OneLine.MinusSignImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.MinusSignImageIndex = imgForm.selectedImages[0];
                    AddMinusImageTemperatureTodayOnelineButton.Text = "Edit minus image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.MinusSignImageIndex = -10000;
                    AddMinusImageTemperatureTodayOnelineButton.Text = "Add minus image";
                }
            }
            else if (btn.Name == "AddDelimeterImageTemperatureTodayOnelineButton")
            {
                if (watch.Weather.Temperature.Today.OneLine.DelimiterImageIndex != -10000) selImg = new List<int>() { watch.Weather.Temperature.Today.OneLine.DelimiterImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.DelimiterImageIndex = imgForm.selectedImages[0];
                    AddDelimeterImageTemperatureTodayOnelineButton.Text = "Edit delimeter image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.DelimiterImageIndex = -10000;
                    AddDelimeterImageTemperatureTodayOnelineButton.Text = "Add delimeter image";
                }
            }
            else if (btn.Name == "AddDegreeImageTemperatureTodayOnelineButton")
            {
                if (watch.Weather.Temperature.Today.OneLine.DegreesImageIndex != -10000) selImg = new List<int>() { watch.Weather.Temperature.Today.OneLine.DegreesImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.DegreesImageIndex = imgForm.selectedImages[0];
                    AddDegreeImageTemperatureTodayOnelineButton.Text = "Edit degree image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Today.OneLine.DegreesImageIndex = -10000;
                    AddDegreeImageTemperatureTodayOnelineButton.Text = "Add degree image";
                }
            }
            else if (btn.Name == "AddMinusImageTemperatureCurrentButton")
            {
                if (watch.Weather.Temperature.Current.MinusImageIndex != -10000) selImg = new List<int>() { watch.Weather.Temperature.Current.MinusImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Current.MinusImageIndex = imgForm.selectedImages[0];
                    AddMinusImageTemperatureCurrentButton.Text = "Edit minus image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Current.MinusImageIndex = -10000;
                    AddMinusImageTemperatureCurrentButton.Text = "Add minus image";
                }
            }
            else if (btn.Name == "AddDegreeImageTemperatureCurrentButton")
            {
                if (watch.Weather.Temperature.Current.MinusImageIndex != -10000) selImg = new List<int>() { watch.Weather.Temperature.Current.MinusImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Current.DegreesImageIndex = imgForm.selectedImages[0];
                    AddDegreeImageTemperatureCurrentButton.Text = "Edit degree image";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Temperature.Current.DegreesImageIndex = -10000;
                    AddDegreeImageTemperatureCurrentButton.Text = "Add degree image";
                }
            }
            else if (btn.Name == "AddSuffixHumidityButton")
            {
                if (watch.Weather.Humidity.SuffixImageIndex != -10000) selImg = new List<int>() { watch.Weather.Humidity.SuffixImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Humidity.SuffixImageIndex = imgForm.selectedImages[0];
                    AddSuffixHumidityButton.Text = "Edit suffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Humidity.SuffixImageIndex = -10000;
                    AddSuffixHumidityButton.Text = "Add suffix";
                }
            }
            else if (btn.Name == "AddSuffixWindButton")
            {
                if (watch.Weather.Wind.ImageSuffixEN != -10000) selImg = new List<int>() { watch.Weather.Wind.ImageSuffixEN };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Wind.ImageSuffixEN = imgForm.selectedImages[0];
                    AddSuffixWindButton.Text = "Edit suffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.Wind.ImageSuffixEN = -10000;
                    AddSuffixWindButton.Text = "Add suffix";
                }
            }
            else if (btn.Name == "AddSuffixUVButton")
            {
                if (watch.Weather.UVIndex.UV.SuffixImageIndex != -10000) selImg = new List<int>() { watch.Weather.UVIndex.UV.SuffixImageIndex };

                imgForm = new ImagesForm(Images, selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.UVIndex.UV.SuffixImageIndex = imgForm.selectedImages[0];
                    AddSuffixUVButton.Text = "Edit suffix";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Weather.UVIndex.UV.SuffixImageIndex = -10000;
                    AddSuffixUVButton.Text = "Add suffix";
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
            ImageBasicForm ibForm = new ImageBasicForm(watch, watch.Weather.Humidity.ImageSuffix, watch.imagesBuff.DeepCopy(), state);
            ibForm.ShowDialog();

            if (ibForm.saved)
            {
                AddSuffixImageHumidityButton.Text = "Edit suffix image";
                watch.Weather.Humidity.ImageSuffix = ibForm.imageBasic;
                watch.imagesBuff = ibForm.watch.imagesBuff;
            }
            else
            {
                AddSuffixImageHumidityButton.Text = "Add suffix image";
                watch.Weather.Humidity.ImageSuffix = null;
                watch.imagesBuff = ibForm.watch.imagesBuff;
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
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save = true;
            if (watch.Weather.Icon == null || WeatherIconCheckbox.Checked == false)
                watch.Weather.Icon = null;
            if ((watch.Weather?.Temperature?.Today?.Separate?.Day == null && watch.Weather?.Temperature?.Today?.Separate?.Night == null) || (TemperatureTodaySeparateDayCheckbox.Checked == false && TemperatureTodaySeparateNightCheckbox.Checked == false))
                if (watch.Weather?.Temperature?.Today != null)
                    watch.Weather.Temperature.Today.Separate = null;
            if (watch.Weather?.Temperature?.Today?.OneLine == null || AddForBothTemperatureTodayOnelineCheckBox.Checked == false)
                if (watch.Weather.Temperature.Today != null)
                    watch.Weather.Temperature.Today.OneLine = null;
            if ((watch.Weather?.Temperature?.Today?.OneLine == null && watch.Weather?.Temperature?.Today?.Separate == null))
                watch.Weather.Temperature.Today = null;

            if (watch.Weather?.Temperature?.Current == null || TemperatureCurrentCheckbox.Checked == false)
                watch.Weather.Temperature.Current = null;

            if (watch.Weather?.Temperature?.Current == null && watch.Weather?.Temperature?.Today == null)
                watch.Weather.Temperature = null;

            if (HumidityCheckbox.Checked == false)
                watch.Weather.Humidity = null;

            if (WindCheckbox.Checked == false)
                watch.Weather.Wind = null;

            if (UVIndexCheckbox.Checked == false)
                watch.Weather.UVIndex = null;
            this.Close();
        }

        private void WeatherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show("Do you want to get out without saving?", "Don't Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (watch.Weather.Icon == null || WeatherIconCheckbox.Checked == false)
                    watch.Weather.Icon = null;
                if ((watch.Weather?.Temperature?.Today?.Separate?.Day == null && watch.Weather?.Temperature?.Today?.Separate?.Night == null) || (TemperatureTodaySeparateDayCheckbox.Checked == false && TemperatureTodaySeparateNightCheckbox.Checked == false))
                    if (watch.Weather?.Temperature?.Today != null)
                        watch.Weather.Temperature.Today.Separate = null;
                if (watch.Weather?.Temperature?.Today?.OneLine == null || AddForBothTemperatureTodayOnelineCheckBox.Checked == false)
                    watch.Weather.Temperature.Today.OneLine = null;
                if ((watch.Weather?.Temperature?.Today?.OneLine == null && watch.Weather?.Temperature?.Today?.Separate == null))
                    watch.Weather.Temperature.Today = null;

                if (watch.Weather?.Temperature?.Current == null || TemperatureCurrentCheckbox.Checked == false)
                    watch.Weather.Temperature.Current = null;

                if (watch.Weather?.Temperature?.Current == null && watch.Weather?.Temperature?.Today == null)
                    watch.Weather.Temperature = null;

                if (HumidityCheckbox.Checked == false)
                    watch.Weather.Humidity = null;

                if (WindCheckbox.Checked == false)
                    watch.Weather.Wind = null;

                if (UVIndexCheckbox.Checked == false)
                    watch.Weather.UVIndex = null;
            }
        }
    }
}
