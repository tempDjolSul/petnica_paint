using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintProjekat
{
    public partial class Form1 : Form
    {
        bool pocni = true;
        Pen olovka = new Pen(Color.Black);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pocni)
            {
                e.Graphics.DrawRectangle(olovka, 5, 5, 50, 50);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pocni = true;
            pictureBox1.Refresh();
        }
    }
}
