using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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


        //entity
        private BussinessEntity entity;
        private BussinessEntity entity_other;


        //draw points
        int[] x;
        int[] y;
        int[] x_other;
        int[] y_other;
        float[] fx;
        float[] fy;
        float[] fx_other;
        float[] fy_other;

        //scaled entity
        BussinessEntity_Scaled scalling;
        BussinessEntity_Scaled scalling_Other;
        public Form1()
        {
            InitializeComponent();
            //initailize User and signature combox
            for (int i = 1; i <= 40; i++)
            {
                User_1_CBox.Items.Add("U" + i);
                User_2_CBox.Items.Add("U" + i);

                Signature_1_CBox.Items.Add("S" + i);
                Signature_2_CBox.Items.Add("S" + i);

                PerformanceSelectedUser1_CBox.Items.Add("U" + i);
                PerformanceSelectedUser2_CBox.Items.Add("U" + i);
            }

            //fx = entity.PointX;
            //fy = entity.PointY;
            //x = entity.PointX_Int;
            //y = entity.PointY_Int;

            //fx_other = entity_other.PointX;
            //fy_other = entity_other.PointY;
            //x_other = entity_other.PointX_Int;
            //y_other = entity_other.PointY_Int;

            /* ///sort!!!!!!Float
             Sorter.Save(fx, fy, null, null);
             sorter.SortF(fx, fy);
             Sorter.Save(fx, fy,null,null);*/
        }

        //read1 button read from signature1
        private void ReadButton_Click(object sender, EventArgs e)
        {
            if (selected_filename == null)
            {
                string message = "You should choose first!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "Signature1_read", buttons);
            }
            else
            {
                //entity read
                /**/
                entity = new BussinessEntity(@"././././Task2/" + selected_filename);
                if (entity != null)
                {
                    entity.ToFloatArray();
                    fx = entity.PointX;
                    fy = entity.PointY;
                    x = entity.PointX_Int;
                    y = entity.PointY_Int;

                    string message = "Read '" + selected_filename + "' successful!!!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(this, message, "Signature1_read", buttons);
                }

                /*  ///sort!!!!!!Int
                 Sorter.Save(null, null, x, y);
                 sorter.SortInt( x,  y);
                 Sorter.Save( null, null, x, y);*/
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //const int SHIFTX = 100;
            //const int SHIFTY = 500;
            //if (x !=null&&y !=null)
            //{
            //    using (Pen pen = new Pen(Color.FromArgb(150, Color.Blue), 2))
            //    {
            //       /* //this is use for check the X,Y coordinates direction
            //            //this is extension along Y coordinate
            //        e.Graphics.DrawRectangle(pen, 30 + 1, 30 + 1, 1, 1);
            //        e.Graphics.DrawRectangle(pen, 30 + 1, 30 + 20, 1, 1);
            //        e.Graphics.DrawRectangle(pen, 30 + 1, 30 + 30, 1, 1);
            //        e.Graphics.DrawRectangle(pen, 30 + 1, 30 + 40, 1, 1);
            //        e.Graphics.DrawRectangle(pen, 30 + 1, 30 + 50, 1, 1); 
            //        //this is extension along X coordinate
            //        e.Graphics.DrawRectangle(pen, 30 + 20, 30 + 1, 1, 1);
            //        e.Graphics.DrawRectangle(pen, 30 + 30, 30 + 1, 1, 1);
            //        e.Graphics.DrawRectangle(pen, 30 + 60, 30 + 60, 1, 1);
            //        */
            //        int i = 0;
            //        while (i<x.Length)
            //        {
            //           // e.Graphics.DrawRectangle(pen, x[i] + 30 , y[i] + 30 , 1, 1);//rectangle  size in 1 pixel represent a point

            //            //entity fraw
            //            e.Graphics.DrawRectangle(pen, fx[i] + SHIFTX , - fy[i] + SHIFTY, 1, 1);//rectangle  size in 1 pixel represent a point
            //            ++i;
            //        }
            //    }
            //}
        }
        //drawBt 1 draw the signature 1 in a new window
        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (selected_filename == null)
            {
                string message = "You should choose first!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "Signature1_Draw", buttons);
            } else if (fx == null || fy == null)
            {
                string message = "You should Read before Draw!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "Signature1_Draw", buttons);
            }
            else
            {
                DrawWindow signatureDraw1 = new DrawWindow();
                signatureDraw1.fx = fx;
                signatureDraw1.fy = fy;
                signatureDraw1.ShowDialog();
            }
        }

        private void DTW_TBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void DTW_Click(object sender, EventArgs e)
        {
            if (x != null & y != null & x_other != null & y_other != null)
            {
                BComp_DTW dtw_Calculator = new BComp_DTW();
                int[,] DTW = BComp_DTW.DTWDistance(x, y, x_other, y_other);
                /*float DTWx = dtw_Calculator.float_DTWDistance(fx, fx_other);
                 float DTWy = dtw_Calculator.float_DTWDistance(fy,fy_other);*/
                DTW_TBox.Clear();
                DTW_TBox.Text = "(" + DTW[0, 0] + "," + DTW[0, 1] + ")";
            }
            else
            {
                string message = "You should Read before DTW!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "DTW_calculator", buttons);
            }
        }

        private void signiture1_LV_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void load()
        {

        }
        private void signiture1_LV_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
        }
        private void signiture1_LV_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void signiture2_LV_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
        }
        private void signiture2_LV_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }
        private void signiture1_LV_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*DirectoryInfo parentDI = new DirectoryInfo(@"D:\Hang Ze Wu\tool\data source\training project\DBreader\OnlineImageRecognition\bin\Debug\Task2");
            Signature_LV_1.Items.Clear();
            Signature_LV_2.Items.Clear();
            try
            {
                foreach (FileInfo fi in parentDI.GetFiles())
                {
                    Signature_LV_1.Items.Add(fi.Name);
                    Signature_LV_2.Items.Add(fi.Name);
                }
            }
            catch { } */
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Singature_TV_1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
        }

        private void Singature_TV_2_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
        }

        private void Singature_TV_1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void Singature_TV_1_AfterExpand(object sender, TreeViewEventArgs e)
        {
        }

        //choose read signature from list view
        string selected_filename;
        string selected_filename_other;
        private void Signature_LV_1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void Signature_LV_2_DoubleClick(object sender, EventArgs e)
        {
        }

        //read2 button read from signature2
        private void ReadBt_2_Click(object sender, EventArgs e)
        {
        }

        private void DrawBt_2_Click(object sender, EventArgs e)
        {
            if (selected_filename_other == null)
            {
                string message = "You should choose first!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "Signature2_read", buttons);
            }
            else if (fx == null || fy == null)
            {
                string message = "You should Read befire Draw!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "Signature2_Draw", buttons);
            } else {
                DrawWindow signatureDraw2 = new DrawWindow();
                signatureDraw2.fx = fx_other;
                signatureDraw2.fy = fy_other;
                signatureDraw2.ShowDialog();
            }
        }
        //select .txt for read
        private void Signature_LV_1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Signature_LV_2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //shift
        private void shiftBT_Click(object sender, EventArgs e)
        {
            if (x != null & y != null & x_other != null & y_other != null)
            {
                BComp_Shift shift_Operator = new BComp_Shift();
                /*shift_Operator.shift_ByDistanceToOrigin(fx,fy);
                shift_Operator.shift_ByDistanceToOrigin(fx_other, fy_other);*/

                shift_Operator.shift_ToOrigin(fx, fy);
                shift_Operator.shift_ToOrigin(fx_other, fy_other);
                //success
                {
                    string message = " Shift success!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(this, message, "Shift_operation_Success", buttons);
                }
            }
            else
            {
                string message = "You should Read before Shift!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "Shift_operation", buttons);
            }
        }

        private void scaleBT_Click(object sender, EventArgs e)
        {
            if (x != null & y != null & x_other != null & y_other != null)
            {
                /*BComp_Scale scale_Operator = new BComp_Scale();
                scale_Operator.Scale(fx, fy,fx_other,fy_other);*/

                scalling = new BussinessEntity_Scaled();
                scalling_Other = new BussinessEntity_Scaled();
                scalling.setEntity(fx, fy);
                scalling_Other.setEntity(fx_other, fy_other);
                //success
                {
                    string message = " Scale success!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(this, message, "Scale_operation_Success", buttons);
                }
            }
            else
            {
                string message = "You should Read before Scalling!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "Scale_operation", buttons);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (scalling.PointX != null & scalling.PointY != null & scalling_Other.PointX != null & scalling_Other.PointY != null)
            {
                BComp_DTW dtw_Calculator = new BComp_DTW();
                //int[,] DTW = dtw_Calculator.DTWDistance(x, y, x_other, y_other);
                float DTWx = dtw_Calculator.float_DTWDistance(scalling.PointX, scalling_Other.PointX);
                float DTWy = dtw_Calculator.float_DTWDistance(scalling.PointY, scalling_Other.PointY);
                newDTW_TextBox.Clear();
                newDTW_TextBox.Text = "(" + (int)DTWx + "," + (int)DTWy + ")";
            }
            else
            {
                string message = "You should Read before DTW!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "DTW_calculator", buttons);
            }
        }

        //disposed authroization average button 
        private void button1_Click_1(object sender, EventArgs e)
        {
            BComp_AverageDTW ave = new BComp_AverageDTW(selected_filename,selected_filename);
            BComp_AverageDTW ave_Comp = new BComp_AverageDTW(selected_filename_other, selected_filename);
            int[,] aveDTW = ave.AverageDTW(1, 10);
            int[,] aveDTW_Other = ave_Comp.AverageDTW(1, 20);
            String AverageDTWLabel_Text = "AverageDTW:" + aveDTW[0, 0] + "," + aveDTW[0, 1];
            String AverageDTW_FrogedLabel_Text = "AverageDTW_Froged:" + aveDTW_Other[0, 0] + "," + aveDTW_Other[0, 1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BComp_Authorization auo = new BComp_Authorization(selected_filename_other,selected_filename);
            AuthorizationLabel.Text = "Authorization:" + auo.Autho();
        }

        private void AverageDTWLabel_Click(object sender, EventArgs e)
        {
        }


        private void readFile(){

            if (selected_filename == null)
            {
                string message = "You should choose first!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "Signature1_read", buttons);
            }
            else
            {
                //entity read
                /**/
                entity = new BussinessEntity(@"././././Task2/" + selected_filename);
                if (entity != null)
                {
                    entity.ToFloatArray();
                    fx = entity.PointX;
                    fy = entity.PointY;
                    x = entity.PointX_Int;
                    y = entity.PointY_Int;

                    string message = "Read '" + selected_filename + "' successful!!!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(this, message, "Signature1_read", buttons);
                }

                /*  ///sort!!!!!!Int
                 Sorter.Save(null, null, x, y);
                 sorter.SortInt( x,  y);
                 Sorter.Save( null, null, x, y);*/
            }
        }

        private void readFile_Other()
        {

            if (selected_filename_other == null)
            {
                string message = "You should choose first!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, "Signature2_read", buttons);
            }
            else
            {
                entity_other = new BussinessEntity(@"././././Task2/" + selected_filename_other);
                if (entity_other != null)
                {
                    entity_other.ToFloatArray();
                    fx_other = entity_other.PointX;
                    fy_other = entity_other.PointY;
                    x_other = entity_other.PointX_Int;
                    y_other = entity_other.PointY_Int;

                    string message = "Read '" + selected_filename_other + "' successful!!!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(this, message, "Signature2_read", buttons);
                }
            }
        }

        String selectedUser = null;
        String selectedUser_Other = null;
        String selectedSignature = null;
        String selectedSignature_Other = null;
        String readFileType = ".TXT";
        private void User_1_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = User_1_CBox.SelectedItem;
            String selected = selectedItem.ToString();

            selectedUser = selected;
            if (selectedUser!=null && selectedSignature!=null)
            {
                //read
                if (selectedUser == selected)
                {
                    selected_filename = selectedUser + selectedSignature + readFileType;
                    readFile();
                }
            }
        }

        private void User_2_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = User_2_CBox.SelectedItem;
            String selected = selectedItem.ToString();

            selectedUser_Other = selected;
            if (selectedUser_Other != null && selectedSignature_Other != null)
            {
                //read
                if (selectedUser_Other == selected)
                {
                    selected_filename_other = selectedUser_Other + selectedSignature_Other + readFileType;
                    readFile_Other();
                }
            }
        }

        private void Signature_1_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = Signature_1_CBox.SelectedItem;
            String selected = selectedItem.ToString();

            selectedSignature = selected;
            if (selectedSignature != null && selectedUser != null)
            {
                //read
                if (selectedSignature == selected)
                {
                    selected_filename = selectedUser + selectedSignature + readFileType;
                    readFile();
                }
            }

        }

        private void Signature_2_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Object selectedItem = Signature_2_CBox.SelectedItem;
            String selected = selectedItem.ToString();

            selectedSignature_Other = selected;
            if (selectedSignature_Other != null && selectedUser_Other != null)
            {
                //read
                if (selectedSignature_Other == selected)
                {
                    selected_filename_other = selectedUser_Other + selectedSignature_Other + readFileType;
                    readFile_Other();
                }
            }
        }

        private void Signature_2_Lb_Click(object sender, EventArgs e)
        {

        }

        private void PerformanceBT_Click(object sender, EventArgs e)
        {
            BComp_SystemPerformance performance = new BComp_SystemPerformance(performanceSelectedUser,other_performanceSelectedUser);
            double[] index = performance.performaceTestCalculation();
            XpointPerformanceLabel.Text = "XpointPerformance: "+index[0].ToString();
            YpointPerformanceLabel.Text = "YpointPerformance: " + index[1].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int performanceSelectedUser = 1;
        int other_performanceSelectedUser = 1;
        private void PerformanceSelectedUser1_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = PerformanceSelectedUser1_CBox.SelectedItem;
            performanceSelectedUser = int.Parse(selectedItem.ToString().Split('U')[1]);
        }

        private void PerformanceSelectedUser2_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = PerformanceSelectedUser2_CBox.SelectedItem;
            other_performanceSelectedUser = int.Parse(selectedItem.ToString().Split('U')[1]);
        }
    }
}
