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
        Bitmap[] undo = new Bitmap[5];
        Bitmap[] redo = new Bitmap[5];
        Graphics g;
        bool paint = false;
       
        Point px, py;
        Pen p = new Pen(Color.Black,2);
        Pen pp = new Pen(Color.White, 2);
        Brush dot = new SolidBrush(Color.Black);
        int indexOfUndo;
        VersionOfDrawing indexDrawing;
        int x, y, sx, sy, cx, cy;
       
        
        private enum VersionOfDrawing { nothing,dot, eraser, elipse, rectangle, line, bucket}
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(Pic.Width,Pic.Height);
            indexOfUndo = 0;
            for (int i = 0; i < 5; i++)
            {
                redo[i] = new Bitmap(Pic.Width, Pic.Height);
                undo[i] = new Bitmap(Pic.Width, Pic.Height);
            }
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
            indexDrawing = VersionOfDrawing.rectangle;
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            indexDrawing = VersionOfDrawing.line;
        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (indexDrawing == VersionOfDrawing.elipse)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }
                else if (indexDrawing == VersionOfDrawing.rectangle)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                   
                }
                else if (indexDrawing == VersionOfDrawing.line)
                {
                    g.DrawLine(p, cx, cy, x, y);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Pic.Image = bm;
            indexDrawing = VersionOfDrawing.nothing;

        }

        private void BtnEraser_Click(object sender, EventArgs e)
        {
            indexDrawing = VersionOfDrawing.eraser;
        }

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            indexDrawing = VersionOfDrawing.dot;
        }
        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (paint)
            {
                if (indexDrawing == VersionOfDrawing.dot)
                {
                    px = e.Location;
                    //g.DrawLine(p, px, py);
                    g.FillEllipse(dot, px.X-10, py.Y-10, 20, 20);

                    py = px;
                   
                }
                else if(indexDrawing == VersionOfDrawing.eraser)
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

        private void btnUndo_Click(object sender, EventArgs e)
        {
            IzvrsiUndo();
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            
            paint = false;

            sx = x - cx;
            sy = y - cy;
            if (indexDrawing == VersionOfDrawing.elipse)
            {
                g.DrawEllipse(p, cx, cy, sx, sy);
            }
            else if (indexDrawing == VersionOfDrawing.rectangle)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
            else if (indexDrawing == VersionOfDrawing.line)
            {
                g.DrawLine(p, cx, cy, x, y);
            }


            NamestiUndo();
        }
        private void NamestiUndo()
        {
            for(int i = 0;i<undo.Length-1;i++)
            {
                undo[i] = undo[i + 1];
            }
            undo[undo.Length - 1] = (Bitmap)Pic.Image;
        }

        private void IzvrsiUndo()
        {
            indexOfUndo++;
            Pic.Image = undo[undo.Length - indexOfUndo];
        }
        private void BtnEraser_MouseClick(object sender, MouseEventArgs e)
        {
            indexDrawing = VersionOfDrawing.eraser;
        }

        private void BtnEllipse_MouseClick(object sender, MouseEventArgs e)
        {
            indexDrawing = VersionOfDrawing.elipse;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        struct DrawedInformation
        {
            int startX;
            int startY;
            int widthX;
            int lengthY;
            VersionOfDrawing typeOfDrawing;
            
        }
    }
    
}
