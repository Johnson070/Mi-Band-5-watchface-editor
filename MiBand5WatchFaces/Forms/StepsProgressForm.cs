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
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

        StateWatchface state;
        VisualRender render;
        public bool Save;
        StateForm stateForm;
        string oldProgress;

        public enum StateForm
        {
            Steps = 0, Calories = 1
        }

        public void Render(StateWatchface state = null)
        {
            if (stateForm == StateForm.Calories) watch.CaloriesProgress = watch.formEdit.ConvertToSP();
            else watch.StepsProgress = watch.formEdit;
            render = new VisualRender(watch, state);
            ImagePic.BackgroundImage = render.GenWatchface();
        }

        public static T DeepCopy<T>(T other)
        {
            if (other == null) return default(T);

            string clone = JsonConvert.SerializeObject(other);
            return JsonConvert.DeserializeObject<T>(clone);
        }

        public StepsProgressForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state, StateForm stateForm)
        {
            InitializeComponent();
            this.watch = watch;
            this.watch.images = Images;
            this.state = state;
            this.stateForm = stateForm;

            if (stateForm == StateForm.Calories)
            {
                this.watch.formEdit = this.watch.CaloriesProgress == null ? new StepsProgress() : this.watch.CaloriesProgress.ConvertToSP();
                this.Text = "Calories Progress";
            }
            else
                this.watch.formEdit = this.watch.StepsProgress;

            this.watch.formEdit = this.watch.formEdit == null ? new StepsProgress() : this.watch.formEdit;

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
            }

            oldProgress = JsonConvert.SerializeObject(this.watch.formEdit, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            Render(state);


            if (watch.formEdit.GoalImage != null)
            {
                AddGoalImageButton.Text = res.GetString("EditImage");
                GoalImageCheckbox.Checked = true;
            }
            if (watch.formEdit.LineScale != null)
            {
                AddLineScaleButton.Text = res.GetString("EditImages");
                LineScaleCheckbox.Checked = true;
            }
            if (watch.formEdit.Linear != null)
            {
                AddLinearImages.Text = res.GetString("EditImages");
                LinearCheckBox.Checked = true;
            }
            if (watch.formEdit.CircleScale != null)
            {
                AddCircleScale.Text = res.GetString("EditCircleScale");
                CircleScaleCheckbox.Checked = true;
            }
        }

        private void AddLineScaleImages_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            if (stateForm == StateForm.Steps)
            {
                watchface.StepsProgress = watchface.formEdit == null ? new StepsProgress() : watchface.StepsProgress;
                watchface.StepsProgress.Linear = watchface.formEdit.Linear == null ? new Scale() : watchface.formEdit.Linear;
                watchface.formEdit.Linear = watchface.StepsProgress.Linear;
            }
            else
            {
                watchface.CaloriesProgress = watchface.formEdit == null ? new CaloriesProgress() : watchface.CaloriesProgress;
                watchface.CaloriesProgress.Linear = watchface.formEdit.Linear == null ? new Scale() : watchface.formEdit.Linear;
                watchface.formEdit.Linear = watchface.CaloriesProgress.Linear;
            }

            StateWatchface stepsState = DeepCopy(state);
            stepsState.Steps = 10000;

            ScaleForm scaleForm = new ScaleForm(watchface, watchface.formEdit.Linear, watch.images.DeepCopy(), stepsState);
            scaleForm.ShowDialog();

            if (scaleForm.saved == true && scaleForm.scale.StartImageIndex >= 0)
            {
                watch.formEdit.Linear = scaleForm.scale;
                watch.images = scaleForm.watch.images;

                AddLinearImages.Text = res.GetString("EditImages");
            }
            else if (scaleForm.delete)
            {
                watch.formEdit.Linear = null;
                watch.images = scaleForm.watch.images;

                AddLinearImages.Text = res.GetString("AddImages");
            }

            Render(state);
        }

        private void AddGoalImageButton_Click(object sender, EventArgs e)
        {
            watch.formEdit.GoalImage = watch.formEdit.GoalImage == null ? new ImageBasic() : watch.formEdit.GoalImage;
            ImageBasicForm ibForm = new ImageBasicForm(watch, watch.formEdit.GoalImage, watch.images.DeepCopy(), state);
            ibForm.ShowDialog();

            if (ibForm.saved)
            {
                AddGoalImageButton.Text = res.GetString("EditImage");
                watch.formEdit.GoalImage = ibForm.imageBasic;
                watch.images = ibForm.watch.images;
            }
            else if (ibForm.delete)
            {
                AddGoalImageButton.Text = res.GetString("AddImage");
                watch.formEdit.GoalImage = null;
                watch.images = ibForm.watch.images;
            }

            Render(state);
        }

        private void AddLineScaleButton_Click(object sender, EventArgs e)
        {
            //List<int> selImg = null;
            //ImagesForm imgForm;
            //if (watch.formEdit.LineScale.ImageIndex >= 0)
            //{
            //    selImg = new List<int>();

            //    for (int i = watch.formEdit.LineScale.ImageIndex; i < watch.formEdit.LineScale.ImageIndex + watch.formEdit.LineScale.ImagesCount; i++)
            //        selImg.Add(i);
            //}

            //imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, true, true);
            //imgForm.ShowDialog();

            //if (imgForm.saveImages == true && imgForm.selectedImages != null)
            //{
            //    watch.imagesBuff = imgForm.Images;
            //    watch.formEdit.LineScale = watch.formEdit.LineScale == null ? new LineScale() : watch.formEdit.LineScale;
            //    watch.formEdit.LineScale.ImageIndex = imgForm.selectedImages[0];
            //    watch.formEdit.LineScale.ImagesCount = imgForm.selectedImages.Count;
            //    AddLineScaleButton.Text = "Edit images";
            //    posXNum.Enabled = true;
            //    posYNum.Enabled = true;
            //}
            //else if (imgForm.saveImages == true)
            //{
            //    watch.imagesBuff = imgForm.Images;
            //    watch.formEdit.LineScale = null;
            //    AddLineScaleButton.Text = "Add images";
            //    posXNum.Enabled = false;
            //    posYNum.Enabled = false;
            //}
            WatchFaceLibrary watchface = DeepCopy(watch);
            if (stateForm == StateForm.Calories)
                watchface.CaloriesProgress.LineScale = watchface.CaloriesProgress.LineScale == null ? new ImageSet() : watchface.CaloriesProgress.LineScale;
            else
                watchface.StepsProgress.LineScale = watchface.StepsProgress.LineScale == null ? new ImageSet() : watchface.StepsProgress.LineScale;
            ImageSetForm setForm = new ImageSetForm(watchface, stateForm == StateForm.Calories ? watchface.CaloriesProgress.LineScale : watchface.StepsProgress.LineScale, watch.images.DeepCopy(), state);
            setForm.ShowDialog();

            if (setForm.saved && setForm.imageSet.ImageIndex >= 0)
            {
                watch.images = setForm.watch.images;
                watch.formEdit.LineScale = watch.formEdit.LineScale == null ? new ImageSet() : watch.formEdit.LineScale;
                watch.formEdit.LineScale = setForm.imageSet;
                AddLineScaleButton.Text = res.GetString("EditImages");
            }
            else if (setForm.delete)
            {
                watch.images = setForm.watch.images;
                watch.formEdit.LineScale = null;
                AddLineScaleButton.Text = res.GetString("AddImages");
            }

            Render(state);
        }

        private void AddCircleScale_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy(watch);
            if (stateForm == StateForm.Steps) watchface.StepsProgress.CircleScale = watchface.formEdit.CircleScale == null ? new CircleScale() : watchface.formEdit.CircleScale;
            else watchface.CaloriesProgress.CircleScale = watchface.formEdit.CircleScale == null ? new CircleScale() : watchface.formEdit.CircleScale;

            CircleScaleForm scaleForm = new CircleScaleForm(watchface, stateForm == StateForm.Steps ? watchface.StepsProgress.CircleScale : watchface.CaloriesProgress.CircleScale, watch.images.DeepCopy(), state);
            scaleForm.ShowDialog();

            if (scaleForm.saved)
            {
                watch.formEdit.CircleScale = scaleForm.circleScale;
                watch.images = scaleForm.watch.images;

                AddCircleScale.Text = res.GetString("EditCircleScale");
            }
            else if (scaleForm.delete)
            {
                watch.formEdit.CircleScale = null;
                watch.images = scaleForm.watch.images;

                AddCircleScale.Text = res.GetString("AddCircleScale");
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
            if (Save == false && oldProgress != JsonConvert.SerializeObject(this.watch.formEdit, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }) && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;

                if (CircleScaleCheckbox.Checked == false) watch.formEdit.CircleScale = null;
                if (LinearCheckBox.Checked == false) watch.formEdit.Linear = null;
                if (LineScaleCheckbox.Checked == false) watch.formEdit.LineScale = null;
                if (GoalImageCheckbox.Checked == false) watch.formEdit.GoalImage = null;

                if (watch.formEdit.GoalImage == null && watch.formEdit.Linear == null && watch.formEdit.LineScale == null && watch.formEdit.CircleScale == null)
                    watch.formEdit = null;

                if (stateForm == StateForm.Calories)
                    watch.CaloriesProgress = watch.formEdit == null ? null : watch.formEdit.ConvertToSP();
                else
                    watch.StepsProgress = watch.formEdit;
            }

            watch.formEdit = null;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save = true;
            if (CircleScaleCheckbox.Checked == false) watch.formEdit.CircleScale = null;
            if (LinearCheckBox.Checked == false) watch.formEdit.Linear = null;
            if (LineScaleCheckbox.Checked == false) watch.formEdit.LineScale = null;
            if (GoalImageCheckbox.Checked == false) watch.formEdit.GoalImage = null;

            if (watch.formEdit.GoalImage == null && watch.formEdit.Linear == null && watch.formEdit.LineScale == null && watch.formEdit.CircleScale == null)
                watch.formEdit = null;

            if (stateForm == StateForm.Calories)
                watch.CaloriesProgress = watch.formEdit == null ? null : watch.formEdit.ConvertToSP();
            else
                watch.StepsProgress = watch.formEdit;

            watch.formEdit = null;
            this.Close();
        }
    }
}
