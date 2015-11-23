using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Dispose();
            StarField(10000);
        }
        
        public void StarField(int stars)
        {
            for (int counter = 0; counter <= stars; counter++)
            {
                Random randNum = new Random();
                Graphics g = this.CreateGraphics();


                int xValue = randNum.Next(0, this.Width);
                int yValue = randNum.Next(0, this.Height);
                int redValue = randNum.Next(1, 256);
                int greenValue = randNum.Next(1, 256);
                int blueValue = randNum.Next(1, 256);
                int starSize = randNum.Next(1, 100);
                int starTransparency = randNum.Next(1, 151);

                SolidBrush freakShow = new SolidBrush(Color.FromArgb(starTransparency, redValue, greenValue, blueValue));
                g.FillEllipse(freakShow, xValue, yValue, starSize, starSize);

                //Thread.Sleep(50);
            }
        }

    }
}