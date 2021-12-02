namespace OnlineImageRecognition
{
    partial class ViewWindow
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DTW_TBox = new System.Windows.Forms.TextBox();
            this.DrawBt_2 = new System.Windows.Forms.Button();
            this.shiftBT = new System.Windows.Forms.Button();
            this.scaleBT = new System.Windows.Forms.Button();
            this.newDTWBT = new System.Windows.Forms.Button();
            this.newDTW_TextBox = new System.Windows.Forms.TextBox();
            this.AuthorizationBT = new System.Windows.Forms.Button();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.User_1_CBox = new System.Windows.Forms.ComboBox();
            this.User_2_CBox = new System.Windows.Forms.ComboBox();
            this.Signature_1_CBox = new System.Windows.Forms.ComboBox();
            this.Signature_2_CBox = new System.Windows.Forms.ComboBox();
            this.User_1_Lb = new System.Windows.Forms.Label();
            this.User_2_Lb = new System.Windows.Forms.Label();
            this.Signature_1_Lb = new System.Windows.Forms.Label();
            this.Signature_2_Lb = new System.Windows.Forms.Label();
            this.PerformanceBT = new System.Windows.Forms.Button();
            this.XpointPerformanceLabel = new System.Windows.Forms.Label();
            this.YpointPerformanceLabel = new System.Windows.Forms.Label();
            this.PerformanceSelectedUser1_CBox = new System.Windows.Forms.ComboBox();
            this.PerformanceSelectedUser2_CBox = new System.Windows.Forms.ComboBox();
            this.vPerformanceSelectedUser1_Label = new System.Windows.Forms.Label();
            this.vPerformanceSelectedUser2_Label = new System.Windows.Forms.Label();
            this.VerifyBT = new System.Windows.Forms.Button();
            this.VerifySignatureLB = new System.Windows.Forms.Label();
            this.VerifyResultLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTW
            // 
            this.DTW.Location = new System.Drawing.Point(217, 12);
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
            this.DrawBt_1.Location = new System.Drawing.Point(13, 193);
            this.DrawBt_1.Margin = new System.Windows.Forms.Padding(4);
            this.DrawBt_1.Name = "DrawBt_1";
            this.DrawBt_1.Size = new System.Drawing.Size(68, 26);
            this.DrawBt_1.TabIndex = 1;
            this.DrawBt_1.Text = "Draw";
            this.DrawBt_1.UseVisualStyleBackColor = true;
            this.DrawBt_1.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DTW_TBox
            // 
            this.DTW_TBox.Location = new System.Drawing.Point(217, 53);
            this.DTW_TBox.Margin = new System.Windows.Forms.Padding(4);
            this.DTW_TBox.Multiline = true;
            this.DTW_TBox.Name = "DTW_TBox";
            this.DTW_TBox.Size = new System.Drawing.Size(115, 37);
            this.DTW_TBox.TabIndex = 1;
            this.DTW_TBox.TextChanged += new System.EventHandler(this.DTW_TBox_TextChanged);
            // 
            // DrawBt_2
            // 
            this.DrawBt_2.Location = new System.Drawing.Point(115, 193);
            this.DrawBt_2.Margin = new System.Windows.Forms.Padding(4);
            this.DrawBt_2.Name = "DrawBt_2";
            this.DrawBt_2.Size = new System.Drawing.Size(68, 26);
            this.DrawBt_2.TabIndex = 12;
            this.DrawBt_2.Text = "Draw";
            this.DrawBt_2.UseVisualStyleBackColor = true;
            this.DrawBt_2.Click += new System.EventHandler(this.DrawBt_2_Click);
            // 
            // shiftBT
            // 
            this.shiftBT.Location = new System.Drawing.Point(364, 59);
            this.shiftBT.Name = "shiftBT";
            this.shiftBT.Size = new System.Drawing.Size(65, 31);
            this.shiftBT.TabIndex = 15;
            this.shiftBT.Text = "shift";
            this.shiftBT.UseVisualStyleBackColor = true;
            this.shiftBT.Click += new System.EventHandler(this.shiftBT_Click);
            // 
            // scaleBT
            // 
            this.scaleBT.Location = new System.Drawing.Point(364, 13);
            this.scaleBT.Name = "scaleBT";
            this.scaleBT.Size = new System.Drawing.Size(65, 31);
            this.scaleBT.TabIndex = 16;
            this.scaleBT.Text = "scale";
            this.scaleBT.UseVisualStyleBackColor = true;
            this.scaleBT.Click += new System.EventHandler(this.scaleBT_Click);
            // 
            // newDTWBT
            // 
            this.newDTWBT.Location = new System.Drawing.Point(217, 137);
            this.newDTWBT.Name = "newDTWBT";
            this.newDTWBT.Size = new System.Drawing.Size(74, 31);
            this.newDTWBT.TabIndex = 17;
            this.newDTWBT.Text = "New DTW";
            this.newDTWBT.UseVisualStyleBackColor = true;
            this.newDTWBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // newDTW_TextBox
            // 
            this.newDTW_TextBox.Location = new System.Drawing.Point(217, 182);
            this.newDTW_TextBox.Multiline = true;
            this.newDTW_TextBox.Name = "newDTW_TextBox";
            this.newDTW_TextBox.Size = new System.Drawing.Size(115, 37);
            this.newDTW_TextBox.TabIndex = 18;
            // 
            // AuthorizationBT
            // 
            this.AuthorizationBT.Location = new System.Drawing.Point(364, 137);
            this.AuthorizationBT.Name = "AuthorizationBT";
            this.AuthorizationBT.Size = new System.Drawing.Size(98, 31);
            this.AuthorizationBT.TabIndex = 20;
            this.AuthorizationBT.Text = "Authorization";
            this.AuthorizationBT.UseVisualStyleBackColor = true;
            this.AuthorizationBT.Click += new System.EventHandler(this.button2_Click);
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.Location = new System.Drawing.Point(361, 193);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(119, 15);
            this.AuthorizationLabel.TabIndex = 25;
            this.AuthorizationLabel.Text = "Authorization:";
            // 
            // User_1_CBox
            // 
            this.User_1_CBox.FormattingEnabled = true;
            this.User_1_CBox.Location = new System.Drawing.Point(15, 45);
            this.User_1_CBox.Name = "User_1_CBox";
            this.User_1_CBox.Size = new System.Drawing.Size(82, 23);
            this.User_1_CBox.TabIndex = 26;
            this.User_1_CBox.SelectedIndexChanged += new System.EventHandler(this.User_1_CBox_SelectedIndexChanged);
            // 
            // User_2_CBox
            // 
            this.User_2_CBox.FormattingEnabled = true;
            this.User_2_CBox.Location = new System.Drawing.Point(15, 137);
            this.User_2_CBox.Name = "User_2_CBox";
            this.User_2_CBox.Size = new System.Drawing.Size(82, 23);
            this.User_2_CBox.TabIndex = 27;
            this.User_2_CBox.SelectedIndexChanged += new System.EventHandler(this.User_2_CBox_SelectedIndexChanged);
            // 
            // Signature_1_CBox
            // 
            this.Signature_1_CBox.FormattingEnabled = true;
            this.Signature_1_CBox.Location = new System.Drawing.Point(115, 45);
            this.Signature_1_CBox.Name = "Signature_1_CBox";
            this.Signature_1_CBox.Size = new System.Drawing.Size(82, 23);
            this.Signature_1_CBox.TabIndex = 28;
            this.Signature_1_CBox.SelectedIndexChanged += new System.EventHandler(this.Signature_1_CBox_SelectedIndexChanged);
            // 
            // Signature_2_CBox
            // 
            this.Signature_2_CBox.FormattingEnabled = true;
            this.Signature_2_CBox.Location = new System.Drawing.Point(114, 137);
            this.Signature_2_CBox.Name = "Signature_2_CBox";
            this.Signature_2_CBox.Size = new System.Drawing.Size(83, 23);
            this.Signature_2_CBox.TabIndex = 29;
            this.Signature_2_CBox.SelectedIndexChanged += new System.EventHandler(this.Signature_2_CBox_SelectedIndexChanged);
            // 
            // User_1_Lb
            // 
            this.User_1_Lb.AutoSize = true;
            this.User_1_Lb.Location = new System.Drawing.Point(12, 9);
            this.User_1_Lb.Name = "User_1_Lb";
            this.User_1_Lb.Size = new System.Drawing.Size(55, 15);
            this.User_1_Lb.TabIndex = 30;
            this.User_1_Lb.Text = "User1:";
            // 
            // User_2_Lb
            // 
            this.User_2_Lb.AutoSize = true;
            this.User_2_Lb.Location = new System.Drawing.Point(12, 93);
            this.User_2_Lb.Name = "User_2_Lb";
            this.User_2_Lb.Size = new System.Drawing.Size(55, 15);
            this.User_2_Lb.TabIndex = 31;
            this.User_2_Lb.Text = "User2:";
            // 
            // Signature_1_Lb
            // 
            this.Signature_1_Lb.AutoSize = true;
            this.Signature_1_Lb.Location = new System.Drawing.Point(112, 9);
            this.Signature_1_Lb.Name = "Signature_1_Lb";
            this.Signature_1_Lb.Size = new System.Drawing.Size(95, 15);
            this.Signature_1_Lb.TabIndex = 32;
            this.Signature_1_Lb.Text = "Signature1:";
            // 
            // Signature_2_Lb
            // 
            this.Signature_2_Lb.AutoSize = true;
            this.Signature_2_Lb.Location = new System.Drawing.Point(112, 93);
            this.Signature_2_Lb.Name = "Signature_2_Lb";
            this.Signature_2_Lb.Size = new System.Drawing.Size(95, 15);
            this.Signature_2_Lb.TabIndex = 33;
            this.Signature_2_Lb.Text = "Signature2:";
            this.Signature_2_Lb.Click += new System.EventHandler(this.Signature_2_Lb_Click);
            // 
            // PerformanceBT
            // 
            this.PerformanceBT.Location = new System.Drawing.Point(507, 13);
            this.PerformanceBT.Name = "PerformanceBT";
            this.PerformanceBT.Size = new System.Drawing.Size(105, 30);
            this.PerformanceBT.TabIndex = 34;
            this.PerformanceBT.Text = "Performance";
            this.PerformanceBT.UseVisualStyleBackColor = true;
            this.PerformanceBT.Click += new System.EventHandler(this.PerformanceBT_Click);
            // 
            // XpointPerformanceLabel
            // 
            this.XpointPerformanceLabel.AutoSize = true;
            this.XpointPerformanceLabel.Location = new System.Drawing.Point(501, 137);
            this.XpointPerformanceLabel.Name = "XpointPerformanceLabel";
            this.XpointPerformanceLabel.Size = new System.Drawing.Size(151, 15);
            this.XpointPerformanceLabel.TabIndex = 35;
            this.XpointPerformanceLabel.Text = "XpointPerformance:";
            this.XpointPerformanceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // YpointPerformanceLabel
            // 
            this.YpointPerformanceLabel.AutoSize = true;
            this.YpointPerformanceLabel.Location = new System.Drawing.Point(501, 153);
            this.YpointPerformanceLabel.Name = "YpointPerformanceLabel";
            this.YpointPerformanceLabel.Size = new System.Drawing.Size(151, 15);
            this.YpointPerformanceLabel.TabIndex = 36;
            this.YpointPerformanceLabel.Text = "YpointPerformance:";
            // 
            // PerformanceSelectedUser1_CBox
            // 
            this.PerformanceSelectedUser1_CBox.FormattingEnabled = true;
            this.PerformanceSelectedUser1_CBox.Location = new System.Drawing.Point(504, 90);
            this.PerformanceSelectedUser1_CBox.Name = "PerformanceSelectedUser1_CBox";
            this.PerformanceSelectedUser1_CBox.Size = new System.Drawing.Size(56, 23);
            this.PerformanceSelectedUser1_CBox.TabIndex = 37;
            this.PerformanceSelectedUser1_CBox.SelectedIndexChanged += new System.EventHandler(this.PerformanceSelectedUser1_CBox_SelectedIndexChanged);
            // 
            // PerformanceSelectedUser2_CBox
            // 
            this.PerformanceSelectedUser2_CBox.FormattingEnabled = true;
            this.PerformanceSelectedUser2_CBox.Location = new System.Drawing.Point(621, 90);
            this.PerformanceSelectedUser2_CBox.Name = "PerformanceSelectedUser2_CBox";
            this.PerformanceSelectedUser2_CBox.Size = new System.Drawing.Size(56, 23);
            this.PerformanceSelectedUser2_CBox.TabIndex = 38;
            this.PerformanceSelectedUser2_CBox.SelectedIndexChanged += new System.EventHandler(this.PerformanceSelectedUser2_CBox_SelectedIndexChanged);
            // 
            // vPerformanceSelectedUser1_Label
            // 
            this.vPerformanceSelectedUser1_Label.AutoSize = true;
            this.vPerformanceSelectedUser1_Label.Location = new System.Drawing.Point(501, 67);
            this.vPerformanceSelectedUser1_Label.Name = "vPerformanceSelectedUser1_Label";
            this.vPerformanceSelectedUser1_Label.Size = new System.Drawing.Size(111, 15);
            this.vPerformanceSelectedUser1_Label.TabIndex = 39;
            this.vPerformanceSelectedUser1_Label.Text = "OriginalUser:";
            // 
            // vPerformanceSelectedUser2_Label
            // 
            this.vPerformanceSelectedUser2_Label.AutoSize = true;
            this.vPerformanceSelectedUser2_Label.Location = new System.Drawing.Point(618, 67);
            this.vPerformanceSelectedUser2_Label.Name = "vPerformanceSelectedUser2_Label";
            this.vPerformanceSelectedUser2_Label.Size = new System.Drawing.Size(111, 15);
            this.vPerformanceSelectedUser2_Label.TabIndex = 40;
            this.vPerformanceSelectedUser2_Label.Text = "ComparedUser:";
            this.vPerformanceSelectedUser2_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // VerifyBT
            // 
            this.VerifyBT.Location = new System.Drawing.Point(727, 12);
            this.VerifyBT.Name = "VerifyBT";
            this.VerifyBT.Size = new System.Drawing.Size(75, 30);
            this.VerifyBT.TabIndex = 41;
            this.VerifyBT.Text = "Verify";
            this.VerifyBT.UseVisualStyleBackColor = true;
            this.VerifyBT.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // VerifySignatureLB
            // 
            this.VerifySignatureLB.AutoSize = true;
            this.VerifySignatureLB.Location = new System.Drawing.Point(724, 56);
            this.VerifySignatureLB.Name = "VerifySignatureLB";
            this.VerifySignatureLB.Size = new System.Drawing.Size(87, 15);
            this.VerifySignatureLB.TabIndex = 42;
            this.VerifySignatureLB.Text = "Signature:";
            // 
            // VerifyResultLB
            // 
            this.VerifyResultLB.AutoSize = true;
            this.VerifyResultLB.Location = new System.Drawing.Point(692, 93);
            this.VerifyResultLB.Name = "VerifyResultLB";
            this.VerifyResultLB.Size = new System.Drawing.Size(119, 15);
            this.VerifyResultLB.TabIndex = 43;
            this.VerifyResultLB.Text = "Verify_Result:";
            // 
            // ViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 250);
            this.Controls.Add(this.VerifyResultLB);
            this.Controls.Add(this.VerifySignatureLB);
            this.Controls.Add(this.VerifyBT);
            this.Controls.Add(this.vPerformanceSelectedUser2_Label);
            this.Controls.Add(this.vPerformanceSelectedUser1_Label);
            this.Controls.Add(this.PerformanceSelectedUser2_CBox);
            this.Controls.Add(this.PerformanceSelectedUser1_CBox);
            this.Controls.Add(this.YpointPerformanceLabel);
            this.Controls.Add(this.XpointPerformanceLabel);
            this.Controls.Add(this.PerformanceBT);
            this.Controls.Add(this.Signature_2_Lb);
            this.Controls.Add(this.Signature_1_Lb);
            this.Controls.Add(this.User_2_Lb);
            this.Controls.Add(this.User_1_Lb);
            this.Controls.Add(this.Signature_2_CBox);
            this.Controls.Add(this.Signature_1_CBox);
            this.Controls.Add(this.User_2_CBox);
            this.Controls.Add(this.User_1_CBox);
            this.Controls.Add(this.AuthorizationLabel);
            this.Controls.Add(this.AuthorizationBT);
            this.Controls.Add(this.newDTW_TextBox);
            this.Controls.Add(this.newDTWBT);
            this.Controls.Add(this.scaleBT);
            this.Controls.Add(this.shiftBT);
            this.Controls.Add(this.DrawBt_2);
            this.Controls.Add(this.DrawBt_1);
            this.Controls.Add(this.DTW);
            this.Controls.Add(this.DTW_TBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewWindow";
            this.Text = "SignatureVerify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DrawBt_1;
        private System.Windows.Forms.Button DTW;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox DTW_TBox;
        private System.Windows.Forms.Button DrawBt_2;
        private System.Windows.Forms.Button shiftBT;
        private System.Windows.Forms.Button scaleBT;
        private System.Windows.Forms.Button newDTWBT;
        private System.Windows.Forms.TextBox newDTW_TextBox;
        private System.Windows.Forms.Button AuthorizationBT;
        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.ComboBox User_1_CBox;
        private System.Windows.Forms.ComboBox User_2_CBox;
        private System.Windows.Forms.ComboBox Signature_1_CBox;
        private System.Windows.Forms.ComboBox Signature_2_CBox;
        private System.Windows.Forms.Label User_1_Lb;
        private System.Windows.Forms.Label User_2_Lb;
        private System.Windows.Forms.Label Signature_1_Lb;
        private System.Windows.Forms.Label Signature_2_Lb;
        private System.Windows.Forms.Button PerformanceBT;
        private System.Windows.Forms.Label XpointPerformanceLabel;
        private System.Windows.Forms.Label YpointPerformanceLabel;
        private System.Windows.Forms.ComboBox PerformanceSelectedUser1_CBox;
        private System.Windows.Forms.ComboBox PerformanceSelectedUser2_CBox;
        private System.Windows.Forms.Label vPerformanceSelectedUser1_Label;
        private System.Windows.Forms.Label vPerformanceSelectedUser2_Label;
        private System.Windows.Forms.Button VerifyBT;
        private System.Windows.Forms.Label VerifySignatureLB;
        private System.Windows.Forms.Label VerifyResultLB;
    }
}

