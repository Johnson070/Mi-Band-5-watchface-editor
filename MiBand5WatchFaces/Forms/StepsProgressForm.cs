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
    public partial class StepsProgressForm : Form
    {
        public WatchFaceLibrary watch;

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

        public StepsProgressForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.watch.imagesBuff = Images;
            this.state = state;

            this.watch.StepsProgress = this.watch.StepsProgress == null ? new StepsProgress() : this.watch.StepsProgress;
            Render(state);


            if (watch.StepsProgress.GoalImage != null)
            {
                AddGoalImageButton.Text = "Edit image";
                GoalImageCheckbox.Checked = true;
            }
            if (watch.StepsProgress.LineScale != null)
            {
                AddLineScaleButton.Text = "Edit images";
                LineScaleCheckbox.Checked = true;
                posXNum.Enabled = true;
                posYNum.Enabled = true;
                posXNum.Value = watch.StepsProgress.LineScale.X;
                posYNum.Value = watch.StepsProgress.LineScale.Y;
            }
            if (watch.StepsProgress.Linear != null)
            {
                AddLinearImages.Text = "Edit images";
                LinearCheckBox.Checked = true;
            }
            if (watch.StepsProgress.CircleScale != null)
            {
                AddCircleScale.Text = "Edit circle scale";
                CircleScaleCheckbox.Checked = true;
            }
        }

        private void AddLineScaleImages_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.StepsProgress.Linear = watchface.StepsProgress.Linear == null ? new Scale() : watchface.StepsProgress.Linear;
            ScaleForm scaleForm = new ScaleForm(watchface, watchface.StepsProgress.Linear, watch.imagesBuff.DeepCopy(), state);
            scaleForm.ShowDialog();

            if (scaleForm.saved == true)
            {
                watch.StepsProgress.Linear = scaleForm.scale;
                watch.imagesBuff = scaleForm.watch.imagesBuff;

                AddLinearImages.Text = "Edit images";
            }
            else if (scaleForm.saved == true && scaleForm.scale.StartImageIndex == -10000)
            {
                watch.StepsProgress.Linear = null;
                watch.imagesBuff = scaleForm.watch.imagesBuff;

                AddLinearImages.Text = "Add images";
            }

            Render(state);
        }

        private void AddGoalImageButton_Click(object sender, EventArgs e)
        {
            watch.StepsProgress.GoalImage = watch.StepsProgress.GoalImage == null ? new ImageBasic() : watch.StepsProgress.GoalImage;
            ImageBasicForm ibForm = new ImageBasicForm(watch, watch.StepsProgress.GoalImage, watch.imagesBuff.DeepCopy(), state);
            ibForm.ShowDialog();

            if (ibForm.saved)
            {
                AddGoalImageButton.Text = "Edit image";
                watch.StepsProgress.GoalImage = ibForm.imageBasic;
                watch.imagesBuff = ibForm.watch.imagesBuff;
            }
            else
            {
                AddGoalImageButton.Text = "Add image";
                watch.StepsProgress.GoalImage = null;
                watch.imagesBuff = ibForm.watch.imagesBuff;
            }

            Render(state);
        }

        private void AddLineScaleButton_Click(object sender, EventArgs e)
        {
            List<int> selImg = null;
            ImagesForm imgForm;
            if (watch.StepsProgress.LineScale.ImageIndex != -10000)
            {
                selImg = new List<int>();

                for (int i = watch.StepsProgress.LineScale.ImageIndex; i < watch.StepsProgress.LineScale.ImageIndex + watch.StepsProgress.LineScale.ImagesCount; i++)
                    selImg.Add(i);
            }

            imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, true, true);
            imgForm.ShowDialog();

            if (imgForm.saveImages == true && imgForm.selectedImages != null)
            {
                watch.imagesBuff = imgForm.Images;
                watch.StepsProgress.LineScale = watch.StepsProgress.LineScale == null ? new LineScale() : watch.StepsProgress.LineScale;
                watch.StepsProgress.LineScale.ImageIndex = imgForm.selectedImages[0];
                watch.StepsProgress.LineScale.ImagesCount = imgForm.selectedImages.Count;
                AddLineScaleButton.Text = "Edit images";
                posXNum.Enabled = true;
                posYNum.Enabled = true;
            }
            else if (imgForm.saveImages == true)
            {
                watch.imagesBuff = imgForm.Images;
                watch.StepsProgress.LineScale = null;
                AddLineScaleButton.Text = "Add images";
                posXNum.Enabled = false;
                posYNum.Enabled = false;
            }

            Render(state);
        }

        private void posChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;

            if (numeric.Name == "posXNum")
            {
                watch.StepsProgress.LineScale.X = (int)posXNum.Value;
            }
            else if (numeric.Name == "posYNum")
            {
                watch.StepsProgress.LineScale.Y = (int)posYNum.Value;
            }

            Render(state);
        }

        private void AddCircleScale_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            watchface.StepsProgress.CircleScale = watchface.StepsProgress.CircleScale == null ? new CircleScale() : watchface.StepsProgress.CircleScale;
            StateWatchface stepsState = state;
            stepsState.Steps = 10000;
            CircleScaleForm scaleForm = new CircleScaleForm(watchface, watchface.StepsProgress.CircleScale, watch.imagesBuff.DeepCopy(), stepsState);
            scaleForm.ShowDialog();

            if (scaleForm.saved)
            {
                watch.StepsProgress.CircleScale = scaleForm.circleScale;
                watch.imagesBuff = scaleForm.watch.imagesBuff;

                AddCircleScale.Text = "Edit circle scale";
            }

            Render(state);
        }

        private void ChangeCheck(object sender, EventArgs e)
        {
            groupBox1.Enabled = GoalImageCheckbox.Checked;
            groupBox3.Enabled = LineScaleCheckbox.Checked;
            groupBox2.Enabled = LinearCheckBox.Checked;
            groupBox4.Enabled = CircleScaleCheckbox.Checked;
        }

        private void NumberFormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show("Do you want to get out without saving?", "Don't Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;

                if (CircleScaleCheckbox.Checked == false) watch.StepsProgress.CircleScale = null;
                if (LinearCheckBox.Checked == false) watch.StepsProgress.Linear = null;
                if (LineScaleCheckbox.Checked == false) watch.StepsProgress.LineScale = null;
                if (GoalImageCheckbox.Checked == false) watch.StepsProgress.GoalImage = null;

                if (watch.StepsProgress.GoalImage == null && watch.StepsProgress.Linear == null && watch.StepsProgress.LineScale == null && watch.StepsProgress.CircleScale == null)
                    watch.StepsProgress = null;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save = true;
            if (CircleScaleCheckbox.Checked == false) watch.StepsProgress.CircleScale = null;
            if (LinearCheckBox.Checked == false) watch.StepsProgress.Linear = null;
            if (LineScaleCheckbox.Checked == false) watch.StepsProgress.LineScale = null;
            if (GoalImageCheckbox.Checked == false) watch.StepsProgress.GoalImage = null;

            if (watch.StepsProgress.GoalImage == null && watch.StepsProgress.Linear == null && watch.StepsProgress.LineScale == null && watch.StepsProgress.CircleScale == null)
                watch.StepsProgress = null;
            this.Close();
        }
    }
}
