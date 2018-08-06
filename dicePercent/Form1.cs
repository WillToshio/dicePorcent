using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicePercent
{
    public partial class Form1 : Form
    {
        private int ones = 0, twos = 0, threes = 0, fours = 0, fives = 0, sixes = 0;

        private void rollDice_Click(object sender, EventArgs e)
        {
            DisplayDie(diePic1);
            DisplayDie(diePic2);
            DisplayDie(diePic3);
            DisplayDie(diePic4);
            DisplayDie(diePic5);
            DisplayDie(diePic6);
            DisplayDie(diePic7);
            DisplayDie(diePic8);
            DisplayDie(diePic9);
            DisplayDie(diePic10);
            DisplayDie(diePic11);
            DisplayDie(diePic12);

            double total = ones + twos + threes + fours + fives + sixes;

            displayTextBox.Text = "Face\t\tFrequencia\tPorcentagem" + Environment.NewLine + 
                "1\t\t" + ones + "\t\t" +
                String.Format("{0:F2}", ones / total * 100) +
                "%" + Environment.NewLine + "2\t\t" + twos + "\t\t" +
                String.Format("{0:F2}", twos / total * 100) +
                "%" + Environment.NewLine + "3\t\t" + threes + "\t\t" +
                String.Format("{0:F2}", threes / total * 100) +
                "%" + Environment.NewLine + "4\t\t" + fours + "\t\t" +
                String.Format("{0:F2}", fours / total * 100) +
                "%" + Environment.NewLine + "5\t\t" + fives + "\t\t" +
                String.Format("{0:F2}", fives / total * 100) +
                "%" + Environment.NewLine + "6\t\t" + sixes + "\t\t" +
                String.Format("{0:F2}", sixes / total * 100) + "%";
        }

        private Random randomNumber = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayDie( PictureBox diePic)
        {
            int face = randomNumber.Next(1, 7);
            switch (face)
            {
                case 1:
                    diePic.Image = Properties.Resources.die1;
                    ones++;
                    break;
                case 2:
                    diePic.Image = Properties.Resources.die2;
                    twos++;
                    break;
                case 3:
                    diePic.Image = Properties.Resources.die3;
                    threes++;
                    break;
                case 4:
                    diePic.Image = Properties.Resources.die4;
                    fours++;
                    break;
                case 5:
                    diePic.Image = Properties.Resources.die5;
                    fives++;
                    break;
                case 6:
                    diePic.Image = Properties.Resources.die6;
                    sixes++;
                    break;
            }
        }
    }
}
