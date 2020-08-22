namespace Convolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_input = new System.Windows.Forms.PictureBox();
            this.pictureBox_output = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button_convolute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_input
            // 
            this.pictureBox_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_input.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_input.Image")));
            this.pictureBox_input.Location = new System.Drawing.Point(12, 11);
            this.pictureBox_input.Name = "pictureBox_input";
            this.pictureBox_input.Size = new System.Drawing.Size(407, 351);
            this.pictureBox_input.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_input.TabIndex = 0;
            this.pictureBox_input.TabStop = false;
            // 
            // pictureBox_output
            // 
            this.pictureBox_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_output.Location = new System.Drawing.Point(702, 12);
            this.pictureBox_output.Name = "pictureBox_output";
            this.pictureBox_output.Size = new System.Drawing.Size(417, 350);
            this.pictureBox_output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_output.TabIndex = 2;
            this.pictureBox_output.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0.0625";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(520, 101);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 34);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0.125";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(593, 101);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 34);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "0.0625";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(445, 141);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 34);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "0.125";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(520, 141);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 34);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "0.25";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(593, 141);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(73, 34);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "0.125";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(445, 181);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(69, 34);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "0.0625";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(520, 181);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(67, 34);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "0.125";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(593, 181);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(73, 34);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "0.0625";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_convolute
            // 
            this.button_convolute.Location = new System.Drawing.Point(498, 238);
            this.button_convolute.Name = "button_convolute";
            this.button_convolute.Size = new System.Drawing.Size(126, 33);
            this.button_convolute.TabIndex = 9;
            this.button_convolute.Text = "Convolute";
            this.button_convolute.UseVisualStyleBackColor = true;
            this.button_convolute.Click += new System.EventHandler(this.button_convolute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 372);
            this.Controls.Add(this.button_convolute);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox_output);
            this.Controls.Add(this.pictureBox_input);
            this.Name = "Form1";
            this.Text = "Convolution Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_input;
        private System.Windows.Forms.PictureBox pictureBox_output;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button_convolute;
    }
}

