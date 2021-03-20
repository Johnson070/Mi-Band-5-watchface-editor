using MiBand5WatchFaces.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MiBand5WatchFaces
{
    public partial class MainForm : Form
    {
        WatchFaceLibrary watchFace = new WatchFaceLibrary();
        StateWatchface state = new StateWatchface();
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

        bool Save = true;
        string file = "";

        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValue);

        public MainForm()
        {
            InitializeComponent();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualRender render = new VisualRender(watchFace, state);
            BackgroundForm bgr = new BackgroundForm(DeepCopy<Background>(watchFace.Background), watchFace.imagesBuff.DeepCopy(), render.genPreview());
            bgr.ShowDialog();
            if (bgr.Save)
            {
                Save = false;
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
                Save = false;
                watchFace = timeForm.watch;
                RenderButton_Click(null, null);
            }
            timeForm.Dispose();
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            Render(state);
        }

        private void Render(StateWatchface stateWatch, bool Animation = false)
        {
            try
            {
                stateWatch = stateWatch.notGen == false ? stateWatch : new StateWatchface() { notGen = true };
                VisualRender render = new VisualRender(watchFace, stateWatch);
                watchfacePreviewImage.Image = Animation ? render.GenAnimationStep(true) : render.GenAnimationStep(false);
            }
            catch { MessageBox.Show(res.GetString("Error"), res.GetString("ErrorGenPreview")); }
        }

        private void OpenFileJson(object sender, EventArgs e)
        {
            try
            {
                if (Save == false && MessageBox.Show(res.GetString("SaveOpenJson"), res.GetString("SaveQ"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    saveToolStripMenuItem.PerformClick();

                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "json watchface (*.json)|*.json|bin file (*.bin)|*.bin";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(file.FileName) == ".bin")
                    {
                        WatchFaceEXE.Close();
                        this.Enabled = false;
                        WatchFaceEXE.StartInfo.FileName = @"WatchFace/WatchFace.exe";
                        //avrdude.StartInfo.Arguments = "-v";
                        WatchFaceEXE.StartInfo.Arguments = $"WatchFace/WatchFace.exe \"{file.FileName}\"";
                        WatchFaceEXE.StartInfo.UseShellExecute = false;
                        WatchFaceEXE.StartInfo.RedirectStandardOutput = true;
                        WatchFaceEXE.StartInfo.RedirectStandardInput = true;
                        WatchFaceEXE.StartInfo.RedirectStandardError = true;
                        WatchFaceEXE.StartInfo.CreateNoWindow = true;
                        WatchFaceEXE.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                        WatchFaceEXE.StartInfo.ErrorDialog = false;

                        //WatchFaceEXE.BeginErrorReadLine();

                        WatchFaceEXE.Start();
                        WatchFaceEXE.BeginOutputReadLine();

                        timerWatchFaceEXE.Start();
                        SaveFileStatus.Text = "";

                        this.file = file.FileName;
                    }
                    else
                    {
                        Save = true;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parse file!\n\n{ex}", res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
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
                        Save = false;
                        watchFace = statusForm.watch;
                        RenderButton_Click(null, null);
                    }

                    statusForm.Dispose();
                }

                updateListElements();
                //}
                //catch { }

                long totalMemory = GC.GetTotalMemory(false);

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void OpenFormImages_Click(object sender, EventArgs e)
        {
            ImagesForm imagesForm = new ImagesForm(watchFace.imagesBuff.DeepCopy());
            imagesForm.ShowDialog();

            if (imagesForm.saveImages)
            {
                Save = false;
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

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm(DeepCopy<WatchFaceLibrary>(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            activityForm.ShowDialog();

            if (activityForm.Save)
            {
                Save = false;
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
                Save = false;
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
                SaveFileDialog saveFile = new SaveFileDialog() { Filter = "json file (*.json)|*.json|packed bin file (*.bin)|*.bin", RestoreDirectory = true };
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    Save = true;
                    string path = Path.GetDirectoryName(saveFile.FileName);
                    foreach (KeyValuePair<int, Image> img in watchFace.imagesBuff)
                        img.Value.Save(Path.Combine(path, $"{img.Key:0000}.png"), ImageFormat.Png);

                    File.WriteAllText(Path.Combine(path, $"{Path.GetFileNameWithoutExtension(saveFile.FileName)}.json"), JsonConvert.SerializeObject(watchFace, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));

                    if (Path.GetExtension(saveFile.FileName) == ".bin")
                    {
                        WatchFaceEXE.Close();
                        this.Enabled = false;
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
                        WatchFaceEXE.BeginOutputReadLine();
                        //WatchFaceEXE.WaitForExit();
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
                MessageBox.Show(ex.ToString(), res.GetString("ErrorSave"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Save = false;
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
                Save = false;
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
                Save = false;
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
                Save = false;
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
                Save = false;
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
                Save = false;
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
                Save = false;
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
                Save = false;
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
                Save = false;
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
                Save = false;
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
                Save = false;
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

                if (MessageBox.Show(res.GetString("DeleteItem"), res.GetString("SureQ"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
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

                Save = false;

                updateListElements();
                RenderButton_Click(null, null);
            }
        }

        private void WatchFaceEXE_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (e.Data != null)
                SaveFileStatus.Text = e.Data.ToString();

            if (e.Data != null && e.Data.ToString().IndexOf("ERROR") != -1)
            {
                this.Enabled = true;
                SaveFileStatus.Text = "";
                //this.BeginInvoke(new Action(() => WatchFaceEXE.Kill()));
                MessageBox.Show(res.GetString("Error") + "\n" + e.Data.ToString(), res.GetString("NotGenerated"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Data != null && e.Data.ToString() == "Writing resources")
            {
                this.Enabled = true;
                SaveFileStatus.Text = "";
                //this.BeginInvoke(new Action(() => WatchFaceEXE.Kill()));
                MessageBox.Show(res.GetString("Succeful"), res.GetString("Complete"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Data != null && e.Data.ToString().IndexOf("Exporting config...") != -1)
            {
                this.Enabled = true;
                SaveFileStatus.Text = "";
                //this.BeginInvoke(new Action(() => WatchFaceEXE.Kill()));
                MessageBox.Show(res.GetString("Succeful"), res.GetString("Complete"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                timerWatchFaceEXE.Stop();

                Save = true;
                StreamReader readFile = new StreamReader(Path.Combine(Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file)), $"{Path.GetFileNameWithoutExtension(file)}.json"));

                string json = readFile.ReadToEnd();
                readFile.Close();

                watchFace = JsonConvert.DeserializeObject<WatchFaceLibrary>(json);//,new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.All,MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead ,PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                watchFace.FilePath = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file));
                watchFace.LoadImages();

                RenderButton_Click(null, null);

                updateListElements();

            }
        }

        private void WatchFaceEXE_Exited(object sender, EventArgs e)
        {
            this.Enabled = true;
            SaveFileStatus.Text = "";
            WatchFaceEXE.CancelOutputRead();
            WatchFaceEXE.Close();
            timerWatchFaceEXE.Stop();
            //this.BeginInvoke(new Action(() => WatchFaceEXE.Kill()));
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show(res.GetString("SaveFileClose"), res.GetString("SaveQ"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                saveToolStripMenuItem_Click(null, null);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            bool state = InternetGetConnectedState(out _, 0);

            if (state && Properties.Settings.Default.ShowChangeLog)
            {
                Properties.Settings.Default.ShowChangeLog = false;
                Properties.Settings.Default.Save();
                MessageBox.Show(GetProgramInfo().changelog, res.GetString("ChangeLog"), MessageBoxButtons.OK);
            }

            if (state)
            {
                if ((GetProgramInfo().version != Application.ProductVersion || GetProgramInfo().versionUpdateForce == Application.ProductVersion) && MessageBox.Show(res.GetString("OpenDownloadUpdate"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog() { RestoreDirectory = true, Filter = "zip file (.zip)|*.zip", FileName = "MiBand5WatchFaceEditor.zip" };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            UpdateForm updateForm = new UpdateForm(String.Format(GetProgramInfo().link, GetProgramInfo().version), saveFileDialog.FileName);
                            updateForm.ShowDialog();
                        }
                        else return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private ProgramInfo GetProgramInfo()
        {
            ProgramInfo programInfo = new ProgramInfo();

            using (WebClient Client = new WebClient())
            {
                Client.Encoding = Encoding.UTF8;
                programInfo = JsonConvert.DeserializeObject<ProgramInfo>(Client.DownloadString("https://raw.githubusercontent.com/Johnson070/MiBand-5-watchface-editor/main/infoProgram.txt"));
            }

            return programInfo;
        }

        private void checkUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool state = InternetGetConnectedState(out _, 0);

            if (state)
            {
                if (GetProgramInfo().version == Application.ProductVersion) MessageBox.Show(String.Format(res.GetString("ShowUpdateInfo"), Application.ProductVersion, GetProgramInfo().version), res.GetString("Update"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (MessageBox.Show(res.GetString("OpenDownloadUpdate"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog() { RestoreDirectory = true, Filter = "zip file (.zip)|*.zip", FileName = "MiBand5WatchFaceEditor.zip" };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            UpdateForm updateForm = new UpdateForm(String.Format(GetProgramInfo().link, GetProgramInfo().version), saveFileDialog.FileName);
                            updateForm.ShowDialog();
                        }
                        else return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool state = InternetGetConnectedState(out _, 0);

            if (state) MessageBox.Show(GetProgramInfo().changelog, res.GetString("ChangeLog"), MessageBoxButtons.OK);
        }

        private void timerWatchFaceEXE_Tick(object sender, EventArgs e)
        {
            WatchFaceEXE.Close();
            this.Enabled = true;
            MessageBox.Show(res.GetString("Error"), res.GetString("NotGenerated"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            watchFace = new WatchFaceLibrary();
            timerWatchFaceEXE.Stop();
        }

        private void supportMeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://www.donationalerts.com/r/johnson070";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void wkiProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://github.com/Johnson070/MiBand-5-watchface-editor/wiki";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void findBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://github.com/Johnson070/MiBand-5-watchface-editor/issues";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void OpenJsonButton_Click(object sender, EventArgs e)
        {
            JSONEditorForm jsonForm = new JSONEditorForm(DeepCopy(watchFace), watchFace.imagesBuff.DeepCopy(), state);
            jsonForm.ShowDialog();

            if (jsonForm.Save)
            {
                watchFace = jsonForm.watch;
                RenderButton.PerformClick();
            }

            jsonForm.Dispose();
        }

        private void ChangeLang(object sender, EventArgs e)
        {
            string tag = ((ToolStripMenuItem)sender).Tag.ToString();

            Properties.Settings.Default.lang = tag;
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private class ProgramInfo
        {
            [JsonProperty("changelog")]
            public string changelog;
            [JsonProperty("version")]
            public string version;
            [JsonProperty("link")]
            public string link;
            [JsonProperty("versionUpdateForce")]
            public string versionUpdateForce;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void AnimateTimer_Tick(object sender, EventArgs e)
        {
            if (watchFace != null && watchFace.Other != null)
            {
                if (this.ContainsFocus) Render(state, true);
            }
        }

        private void AnimateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AnimateCheckBox.Checked) AnimateTimer.Start();
            else
            {
                AnimateTimer.Stop();
                watchfacePreviewImage.Tag = 0;
                RenderButton.PerformClick();
            }
        }

        private void DeleteTrash_Tick(object sender, EventArgs e)
        {
            long trash = (GC.GetTotalMemory(false) / 1024);
            if (trash > 4000)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void convertGIFToPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog() { RestoreDirectory = true, Filter = "GIF (*.gif)|*.gif" };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<Image> images = Gif.LoadAnimatedGif(openFile.FileName);
                string path = Path.GetDirectoryName(openFile.FileName);
                string newPath = Path.Combine(path, Path.GetFileNameWithoutExtension(openFile.FileName));

                if (Directory.Exists(newPath) == false)
                    Directory.CreateDirectory(newPath);

                int count = 0;
                foreach (Image img in images)
                    img.Save(Path.Combine(newPath, $"{count++}.png"), ImageFormat.Png);

                MessageBox.Show($"Path: {newPath}", "Convert", MessageBoxButtons.OK);
            }
        }

        private void CloseProjectButton_Click(object sender, EventArgs e)
        {
            if (Save == false && MessageBox.Show(res.GetString("SaveOpenJson"), res.GetString("SaveQ"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                saveToolStripMenuItem.PerformClick();

            Save = true;
            watchFace = new WatchFaceLibrary();
            RenderButton_Click(null, null);
            updateListElements();
        }
    }

    public class Gif
    {
        public static List<Image> LoadAnimatedGif(string path)
        {
            if (!File.Exists(path))
                throw new IOException("File does not exist");
            //Load the image
            var img = Image.FromFile(path);

            var dimension = new FrameDimension(img.FrameDimensionsList.First());
            var frameCount = img.GetFrameCount(dimension);

            if (frameCount <= 1)
                throw new ArgumentException("Image is not animated");

            List<Image> imgs = new List<Image>();

            foreach (var i in Enumerable.Range(0, frameCount))
            {
                img.SelectActiveFrame(dimension, i);
                imgs.Add((Image)img.Clone());
            }
            img.Dispose();
            return imgs;
        }
    }
}
