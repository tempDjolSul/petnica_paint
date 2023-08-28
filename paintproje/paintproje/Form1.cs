using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintproje
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
       
        Point px, py;
        Pen p = new Pen(Color.Black,2);
        Pen pp = new Pen(Color.White, 2);
        Brush tacka = new SolidBrush(Color.Black);
        int index;
        int x, y, sx, sy, cx, cy;
       
        

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(Pic.Width,Pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Pic.Image = bm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cx = e.X;
            cy = e.Y;
           
        }

        
        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }
                else if (index == 4)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                }
                else if (index == 5)
                {
                    g.DrawLine(p, cx, cy, x, y);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Pic.Image = bm;
            index = 0;

        }

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    //g.DrawLine(p, px, py);
                    g.FillEllipse(tacka, px.X-10, py.Y-10, 20, 20);
                    py = px;
                   
                }
                else if(index == 2)
                {
                    px = e.Location;
                    g.DrawLine(pp, px, py);
                    py = px;

                }
                
            }
            
            Pic.Refresh();
            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        
        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            
            paint = false;

            sx = x - cx;
            sy = y - cy;
            if (index == 3)
            {
                g.DrawEllipse(p, cx, cy, sx, sy);
            }
            else if (index == 4)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
            else if (index == 5)
            {
                g.DrawLine(p, cx, cy, x, y);
            }


        }

        private void BtnEraser_MouseClick(object sender, MouseEventArgs e)
        {
            index = 2;
        }

        private void BtnEllipse_MouseClick(object sender, MouseEventArgs e)
        {
            index = 3;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
