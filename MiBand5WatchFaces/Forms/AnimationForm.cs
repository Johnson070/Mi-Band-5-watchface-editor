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
    public partial class AnimationForm : Form
    {
        public WatchFaceLibrary watch;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Resources.Resource1));

        StateWatchface state;
        VisualRender render;
        public bool Save;

        public void Render(StateWatchface state = null, bool Animation = false)
        {
            render = new VisualRender(watch, state);
            ImagePic.BackgroundImage = Animation ? render.GenAnimationStep(true) : render.GenAnimationStep(false);

            if (GC.GetTotalMemory(false) / 1024 / 1024 > 10)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static T DeepCopy<T>(T other)
        {
            if (other == null) return default(T);

            string clone = JsonConvert.SerializeObject(other);
            return JsonConvert.DeserializeObject<T>(clone);
        }

        public void FillListBox()
        {
            if (watch.Other.Animation != null)
            {
                AnimationsListBox.Items.Clear();

                for (int i = 0; i < watch.Other.Animation.Count; i++)
                    AnimationsListBox.Items.Add(i);
            }
        }

        public AnimationForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();

            this.watch = watch;
            this.state = state;
            this.watch.images = Images;

            this.watch.Other = this.watch.Other == null ? new Other() : this.watch.Other;

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
            }

            Render(state);
            FillListBox();
        }

        private void AddImagesAnimationButton_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.Other.Animation = watchface.Other.Animation == null ? new List<Animation>() { new Animation() { AnimationImages = new ImageSet() } } : watchface.Other.Animation;
            ImageSetForm setForm = new ImageSetForm(watchface, watchface.Other.Animation[AnimationsListBox.SelectedIndex].AnimationImages, watch.images.DeepCopy(), state);
            setForm.ShowDialog();

            if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
            {
                watch.Other.Animation = watch.Other.Animation == null ? new List<Animation>() { new Animation() } : watch.Other.Animation;
                watch.images = setForm.watch.images;
                watch.Other.Animation[AnimationsListBox.SelectedIndex].AnimationImages = setForm.imageSet;
                AddImagesAnimationButton.Text = resources.GetString("EditImages");
            }
            else if (setForm.delete)
            {
                watch.images = setForm.watch.images;
                watch.Other.Animation.RemoveAt(AnimationsListBox.SelectedIndex);
                AddImagesAnimationButton.Text = resources.GetString("AddImages");
                FillListBox();
            }

            Render(state);
        }

        private void AnimationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AnimationsListBox.SelectedIndex != -1)
            {
                groupBox1.Enabled = true;
                AddImagesAnimationButton.Text = watch.Other.Animation[AnimationsListBox.SelectedIndex].AnimationImages.ImageIndex >= 0 ? resources.GetString("EditImages") : resources.GetString("AddImages");
                if (watch.Other.Animation[AnimationsListBox.SelectedIndex].AnimationImages.ImageIndex >= 0)
                {
                    SpeedUpDown.Enabled = true;
                    RepeatCountUpDown.Enabled = true;

                    SpeedUpDown.Value = watch.Other.Animation[AnimationsListBox.SelectedIndex].Speed > 255 ? 255 : watch.Other.Animation[AnimationsListBox.SelectedIndex].Speed;
                    RepeatCountUpDown.Value = watch.Other.Animation[AnimationsListBox.SelectedIndex].RepeatCount > 255 ? 255 : watch.Other.Animation[AnimationsListBox.SelectedIndex].RepeatCount;
                }
                else
                {
                    SpeedUpDown.Enabled = true;
                    RepeatCountUpDown.Enabled = true;
                    SpeedUpDown.Value = 100;
                    RepeatCountUpDown.Value = 10;
                }
            }
            else
            {
                groupBox1.Enabled = false;
                SpeedUpDown.Enabled = false;
                RepeatCountUpDown.Enabled = false;
                SpeedUpDown.Value = 100;
                RepeatCountUpDown.Value = 10;
                AddImagesAnimationButton.Text = resources.GetString("AddImages");
            }
        }

        private void SpeedUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (AnimationsListBox.SelectedIndex != -1)
                watch.Other.Animation[AnimationsListBox.SelectedIndex].Speed = (int)SpeedUpDown.Value;
            Render(state);
        }

        private void RepeatCountUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (AnimationsListBox.SelectedIndex != -1)
                watch.Other.Animation[AnimationsListBox.SelectedIndex].RepeatCount = (int)RepeatCountUpDown.Value;

            Render(state);
        }

        private void AddAnimationButton_Click(object sender, EventArgs e)
        {
            watch.Other.Animation = watch.Other.Animation == null ? new List<Animation>() : watch.Other.Animation;
            watch.Other.Animation.Add(new Animation() { AnimationImages = new ImageSet() });
            int select = AnimationsListBox.SelectedIndex;
            FillListBox();
            Render(state);
            AnimationsListBox.SelectedIndex = select;
        }

        private void RemoveAnimationButton_Click(object sender, EventArgs e)
        {
            if (AnimationsListBox.SelectedIndex != -1)
            {
                watch.Other.Animation.RemoveAt(AnimationsListBox.SelectedIndex);
                FillListBox();
                groupBox1.Enabled = false;
                SpeedUpDown.Enabled = false;
                RepeatCountUpDown.Enabled = false;

                Render(state);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save = true;
            if (watch.Other.Animation != null)
                for (int i = 0; i < watch.Other.Animation.Count; i++)
                    if (watch.Other.Animation[i].AnimationImages.ImageIndex < 0)
                    {
                        watch.Other.Animation.RemoveAt(i);
                        i -= 2;
                    }

            if (watch.Other.Animation == null)
                watch.Other = null;

            if (watch.Other != null && watch.Other.Animation != null && watch.Other.Animation.Count == 0)
                watch.Other = null;

            this.Close();
        }

        private void AnimationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show(resources.GetString("ExitMessage"), resources.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (watch.Other.Animation != null)
                    for (int i = 0; i < watch.Other.Animation.Count; i++)
                        if (watch.Other.Animation[i].AnimationImages.ImageIndex < 0)
                        {
                            watch.Other.Animation.RemoveAt(i);
                            i -= 2;
                        }

                if (watch.Other.Animation == null)
                    watch.Other = null;

                if (watch.Other != null && watch.Other.Animation != null && watch.Other.Animation.Count == 0)
                    watch.Other = null;
            }
        }

        private void AnimateTimer_Tick(object sender, EventArgs e)
        {
            if (watch.Other != null)
            {
                Render(state, true);
            }
        }
    }
}
