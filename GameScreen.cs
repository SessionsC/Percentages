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

namespace Percentages
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
            
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            BuildQuestion();
            
                                 
        }
        private void button2_Click(object sender, EventArgs e)
        {

            var answer = 1;
            var userAnswer = Convert.ToInt32(textBox1.Text);
            if (userAnswer == answer)
                MessageBox.Show("correct");
            else
                MessageBox.Show("incorrect");

            ClearQuestion();


        }
        private void ClearQuestion()
        {
            panel.Invalidate();


        }
        private void BuildQuestion()
        {
            Graphics gr = panel.CreateGraphics();
            Pen myPen = new Pen(Brushes.Black, 1);
            Font myFont = new Font("Arial", 10);
            Random rnd = new Random();

            int lines = rnd.Next(2, 10);
            float x = 0f;
            float y = 0f;
            float xSpace = (panel.Width / lines) - myPen.Width;
            float ySpace = (panel.Height / lines) - myPen.Width;

            //Vertical Lines
            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(myPen, x, y, x, panel.Height);
                x += xSpace;

            }

            x = 0f;

            //Horizonal Lines
            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(myPen, x, y, panel.Width, y);
                y += ySpace;

            }

            //Text
            x = 0f;
            y = 0f;
            int counter = 1;
            for (int r = 0; r < lines; r++)
            {
                for (int c = 0; c < lines; c++)
                {
                    gr.DrawString(Convert.ToString(counter), myFont, Brushes.Black, x, y);
                    x += xSpace;
                    counter++;
                }
                y += ySpace;
                x = 0f;

            }

        }

    }
}
