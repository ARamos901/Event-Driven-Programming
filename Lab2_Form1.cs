using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramos_Lab2
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GetSum_Click(object sender, EventArgs e)
        {
            
            //gets each of the quantitys fron the Up Down values
            decimal TotalHotDog = HotDogUpDown.Value;
            decimal TotalSoda = SodaUpDown.Value;
            decimal TotalChips=ChipsUpDown.Value;

            //these are to be multiplied by each of the values fron the Up Down Values
            float HotDogMult = 2.00f;
            float SodaMult = 1.50f;
            float ChipsMult = 1.00f;
            float TipMult = 0.18f;
            float TaxtMult = 0.06f;

            //this finds the total amount of the whole order w/o the tax and tip included
            decimal TotalCalculation = (TotalHotDog * (decimal)HotDogMult) + 
                            (TotalSoda * (decimal)SodaMult) + 
                            (TotalChips * (decimal)ChipsMult);

            //these two lines of code finds the total tax,tip and total balance using the total calculation from the order
            decimal TaxCalculation = TotalCalculation * (decimal)TaxtMult;

            decimal TipCalculation = TotalCalculation * (decimal)TipMult;

            decimal Balance = TaxCalculation + TipCalculation + TotalCalculation;

            //displays the results to the user rounded to two decimal places
            TaxTotal.Text = TaxCalculation.ToString("F2");
            TipTotal.Text = TipCalculation.ToString("F2");
            BalanceTotal.Text = Balance.ToString("F2");




        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            //resets the up down controls to 0
            HotDogUpDown.Value = 0;
            SodaUpDown.Value = 0;
            ChipsUpDown.Value = 0;

            //resets totals to empty 
            TaxTotal.Clear();
            TipTotal.Clear();
            BalanceTotal.Clear();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //closes the form upon click
            this.Close();
        }
    }
}
