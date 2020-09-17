using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBoard_csProject
{
    class Dotmatrix
    {
        public PictureBox[,] ImageState { get; set; }
        public bool[,] SelectState { get; set; }
        // 도트매트릭스 클래스 개수 (0부터)
        public int i { get; set; }

        private const int width_i = (64 * 8) + 16;
        private const int width_j = 64;
        private const int height_k = 64;

        public Dotmatrix(int _i, Form form)
        {
            ImageState = new PictureBox[8, 8];
            SelectState = new bool[8, 8];
            i = _i;
            for (int j = 0; j < 8; j++)
            {
                for (int k = 0; k < 8; k++)
                {
                    ImageState[j, k] = new PictureBox();
                    ImageState[j, k].Location = new Point(12 + (width_i * _i) + (width_j * j), 40 + (height_k * k));
                    ImageState[j, k].Image = Properties.Resources.CheckBox_White;
                    ImageState[j, k].Size = new Size(width_j, height_k);
                    ImageState[j, k].Click += Dotmatrix_Click_ex;
                    form.Controls.Add(ImageState[j, k]);

                    SelectState[j, k] = new bool();
                    SelectState[j, k] = false;
                }
            }
        }

        private void Dotmatrix_Click_ex(object sender, EventArgs e)
        {
            PictureBox self = (PictureBox)sender;

            int j = (self.Left - 12 - (i * width_i)) / (width_j);
            int k = (self.Top - 40) / (height_k);

            DotInverse(this, j, k);
        }

        public static void DotSelect(Dotmatrix dot, int j, int k)
        {
            if(dot.SelectState[j, k] == false)
            {
                dot.SelectState[j, k] = true;
                dot.ImageState[j, k].Image = Properties.Resources.CheckBox_Green;
                Packet.Data[(dot.i * 8) + j] += Convert.ToByte(Math.Pow(2, k));
            }
        }

        public static void DotDeselect(Dotmatrix dot, int j, int k)
        {
            if (dot.SelectState[j, k] == true)
            {
                dot.SelectState[j, k] = false;
                dot.ImageState[j, k].Image = Properties.Resources.CheckBox_White;
                Packet.Data[(dot.i * 8) + j] -= Convert.ToByte(Math.Pow(2, k));
            }
        }

        public static void DotInverse(Dotmatrix dot, int j, int k)
        {
            if (dot.SelectState[j, k] == false)
            {
                dot.SelectState[j, k] = true;
                dot.ImageState[j, k].Image = Properties.Resources.CheckBox_Green;
                Packet.Data[(dot.i * 8) + j] += Convert.ToByte(Math.Pow(2, k));
            }
            else
            {
                dot.SelectState[j, k] = false;
                dot.ImageState[j, k].Image = Properties.Resources.CheckBox_White;
                Packet.Data[(dot.i * 8) + j] -= Convert.ToByte(Math.Pow(2, k));
            }
        }
    }
}
