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
                    if (watch.Status?.Bluetooth?.ImageIndexOn != -10000) selImg = new List<int>() { watch.Status.Bluetooth.ImageIndexOn };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Bluetooth = watch.Status.Bluetooth == null ? new Switch() : watch.Status.Bluetooth;
                        watch.Status.Bluetooth.Coordinates = new Coordinates();
                        watch.Status.Bluetooth.ImageIndexOn = imgForm.selectedImages[0];
                        AddImageONBluetooth.Text = "Edit image ON";
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
                    if (watch.Status?.Bluetooth?.ImageIndexOff != -10000) selImg = new List<int>() { watch.Status.Bluetooth.ImageIndexOff };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Bluetooth = watch.Status.Bluetooth == null ? new Switch() : watch.Status.Bluetooth;
                        watch.Status.Bluetooth.Coordinates = new Coordinates();
                        watch.Status.Bluetooth.ImageIndexOff = imgForm.selectedImages[0];
                        AddImageOFFBluetooth.Text = "Edit image OFF";
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
                    if (watch.Status?.Lock?.ImageIndexOn != -10000) selImg = new List<int>() { watch.Status.Lock.ImageIndexOn };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Lock = watch.Status.Lock == null ? new Switch() : watch.Status.Lock;
                        watch.Status.Lock.Coordinates = new Coordinates();
                        watch.Status.Lock.ImageIndexOn = imgForm.selectedImages[0];
                        AddImageONLock.Text = "Edit image ON";
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
                    if (watch.Status?.Lock?.ImageIndexOff != -10000) selImg = new List<int>() { watch.Status.Lock.ImageIndexOff };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.Lock = watch.Status.Lock == null ? new Switch() : watch.Status.Lock;
                        watch.Status.Lock.Coordinates = new Coordinates();
                        watch.Status.Lock.ImageIndexOff = imgForm.selectedImages[0];
                        AddImageOFFLock.Text = "Edit image OFF";
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
                    if (watch.Status?.DoNotDisturb?.ImageIndexOn != -10000) selImg = new List<int>() { watch.Status.DoNotDisturb.ImageIndexOn };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.DoNotDisturb = watch.Status.DoNotDisturb == null ? new Switch() : watch.Status.DoNotDisturb;
                        watch.Status.DoNotDisturb.Coordinates = new Coordinates();
                        watch.Status.DoNotDisturb.ImageIndexOn = imgForm.selectedImages[0];
                        AddImageONDND.Text = "Edit image ON";
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
                    if (watch.Status?.DoNotDisturb?.ImageIndexOff != -10000) selImg = new List<int>() { watch.Status.DoNotDisturb.ImageIndexOff };

                    imgForm = new ImagesForm(watch.imagesBuff.DeepCopy(), selImg, true, false);
                    imgForm.ShowDialog();

                    if (imgForm.saveImages == true && imgForm.selectedImages != null)
                    {
                        watch.imagesBuff = imgForm.Images;
                        watch.Status.DoNotDisturb = watch.Status.DoNotDisturb == null ? new Switch() : watch.Status.DoNotDisturb;
                        watch.Status.DoNotDisturb.Coordinates = new Coordinates();
                        watch.Status.DoNotDisturb.ImageIndexOff = imgForm.selectedImages[0];
                        AddImageOFFDND.Text = "Edit image OFF";
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
    }
}
