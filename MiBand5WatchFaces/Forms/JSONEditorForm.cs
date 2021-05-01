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
    public partial class JSONEditorForm : Form
    {
        public WatchFaceLibrary watch;
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

        DefaultDictionary<int, Image> Images;
        StateWatchface state;
        VisualRender render;
        public bool Save;
        string oldJson;

        public void Render(StateWatchface state = null)
        {
            try
            {
                render = new VisualRender(watch, state);
                ImagePic.BackgroundImage = render.GenWatchface();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), res.GetString("Error"));
            }
        }

        public static T DeepCopy<T>(T other)
        {
            if (other == null) return default(T);

            string clone = JsonConvert.SerializeObject(other);
            return JsonConvert.DeserializeObject<T>(clone);
        }

        public JSONEditorForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.state = state;
            this.watch.images = Images;
            this.Images = Images;

            try
            {
                WatchFaceLibrary saveWatch = DeepCopy(watch);
                saveWatch.TypeWatch = WatchFaceLibrary.typeWatch.None;
                jsonTextBox.Text = JsonConvert.SerializeObject(saveWatch, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                oldJson = jsonTextBox.Text;
            }
            catch { }

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                ImagePic.Size += watch.SizeMiBand6Rasn;
                //Size += watch.SizeMiBand6Rasn;

                jsonTextBox.Location += new Size(watch.SizeMiBand6Rasn.Width,0);
                jsonTextBox.Size -= new Size(watch.SizeMiBand6Rasn.Width, 0);
                RenderButton.Location += new Size(watch.SizeMiBand6Rasn.Width / 2, watch.SizeMiBand6Rasn.Height);
            }

            Render(state);
        }

        private void jsonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            try
            {
                WatchFaceLibrary.typeWatch type = watch.TypeWatch;
                watch = JsonConvert.DeserializeObject<WatchFaceLibrary>(jsonTextBox.Text);
                watch.TypeWatch = type;
                watch.images = Images.DeepCopy();
                Render(state);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), res.GetString("Error"));
            }
        }

        private void JSONEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                WatchFaceLibrary saveWatch = DeepCopy(watch);
                saveWatch.TypeWatch = WatchFaceLibrary.typeWatch.None;

                if (Save == false && oldJson != JsonConvert.SerializeObject(saveWatch, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }) && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    try
                    {
                        watch = JsonConvert.DeserializeObject<WatchFaceLibrary>(jsonTextBox.Text);
                        watch.images = Images.DeepCopy();
                        Render(state);
                        Save = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), res.GetString("Error"));
                        e.Cancel = true;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), res.GetString("Error"));
                e.Cancel = true;
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                watch = JsonConvert.DeserializeObject<WatchFaceLibrary>(jsonTextBox.Text);
                watch.images = Images.DeepCopy();
                Render(state);
                Save = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), res.GetString("Error"));
                return;
            }
            this.Close();
        }
    }
}
