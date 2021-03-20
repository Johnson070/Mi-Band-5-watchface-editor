using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBand5WatchFaces
{
    class ImageWorker
    {
        DefaultDictionary<int, Image> images;
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

        public ImageWorker(DefaultDictionary<int, Image> images)
        {
            this.images = images;
        }

        public DefaultDictionary<int, Image> addImage()
        {
            OpenFileDialog image = new OpenFileDialog();
            image.RestoreDirectory = true;
            image.Filter = "png images (*.png)|*.png";

            if (image.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(image.FileName, FileMode.Open, FileAccess.Read);
                Bitmap temp = new Bitmap(stream);
                temp.SetResolution(96f, 96f);
                Image openpng = temp;

                stream.Close();
                float dpi = openpng.HorizontalResolution;

                if (Math.Round(dpi) == 96)
                    images.Add(images.Keys.Count == 0 ? images.Count : images.Keys.Max() + 1, openpng);
                else MessageBox.Show(res.GetString("ImageDPI"), $"File: {Path.GetFileName(image.FileName)}");
            }
            else return null;

            return images;
        }

        public DefaultDictionary<int, Image> addImage(string file)
        {
            if (Path.GetExtension(file) == ".png")
            {
                FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
                Bitmap temp = new Bitmap(stream);
                temp.SetResolution(96f, 96f);
                Image openpng = temp;
                float dpi = openpng.HorizontalResolution;
                stream.Close();

                if (Math.Round(dpi) == 96)
                    images.Add(images.Keys.Count == 0 ? images.Count : images.Keys.Max() + 1, openpng);
                else MessageBox.Show(res.GetString("ImageDPI"), $"File: {Path.GetFileName(file)}");
            }
            else return null;

            return images;
        }
    }
}
