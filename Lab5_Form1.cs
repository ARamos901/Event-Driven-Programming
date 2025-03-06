using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //when the form is loaded, you cannot see the total cost label
            TotalCostlabel.Visible = false;
            //sets the tab order
            SetTabOrder();
        }
        

        //Calucation for amount of days spent
        private decimal DaysSpentCaluc(decimal num1)
        {
            //multiples the amount of days spent by 350
            return num1 * 350;
        }

        //function to check to make sure the text boxes contain numbers
        private bool CheckTextBoxes_Nums(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                //variable just to hold the parsed values, does not have any use
                decimal random;

                //loops through all of the textbox parameters and if a textbox does not contain a number
                //it displays a message box telling the user to enter  a number
                //it then clears the textbox, focuses on it for the user to enter another input in it
                //and returns false
                if(!decimal.TryParse(textBox.Text, out random))
                {
                    MessageBox.Show("Please enter an number in the textbox.");
                    //clears and focues on the textbox that does not have a number
                    textBox.Clear();
                    textBox.Focus();
                    //returns false in the function
                    return false;


                }
            }
            //if it gets out of the loop, all of the textboxes are numbers
            return true;
        }

        //simalar logic to the above method,but instead of just checking if it can be parsed as a number
        //but this one checks to make sure it is postive
        private bool CheckTextBoxes_Postive(params TextBox[] textBoxes)
        {
            //loops through each text box
            foreach (TextBox textBox in textBoxes)
            {
                //tries to parse the text from the text box and its out variable is Num
                //then it checks to make sure the Num variables is postive
                if (!decimal.TryParse(textBox.Text, out decimal Num) || Num <= 0)
                {
                    MessageBox.Show("Please enter a postive number in the text box.");
                    //clears and focues on the textbox that does not have a postive number
                    textBox.Clear();
                    textBox.Focus();

                    return false;
                    
                }
            }
            return true; 
        }

        private bool CheckDaysStayed(decimal num)
        {
            if (num == 0)
            {
                MessageBox.Show("Please enter a valid number of\n" + "days stayed at the hospital");
                return false;
            }
            return true;
        }


        //button to calucation to find total
        private void CalucTotalbutton_Click(object sender, EventArgs e)
        {
            //makes sure the user inputs the number of days stayed at the hospital
            if (CheckDaysStayed(DaysSpentUpDown.Value))
            {
                

                //calls the function to make sure the inputs are numbers
                if (CheckTextBoxes_Nums(MedicationChargestextBox, SurgicalChargestextBox, LabFeestextBox, RehabChargestextBox))
                {
                    //calls the function to make sure the inputs are postive numbers
                    if (CheckTextBoxes_Postive(MedicationChargestextBox, SurgicalChargestextBox, LabFeestextBox, RehabChargestextBox))
                    {
                        //holds Days Charges method in variable to use to do calucation
                        decimal DaysSpentValue = DaysSpentCaluc(DaysSpentUpDown.Value);

                        //parses all of the text boxes values into ints variables to do calucation
                        decimal MedicationChargeValue = decimal.Parse(MedicationChargestextBox.Text);
                        decimal SurgicalChargesValue = decimal.Parse(SurgicalChargestextBox.Text);
                        decimal LabFeesValue = decimal.Parse(LabFeestextBox.Text);
                        decimal RehabChargesValues = decimal.Parse(RehabChargestextBox.Text);
                        //adds up all of the values to a temp variable to be formatted
                        decimal TempTotalAmount = DaysSpentValue + MedicationChargeValue + SurgicalChargesValue + LabFeesValue + RehabChargesValues;
                        //the TotalCost label becomes visble and the user can see the total
                        string TotalAmount = TempTotalAmount.ToString("#,0.00");
                        TotalCostlabel.Visible = true;
                        TotalCostlabel.Text = $"The total amount for the stay at the hosptial is:${TotalAmount}";



                    }
                }
            }
        }
        //sets tab order
        private void SetTabOrder()
        {
            //Up Down Tool
            DaysSpentUpDown.TabIndex = 0;
            //text boxes
            MedicationChargestextBox.TabIndex = 1;
            SurgicalChargestextBox.TabIndex = 2;
            LabFeestextBox.TabIndex= 3;
            RehabChargestextBox.TabIndex = 4;
            //buttons
            CalucTotalbutton.TabIndex = 5;
            Resetbutton.TabIndex = 6;
            Exitbutton.TabIndex = 7;
        }

    

        //exit button
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //reset button
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            //clears all of the text boxes
            MedicationChargestextBox.Clear();
            SurgicalChargestextBox.Clear();
            LabFeestextBox.Clear();
            RehabChargestextBox.Clear();
            //resets the TotalCost label to 0
            TotalCostlabel.Text = "The total amount for the stay at the hosptial is:$0";
            //resets UpDown Values
            DaysSpentUpDown.Value = 0;
        }
    }
}
