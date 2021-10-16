using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineImageRecognition
{
    public partial class Form1 : Form
    {
        //user defined sorter
        Sorter sorter = new Sorter();


        //draw points
        int[] x;
        int[] y;
        //entity
        BussinessEntity entity;
        float[] fx;
        float[] fy;
        public Form1()
        {
            InitializeComponent();
            //entity intial
            /**/
            entity = new BussinessEntity();
            fx = entity.PointX;
            fy = entity.PointY;

            ///sort!!!!!!Float
            Sorter.Save(fx, fy, null, null);
            sorter.SortF(fx, fy);
            Sorter.Save(fx, fy,null,null);
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            DBReader reader = new DBReader();
            reader.Read();
             x = reader.pointX;
             y = reader.pointY;

            //show the point value in text box
            CheckTBox.Text += "Point:";
                int i = 0;
            while (i<x.Length)
            {
               CheckTBox.Text += " (" + x[i] +"," + y[i] +") ";
                CheckTBox.Text += " (" + fx[i] + "," + fy[i] + ") ";
                ++i;
            }


            ///sort!!!!!!Int
            Sorter.Save(null, null, x, y);
            sorter.SortInt( x,  y);
            Sorter.Save( null, null, x, y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        const int Shift = 100;
        //draw every point
        protected override void OnPaint(PaintEventArgs e)
        {
            if (x !=null&&y !=null)
            {
                using (Pen pen = new Pen(Color.FromArgb(150, Color.Blue), 2))
                {
                   /* //this is use for check the X,Y coordinates direction
                        //this is extension along Y coordinate
                    e.Graphics.DrawRectangle(pen, 30 + 1, 30 + 1, 1, 1);
                    e.Graphics.DrawRectangle(pen, 30 + 1, 30 + 20, 1, 1);
                    e.Graphics.DrawRectangle(pen, 30 + 1, 30 + 30, 1, 1);
                    e.Graphics.DrawRectangle(pen, 30 + 1, 30 + 40, 1, 1);
                    e.Graphics.DrawRectangle(pen, 30 + 1, 30 + 50, 1, 1); 
                    //this is extension along X coordinate
                    e.Graphics.DrawRectangle(pen, 30 + 20, 30 + 1, 1, 1);
                    e.Graphics.DrawRectangle(pen, 30 + 30, 30 + 1, 1, 1);
                    e.Graphics.DrawRectangle(pen, 30 + 60, 30 + 60, 1, 1);
                    */
                    int i = 0;
                    while (i<x.Length)
                    {
                       // e.Graphics.DrawRectangle(pen, x[i] + 30 , y[i] + 30 , 1, 1);//rectangle  size in 1 pixel represent a point

                        //entity fraw
                        e.Graphics.DrawRectangle(pen, fx[i] + Shift , fy[i] + Shift, 1, 1);//rectangle  size in 1 pixel represent a point
                        ++i;
                    }
                }
            }
        }
        private void DrawButton_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
