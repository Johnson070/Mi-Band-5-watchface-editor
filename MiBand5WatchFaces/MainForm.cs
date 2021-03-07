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
            VisualRender render = new VisualRender(watchFace,state);
            BackgroundForm bgr = new BackgroundForm(DeepCopy<Background>(watchFace.Background), watchFace.imagesBuff.DeepCopy(), render.genPreview());
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
            TimeForm timeForm = new TimeForm(DeepCopy<WatchFaceLibrary>(watchFace), watchFace.imagesBuff.DeepCopy(), state);
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
                state = state.notGen == false ? state : new StateWatchface() { notGen = true };
                VisualRender render = new VisualRender(watchFace, state);
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

            if (item.SelectedItems.Count > 0)
            {
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
                    StepsProgressForm progressForm = new StepsProgressForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state, StepsProgressForm.StateForm.Steps);
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
                    StatusForm statusForm = new StatusForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state, StatusForm.statusForm.Status);
                    statusForm.ShowDialog();

                    if (statusForm.Save)
                    {
                        watchFace = statusForm.watch;
                        RenderButton_Click(null, null);
                    }

                    statusForm.Dispose();
                }
                else if (type == typeof(Battery))
                {
                    BatteryForm batteryForm = new BatteryForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                    batteryForm.ShowDialog();

                    if (batteryForm.Save)
                    {
                        watchFace = batteryForm.watch;
                        RenderButton_Click(null, null);
                    }
                    batteryForm.Dispose();
                }
                else if (type == typeof(AnalogDialFace))
                {
                    AnalogDialFaceForm analogDial = new AnalogDialFaceForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                    analogDial.ShowDialog();

                    if (analogDial.Save)
                    {
                        watchFace = analogDial.watch;
                        RenderButton_Click(null, null);
                    }

                    analogDial.Dispose();
                }
                else if (type == typeof(Other))
                {
                    AnimationForm animationForm = new AnimationForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                    animationForm.ShowDialog();

                    if (animationForm.Save)
                    {
                        watchFace = animationForm.watch;
                        RenderButton_Click(null, null);
                    }
                    animationForm.Dispose();
                }
                else if (type == typeof(CaloriesProgress))
                {
                    StepsProgressForm progressForm = new StepsProgressForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state, StepsProgressForm.StateForm.Calories);
                    progressForm.ShowDialog();

                    if (progressForm.Save)
                    {
                        watchFace = progressForm.watch;
                        RenderButton_Click(null, null);
                    }
                    progressForm.Dispose();
                }
                else if (type == typeof(HeartProgress))
                {
                    HeartProgressForm heartProgress = new HeartProgressForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                    heartProgress.ShowDialog();

                    if (heartProgress.Save)
                    {
                        watchFace = heartProgress.watch;
                        RenderButton_Click(null, null);
                    }
                    heartProgress.Dispose();
                }
                else if (type == typeof(WeekDaysIcons))
                {
                    WeekDaysIconsForm weekDays = new WeekDaysIconsForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                    weekDays.ShowDialog();

                    if (weekDays.Save)
                    {
                        watchFace = weekDays.watch;
                        RenderButton_Click(null, null);
                    }
                    weekDays.Dispose();
                }
                else if (type == typeof(Alarm))
                {
                    AlarmForm alarmForm = new AlarmForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
                    alarmForm.ShowDialog();

                    if (alarmForm.Save)
                    {
                        watchFace = alarmForm.watch;
                        RenderButton_Click(null, null);
                    }
                    alarmForm.Dispose();
                }
                else if (type == typeof(StatusSimple))
                {
                    StatusForm statusForm = new StatusForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state, StatusForm.statusForm.StatusSpecial);
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
            ActivityForm activityForm = new ActivityForm(DeepCopy<WatchFaceLibrary>(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            activityForm.ShowDialog();

            if (activityForm.Save)
            {
                watchFace = activityForm.watch;
                RenderButton_Click(null, null);
            }
            activityForm.Dispose();
            updateListElements();
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
            updateListElements();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText();
            //MessageBox.Show("Json saved to clipboard!", "Succeful!");

            try
            {
                SaveFileDialog saveFile = new SaveFileDialog() { Filter = "json file (*.json)|*.json|bin file (*.bin)|*.bin", RestoreDirectory = true };
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string path = Path.GetDirectoryName(saveFile.FileName);
                    foreach (KeyValuePair<int, Image> img in watchFace.imagesBuff)
                        img.Value.Save(Path.Combine(path, $"{img.Key:0000}.png"));

                    File.WriteAllText(Path.Combine(path, $"{Path.GetFileNameWithoutExtension(saveFile.FileName)}.json"), JsonConvert.SerializeObject(watchFace, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));

                    if (Path.GetExtension(saveFile.FileName) == ".bin")
                    {
                        this.Enabled = false ;
                        WatchFaceEXE.StartInfo.FileName = @"WatchFace/WatchFace.exe";
                        //avrdude.StartInfo.Arguments = "-v";
                        WatchFaceEXE.StartInfo.Arguments = $"WatchFace/WatchFace.exe \"{Path.Combine(path, Path.GetFileNameWithoutExtension(saveFile.FileName))}.json\"";
                        WatchFaceEXE.StartInfo.UseShellExecute = false;
                        WatchFaceEXE.StartInfo.RedirectStandardOutput = true;
                        WatchFaceEXE.StartInfo.RedirectStandardInput = true;
                        WatchFaceEXE.StartInfo.RedirectStandardError = true;
                        WatchFaceEXE.StartInfo.CreateNoWindow = true;
                        WatchFaceEXE.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                        WatchFaceEXE.StartInfo.ErrorDialog = false;

                        WatchFaceEXE.Start();
                        //WatchFaceEXE.WaitForExit();
                        //WatchFaceEXE.BeginErrorReadLine();
                        WatchFaceEXE.BeginOutputReadLine();
                        SaveFileStatus.Text = "";
                    }
                    //if (File.Exists(Path.GetFileNameWithoutExtension(saveFile.FileName) + "_packed.bin")) {
                    //    File.Move(Path.Combine(path, Path.GetFileNameWithoutExtension(saveFile.FileName) + "_packed.bin"), Path.Combine(path, Path.GetFileNameWithoutExtension(saveFile.FileName) + ".bin"));
                    //    File.Delete(Path.GetFileNameWithoutExtension(saveFile.FileName) + "_packed.log"); 
                    //}
                }
                else return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error save!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
                SaveFileStatus.Text = "";
            }
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
            updateListElements();
        }

        private void stepsProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StepsProgressForm progressForm = new StepsProgressForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state, StepsProgressForm.StateForm.Steps);
            progressForm.ShowDialog();

            if (progressForm.Save)
            {
                watchFace = progressForm.watch;
                RenderButton_Click(null, null);
            }
            progressForm.Dispose();
            updateListElements();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusForm statusForm = new StatusForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state, StatusForm.statusForm.Status);
            statusForm.ShowDialog();

            if (statusForm.Save)
            {
                watchFace = statusForm.watch;
                RenderButton_Click(null, null);
            }

            statusForm.Dispose();
            updateListElements();
        }

        private void batteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatteryForm batteryForm = new BatteryForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            batteryForm.ShowDialog();

            if (batteryForm.Save)
            {
                watchFace = batteryForm.watch;
                RenderButton_Click(null, null);
            }
            batteryForm.Dispose();
            updateListElements();
        }

        private void analogDialFaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalogDialFaceForm analogDial = new AnalogDialFaceForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            analogDial.ShowDialog();

            if (analogDial.Save)
            {
                watchFace = analogDial.watch;
                RenderButton_Click(null, null);
            }

            analogDial.Dispose();
            updateListElements();
        }

        private void animationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimationForm animationForm = new AnimationForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            animationForm.ShowDialog();

            if (animationForm.Save)
            {
                watchFace = animationForm.watch;
                RenderButton_Click(null, null);
            }
            animationForm.Dispose();
            updateListElements();
        }

        private void heartProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeartProgressForm heartProgress = new HeartProgressForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            heartProgress.ShowDialog();

            if (heartProgress.Save)
            {
                watchFace = heartProgress.watch;
                RenderButton_Click(null, null);
            }
            heartProgress.Dispose();
            updateListElements();
        }

        private void caloriesProgressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StepsProgressForm progressForm = new StepsProgressForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state, StepsProgressForm.StateForm.Calories);
            progressForm.ShowDialog();

            if (progressForm.Save)
            {
                watchFace = progressForm.watch;
                RenderButton_Click(null, null);
            }
            progressForm.Dispose();
            updateListElements();
        }

        private void weekDaysIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeekDaysIconsForm weekDays = new WeekDaysIconsForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            weekDays.ShowDialog();

            if (weekDays.Save)
            {
                watchFace = weekDays.watch;
                RenderButton_Click(null, null);
            }
            weekDays.Dispose();
            updateListElements();
        }

        private void alarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlarmForm alarmForm = new AlarmForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            alarmForm.ShowDialog();

            if (alarmForm.Save)
            {
                watchFace = alarmForm.watch;
                RenderButton_Click(null, null);
            }
            alarmForm.Dispose();
            updateListElements();
        }

        private void statusSimplifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusForm statusForm = new StatusForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state, StatusForm.statusForm.StatusSpecial);
            statusForm.ShowDialog();

            if (statusForm.Save)
            {
                watchFace = statusForm.watch;
                RenderButton_Click(null, null);
            }

            statusForm.Dispose();
            updateListElements();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewElements_DoubleClick(listViewElements, null);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewElements.SelectedItems.Count > 0)
            {
                Type type = listViewElements.SelectedItems[0].Tag.GetType();

                if (MessageBox.Show("The selected item will be deleted irretrievably.\nAre you sure?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;

                if (type == typeof(Background)) watchFace.Background = null;
                else if (type == typeof(Time)) watchFace.Time = null;
                else if (type == typeof(Activity)) watchFace.Activity = null;
                else if (type == typeof(Date)) watchFace.Date = null;
                else if (type == typeof(Weather)) watchFace.Weather = null;
                else if (type == typeof(StepsProgress)) watchFace.StepsProgress = null;
                else if (type == typeof(Status)) watchFace.Status = null;
                else if (type == typeof(Battery)) watchFace.Battery = null;
                else if (type == typeof(AnalogDialFace)) watchFace.AnalogDialFace = null;
                else if (type == typeof(Other)) watchFace.Other = null;
                else if (type == typeof(CaloriesProgress)) watchFace.CaloriesProgress = null;
                else if (type == typeof(HeartProgress)) watchFace.HeartProgress = null;
                else if (type == typeof(WeekDaysIcons)) watchFace.WeekDaysIcons = null;
                else if (type == typeof(Alarm)) watchFace.Alarm = null;
                else if (type == typeof(StatusSimple)) watchFace.StatusSimplified = null;

                updateListElements();
                RenderButton_Click(null, null);
            }
        }

        private void WatchFaceEXE_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (e.Data != null)
                SaveFileStatus.Text = e.Data.ToString();
            if (e.Data != null && e.Data.ToString() == "Writing resources")
            {
                this.Enabled = true;
                SaveFileStatus.Text = "";
                WatchFaceEXE.Close();
                MessageBox.Show("Succeful!", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WatchFaceEXE_Exited(object sender, EventArgs e)
        {
            this.Enabled = true;
        }
    }
}
