using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawHere
{
    public partial class Form1 : Form
    {

        Bitmap[] frames;
        Bitmap pic;
        int x1, y1;
        bool isStop = false;
        bool erase = false;
        string canvasName;

        public Form1()
        {
            InitializeComponent();
        }

        private void colorSelectBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                colorSelectBtn.BackColor = colorDialog1.Color; 
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName == "")
                    saveFileDialog1.FileName = canvasName;
                frames[framesBar.Value].Save(saveFileDialog1.FileName);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK && openFileDialog1.FileName != "")
            {
                pic = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                frames[framesBar.Value] = pic;
                pictureBox1.Image = frames[framesBar.Value];
            }
        }

        private void eraserBtn_Click(object sender, EventArgs e) { erase = true; }

        private void drawBtn_Click(object sender, EventArgs e) { erase=false; }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create create = new Create();

            if (create.ShowDialog() == DialogResult.OK)
            {
                canvasesCombo.Items.Add(create.GetName());
                canvasName = create.GetName();
                canvasesCombo.SelectedIndex = canvasesCombo.Items.IndexOf(create.GetName());

                pictureBox1.Width = create.GetX();
                pictureBox1.Height = create.GetY();

                pictureBox1.Location = new Point(364 - pictureBox1.Width/2,188 - pictureBox1.Height);

                framesBar.Maximum = create.GetTime() * 24;
                frames = new Bitmap[framesBar.Maximum+1];

                pic = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                frames[framesBar.Value] = pic;
                x1 = y1 = 0;

                pictureBox1.Visible = true;
            }
        }

        private void framesBar_Scroll(object sender, EventArgs e) { pictureBox1.Image = frames[framesBar.Value]; }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            framesBar.Value = 0;
            if (!inCirclesChk.Checked)
            {
                for (int i = 0; i <= framesBar.Maximum-1; i++)
                {
                    await Task.Delay(1);
                    framesBar.Value++;
                    pictureBox1.Image = frames[framesBar.Value];
                }
            } 
            else
            {
                while (!isStop)
                {
                    framesBar.Value = 0;
                    for (int i = 0; i <= framesBar.Maximum-1; i++)
                    {
                        await Task.Delay(1);
                        framesBar.Value++;
                        pictureBox1.Image = frames[framesBar.Value];
                    }
                }
                isStop = false;
            }
            
        }

        private void stopBtn_Click(object sender, EventArgs e) { isStop = true; }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (framesBar.Value > 0)
                framesBar.Value--;
            framesBar_Scroll(sender, e);
        }

        private void forthBtn_Click(object sender, EventArgs e)
        {
            if (framesBar.Value < framesBar.Maximum)
                framesBar.Value++;
            framesBar_Scroll(sender, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen p;
            if (frames[framesBar.Value] != null)
                pic = frames[framesBar.Value];
            else
                pic = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var size = widthTrack.Value;
            p = new Pen(colorSelectBtn.BackColor, size);
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            Graphics g = Graphics.FromImage(pic);

            if (e.Button == MouseButtons.Left)
            {
                if (erase)
                    g.FillEllipse(new SolidBrush(pictureBox1.BackColor), e.X - size/2, e.Y - size/2, size, size);
                else
                    g.DrawLine(p, x1, y1, e.X, e.Y);

                frames[framesBar.Value] = pic;
                pictureBox1.Image = frames[framesBar.Value];
            }
            x1 = e.X; y1 = e.Y;
        }
    }
}

