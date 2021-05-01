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
    public partial class WeekDaysIconsForm : Form
    {
        public WatchFaceLibrary watch;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Resources.Resource1));

        StateWatchface state;
        VisualRender render;
        public bool Save;
        string oldWeek;

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

        public WeekDaysIconsForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.watch.images = Images;
            this.state = state;
            this.watch.WeekDaysIcons = this.watch.WeekDaysIcons == null ? new WeekDaysIcons() : this.watch.WeekDaysIcons;

            if (watch.TypeWatch == WatchFaceLibrary.typeWatch.MiBand6)
            {
                Size += watch.SizeMiBand6Rasn;
            }

            oldWeek = JsonConvert.SerializeObject(this.watch.WeekDaysIcons, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            Render(state);

            if (watch.WeekDaysIcons.Monday != null) mondayButton.Text = resources.GetString("EditMondayImage");
            if (watch.WeekDaysIcons.Tuesday != null) tuesdayButton.Text = resources.GetString("EditTuesdayImage");
            if (watch.WeekDaysIcons.Wednesday != null) wednesdayButton.Text = resources.GetString("EditWednesdayImage");
            if (watch.WeekDaysIcons.Thursday != null) thursdayButton.Text = resources.GetString("EditThursdayImage");
            if (watch.WeekDaysIcons.Friday != null) fridayButton.Text = resources.GetString("EditFridayImage");
            if (watch.WeekDaysIcons.Saturday != null) saturdayButton.Text = resources.GetString("EditSaturdayImage");
            if (watch.WeekDaysIcons.Sunday != null) sundayButton.Text = resources.GetString("EditSundayImage");
        }

        private void weekDayClick(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;

            if (name == mondayButton.Name)
            {
                watch.WeekDaysIcons.Monday = watch.WeekDaysIcons.Monday == null ? new ImageBasic() : watch.WeekDaysIcons.Monday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Monday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Monday, watch.images.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    mondayButton.Text = resources.GetString("EditMondayImage");
                    watch.WeekDaysIcons.Monday = ibForm.imageBasic;
                    watch.images = ibForm.watch.images;
                }
                else if (ibForm.delete)
                {
                    mondayButton.Text = resources.GetString("AddMondayImage");
                    watch.WeekDaysIcons.Monday = null;
                    watch.images = ibForm.watch.images;
                }
            }
            else if (name == tuesdayButton.Name)
            {
                watch.WeekDaysIcons.Tuesday = watch.WeekDaysIcons.Tuesday == null ? new ImageBasic() : watch.WeekDaysIcons.Tuesday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Tuesday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Tuesday, watch.images.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    tuesdayButton.Text = resources.GetString("EditTuesdayImage");
                    watch.WeekDaysIcons.Tuesday = ibForm.imageBasic;
                    watch.images = ibForm.watch.images;
                }
                else if (ibForm.delete)
                {
                    tuesdayButton.Text = resources.GetString("AddTuesdayImage");
                    watch.WeekDaysIcons.Tuesday = null;
                    watch.images = ibForm.watch.images;
                }
            }
            else if (name == wednesdayButton.Name)
            {
                watch.WeekDaysIcons.Wednesday = watch.WeekDaysIcons.Wednesday == null ? new ImageBasic() : watch.WeekDaysIcons.Wednesday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Wednesday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Wednesday, watch.images.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    wednesdayButton.Text = resources.GetString("EditWednesdayImage");
                    watch.WeekDaysIcons.Wednesday = ibForm.imageBasic;
                    watch.images = ibForm.watch.images;
                }
                else if (ibForm.delete)
                {
                    wednesdayButton.Text = resources.GetString("AddWednesdayImage");
                    watch.WeekDaysIcons.Wednesday = null;
                    watch.images = ibForm.watch.images;
                }
            }
            else if (name == thursdayButton.Name)
            {
                watch.WeekDaysIcons.Thursday = watch.WeekDaysIcons.Thursday == null ? new ImageBasic() : watch.WeekDaysIcons.Thursday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Thursday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Thursday, watch.images.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    thursdayButton.Text = resources.GetString("EditThursdayImage");
                    watch.WeekDaysIcons.Thursday = ibForm.imageBasic;
                    watch.images = ibForm.watch.images;
                }
                else if (ibForm.delete)
                {
                    thursdayButton.Text = resources.GetString("AddThursdayImage");
                    watch.WeekDaysIcons.Thursday = null;
                    watch.images = ibForm.watch.images;
                }
            }
            else if (name == fridayButton.Name)
            {
                watch.WeekDaysIcons.Friday = watch.WeekDaysIcons.Friday == null ? new ImageBasic() : watch.WeekDaysIcons.Friday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Friday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Friday, watch.images.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    fridayButton.Text = resources.GetString("EditFridayImage");
                    watch.WeekDaysIcons.Friday = ibForm.imageBasic;
                    watch.images = ibForm.watch.images;
                }
                else if (ibForm.delete)
                {
                    fridayButton.Text = resources.GetString("AddFridayImage");
                    watch.WeekDaysIcons.Friday = null;
                    watch.images = ibForm.watch.images;
                }
            }
            else if (name == saturdayButton.Name)
            {
                watch.WeekDaysIcons.Saturday = watch.WeekDaysIcons.Saturday == null ? new ImageBasic() : watch.WeekDaysIcons.Saturday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Saturday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Saturday, watch.images.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    saturdayButton.Text = resources.GetString("EditSaturdayImage");
                    watch.WeekDaysIcons.Saturday = ibForm.imageBasic;
                    watch.images = ibForm.watch.images;
                }
                else if (ibForm.delete)
                {
                    saturdayButton.Text = resources.GetString("AddSaturdayImage");
                    watch.WeekDaysIcons.Saturday = null;
                    watch.images = ibForm.watch.images;
                }
            }
            else if (name == sundayButton.Name)
            {
                watch.WeekDaysIcons.Sunday = watch.WeekDaysIcons.Sunday == null ? new ImageBasic() : watch.WeekDaysIcons.Sunday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Sunday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Sunday, watch.images.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    sundayButton.Text = resources.GetString("EditSundayImage");
                    watch.WeekDaysIcons.Sunday = ibForm.imageBasic;
                    watch.images = ibForm.watch.images;
                }
                else if (ibForm.delete)
                {
                    sundayButton.Text = resources.GetString("AddSundayImage");
                    watch.WeekDaysIcons.Sunday = null;
                    watch.images = ibForm.watch.images;
                }
            }

            Render(state);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save = true;

            if (watch.WeekDaysIcons.Monday == null &&
                watch.WeekDaysIcons.Tuesday == null &&
                watch.WeekDaysIcons.Wednesday == null &&
                watch.WeekDaysIcons.Thursday == null &&
                watch.WeekDaysIcons.Friday == null &&
                watch.WeekDaysIcons.Saturday == null &&
                watch.WeekDaysIcons.Sunday == null)
                watch.WeekDaysIcons = null;
            this.Close();
        }

        private void WeekDaysIconsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && oldWeek != JsonConvert.SerializeObject(this.watch.WeekDaysIcons, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }) && MessageBox.Show(resources.GetString("ExitMessage"), resources.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;

                if (watch.WeekDaysIcons.Monday == null &&
                watch.WeekDaysIcons.Tuesday == null &&
                watch.WeekDaysIcons.Wednesday == null &&
                watch.WeekDaysIcons.Thursday == null &&
                watch.WeekDaysIcons.Friday == null &&
                watch.WeekDaysIcons.Saturday == null &&
                watch.WeekDaysIcons.Sunday == null)
                    watch.WeekDaysIcons = null;
            }
        }
    }
}
