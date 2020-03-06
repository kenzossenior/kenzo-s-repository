using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palindrome
{
    public partial class Form1 : Form
    {

        static int num;
        static int guess;
        static int tries;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random RNG = new Random();
            num = RNG.Next(1, 100);
        }

        private void enterGuess_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guess_btn_Click(object sender, EventArgs e)
        {
            guessmade();
        }

        private void enterGuess_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                guessmade();
            }
        }

        private void guessmade()
        {
            tries++;
            lbl1.Text = $"tries: {tries}";
            guess = int.Parse(enterGuess_txt.Text);
            if(guess == num)
            {
                higherOrLower_lbl.Text = "";
                lbl1.Text = $"Congratulations you guessed the number in {tries} tries";
            }
            else if (guess < num)
            {
                higherOrLower_lbl.Text = "too low";
            }
            else
            {
                higherOrLower_lbl.Text = "too high";
            }
        }
    }
}
