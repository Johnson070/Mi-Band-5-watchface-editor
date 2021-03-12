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
    public partial class TimeForm : Form
    {
        public WatchFaceLibrary watch;

        StateWatchface state;
        VisualRender render;
        bool checkArrows;
        bool editPosNoTime = false;
        public bool Save;

        public TimeForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            watch.imagesBuff = Images;
            this.state = state;

            this.watch.Time = watch.Time == null ? new Time() : watch.Time;
            this.watch.Time.UnknownV11 = 0;
            Render(state);


            if (watch.Time != null)
            {
                if (watch.Time.Hours != null && watch.Time.Hours.Ones != null) AddOnesHourBtn.Text = "Edit Ones";
                if (watch.Time.Hours != null && watch.Time.Hours.Tens != null) AddTensHourBtn.Text = "Edit Tens";
                if (watch.Time.Minutes != null && watch.Time.Minutes.Ones != null) AddOnesMinuteBtn.Text = "Edit Ones";
                if (watch.Time.Minutes != null && watch.Time.Minutes.Tens != null) AddTensMinuteBtn.Text = "Edit Tens";

                if (watch.Time.TimeZone1 != null)
                {
                    timeZone1ButtonEdit.Text = "Edit";
                    TZ1groupBox.Enabled = true;
                    timeZone1Check.Checked = true;
                    editPosTZ1Btn.Enabled = true;
                }
                if (watch.Time.TimeZone2 != null)
                {
                    timeZone2ButtonEdit.Text = "Edit";
                    TZ2groupBox.Enabled = true;
                    timeZone2Check.Checked = true;
                    editPosTZ2Btn.Enabled = true;
                }
                if (watch.Time?.TimeZone1NoTime != null)
                {
                    TZ1NoTime.Text = "Edit no time";
                }
                if (watch.Time?.TimeZone2NoTime != null)
                {
                    TZ2NoTime.Text = "Edit no time";
                }
                TZ1DelimeterBtn.Text = watch.Time.TimeZone1DelimiterImage >= 0 ? "Edit delimeter" : TZ1DelimeterBtn.Text;
                TZ2DelimeterBtn.Text = watch.Time.TimeZone2DelimiterImage >= 0 ? "Edit delimeter" : TZ2DelimeterBtn.Text;
            }
        }

        private void EditTwoDigits(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            List<int> selImg = null;
            ImagesForm imgForm;

            if (btn.Name == AddOnesHourBtn.Name)
            {
                if (watch.Time.Hours != null && watch.Time.Hours.Ones != null)
                {
                    selImg = new List<int>();

                    for (int i = watch.Time.Hours.Ones.ImageIndex; i < watch.Time.Hours.Ones.ImageIndex + watch.Time.Hours.Ones.ImagesCount; i++)
                        selImg.Add(i);
                }
                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, true, true,10);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.Hours = watch.Time.Hours == null ? new TwoDigits() : watch.Time.Hours;
                    watch.Time.Hours.Ones = watch.Time.Hours.Ones == null ? new ImageSet() : watch.Time.Hours.Ones;
                    watch.Time.Hours.Ones.ImageIndex = imgForm.selectedImages[0];
                    watch.Time.Hours.Ones.ImagesCount = imgForm.selectedImages.Count();
                    btn.Text = "Edit Ones";
                }
            }
            else if (btn.Name == AddTensHourBtn.Name)
            {
                if (watch.Time.Hours != null && watch.Time.Hours.Tens != null)
                {
                    selImg = new List<int>();

                    for (int i = watch.Time.Hours.Tens.ImageIndex; i < watch.Time.Hours.Tens.ImageIndex + watch.Time.Hours.Tens.ImagesCount; i++)
                        selImg.Add(i);
                }
                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, true, true,10);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.Hours = watch.Time.Hours == null ? new TwoDigits() : watch.Time.Hours;
                    watch.Time.Hours.Tens = watch.Time.Hours.Tens == null ? new ImageSet() : watch.Time.Hours.Tens;
                    watch.Time.Hours.Tens.ImageIndex = imgForm.selectedImages[0];
                    watch.Time.Hours.Tens.ImagesCount = imgForm.selectedImages.Count();
                    btn.Text = "Edit Tens";
                }
            }
            else if (btn.Name == AddOnesMinuteBtn.Name)
            {
                if (watch.Time.Minutes != null && watch.Time.Minutes.Ones != null)
                {
                    selImg = new List<int>();

                    for (int i = watch.Time.Minutes.Ones.ImageIndex; i < watch.Time.Minutes.Ones.ImageIndex + watch.Time.Minutes.Ones.ImagesCount; i++)
                        selImg.Add(i);
                }
                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, true, true,10);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.Minutes = watch.Time.Minutes == null ? new TwoDigits() : watch.Time.Minutes;
                    watch.Time.Minutes.Ones = watch.Time.Minutes.Ones == null ? new ImageSet() : watch.Time.Minutes.Ones;
                    watch.Time.Minutes.Ones.ImageIndex = imgForm.selectedImages[0];
                    watch.Time.Minutes.Ones.ImagesCount = imgForm.selectedImages.Count();
                    btn.Text = "Edit Ones";
                }
            }
            else if (btn.Name == AddTensMinuteBtn.Name)
            {
                if (watch.Time.Minutes != null && watch.Time.Minutes.Tens != null)
                {
                    selImg = new List<int>();

                    for (int i = watch.Time.Minutes.Tens.ImageIndex; i < watch.Time.Minutes.Tens.ImageIndex + watch.Time.Minutes.Tens.ImagesCount; i++)
                        selImg.Add(i);
                }
                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, true, true,10);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.Minutes = watch.Time.Minutes == null ? new TwoDigits() : watch.Time.Minutes;
                    watch.Time.Minutes.Tens = watch.Time.Minutes.Tens == null ? new ImageSet() : watch.Time.Minutes.Tens;
                    watch.Time.Minutes.Tens.ImageIndex = imgForm.selectedImages[0];
                    watch.Time.Minutes.Tens.ImagesCount = imgForm.selectedImages.Count();
                    btn.Text = "Edit Tens";
                }
            }

            Render(state);
        }

        private void editPos_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.Text = checkArrows ? (btn.Name.IndexOf("Tens") != -1 ? "Edit pos Tens" : "Edit pos Ones") : "End edit";
            checkArrows = checkArrows ? false : true;
            editPosDisableForm(new List<string>() { btn.Name }, checkArrows ? false : true);

            if (checkArrows == false) posImageLabel.Text = "";
            else
                switch (btn.Name)
                {
                    case "editPosTensHourBtn":
                        posImageLabel.Text = $"X: {watch.Time.Hours.Tens.X} Y:{watch.Time.Hours.Tens.Y}";
                        break;
                    case "editPosOnesHourBtn":
                        posImageLabel.Text = $"X: {watch.Time.Hours.Ones.X} Y:{watch.Time.Hours.Ones.Y}";
                        break;
                    case "editPosTensMinuteBtn":
                        posImageLabel.Text = $"X: {watch.Time.Minutes.Tens.X} Y:{watch.Time.Minutes.Tens.Y}";
                        break;
                    case "editPosOnesMinuteBtn":
                        posImageLabel.Text = $"X: {watch.Time.Minutes.Ones.X} Y:{watch.Time.Minutes.Ones.Y}";
                        break;
                    default:
                        break;
                }
        }

        private void editPosDisableForm(List<string> btnName, bool state)
        {
            foreach (var element in Controls)
                if (!(element is GroupBox))
                {
                    if (element is Button) ((Button)element).Enabled = state;
                    else if (element is CheckBox) ((CheckBox)element).Enabled = state;
                    else if (element is Panel) ((Panel)element).Enabled = state;
                }
                else
                    foreach (var elementGroup in ((GroupBox)element).Controls)
                    {
                        bool find = true;
                        foreach (string name in btnName)
                        {
                            if (((Button)elementGroup).Name != name) find = find && true;
                            else find = false;
                        }
                        if (elementGroup is Button && find) ((Button)elementGroup).Enabled = state;
                    }
        }

        private void editPosKeyArrowsPress(object sender, PreviewKeyDownEventArgs e)
        {
            Button btn = (Button)sender;

            int x = 0, y = 0;

            if (checkArrows)
                switch (e.KeyCode)
                {
                    case Keys.W:
                    case Keys.Up:
                        y -= 1;
                        break;
                    case Keys.S:
                    case Keys.Down:
                        y += 1;
                        break;
                    case Keys.D:
                    case Keys.Right:
                        x += 1;
                        break;
                    case Keys.A:
                    case Keys.Left:
                        x -= 1;
                        break;
                    default:
                        break;
                }

            switch (btn.Name)
            {
                case "editPosTensHourBtn":
                    if (watch.Time.Hours != null && watch.Time.Hours.Tens != null)
                    {
                        watch.Time.Hours.Tens.X += x;
                        watch.Time.Hours.Tens.Y += y;
                        posImageLabel.Text = $"X: {watch.Time.Hours.Tens.X} Y:{watch.Time.Hours.Tens.Y}";
                    }
                    break;
                case "editPosOnesHourBtn":
                    if (watch.Time.Hours != null && watch.Time.Hours.Ones != null)
                    {
                        watch.Time.Hours.Ones.X += x;
                        watch.Time.Hours.Ones.Y += y;
                        posImageLabel.Text = $"X: {watch.Time.Hours.Ones.X} Y:{watch.Time.Hours.Ones.Y}";
                    }
                    break;
                case "editPosTensMinuteBtn":
                    if (watch.Time.Minutes != null && watch.Time.Minutes.Tens != null)
                    {
                        watch.Time.Minutes.Tens.X += x;
                        watch.Time.Minutes.Tens.Y += y;
                        posImageLabel.Text = $"X: {watch.Time.Minutes.Tens.X} Y:{watch.Time.Minutes.Tens.Y}";
                    }
                    break;
                case "editPosOnesMinuteBtn":
                    if (watch.Time.Minutes != null && watch.Time.Minutes.Ones != null)
                    {
                        watch.Time.Minutes.Ones.X += x;
                        watch.Time.Minutes.Ones.Y += y;
                        posImageLabel.Text = $"X: {watch.Time.Minutes.Ones.X} Y:{watch.Time.Minutes.Ones.Y}";
                    }
                    break;
                case "editPosTZ1Btn":
                    if (editPosNoTime)
                    {
                        watch.Time.TimeZone1NoTime.X += x;
                        watch.Time.TimeZone1NoTime.Y += y;
                        posImageLabel.Text = $"X: {watch.Time.TimeZone1NoTime.X} Y:{watch.Time.TimeZone1NoTime.Y}";
                    }
                    else if (watch.Time.TimeZone1 != null)
                    {
                        watch.Time.TimeZone1.TopLeftX += x;
                        watch.Time.TimeZone1.BottomRightX += x;
                        watch.Time.TimeZone1.TopLeftY += y;
                        watch.Time.TimeZone1.BottomRightY += y;
                        posImageLabel.Text = $"X: {watch.Time.TimeZone1.TopLeftX} Y:{watch.Time.TimeZone1.TopLeftY}";
                    }

                    break;
                case "editPosTZ2Btn":
                    if (editPosNoTime)
                    {
                        watch.Time.TimeZone2NoTime.X += x;
                        watch.Time.TimeZone2NoTime.Y += y;
                        posImageLabel.Text = $"X: {watch.Time.TimeZone2NoTime.X} Y:{watch.Time.TimeZone2NoTime.Y}";
                    }
                    else if (watch.Time.TimeZone2 != null)
                    {
                        watch.Time.TimeZone2.TopLeftX += x;
                        watch.Time.TimeZone2.BottomRightX += x;
                        watch.Time.TimeZone2.TopLeftY += y;
                        watch.Time.TimeZone2.BottomRightY += y;
                        posImageLabel.Text = $"X: {watch.Time.TimeZone2.TopLeftX} Y:{watch.Time.TimeZone2.TopLeftY}";
                    }

                    break;
                default:
                    break;
            }

            StateWatchface stateNoTime = state;
            Render(editPosNoTime ? stateNoTime : state);
        }

        private void timeZoneChanged(object sender, EventArgs e)
        {
            TZ1groupBox.Enabled = timeZone1Check.Checked;
            TZ2groupBox.Enabled = timeZone2Check.Checked;
        }

        private void timeZone1ButtonEdit_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy<WatchFaceLibrary>(watch);
            watchface.Time.TimeZone1 = watchface.Time?.TimeZone1?.ImageIndex >= 0 ? watchface.Time.TimeZone1 : new Number() { notDraw = true };
            NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Time.TimeZone1, watch.imagesBuff.DeepCopy(), state,10);
            numForm.ShowDialog();

            if (numForm.saved && numForm.number.ImageIndex >= 0)
            {
                watch.Time.TimeZone1 = numForm.number;
                watch.imagesBuff = numForm.watch.imagesBuff;
                editPosTZ1Btn.Enabled = true;
                timeZone1ButtonEdit.Text = "Edit";
            }
            else if (numForm.delete)
            {
                watch.Time.TimeZone1 = null;
                watch.Time.TimeZone1DelimiterImage = -10000;
                watch.Time.TimeZone1NoTime = null;
                watch.imagesBuff = numForm.watch.imagesBuff;
                editPosTZ1Btn.Enabled = false;
                timeZone1ButtonEdit.Text = "Add";
                TZ1DelimeterBtn.Text = "Add delimeter";
                TZ1NoTime.Text = "Add no time";
                TZ1DelimeterBtn.Enabled = false;
                TZ1NoTime.Enabled = false;
            }

            Render(state);
        }

        private void timeZone2ButtonEdit_Click(object sender, EventArgs e)
        {
            WatchFaceLibrary watchface = DeepCopy<WatchFaceLibrary>(watch);
            watchface.Time.TimeZone2 = watchface.Time?.TimeZone2?.ImageIndex >= 0 ? watchface.Time.TimeZone2 : new Number() { notDraw = true };
            NumberFormEdit numForm = new NumberFormEdit(watchface, watchface.Time.TimeZone2, watch.imagesBuff.DeepCopy(), state,10);
            numForm.ShowDialog();

            if (numForm.saved && numForm.number.ImageIndex >= 0)
            {
                watch.Time.TimeZone2 = numForm.number;
                watch.imagesBuff = numForm.watch.imagesBuff;
                editPosTZ2Btn.Enabled = true;
                timeZone2ButtonEdit.Text = "Edit";
            }
            else if (numForm.delete)
            {
                watch.Time.TimeZone2 = null;
                watch.Time.TimeZone2DelimiterImage = -10000;
                watch.Time.TimeZone2NoTime = null;
                watch.imagesBuff = numForm.watch.imagesBuff;
                editPosTZ2Btn.Enabled = false;
                timeZone2ButtonEdit.Text = "Add";
                TZ2DelimeterBtn.Text = "Add delimeter";
                TZ2NoTime.Text = "Add no time";
                TZ2DelimeterBtn.Enabled = false;
                TZ2NoTime.Enabled = false;
            }

            Render(state);
        }

        private void addDelimeter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            List<int> selImg = null;
            ImagesForm imgForm;

            if (btn.Name == TZ1DelimeterBtn.Name)
            {
                if (watch.Time.TimeZone1DelimiterImage >= 0) selImg = new List<int>() { watch.Time.TimeZone1DelimiterImage };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.TimeZone1DelimiterImage = imgForm.selectedImages[0];
                    TZ1DelimeterBtn.Text = "Edit delimeter";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.TimeZone1DelimiterImage = -10000;
                    TZ1DelimeterBtn.Text = "Add delimeter";
                }
            }
            else if (btn.Name == TZ2DelimeterBtn.Name)
            {
                if (watch.Time.TimeZone2DelimiterImage >= 0) selImg = new List<int>() { watch.Time.TimeZone2DelimiterImage };

                imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                imgForm.ShowDialog();

                if (imgForm.saveImages == true && imgForm.selectedImages != null)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.TimeZone2DelimiterImage = imgForm.selectedImages[0];
                    TZ2DelimeterBtn.Text = "Edit delimeter";
                }
                else if (imgForm.saveImages == true)
                {
                    watch.imagesBuff = imgForm.Images;
                    watch.Time.TimeZone2DelimiterImage = -10000;
                    TZ2DelimeterBtn.Text = "Add delimeter";
                }
            }

            Render(state);
        }

        private void TZNoTime_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            List<int> selImg = null;
            ImagesForm imgForm;

            if (btn.Name == TZ1NoTime.Name)
            {
                if (btn.Text == "End edit no time")
                {
                    editPosDisableForm(new List<string>() { }, true);
                    TZ1NoTime.Text = "Edit no time";
                    editPosNoTime = false;
                }
                else
                {
                    if (watch.Time.TimeZone1NoTime != null && watch.Time?.TimeZone1NoTime?.ImageIndex >= 0) selImg = new List<int>() { watch.Time.TimeZone1NoTime.ImageIndex };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Time.TimeZone1NoTime = watch.Time.TimeZone1NoTime != null ? watch.Time.TimeZone1NoTime : new ImageBasic();
                        watch.Time.TimeZone1NoTime.ImageIndex = imgForm.selectedImages[0];
                        //TZ2DelimeterBtn.Text = "Edit delimeter";
                        editPosDisableForm(new List<string>() { btn.Name, editPosTZ1Btn.Name }, false);
                        editPosTZ1Btn.Enabled = true;
                        TZ1NoTime.Text = "End edit no time";
                        editPosNoTime = true;
                    }
                    else if (imgForm.saveImages == true)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Time.TimeZone1NoTime = null;
                        //TZ2DelimeterBtn.Text = "Edit delimeter";
                        editPosDisableForm(new List<string>() { btn.Name, editPosTZ1Btn.Name }, true);
                        //editPosTZ1Btn.Enabled = false;
                        TZ1NoTime.Text = "Add edit no time";
                    }
                }
            }
            else if (btn.Name == TZ2NoTime.Name)
            {
                if (btn.Text == "End edit no time")
                {
                    editPosDisableForm(new List<string>() { }, true);
                    TZ2NoTime.Text = "Edit no time";
                    editPosNoTime = false;
                }
                else
                {
                    if (watch.Time.TimeZone2NoTime != null && watch.Time?.TimeZone2NoTime?.ImageIndex >= 0) selImg = new List<int>() { watch.Time.TimeZone2NoTime.ImageIndex };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Time.TimeZone2NoTime = watch.Time.TimeZone2NoTime != null ? watch.Time.TimeZone2NoTime : new ImageBasic();
                        watch.Time.TimeZone2NoTime.ImageIndex = imgForm.selectedImages[0];
                        //TZ2DelimeterBtn.Text = "Edit delimeter";
                        editPosDisableForm(new List<string>() { btn.Name, editPosTZ2Btn.Name }, false);
                        editPosTZ2Btn.Enabled = true;
                        TZ2NoTime.Text = "End edit no time";
                        editPosNoTime = true;
                    }
                    else if (imgForm.saveImages == true)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Time.TimeZone2NoTime = null;
                        //TZ2DelimeterBtn.Text = "Edit delimeter";
                        editPosDisableForm(new List<string>() { btn.Name, editPosTZ2Btn.Name }, true);
                        //editPosTZ2Btn.Enabled = false;
                        TZ2NoTime.Text = "Add edit no time";
                    }
                }
            }

            state.NoTimeZone = editPosNoTime ? true : false;
            Render(state);
        }


        public static T DeepCopy<T>(T other)
        {
            if (other == null) return default(T);

            string clone = JsonConvert.SerializeObject(other);
            return JsonConvert.DeserializeObject<T>(clone);
        }

        private void editPosTZ(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.Text = checkArrows ? "Edit pos" : "End edit";
            checkArrows = checkArrows ? false : true;
            if (editPosNoTime == false) editPosDisableForm(new List<string>() { btn.Name }, checkArrows ? false : true);
            if (btn.Name == editPosTZ1Btn.Name) TZ1NoTime.Enabled = !checkArrows;
            else if (btn.Name == editPosTZ2Btn.Name) TZ2NoTime.Enabled = !checkArrows;

            if (checkArrows == false) posImageLabel.Text = "";
            else
                switch (btn.Name)
                {
                    case "editPosTZ1Btn":
                        if (editPosNoTime) posImageLabel.Text = $"X: {watch.Time.TimeZone1NoTime.X} Y:{watch.Time.TimeZone1NoTime.Y}";
                        else posImageLabel.Text = $"X: {watch.Time.TimeZone1.TopLeftX} Y:{watch.Time.TimeZone1.TopLeftY}";
                        break;
                    case "editPosTZ2Btn":
                        if (editPosNoTime) posImageLabel.Text = $"X: {watch.Time.TimeZone2NoTime.X} Y:{watch.Time.TimeZone2NoTime.Y}";
                        else posImageLabel.Text = $"X: {watch.Time.TimeZone2.TopLeftX} Y:{watch.Time.TimeZone2.TopLeftY}";
                        break;
                    default:
                        break;
                }
        }

        private void TimeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show("Do you want to get out without saving?", "Don't save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
            }

            if (timeZone1Check.Checked == false)
            {
                watch.Time.TimeZone1 = null;
                watch.Time.TimeZone1DelimiterImage = -10000;
                watch.Time.TimeZone1NoTime = null;
            }
            if (timeZone2Check.Checked == false)
            {
                watch.Time.TimeZone2 = null;
                watch.Time.TimeZone2DelimiterImage = -10000;
                watch.Time.TimeZone2NoTime = null;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (watch.Time.Hours.Ones == null || watch.Time.Hours.Tens == null || watch.Time.Minutes.Tens == null || watch.Time.Minutes.Ones == null)
            {
                if (MessageBox.Show("Hours tens and hour ones and minute tens and minutes ones should be added!\nExit without save?", "Don't save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
                else return;
            }
            Save = true;
            this.Close();
        }

        private void Render(StateWatchface state)
        {
            render = new VisualRender(watch,state);
            ImagePic.BackgroundImage = render.GenWatchface();
        }
    }
}
