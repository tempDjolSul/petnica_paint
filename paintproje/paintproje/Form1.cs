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

        Brush dotWhite = new SolidBrush(Color.White);
        int strokeSize = 10;
        Color New_Color = Color.Firebrick;
        int DisUnit = 1;

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
        private void BtnPaint_Click(object sender, EventArgs e)
        {
            indexDrawing = VersionOfDrawing.bucket; 
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
            if (indexDrawing == VersionOfDrawing.bucket)
            {
                Point point = set_Point(Pic, e.Location);
                Fill(bm, point.X, point.Y, New_Color);

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            //strokeSize = (int)numericUpDown1.Value;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            this.Controls.Add(txt);
            txt.Top = DisUnit * 70;
            txt.Left = 415;
            DisUnit = DisUnit + 1;
            txt.ForeColor= Color.Green;
            txt.Font = new Font("Arial",20.25F, FontStyle.Bold, GraphicsUnit.Point,((byte)(0)));
            txt.Width = 150;
            txt.Height = 50;
            txt.Text= " ";
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

                    g.FillEllipse(dot, px.X-strokeSize/2, py.Y-strokeSize/2, strokeSize, strokeSize);
                    py = px;
                   
                }
                else if(indexDrawing == VersionOfDrawing.eraser)
                {
                    px = e.Location;
                    g.FillEllipse(dotWhite, px.X - strokeSize / 2, py.Y - strokeSize / 2, strokeSize, strokeSize);
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

        private void Pic_Click(object sender, EventArgs e)
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
