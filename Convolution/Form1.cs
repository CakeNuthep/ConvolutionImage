using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_convolute_Click(object sender, EventArgs e)
        {
            
            double[,] kernel;
            bool canConvertToKernel = convertInputToKernel(out kernel);
            if (canConvertToKernel)
            {
                Bitmap newImage = convolution(kernel, (Bitmap)pictureBox_input.Image);
                pictureBox_output.Image = newImage;
            }
        }


        private Bitmap convolution(double[,] kernel, Bitmap image)
        {
            Bitmap originImage = image;
            Bitmap newImage = new Bitmap(originImage.Width,originImage.Height);
            int indexXCenter = 1;
            int indexYCenter = 1;
            for (int x = indexXCenter; x < originImage.Width-indexXCenter; x++)
            {
                for (int y = indexYCenter; y < originImage.Height-indexYCenter; y++)
                {
                    Color newPixelColor = sumKernel(x, y, kernel, image);
                    newImage.SetPixel(x, y, newPixelColor);
                }
            }
            return newImage;
        }

        private bool convertInputToKernel(out double[,] kernel)
        {
            double input1=0, input2=0, input3=0, input4=0, input5=0, input6=0, input7=0, input8=0, input9=0;
            bool canConvert = true;
            if (!double.TryParse(textBox1.Text, out input1))
            {
                canConvert = false;
            }
            else if (!double.TryParse(textBox2.Text, out input2))
            {
                canConvert = false;
            }
            else if (!double.TryParse(textBox3.Text, out input3))
            {
                canConvert = false;
            }
            else if (!double.TryParse(textBox4.Text, out input4))
            {
                canConvert = false;
            }
            else if (!double.TryParse(textBox5.Text, out input5))
            {
                canConvert = false;
            }
            else if (!double.TryParse(textBox6.Text, out input6))
            {
                canConvert = false;
            }
            else if (!double.TryParse(textBox7.Text, out input7))
            {
                canConvert = false;
            }
            else if (!double.TryParse(textBox8.Text, out input8))
            {
                canConvert = false;
            }
            else if (!double.TryParse(textBox9.Text, out input9))
            {
                canConvert = false;
            }
            kernel = new double[3, 3];
            if (canConvert)
            {
                
                kernel[0, 0] = input1;
                kernel[0, 1] = input2;
                kernel[0, 2] = input3;

                kernel[1, 0] = input4;
                kernel[1, 1] = input5;
                kernel[1, 2] = input6;

                kernel[2, 0] = input7;
                kernel[2, 1] = input8;
                kernel[2, 2] = input9;
            }
            return canConvert;
        }

        private Color sumKernel(int indexX,int indexY,double[,] Kernel,Bitmap image)
        {
            double sumR = 0;
            double sumG = 0;
            double sumB = 0;
            double sumA = 0;
            for(int y=0;y<3;y++)
            {
                for(int x=0;x<3;x++)
                {
                    Color pixelColor = image.GetPixel(indexX + x - 1, indexY + y - 1);
                    sumR = sumR + (pixelColor.R * Kernel[x, y]);
                    sumG = sumG + (pixelColor.G * Kernel[x, y]);
                    sumB = sumB + (pixelColor.B * Kernel[x, y]);
                    sumA = sumA + (pixelColor.A * Kernel[x, y]);
                }
            }
            Color newPixelColor = Color.FromArgb((byte)sumA, (byte)sumR, (byte)sumG, (byte)sumB);
            return newPixelColor;

        }
    }
}
