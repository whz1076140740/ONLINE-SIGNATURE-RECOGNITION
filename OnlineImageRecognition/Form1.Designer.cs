namespace OnlineImageRecognition
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DTW = new System.Windows.Forms.Button();
            this.DrawBt_1 = new System.Windows.Forms.Button();
            this.ReadBt_1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DTW_TBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Signature_LV_1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Signature_LV_2 = new System.Windows.Forms.ListView();
            this.ReadBt_2 = new System.Windows.Forms.Button();
            this.DrawBt_2 = new System.Windows.Forms.Button();
            this.signature1Label = new System.Windows.Forms.Label();
            this.signature2Label = new System.Windows.Forms.Label();
            this.shiftBT = new System.Windows.Forms.Button();
            this.scaleBT = new System.Windows.Forms.Button();
            this.newDTWBT = new System.Windows.Forms.Button();
            this.newDTW_TextBox = new System.Windows.Forms.TextBox();
            this.AverageDTWBT = new System.Windows.Forms.Button();
            this.AuthorizationBT = new System.Windows.Forms.Button();
            this.AverageDTWLabel = new System.Windows.Forms.Label();
            this.AverageDTW_FrogedLabel = new System.Windows.Forms.Label();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTW
            // 
            this.DTW.Location = new System.Drawing.Point(461, 374);
            this.DTW.Margin = new System.Windows.Forms.Padding(4);
            this.DTW.Name = "DTW";
            this.DTW.Size = new System.Drawing.Size(74, 31);
            this.DTW.TabIndex = 2;
            this.DTW.Text = "DTW";
            this.DTW.UseVisualStyleBackColor = true;
            this.DTW.Click += new System.EventHandler(this.DTW_Click);
            // 
            // DrawBt_1
            // 
            this.DrawBt_1.Location = new System.Drawing.Point(65, 423);
            this.DrawBt_1.Margin = new System.Windows.Forms.Padding(4);
            this.DrawBt_1.Name = "DrawBt_1";
            this.DrawBt_1.Size = new System.Drawing.Size(68, 26);
            this.DrawBt_1.TabIndex = 1;
            this.DrawBt_1.Text = "Draw";
            this.DrawBt_1.UseVisualStyleBackColor = true;
            this.DrawBt_1.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // ReadBt_1
            // 
            this.ReadBt_1.Location = new System.Drawing.Point(65, 374);
            this.ReadBt_1.Margin = new System.Windows.Forms.Padding(4);
            this.ReadBt_1.Name = "ReadBt_1";
            this.ReadBt_1.Size = new System.Drawing.Size(67, 31);
            this.ReadBt_1.TabIndex = 0;
            this.ReadBt_1.Text = "Read";
            this.ReadBt_1.UseVisualStyleBackColor = true;
            this.ReadBt_1.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DTW_TBox
            // 
            this.DTW_TBox.Location = new System.Drawing.Point(446, 423);
            this.DTW_TBox.Margin = new System.Windows.Forms.Padding(4);
            this.DTW_TBox.Multiline = true;
            this.DTW_TBox.Name = "DTW_TBox";
            this.DTW_TBox.Size = new System.Drawing.Size(115, 37);
            this.DTW_TBox.TabIndex = 1;
            this.DTW_TBox.TextChanged += new System.EventHandler(this.DTW_TBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "SelectedSignature1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "SelectedSignature2";
            // 
            // Signature_LV_1
            // 
            this.Signature_LV_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Signature_LV_1.HideSelection = false;
            this.Signature_LV_1.Location = new System.Drawing.Point(0, 0);
            this.Signature_LV_1.Name = "Signature_LV_1";
            this.Signature_LV_1.Size = new System.Drawing.Size(96, 212);
            this.Signature_LV_1.TabIndex = 8;
            this.Signature_LV_1.UseCompatibleStateImageBehavior = false;
            this.Signature_LV_1.SelectedIndexChanged += new System.EventHandler(this.Signature_LV_1_SelectedIndexChanged);
            this.Signature_LV_1.DoubleClick += new System.EventHandler(this.Signature_LV_1_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Signature_LV_1);
            this.panel3.Location = new System.Drawing.Point(65, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 212);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Signature_LV_2);
            this.panel1.Location = new System.Drawing.Point(245, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 212);
            this.panel1.TabIndex = 10;
            // 
            // Signature_LV_2
            // 
            this.Signature_LV_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Signature_LV_2.HideSelection = false;
            this.Signature_LV_2.Location = new System.Drawing.Point(0, 0);
            this.Signature_LV_2.Name = "Signature_LV_2";
            this.Signature_LV_2.Size = new System.Drawing.Size(95, 212);
            this.Signature_LV_2.TabIndex = 8;
            this.Signature_LV_2.UseCompatibleStateImageBehavior = false;
            this.Signature_LV_2.SelectedIndexChanged += new System.EventHandler(this.Signature_LV_2_SelectedIndexChanged);
            this.Signature_LV_2.DoubleClick += new System.EventHandler(this.Signature_LV_2_DoubleClick);
            // 
            // ReadBt_2
            // 
            this.ReadBt_2.Location = new System.Drawing.Point(245, 374);
            this.ReadBt_2.Margin = new System.Windows.Forms.Padding(4);
            this.ReadBt_2.Name = "ReadBt_2";
            this.ReadBt_2.Size = new System.Drawing.Size(67, 31);
            this.ReadBt_2.TabIndex = 11;
            this.ReadBt_2.Text = "Read";
            this.ReadBt_2.UseVisualStyleBackColor = true;
            this.ReadBt_2.Click += new System.EventHandler(this.ReadBt_2_Click);
            // 
            // DrawBt_2
            // 
            this.DrawBt_2.Location = new System.Drawing.Point(245, 423);
            this.DrawBt_2.Margin = new System.Windows.Forms.Padding(4);
            this.DrawBt_2.Name = "DrawBt_2";
            this.DrawBt_2.Size = new System.Drawing.Size(68, 26);
            this.DrawBt_2.TabIndex = 12;
            this.DrawBt_2.Text = "Draw";
            this.DrawBt_2.UseVisualStyleBackColor = true;
            this.DrawBt_2.Click += new System.EventHandler(this.DrawBt_2_Click);
            // 
            // signature1Label
            // 
            this.signature1Label.AutoSize = true;
            this.signature1Label.Location = new System.Drawing.Point(65, 330);
            this.signature1Label.Name = "signature1Label";
            this.signature1Label.Size = new System.Drawing.Size(15, 15);
            this.signature1Label.TabIndex = 13;
            this.signature1Label.Text = ":";
            // 
            // signature2Label
            // 
            this.signature2Label.AutoSize = true;
            this.signature2Label.Location = new System.Drawing.Point(252, 326);
            this.signature2Label.Name = "signature2Label";
            this.signature2Label.Size = new System.Drawing.Size(15, 15);
            this.signature2Label.TabIndex = 14;
            this.signature2Label.Text = ":";
            // 
            // shiftBT
            // 
            this.shiftBT.Location = new System.Drawing.Point(470, 80);
            this.shiftBT.Name = "shiftBT";
            this.shiftBT.Size = new System.Drawing.Size(65, 31);
            this.shiftBT.TabIndex = 15;
            this.shiftBT.Text = "shift";
            this.shiftBT.UseVisualStyleBackColor = true;
            this.shiftBT.Click += new System.EventHandler(this.shiftBT_Click);
            // 
            // scaleBT
            // 
            this.scaleBT.Location = new System.Drawing.Point(470, 157);
            this.scaleBT.Name = "scaleBT";
            this.scaleBT.Size = new System.Drawing.Size(65, 31);
            this.scaleBT.TabIndex = 16;
            this.scaleBT.Text = "scale";
            this.scaleBT.UseVisualStyleBackColor = true;
            this.scaleBT.Click += new System.EventHandler(this.scaleBT_Click);
            // 
            // newDTWBT
            // 
            this.newDTWBT.Location = new System.Drawing.Point(461, 235);
            this.newDTWBT.Name = "newDTWBT";
            this.newDTWBT.Size = new System.Drawing.Size(74, 31);
            this.newDTWBT.TabIndex = 17;
            this.newDTWBT.Text = "New DTW";
            this.newDTWBT.UseVisualStyleBackColor = true;
            this.newDTWBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // newDTW_TextBox
            // 
            this.newDTW_TextBox.Location = new System.Drawing.Point(446, 289);
            this.newDTW_TextBox.Multiline = true;
            this.newDTW_TextBox.Name = "newDTW_TextBox";
            this.newDTW_TextBox.Size = new System.Drawing.Size(115, 37);
            this.newDTW_TextBox.TabIndex = 18;
            // 
            // AverageDTWBT
            // 
            this.AverageDTWBT.Location = new System.Drawing.Point(588, 66);
            this.AverageDTWBT.Name = "AverageDTWBT";
            this.AverageDTWBT.Size = new System.Drawing.Size(98, 30);
            this.AverageDTWBT.TabIndex = 19;
            this.AverageDTWBT.Text = "AverageDTW";
            this.AverageDTWBT.UseVisualStyleBackColor = true;
            this.AverageDTWBT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AuthorizationBT
            // 
            this.AuthorizationBT.Location = new System.Drawing.Point(588, 314);
            this.AuthorizationBT.Name = "AuthorizationBT";
            this.AuthorizationBT.Size = new System.Drawing.Size(98, 31);
            this.AuthorizationBT.TabIndex = 20;
            this.AuthorizationBT.Text = "Authorization";
            this.AuthorizationBT.UseVisualStyleBackColor = true;
            this.AuthorizationBT.Click += new System.EventHandler(this.button2_Click);
            // 
            // AverageDTWLabel
            // 
            this.AverageDTWLabel.AutoSize = true;
            this.AverageDTWLabel.Location = new System.Drawing.Point(591, 117);
            this.AverageDTWLabel.Name = "AverageDTWLabel";
            this.AverageDTWLabel.Size = new System.Drawing.Size(95, 15);
            this.AverageDTWLabel.TabIndex = 23;
            this.AverageDTWLabel.Text = "AverageDTW:";
            this.AverageDTWLabel.Click += new System.EventHandler(this.AverageDTWLabel_Click);
            // 
            // AverageDTW_FrogedLabel
            // 
            this.AverageDTW_FrogedLabel.AutoSize = true;
            this.AverageDTW_FrogedLabel.Location = new System.Drawing.Point(591, 157);
            this.AverageDTW_FrogedLabel.Name = "AverageDTW_FrogedLabel";
            this.AverageDTW_FrogedLabel.Size = new System.Drawing.Size(151, 15);
            this.AverageDTW_FrogedLabel.TabIndex = 24;
            this.AverageDTW_FrogedLabel.Text = "AverageDTW_Froged:";
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.Location = new System.Drawing.Point(585, 359);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(119, 15);
            this.AuthorizationLabel.TabIndex = 25;
            this.AuthorizationLabel.Text = "Authorization:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 525);
            this.Controls.Add(this.AuthorizationLabel);
            this.Controls.Add(this.AverageDTW_FrogedLabel);
            this.Controls.Add(this.AverageDTWLabel);
            this.Controls.Add(this.AuthorizationBT);
            this.Controls.Add(this.AverageDTWBT);
            this.Controls.Add(this.newDTW_TextBox);
            this.Controls.Add(this.newDTWBT);
            this.Controls.Add(this.scaleBT);
            this.Controls.Add(this.shiftBT);
            this.Controls.Add(this.signature2Label);
            this.Controls.Add(this.signature1Label);
            this.Controls.Add(this.DrawBt_2);
            this.Controls.Add(this.ReadBt_2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DrawBt_1);
            this.Controls.Add(this.DTW);
            this.Controls.Add(this.ReadBt_1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTW_TBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DrawBt_1;
        private System.Windows.Forms.Button ReadBt_1;
        private System.Windows.Forms.Button DTW;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox DTW_TBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView Signature_LV_1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView Signature_LV_2;
        private System.Windows.Forms.Button ReadBt_2;
        private System.Windows.Forms.Button DrawBt_2;
        private System.Windows.Forms.Label signature1Label;
        private System.Windows.Forms.Label signature2Label;
        private System.Windows.Forms.Button shiftBT;
        private System.Windows.Forms.Button scaleBT;
        private System.Windows.Forms.Button newDTWBT;
        private System.Windows.Forms.TextBox newDTW_TextBox;
        private System.Windows.Forms.Button AverageDTWBT;
        private System.Windows.Forms.Button AuthorizationBT;
        private System.Windows.Forms.Label AverageDTWLabel;
        private System.Windows.Forms.Label AverageDTW_FrogedLabel;
        private System.Windows.Forms.Label AuthorizationLabel;
    }
}

