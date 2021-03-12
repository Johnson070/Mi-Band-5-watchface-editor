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

        public WeekDaysIconsForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.watch.imagesBuff = Images;
            this.state = state;
            this.watch.WeekDaysIcons = this.watch.WeekDaysIcons == null ? new WeekDaysIcons() : this.watch.WeekDaysIcons;
            Render(state);

            if (watch.WeekDaysIcons.Monday != null) mondayButton.Text = "Edit monday image";
            if (watch.WeekDaysIcons.Tuesday != null) tuesdayButton.Text = "Edit tuesday image";
            if (watch.WeekDaysIcons.Wednesday != null) wednesdayButton.Text = "Edit wednesday image";
            if (watch.WeekDaysIcons.Thursday != null) thursdayButton.Text = "Edit thursday image";
            if (watch.WeekDaysIcons.Friday != null) fridayButton.Text = "Edit friday image";
            if (watch.WeekDaysIcons.Saturday != null) saturdayButton.Text = "Edit saturday image";
            if (watch.WeekDaysIcons.Sunday != null) sundayButton.Text = "Edit sunday image";
        }

        private void weekDayClick(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;

            if (name == mondayButton.Name)
            {
                watch.WeekDaysIcons.Monday = watch.WeekDaysIcons.Monday == null ? new ImageBasic() : watch.WeekDaysIcons.Monday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Monday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Monday, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    mondayButton.Text = "Edit monday image";
                    watch.WeekDaysIcons.Monday = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    mondayButton.Text = "Add monday image";
                    watch.WeekDaysIcons.Monday = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (name == tuesdayButton.Name)
            {
                watch.WeekDaysIcons.Tuesday = watch.WeekDaysIcons.Tuesday == null ? new ImageBasic() : watch.WeekDaysIcons.Tuesday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Tuesday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Tuesday, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    tuesdayButton.Text = "Edit tuesday image";
                    watch.WeekDaysIcons.Tuesday = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    tuesdayButton.Text = "Add tuesday image";
                    watch.WeekDaysIcons.Tuesday = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (name == wednesdayButton.Name)
            {
                watch.WeekDaysIcons.Wednesday = watch.WeekDaysIcons.Wednesday == null ? new ImageBasic() : watch.WeekDaysIcons.Wednesday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Wednesday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Wednesday, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    wednesdayButton.Text = "Edit wednesday image";
                    watch.WeekDaysIcons.Wednesday = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    wednesdayButton.Text = "Add wednesday image";
                    watch.WeekDaysIcons.Wednesday = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (name == thursdayButton.Name)
            {
                watch.WeekDaysIcons.Thursday = watch.WeekDaysIcons.Thursday == null ? new ImageBasic() : watch.WeekDaysIcons.Thursday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Thursday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Thursday, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    thursdayButton.Text = "Edit thursday image";
                    watch.WeekDaysIcons.Thursday = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    thursdayButton.Text = "Add thursday image";
                    watch.WeekDaysIcons.Thursday = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (name == fridayButton.Name)
            {
                watch.WeekDaysIcons.Friday = watch.WeekDaysIcons.Friday == null ? new ImageBasic() : watch.WeekDaysIcons.Friday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Friday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Friday, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    fridayButton.Text = "Edit friday image";
                    watch.WeekDaysIcons.Friday = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    fridayButton.Text = "Add friday image";
                    watch.WeekDaysIcons.Friday = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (name == saturdayButton.Name)
            {
                watch.WeekDaysIcons.Saturday = watch.WeekDaysIcons.Saturday == null ? new ImageBasic() : watch.WeekDaysIcons.Saturday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Saturday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Saturday, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    saturdayButton.Text = "Edit saturday image";
                    watch.WeekDaysIcons.Saturday = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    saturdayButton.Text = "Add saturday image";
                    watch.WeekDaysIcons.Saturday = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
            }
            else if (name == sundayButton.Name)
            {
                watch.WeekDaysIcons.Sunday = watch.WeekDaysIcons.Sunday == null ? new ImageBasic() : watch.WeekDaysIcons.Sunday;
                StateWatchface newState = DeepCopy(state);
                newState.DayOfWeek = DayOfWeek.Sunday;
                ImageBasicForm ibForm = new ImageBasicForm(watch, watch.WeekDaysIcons.Sunday, watch.imagesBuff.DeepCopy(), newState);
                ibForm.ShowDialog();

                if (ibForm.saved)
                {
                    sundayButton.Text = "Edit sunday image";
                    watch.WeekDaysIcons.Sunday = ibForm.imageBasic;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
                }
                else if (ibForm.delete)
                {
                    sundayButton.Text = "Add sunday image";
                    watch.WeekDaysIcons.Sunday = null;
                    watch.imagesBuff = ibForm.watch.imagesBuff;
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
            if (Save == false && MessageBox.Show("Do you want to get out without saving?", "Don't Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
