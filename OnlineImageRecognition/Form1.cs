﻿using System;
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
    public partial class Form1 : Form
    {
        //draw points
        int[] x;
        int[] y;

        public Form1()
        {
            InitializeComponent();
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
            while (x[i] != -1 && i != 400)
            {
                CheckTBox.Text += " (" + x[i] +"," + y[i] +") ";
                ++i;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        const int baseX = 60;
        const int baseY = 100;
        //draw every point
        protected override void OnPaint(PaintEventArgs e)
        {
            if (x !=null&&y !=null)
            {
                using (Pen pen = new Pen(Color.FromArgb(150, Color.Blue), 2))
                {
                    int i = 0;
                    while (x[i] != -1 && i != 400)
                    {
                        e.Graphics.DrawRectangle(pen, x[i] + baseX , y[i] + baseY , 1, 1);//rectangle  size in 1 pixel represent a point
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