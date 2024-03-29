﻿using Newtonsoft.Json;
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
    public partial class ArrowPaintForm : Form
    {
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));
        string oldShape;

        Graphics arrow;
        Bitmap Preview;
        private bool Dragging;
        private int xPos;
        private int yPos;
        private int xInc, incMouseX;
        private int yInc, incMouseY;

        public List<XY> shape = new List<XY>();
        public bool Save;
        public bool delete; // 690
        int PreviewWidth = 4001;
        int PreviewHeight = 4001;
        int incXYPreview = (4000 / 10) / 2;

        public ArrowPaintForm(List<XY> shape)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Preview = new Bitmap(PreviewWidth, PreviewHeight);
            arrow = Graphics.FromImage(Preview);
            for (int i = 0; i < Preview.Size.Width; i += 10)
                arrow.DrawLine(new Pen(Color.Black, 1), i, 0, i, Preview.Size.Width - 1);

            for (int i = 0; i < Preview.Size.Height; i += 10)
                arrow.DrawLine(new Pen(Color.Black, 1), 0, i, Preview.Size.Width - 1, i);

            arrow.DrawLine(new Pen(Color.Red, 1), Preview.Size.Width / 2 + 5, 0, Preview.Size.Width / 2 + 5, Preview.Size.Width - 1);
            arrow.DrawLine(new Pen(Color.Red, 1), 0, Preview.Size.Height / 2 + 5, Preview.Size.Width - 1, Preview.Size.Height / 2 + 5);
            panelArrow.SizeMode = PictureBoxSizeMode.CenterImage;
            panelArrow.Image = Preview;
            xInc -= Preview.Size.Width / 2 - 250;
            yInc -= Preview.Size.Height / 2 - 250;

            this.shape = shape == null ? new List<XY>() : shape;

            foreach (XY dot in this.shape)
                arrow.FillRectangle(new SolidBrush(Color.DarkGray), (dot.X + incXYPreview) * 10 + 1, ((-dot.Y) + incXYPreview) * 10 + 1, 10 - 1, 10 - 1);

            fillListBox();
            panelArrow.Refresh();

            oldShape = JsonConvert.SerializeObject(shape, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
            incMouseX = 0;
            incMouseY = 0;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dragging = true;
                xPos = e.X;
                yPos = e.Y;
                incMouseX = e.X;
                incMouseY = e.Y;
                panelArrow.Image = null;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (Dragging && c != null)
            {
                incMouseX = (e.X - xPos);
                incMouseY = (e.Y - yPos);
                xPos = e.X;
                yPos = e.Y;
                xInc += incMouseX;
                yInc += incMouseY;
                if (xInc > 0) xInc = 0;
                if (xInc < -(Preview.Width - panelArrow.Size.Width)) xInc = -(Preview.Width - panelArrow.Size.Width);
                if (yInc > 0) yInc = 0;
                if (yInc < -(Preview.Width - panelArrow.Size.Height)) yInc = -(Preview.Width - panelArrow.Size.Height);
                panelArrow.Refresh();
            }

            posPanel.Text = $"X: {(e.X - xInc) / 10 - incXYPreview} Y: {-((e.Y - yInc) / 10 - incXYPreview)}";
        }

        private void panelArrow_MouseClick(object sender, MouseEventArgs e)
        {
            int clickX = (e.X - xInc) / 10 - 200;
            int clickY = -((e.Y - yInc) / 10 - 200);

            if (dotRadioButton.Checked)
            {
                arrow.FillRectangle(new SolidBrush(Color.DarkGray), (clickX + incXYPreview) * 10 + 1, ((-clickY) + 100) * 10 + 1, 10 - 1, 10 - 1);
                bool match = false;
                foreach (XY dot in shape)
                    if (dot.X == clickX && dot.Y == clickY)
                        match = true;

                if (!match)
                    shape.Add(new XY() { X = clickX, Y = clickY });
            }
            else if (eraseRadioButton.Checked)
            {
                arrow.FillRectangle(new SolidBrush(Color.White), (clickX + incXYPreview) * 10 + 1, ((-clickY) + incXYPreview) * 10 + 1, 10 - 1, 10 - 1);
                for (int i = 0; i < shape.Count; i++)
                    if (shape[i].X == clickX && shape[i].Y == clickY)
                    {
                        shape.RemoveAt(i);
                        break;
                    }
            }
            arrow.DrawLine(new Pen(Color.Red, 1), Preview.Size.Width / 2 + 5, 0, Preview.Size.Width / 2 + 5, Preview.Size.Width - 1);
            arrow.DrawLine(new Pen(Color.Red, 1), 0, Preview.Size.Height / 2 + 5, Preview.Size.Width - 1, Preview.Size.Height / 2 + 5);
            fillListBox();
            panelArrow.Refresh();
            panelArrow.Refresh();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            shape = new List<XY>();
            arrow.FillRectangle(new SolidBrush(Color.White), 0, 0, Preview.Width, Preview.Height);
            for (int i = 0; i < Preview.Size.Width; i += 10)
                arrow.DrawLine(new Pen(Color.Black, 1), i, 0, i, Preview.Size.Width - 1);

            for (int i = 0; i < Preview.Size.Height; i += 10)
                arrow.DrawLine(new Pen(Color.Black, 1), 0, i, Preview.Size.Width - 1, i);

            arrow.DrawLine(new Pen(Color.Red, 1), Preview.Size.Width / 2 + 5, 0, Preview.Size.Width / 2 + 5, Preview.Size.Width - 1);
            arrow.DrawLine(new Pen(Color.Red, 1), 0, Preview.Size.Height / 2 + 5, Preview.Size.Width - 1, Preview.Size.Height / 2 + 5);
            fillListBox();
            panelArrow.Image = Preview;
            xInc = -(Preview.Size.Width / 2 - 250);
            yInc = -(Preview.Size.Height / 2 - 250);
            xPos = 0;
            yPos = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save = true;
            this.Close();
        }

        private void ArrowPaintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save == false && oldShape != JsonConvert.SerializeObject(shape, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }) && MessageBox.Show(res.GetString("ExitMessage"), res.GetString("ExitMessageCaption"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Save = true;
            }
        }

        private void deleteDotToolStrip_Click(object sender, EventArgs e)
        {
            if (shapeListBox.SelectedIndex != -1)//
            {
                arrow.FillRectangle(new SolidBrush(Color.White), (shape[shapeListBox.SelectedIndex].X + incXYPreview) * 10 + 1, ((-shape[shapeListBox.SelectedIndex].Y) + incXYPreview) * 10 + 1, 10 - 1, 10 - 1);
                shape.RemoveAt(shapeListBox.SelectedIndex);
                arrow.DrawLine(new Pen(Color.Red, 1), Preview.Size.Width / 2 + 5, 0, Preview.Size.Width / 2 + 5, Preview.Size.Width - 1);
                arrow.DrawLine(new Pen(Color.Red, 1), 0, Preview.Size.Height / 2 + 5, Preview.Size.Width - 1, Preview.Size.Height / 2 + 5);
                fillListBox();
                panelArrow.Refresh();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Save = false;
            delete = true;
            this.Close();
        }

        private void panelArrow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Preview, xInc, yInc, PreviewWidth, PreviewHeight);
            foreach (XY dot in this.shape)
                arrow.FillRectangle(new SolidBrush(Color.DarkGray), (dot.X + incXYPreview) * 10 + 1, ((-dot.Y) + incXYPreview) * 10 + 1, 10 - 1, 10 - 1);
        }

        private void fillListBox()
        {
            shapeListBox.Items.Clear();
            int count = 0;
            foreach (XY dot in shape)
            {
                count++;
                shapeListBox.Items.Add($"{count}: ({dot.X};{dot.Y})");
            }
        }
    }
}
