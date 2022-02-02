using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24
{
    public partial class Form1 : Form
    {
        static Random rnd=new Random();
        static int number = rnd.Next(0, 101);
        static int guessCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(number);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = Convert.ToInt32(textboxGuess.Text);
                guessCount++;
                if (guess>number)
                {
                    labelMessage.Text = "Too big!";
                } 
                else if(guess<number)
                {
                    labelMessage.Text = "Too small!";
                }
                else
                {
                    labelMessage.Text = $"Congratulations, you guessed it by {guessCount}! Try again...";
                    number = rnd.Next(0, 101);
                    guessCount = 0;
                    this.Text = Convert.ToString(number);
                }
                
                if(guessCount>7)
                {
                    labelMessage.Text = $"You did not guess the easy one, {number}! Try again...";
                    number = rnd.Next(0, 101);
                    guessCount = 0;
                    this.Text = Convert.ToString(number);
                }
            }
            catch(Exception ex)
            {
                labelMessage.Text = "Write an integer in range 0...100!";
            }
        }
    }
}
