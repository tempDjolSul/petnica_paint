using System;
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
        Stack<DrawedInformation> undoStack = new Stack<DrawedInformation>();
        Stack<DrawedInformation> redoStack = new Stack<DrawedInformation>();
        Graphics g;
        bool paint = false;
        List<Point> penPoints = new List<Point>();
       
        Point penX, penY;
        Pen drawingPen = new Pen(Color.Black,2);
        Pen pp = new Pen(Color.White, 2);
        Brush dot = new SolidBrush(Color.Black);
        Color brushColor = Color.Black;
        VersionOfDrawing indexDrawing;
        int x, y, endX, endY, startX, startY;
        Color New_Color;
        Color startColor;
        ColorDialog cd;

       

        
        
        private enum VersionOfDrawing { nothing,dot, eraser, elipse, rectangle, line, bucket,star}

        Brush dotWhite = new SolidBrush(Color.White);
        int strokeSize = 10;
        int DisUnit = 1;

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(Pic.Width,Pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Pic.Image = bm;
            cd = new ColorDialog();
            //ova  linija koda ne radi jer mora da se klikne dugme star koje nemam 
            //BtnStar.Click += BtnStar_Click; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            penY = e.Location;
            startX = e.X;
            startY = e.Y;
            startColor = bm.GetPixel(startX, startY);
        }
        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            indexDrawing = VersionOfDrawing.rectangle;
            MessageBox.Show(x + " " + y);
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
                    g.DrawEllipse(drawingPen, startX, startY, endX, endY);
                }
                else if (indexDrawing == VersionOfDrawing.rectangle)
                {
                    g.DrawRectangle(drawingPen, startX, startY, endX, endY);
                   
                }
                else if (indexDrawing == VersionOfDrawing.line)
                {
                    g.DrawLine(drawingPen, startX, startY, x, y);
                }
                else if (indexDrawing == VersionOfDrawing.star)
                {
                    DrawStar(g, startX, startY, endX, endY, 5);
                }
            }
        }
        
        private void PaintShapes()
        {
            if (indexDrawing == VersionOfDrawing.elipse)
            {
                g.DrawEllipse(drawingPen, startX, startY, endX, endY);
            }
            else if (indexDrawing == VersionOfDrawing.rectangle)
            {
                g.DrawRectangle(drawingPen, startX, startY, endX, endY);

            }
            else if (indexDrawing == VersionOfDrawing.line)
            {
                g.DrawLine(drawingPen, startX, startY, x, y);
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
            float penX = 1f * pb.Width / pb.Width;
            float penY = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * penX), (int)(pt.Y * penY));
        }

        private void Validate(Bitmap bm, Stack<Point>sp,int x, int y, Color Old_Color, Color New_Color)
        {
            Color pixelColor = bm.GetPixel(x, y);
            if (pixelColor == Old_Color)
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

            strokeSize = (int)numericUpDown1.Value;
            drawingPen.Width = (int)numericUpDown1.Value;
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
                        penX = e.Location;
                    makeUndoInfo(startColor,brushColor, strokeSize, penX);
                    g.FillEllipse(dot, penX.X - strokeSize / 2, penX.Y - strokeSize / 2, strokeSize, strokeSize);
                    

                    //penY = penX;

                }
                else if (indexDrawing == VersionOfDrawing.eraser)
                    {
                        penX = e.Location;
                    makeUndoInfo(startColor, Color.White, strokeSize, penX);
                    g.FillEllipse(dotWhite, penX.X - strokeSize / 2, penX.Y - strokeSize / 2, strokeSize, strokeSize);


                    //penPoints.Add(penX);
                    //penY = penX;
                }

               
                
            }
                //pokrece Pic.Paint()
                Pic.Refresh();

                // bez ovog bude sve u gornjem levom cosku
                x = e.X;
                y = e.Y;

                //bez ovoga nema animacije crtanja
                endX = e.X - startX;
                endY = e.Y - startY;
            
            }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            IzvrsiUndo();
        }


        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {

            paint = false;

            //endX = x - startX;
            //endY = y - startY;
            if ((int)indexDrawing > 2)
            {
                makeUndoInfo(drawingPen.Color, (int)drawingPen.Width);
            }
            else
            {
            }
            PaintShapes();
            //MessageBox.Show(drawingPen.Color.ToString());

            //MessageBox.Show(drawingPen.Color.ToString() + paint.ToString());
        }


        private void makeUndoInfo(Color replacing, int drawingSize)
        {
            DrawedInformation info;
            info.startX = startX;
            info.startY = startY;
            info.endX = endX;
            info.endY = endY;
            info.typeOfDrawing = indexDrawing;
            info.replacedColor = bm.GetPixel(startX, startY);
            info.replacingColor =  replacing;
            info.size = drawingSize;
            undoStack.Push(info);
        }
        private void makeUndoInfo(Color replaced,Color replacing, int drawingSize,Point location)
        {
            DrawedInformation info;
            info.startX = location.X;
            info.startY = location.Y;
            info.endX = endX;
            info.endY = endY;
            info.typeOfDrawing = indexDrawing;
            info.replacedColor = replaced;
            info.replacingColor = replacing;
            info.size = drawingSize;
            undoStack.Push(info);
        }

        private void IzvrsiUndo()
        {
         if(undoStack.Count > 0)
            {
                DrawedInformation previousDrawing = undoStack.Pop();
                if((int)previousDrawing.typeOfDrawing > 2)
                {
                    ShapeUndo(previousDrawing);
                }
                else if((int)previousDrawing.typeOfDrawing < 3)
                {
                    BrushUndo(previousDrawing);
                    if (undoStack.Count > 0)
                    {
                        DrawedInformation nextPrevDrawing = undoStack.Peek();
                        int razdaljina = (int)Math.Sqrt((nextPrevDrawing.startX - previousDrawing.startX) * (nextPrevDrawing.startX - previousDrawing.startX) + (nextPrevDrawing.startY - previousDrawing.startY) * (nextPrevDrawing.startY - previousDrawing.startY));
                        if(nextPrevDrawing.typeOfDrawing == previousDrawing.typeOfDrawing && razdaljina < 10)
                        {
                          //  nextPrevDrawing.replacingColor = previousDrawing.replacingColor;
                          //  undoStack.Pop();
                          //  undoStack.Push(nextPrevDrawing);
                            IzvrsiUndo();
                        }
                    }
                }
                //redoStack.Push(previousDrawing);
            }
            else
            {
               MessageBox.Show("Can't Undo");
            }
            
        }

        private void BrushUndo(DrawedInformation i)
        {
            //MessageBox.Show(i.replacedColor.ToString());
            Brush tempBrush = new SolidBrush(i.replacedColor);
                if(i.typeOfDrawing == VersionOfDrawing.dot)
                {
                    g.FillEllipse(tempBrush, i.startX - i.size / 2, i.startY - i.size / 2, i.size, i.size);
                }
                if(i.typeOfDrawing == VersionOfDrawing.eraser)
                {
                    g.FillEllipse(tempBrush, i.startX - i.size / 2, i.startY - i.size / 2, i.size, i.size);
                }
            
        }

        private void ShapeUndo(DrawedInformation i)
        {
            drawingPen.Color = i.replacedColor;
            startX = i.startX;
            startY = i.startY;
            endX = i.endX;
            endY = i.endY;
            indexDrawing = i.typeOfDrawing;
            if (i.typeOfDrawing != VersionOfDrawing.bucket)
            {
                PaintShapes();
            }
            else
            {
                Fill(bm, i.startX, i.startY, i.replacedColor);
            }

            drawingPen.Color = i.replacingColor;
            //MessageBox.Show("Hej!" + startX + "," + startY);
            //MessageBox.Show("Hej!" + endX + "," + endY);
            //MessageBox.Show("Hej!" + i.replacedColor);

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

       

        private void btnStar_Click_1(object sender, EventArgs e)
        {
            indexDrawing = VersionOfDrawing.star;
        }

        private void BtnColor_Click_1(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            New_Color = colorDialog.Color;
            //Pic.BackColor = colorDialog.Color;
            dot = new SolidBrush(New_Color);
            drawingPen.Color = colorDialog.Color;

        }

        struct DrawedInformation
        {
            public int startX;
            public int startY;
            public int endX;
            public int endY;
            public VersionOfDrawing typeOfDrawing;
            public Color replacedColor;
            public Color replacingColor;
            public int size;
            //public Point[] pointArray;
        }
        //Dodata paleta boja
        

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
            PointF[] array = new PointF[10];
            array[0] = new Point(startX, startY + (endY - startY) / 3);
            array[1] = array[0];
            array[1].X += (endX - startX) / 4;
            array[3] = array[0];
            array[3].X += (endX - startX) / 4;
            array[4] = array[0];
            array[4].X = endX;
            //g.DrawPolygon(drawingPen, starPoints);
        }

        

        

        

        //pogledati liniju 40!
        
    }
   }
