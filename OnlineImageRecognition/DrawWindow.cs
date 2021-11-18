using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineImageRecognition
{
    public partial class DrawWindow : Form
    {
        public DrawWindow()
        {
            InitializeComponent();
            Invalidate();
        }

        public float[] fx;
        public float[] fy;


        const int SHIFTX = 30;
        const int SHIFTY = 70;
        protected override void OnPaint(PaintEventArgs e)
        {


            using (Pen pen = new Pen(Color.FromArgb(150, Color.Black), 2))
            {
                e.Graphics.DrawLine(pen, 30, 72, 300, 72);
                e.Graphics.DrawLine(pen, 30, 72, 30, 0);
            }
            if (fx != null && fy != null)
            {
                using (Pen pen = new Pen(Color.FromArgb(150, Color.Blue), 2))
                {
                    int i = 0;
                    while (i < fx.Length)
                    {
                        //entity draw
                        e.Graphics.DrawRectangle(pen, fx[i] + SHIFTX, -fy[i] + SHIFTY, 1, 1);//rectangle  size in 1 pixel represent a point
                        ++i;
                    }
                }
            }
        }
        private void DrawWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
