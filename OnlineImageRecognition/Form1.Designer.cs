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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReadButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.CheckTBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DrawButton);
            this.panel1.Controls.Add(this.ReadButton);
            this.panel1.Location = new System.Drawing.Point(894, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 310);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CheckTBox);
            this.panel2.Location = new System.Drawing.Point(812, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 440);
            this.panel2.TabIndex = 1;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(10, 29);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(50, 25);
            this.ReadButton.TabIndex = 0;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(8, 69);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(51, 21);
            this.DrawButton.TabIndex = 1;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // CheckTBox
            // 
            this.CheckTBox.Location = new System.Drawing.Point(18, 16);
            this.CheckTBox.Multiline = true;
            this.CheckTBox.Name = "CheckTBox";
            this.CheckTBox.Size = new System.Drawing.Size(49, 363);
            this.CheckTBox.TabIndex = 0;
            this.CheckTBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CheckTBox;
    }
}

