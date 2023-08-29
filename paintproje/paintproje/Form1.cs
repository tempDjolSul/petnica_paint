﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

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
        Color New_Color;
        ColorDialog cd = new ColorDialog();

       
        

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(Pic.Width,Pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Pic.Image = bm;
            //ova  linija koda ne radi jer mora da se klikne dugme star koje nemam 
            //BtnStar.Click += BtnStar_Click; 
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

        private void BtnPaint_Click(object sender, EventArgs e)
        {
            index = 6; 
        }
        
        static Point set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }

        private void Validate(Bitmap bm, Stack<Point>sp,int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                //greska kad ostane predugo (system out of memory excep)
                sp.Push(new Point(x, y));
                    bm.SetPixel(x, y, New_Color);
            }
        }
        
        public void Fill(Bitmap bm, int x, int y, Color New_Clr)
        {
            Color Old_Color = bm.GetPixel(x, y);
            Stack< Point > pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, New_Clr);
            if(Old_Color==New_Clr) { return; }
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y-1, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X , pt.Y+1, Old_Color, New_Clr);
                }

            }
        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 6)
            {
                Point point = set_Point(Pic, e.Location);
                //MessageBox.Show(cx + " " + cy);
                Fill(bm, point.X, point.Y, New_Color);

            }
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

        private void Pic_Click(object sender, EventArgs e)
        {
            
        }

        //Dodata paleta boja
        private void BtnColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            New_Color = cd.Color;
            Pic.BackColor = cd.Color;
            p.Color = cd.Color;

         }

        //Dodato save dugme
        private void BtnSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, Pic.Width, Pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);

            }
        }

        //pokusaj zvezde
        private void DrawStar(Graphics g, int x,int y, int Width, int Height, int numPoints)
        {
            PointF[] starPoints = CalculateStarPoints(new PointF(x, y), Width, Height, numPoints);
            g.DrawPolygon(p, starPoints);
        }

        private PointF[] CalculateStarPoints(PointF pointF, int width, int height, int numPoints)
        {
            throw new NotImplementedException();
        }

        private void BtnStar_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void Pic_Paint2(object sender, PaintEventArgs e)
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
                else if (index == 7)
                {
                    DrawStar(g, cx, cy, sx, sy, 5);
                }
            }
        }

        //pogledati liniju 40!
        
    }
}
