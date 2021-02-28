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
    public partial class StatusForm : Form
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

        //public static T DeepCopy<T>(T other)
        //{
        //    if (other == null) return default(T);

        //    string clone = JsonConvert.SerializeObject(other);
        //    return JsonConvert.DeserializeObject<T>(clone);
        //}

        public StatusForm(WatchFaceLibrary watch, DefaultDictionary<int, Image> Images, StateWatchface state)
        {
            InitializeComponent();
            this.watch = watch;
            this.state = state;
            this.watch.imagesBuff = Images;

            this.watch.Status = this.watch.Status == null ? new Status() : this.watch.Status;

            Render(state);

            if (watch.Status.Bluetooth != null)
            {
                bluetoothCheckbox.Checked = true;
                if (watch.Status.Bluetooth.ImageIndexOn >= 0) AddImageONBluetooth.Text = "Edit image ON";
                if (watch.Status.Bluetooth.ImageIndexOff >= 0) AddImageOFFBluetooth.Text = "Edit image OFF";
                posXBluetooth.Value = watch.Status.Bluetooth.Coordinates.X;
                posYBluetooth.Value = watch.Status.Bluetooth.Coordinates.Y;
                if (watch.Status.Bluetooth.ImageIndexOn >= 0 || watch.Status.Bluetooth.ImageIndexOff >= 0)
                {
                    posXBluetooth.Enabled = true;
                    posYBluetooth.Enabled = true;
                }
            }
            if (watch.Status.Lock != null)
            {
                lockCheckbox.Checked = true;
                if (watch.Status.Lock.ImageIndexOn >= 0) AddImageONLock.Text = "Edit image ON";
                if (watch.Status.Lock.ImageIndexOff >= 0) AddImageOFFLock.Text = "Edit image OFF";
                posXLock.Value = watch.Status.Lock.Coordinates.X;
                posYLock.Value = watch.Status.Lock.Coordinates.Y;
                if (watch.Status.Lock.ImageIndexOn >= 0 || watch.Status.Lock.ImageIndexOff >= 0)
                {
                    posXLock.Enabled = true;
                    posYLock.Enabled = true;
                }
            }
            if (watch.Status.DoNotDisturb != null)
            {
                dndCheclbox.Checked = true;
                if (watch.Status.DoNotDisturb.ImageIndexOn >= 0) AddImageONDND.Text = "Edit image ON";
                if (watch.Status.DoNotDisturb.ImageIndexOff >= 0) AddImageOFFDND.Text = "Edit image OFF";
                posXDND.Value = watch.Status.DoNotDisturb.Coordinates.X;
                posYDND.Value = watch.Status.DoNotDisturb.Coordinates.Y;
                if (watch.Status.DoNotDisturb.ImageIndexOn >= 0 || watch.Status.DoNotDisturb.ImageIndexOff >= 0)
                {
                    posXDND.Enabled = true;
                    posYDND.Enabled = true;
                }
            }
        }

        private void AddImageClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            List<int> selImg = null;
            ImagesForm imgForm;

            if (btn.Name.IndexOf("Bluetooth") != -1)
            {
                if (btn.Name == "AddImageONBluetooth")
                {
                    if (watch.Status?.Bluetooth?.ImageIndexOn >= 0) selImg = new List<int>() { watch.Status.Bluetooth.ImageIndexOn };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Bluetooth = watch.Status.Bluetooth == null ? new Switch() : watch.Status.Bluetooth;
                        watch.Status.Bluetooth.Coordinates = watch.Status.Bluetooth.Coordinates == null ? new Coordinates() : watch.Status.Bluetooth.Coordinates;
                        watch.Status.Bluetooth.ImageIndexOn = imgForm.selectedImages[0];
                        AddImageONBluetooth.Text = "Edit image ON";
                        posXBluetooth.Enabled = true;
                        posYBluetooth.Enabled = true;
                    }
                    else if (imgForm.saveImages == true)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Bluetooth.ImageIndexOn = -10000;
                        AddImageONBluetooth.Text = "Add image ON";
                    }
                }
                else if (btn.Name == "AddImageOFFBluetooth")
                {
                    if (watch.Status?.Bluetooth?.ImageIndexOff >= 0) selImg = new List<int>() { watch.Status.Bluetooth.ImageIndexOff };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Bluetooth = watch.Status.Bluetooth == null ? new Switch() : watch.Status.Bluetooth;
                        watch.Status.Bluetooth.Coordinates = watch.Status.Bluetooth.Coordinates == null ? new Coordinates() : watch.Status.Bluetooth.Coordinates;
                        watch.Status.Bluetooth.ImageIndexOff = imgForm.selectedImages[0];
                        AddImageOFFBluetooth.Text = "Edit image OFF";
                        posXBluetooth.Enabled = true;
                        posYBluetooth.Enabled = true;
                    }
                    else if (imgForm.saveImages == true)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Bluetooth.ImageIndexOff = -10000;
                        AddImageOFFBluetooth.Text = "Add image OFF";
                    }
                }

                if (watch.Status.Bluetooth != null && watch.Status.Bluetooth.ImageIndexOn == -10000 && watch.Status.Bluetooth.ImageIndexOff == -10000)
                {
                    AddImageOFFBluetooth.Text = "Add image OFF";
                    AddImageONBluetooth.Text = "Add image ON";
                    posXBluetooth.Enabled = false;
                    posYBluetooth.Enabled = false;
                    watch.Status.Bluetooth = null;
                }
            }
            if (btn.Name.IndexOf("Lock") != -1)
            {
                if (btn.Name == "AddImageONLock")
                {
                    if (watch.Status?.Lock?.ImageIndexOn >= 0) selImg = new List<int>() { watch.Status.Lock.ImageIndexOn };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Lock = watch.Status.Lock == null ? new Switch() : watch.Status.Lock;
                        watch.Status.Lock.Coordinates = watch.Status.Lock.Coordinates == null ? new Coordinates() : watch.Status.Lock.Coordinates;
                        watch.Status.Lock.ImageIndexOn = imgForm.selectedImages[0];
                        AddImageONLock.Text = "Edit image ON";
                        posXLock.Enabled = true;
                        posYLock.Enabled = true;
                    }
                    else if (imgForm.saveImages == true)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Lock.ImageIndexOn = -10000;
                        AddImageONLock.Text = "Add image ON";
                    }
                }
                else if (btn.Name == "AddImageOFFLock")
                {
                    if (watch.Status?.Lock?.ImageIndexOff >= 0) selImg = new List<int>() { watch.Status.Lock.ImageIndexOff };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Lock = watch.Status.Lock == null ? new Switch() : watch.Status.Lock;
                        watch.Status.Lock.Coordinates = watch.Status.Lock.Coordinates == null ? new Coordinates() : watch.Status.Lock.Coordinates;
                        watch.Status.Lock.ImageIndexOff = imgForm.selectedImages[0];
                        AddImageOFFLock.Text = "Edit image OFF";
                        posXLock.Enabled = true;
                        posYLock.Enabled = true;
                    }
                    else if (imgForm.saveImages == true)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Lock.ImageIndexOff = -10000;
                        AddImageOFFLock.Text = "Add image OFF";
                    }
                }

                if (watch.Status.Lock != null && watch.Status.Lock.ImageIndexOn == -10000 && watch.Status.Lock.ImageIndexOff == -10000)
                {
                    AddImageOFFLock.Text = "Add image OFF";
                    AddImageONLock.Text = "Add image ON";
                    posXLock.Enabled = false;
                    posYLock.Enabled = false;
                    watch.Status.Lock = null;
                }
            }
            if (btn.Name.IndexOf("DND") != -1)
            {
                if (btn.Name == "AddImageONDND")
                {
                    if (watch.Status?.DoNotDisturb?.ImageIndexOn >= 0) selImg = new List<int>() { watch.Status.DoNotDisturb.ImageIndexOn };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.DoNotDisturb = watch.Status.DoNotDisturb == null ? new Switch() : watch.Status.DoNotDisturb;
                        watch.Status.DoNotDisturb.Coordinates = watch.Status.DoNotDisturb.Coordinates == null ? new Coordinates() : watch.Status.DoNotDisturb.Coordinates;
                        watch.Status.DoNotDisturb.ImageIndexOn = imgForm.selectedImages[0];
                        AddImageONDND.Text = "Edit image ON";
                        posXDND.Enabled = true;
                        posYDND.Enabled = true;
                    }
                    else if (imgForm.saveImages == true)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.DoNotDisturb.ImageIndexOn = -10000;
                        AddImageONDND.Text = "Add image ON";
                    }
                }
                else if (btn.Name == "AddImageOFFDND")
                {
                    if (watch.Status?.DoNotDisturb?.ImageIndexOff >= 0) selImg = new List<int>() { watch.Status.DoNotDisturb.ImageIndexOff };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.DoNotDisturb = watch.Status.DoNotDisturb == null ? new Switch() : watch.Status.DoNotDisturb;
                        watch.Status.DoNotDisturb.Coordinates = watch.Status.DoNotDisturb.Coordinates == null ? new Coordinates() : watch.Status.DoNotDisturb.Coordinates;
                        watch.Status.DoNotDisturb.ImageIndexOff = imgForm.selectedImages[0];
                        AddImageOFFDND.Text = "Edit image OFF";
                        posXDND.Enabled = true;
                        posYDND.Enabled = true;
                    }
                    else if (imgForm.saveImages == true)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.DoNotDisturb.ImageIndexOff = -10000;
                        AddImageOFFDND.Text = "Add image OFF";
                    }
                }

                if (watch.Status.DoNotDisturb != null && watch.Status.DoNotDisturb.ImageIndexOn == -10000 && watch.Status.DoNotDisturb.ImageIndexOff == -10000)
                {
                    AddImageOFFDND.Text = "Add image OFF";
                    AddImageONDND.Text = "Add image ON";
                    posXDND.Enabled = false;
                    posYDND.Enabled = false;
                    watch.Status.DoNotDisturb = null;
                }
            }

            Render(state);
        }

        private void ChangePosValue(object sender, EventArgs e)
        {
            string name = ((NumericUpDown)sender).Name;

            if (name == "posXBluetooth" && watch.Status.Bluetooth != null) watch.Status.Bluetooth.Coordinates.X = (int)posXBluetooth.Value;
            if (name == "posYBluetooth" && watch.Status.Bluetooth != null) watch.Status.Bluetooth.Coordinates.Y = (int)posYBluetooth.Value;

            if (name == "posXLock" && watch.Status.Lock != null) watch.Status.Lock.Coordinates.X = (int)posXLock.Value;
            if (name == "posYLock" && watch.Status.Lock != null) watch.Status.Lock.Coordinates.Y = (int)posYLock.Value;

            if (name == "posXDND" && watch.Status.DoNotDisturb != null) watch.Status.DoNotDisturb.Coordinates.X = (int)posXDND.Value;
            if (name == "posYDND" && watch.Status.DoNotDisturb != null) watch.Status.DoNotDisturb.Coordinates.Y = (int)posYDND.Value;

            Render(state);
        }

        private void NumberFormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && MessageBox.Show("Do you want to get out without saving?", "Don't Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
                if (watch.Status.Bluetooth != null)
                    if ((watch.Status.Bluetooth.ImageIndexOff == -10000 && watch.Status.Bluetooth.ImageIndexOn == -10000) || bluetoothCheckbox.Checked == false)
                        watch.Status.Bluetooth = null;
                if (watch.Status.Lock != null)
                    if ((watch.Status.Lock.ImageIndexOff == -10000 && watch.Status.Lock.ImageIndexOn == -10000) || lockCheckbox.Checked == false)
                        watch.Status.Lock = null;
                if (watch.Status.DoNotDisturb != null)
                    if ((watch.Status.DoNotDisturb.ImageIndexOn == -10000 && watch.Status.DoNotDisturb.ImageIndexOff == -10000) || dndCheclbox.Checked == false)
                        watch.Status.DoNotDisturb = null;

                if (watch.Status.Lock == null && watch.Status.DoNotDisturb == null && watch.Status.Bluetooth == null)
                    watch.Status = null;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save = true;
            if (watch.Status.Bluetooth != null)
                if ((watch.Status.Bluetooth.ImageIndexOff == -10000 && watch.Status.Bluetooth.ImageIndexOn == -10000) || bluetoothCheckbox.Checked == false)
                    watch.Status.Bluetooth = null;
            if (watch.Status.Lock != null)
                if ((watch.Status.Lock.ImageIndexOff == -10000 && watch.Status.Lock.ImageIndexOn == -10000) || lockCheckbox.Checked == false)
                    watch.Status.Lock = null;
            if (watch.Status.DoNotDisturb != null)
                if ((watch.Status.DoNotDisturb.ImageIndexOn == -10000 && watch.Status.DoNotDisturb.ImageIndexOff == -10000) || dndCheclbox.Checked == false)
                    watch.Status.DoNotDisturb = null;

            if (watch.Status.Lock == null && watch.Status.DoNotDisturb == null && watch.Status.Bluetooth == null)
                watch.Status = null;
            this.Close();
        }

        private void CheckChangedCheckBox(object sender, EventArgs e)
        {
            groupBox1.Enabled = lockCheckbox.Checked;
            groupBox2.Enabled = dndCheclbox.Checked;
            groupBox3.Enabled = bluetoothCheckbox.Checked;
        }
    }
}
