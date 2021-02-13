using System;
using System.Collections.Generic;
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

        public ImageWorker(DefaultDictionary<int, Image> images)
        {
            this.images = images;
        }

        public DefaultDictionary<int, Image> addImage()
        {
            OpenFileDialog image = new OpenFileDialog();
            image.RestoreDirectory = true;
            image.Filter = "png images (0000.png)|*.png";

            if (image.ShowDialog() == DialogResult.OK)
            {
                Image openpng = Image.FromFile(image.FileName);
                float dpi = openpng.HorizontalResolution;

                if (Math.Round(dpi) == 96)
                    images.Add(images.Keys.Count == 0 ? images.Count : images.Keys.Max() + 1, openpng);
                else MessageBox.Show("Image DPI is not 96!", $"File: {Path.GetFileName(image.FileName)}");
            }
            else return null;

            return images;
        }

        public DefaultDictionary<int, Image> addImage(string file)
        {
            if (Path.GetExtension(file) == ".png")
            {
                Image openpng = Image.FromFile(file);
                float dpi = openpng.HorizontalResolution;

                if (Math.Round(dpi) == 96)
                    images.Add(images.Keys.Count == 0 ? images.Count : images.Keys.Max() + 1, openpng);
                else MessageBox.Show("Image DPI is not 96!", $"File: {Path.GetFileName(file)}");
            }
            else return null;

            return images;
        }
    }
}
