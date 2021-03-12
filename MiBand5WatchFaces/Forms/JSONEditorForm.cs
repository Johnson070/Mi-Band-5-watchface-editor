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

        DefaultDictionary<int, Image> Images;
        StateWatchface state;
        VisualRender render;
        public bool Save;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Resources.Resource1));

        public void Render(StateWatchface state = null)
        {
            try
            {
                render = new VisualRender(watch, state);
                ImagePic.BackgroundImage = render.GenWatchface();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
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
            this.watch.imagesBuff = Images;
            this.Images = Images;

            try
            {
                jsonTextBox.Text = JsonConvert.SerializeObject(watch, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
            }
            catch { }

            Render(state);
        }

        private void jsonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            try
            {
                watch = JsonConvert.DeserializeObject<WatchFaceLibrary>(jsonTextBox.Text);
                watch.imagesBuff = Images.DeepCopy();
                Render(state);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }

        private void JSONEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show(resources.GetString("ExitMessage"), resources.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                try
                {
                    watch = JsonConvert.DeserializeObject<WatchFaceLibrary>(jsonTextBox.Text);
                    watch.imagesBuff = Images.DeepCopy();
                    Render(state);
                    Save = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error!");
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                watch = JsonConvert.DeserializeObject<WatchFaceLibrary>(jsonTextBox.Text);
                watch.imagesBuff = Images.DeepCopy();
                Render(state);
                Save = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
                return;
            }
            this.Close();
        }
    }
}
