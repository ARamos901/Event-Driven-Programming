using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Tag for each Card to display which card it is
            pictureBox1.Tag = "6 of Diamonds";
            pictureBox2.Tag = "King of Spades";
            pictureBox3.Tag = "Ace of Diamonds";
            pictureBox4.Tag = "Queen of Hearts";
            pictureBox5.Tag = "6 of Hearts";


            //upon being clicked, it is sent to the Card_Display function to be displayed to the user
            pictureBox1.Click += Card_Display;
            pictureBox2.Click += Card_Display;
            pictureBox3.Click += Card_Display;
            pictureBox4.Click += Card_Display;
            pictureBox5.Click += Card_Display;



        }
        private void CardPictureBox()
        {

        }

        //function to display the card info to the user
        private void Card_Display(object sender, EventArgs e)
        {
            //info for card
            PictureBox clicked=(PictureBox)sender;

           CardDisplay.Text = clicked.Tag.ToString();
        }

        private void Exit_Button_Clicked(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }
    }
}
