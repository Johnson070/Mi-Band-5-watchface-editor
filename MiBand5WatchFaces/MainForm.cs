using MiBand5WatchFaces.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MiBand5WatchFaces
{
    public partial class MainForm : Form
    {
        WatchFaceLibrary watchFace = new WatchFaceLibrary();
        StateWatchface state = new StateWatchface();

        public MainForm()
        {
            InitializeComponent();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualRender render = new VisualRender(watchFace);
            BackgroundForm bgr = new BackgroundForm(DeepCopy<Background>(watchFace.Background), new DefaultDictionary<int, Image>(() => new Bitmap(1, 1), watchFace.imagesBuff), render.genPreview());
            bgr.ShowDialog();
            if (bgr.Save)
            {
                watchFace.Background = bgr.background;
                watchFace.imagesBuff = bgr.images;
                RenderButton_Click(null, null);
            }
            updateListElements();
            bgr.Dispose();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeForm timeForm = new TimeForm(DeepCopy<WatchFaceLibrary>(watchFace), new DefaultDictionary<int, Image>(() => new Bitmap(1, 1), watchFace.imagesBuff),state);
            timeForm.ShowDialog();

            if (timeForm.Save)
            {
                watchFace = timeForm.watch;
                RenderButton_Click(null, null);
            }
            timeForm.Dispose();
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            try
            {
                state = state.notGen == false ? state : new StateWatchface() { notGen = true};
                VisualRender render = new VisualRender(watchFace,state);
                watchfacePreviewImage.Image = render.GenWatchface();
            }
            catch { MessageBox.Show("Error!", "Error generate preview!"); }
        }

        private void OpenFileJson(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "json watchface (*.json)|*.json";
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader readFile = new StreamReader(file.FileName);

                string json = readFile.ReadToEnd();
                readFile.Close();

                watchFace = JsonConvert.DeserializeObject<WatchFaceLibrary>(json);//,new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.All,MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead ,PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                watchFace.FilePath = Path.GetDirectoryName(file.FileName);
                watchFace.LoadImages();

                RenderButton_Click(null, null);

                updateListElements();
            }
        }

        private void updateListElements()
        {
            listViewElements.Clear();
            foreach (object element in watchFace.getElements())
                if (element != null)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = element;
                    item.Text = element.GetType().ToString().Replace("MiBand5WatchFaces.", string.Empty);
                    listViewElements.Items.Add(item);
                }
        }

        private void listViewElements_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            ListView item = (ListView)sender;
            Type type = item.SelectedItems[0].Tag.GetType();

            if (type == typeof(Background))
            {
                VisualRender render = new VisualRender(watchFace);
                BackgroundForm backgroundForm = new BackgroundForm(DeepCopy<Background>((Background)item.SelectedItems[0].Tag), watchFace.imagesBuff.DeepCopy(), render.genPreview());
                backgroundForm.ShowDialog();
                if (backgroundForm.Save)
                {
                    watchFace.Background = backgroundForm.background;
                    watchFace.imagesBuff = backgroundForm.images;
                    RenderButton_Click(null, null);
                }
                backgroundForm.Dispose();
            }
            else if (type == typeof(Time))
            {
                TimeForm timeForm = new TimeForm(DeepCopy<WatchFaceLibrary>(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                timeForm.ShowDialog();

                if (timeForm.Save)
                {
                    watchFace = timeForm.watch;
                    RenderButton_Click(null, null);
                }
                timeForm.Dispose();
            }
            else if (type == typeof(Activity))
            {
                ActivityForm activityForm = new ActivityForm(DeepCopy<WatchFaceLibrary>(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                activityForm.ShowDialog();

                if (activityForm.Save)
                {
                    watchFace = activityForm.watch;
                    RenderButton_Click(null, null);
                }
                activityForm.Dispose();
            }
            else if (type == typeof(Date))
            {
                DateForm dateForm = new DateForm(DeepCopy<WatchFaceLibrary>(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                dateForm.ShowDialog();

                if (dateForm.Save)
                {
                    watchFace = dateForm.watch;
                    RenderButton_Click(null, null);
                }
                dateForm.Dispose();
            }
            else if (type == typeof(Weather))
            {
                WeatherForm weatherForm = new WeatherForm(DeepCopy<WatchFaceLibrary>(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                weatherForm.ShowDialog();

                if (weatherForm.Save)
                {
                    watchFace = weatherForm.watch;
                    RenderButton_Click(null, null);
                }
                weatherForm.Dispose();
            }
            else if (type == typeof(StepsProgress))
            {
                StepsProgressForm progressForm = new StepsProgressForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                progressForm.ShowDialog();

                if (progressForm.Save)
                {
                    watchFace = progressForm.watch;
                    RenderButton_Click(null, null);
                }
                progressForm.Dispose();
            }
            else if (type == typeof(Status))
            {
                StatusForm statusForm = new StatusForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                statusForm.ShowDialog();

                if (statusForm.Save)
                {
                    watchFace = statusForm.watch;
                    RenderButton_Click(null, null);
                }

                statusForm.Dispose();
            }

            updateListElements();
            //}
            //catch { }
        }

        private void OpenFormImages_Click(object sender, EventArgs e)
        {
            ImagesForm imagesForm = new ImagesForm(watchFace.imagesBuff.DeepCopy());
            imagesForm.ShowDialog();

            if (imagesForm.saveImages)
            {
                watchFace.imagesBuff = imagesForm.Images;
                RenderButton_Click(null, null);
            }
        }

        public static T DeepCopy<T>(T other)
        {
            if (other == null) return default(T);

            string clone = JsonConvert.SerializeObject(other);
            return JsonConvert.DeserializeObject<T>(clone);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm(DeepCopy<WatchFaceLibrary>(watchFace),watchFace.imagesBuff.DeepCopy(), state);
            activityForm.ShowDialog();

            if (activityForm.Save)
            {
                watchFace = activityForm.watch;
                RenderButton_Click(null, null);
            }
            activityForm.Dispose();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateForm dateForm = new DateForm(DeepCopy<WatchFaceLibrary>(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            dateForm.ShowDialog();

            if (dateForm.Save)
            {
                watchFace = dateForm.watch;
                RenderButton_Click(null, null);
            }
            dateForm.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(JsonConvert.SerializeObject(watchFace,Formatting.Indented,new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));
            MessageBox.Show("Json saved to clipboard!", "Succeful!");
        }

        private void SetWatchfaceState_Click(object sender, EventArgs e)
        {
            WatchfaceStateEditor watchfaceStateEditor = new WatchfaceStateEditor(state, watchFace);
            watchfaceStateEditor.ShowDialog();

            if (watchfaceStateEditor.save)
            {
                state = watchfaceStateEditor.state;
                RenderButton_Click(null, null);
            }
        }

        private void weatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeatherForm weatherForm = new WeatherForm(DeepCopy<WatchFaceLibrary>(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            weatherForm.ShowDialog();

            if (weatherForm.Save)
            {
                watchFace = weatherForm.watch;
                RenderButton_Click(null, null);
            }
            weatherForm.Dispose();
        }

        private void stepsProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StepsProgressForm progressForm = new StepsProgressForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            progressForm.ShowDialog();

            if (progressForm.Save)
            {
                watchFace = progressForm.watch;
                RenderButton_Click(null, null);
            }
            progressForm.Dispose();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusForm statusForm = new StatusForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            statusForm.ShowDialog();

            if (statusForm.Save)
            {
                watchFace = statusForm.watch;
                RenderButton_Click(null, null);
            }

            statusForm.Dispose();
        }
    }
}
