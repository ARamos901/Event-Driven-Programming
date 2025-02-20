using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramos_lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //when the form loads, all radio boxes are unchecked by default
            LicenseYearlySubbutton.Checked = false;
            LicenseLifetimebutton.Checked = false;

            //when the form loads, all check boxes are unchecked by default
            TechSupportcheckbox.Checked = false;
            CloudcheckBox.Checked = false;
            TrainingcheckBox.Checked = false;
            //when the form loads, the tech support is off from default
            TechSupportcheckbox.Visible = false;
            //
            AdditionalStudentsUpDown.Visible = false;
            AdditionalStudentslabel.Visible = false;

        }

       

      

        private void Form1_Load(object sender, EventArgs e)
        {
            //sets tab order when the form is loaded
            SetTabOrder();
        }

        private void SupportDescriptionbutton_Click(object sender, EventArgs e)
        {
            //this provides the description of the support options when clicked
            MessageBox.Show("Technical Support-Included in the yearly subscription, but it is an additional $2,500 for the lifetime license.\n"
                            + "\nCloud Backup-Additional $300 per year.\n" +
                            "\nOn-Site Training-Additional $2,000 for 5 students, anymore additional students is $200 per student.");
        }

        private void LicenseDescriptionbutton_Click(object sender, EventArgs e)
        {

            //provides the description of differant plans
            MessageBox.Show("Yearly Subscription-$5,000 per year.\n"
                + "\nLifetime License-$20,000 one time fee.\n");
        }

        private void AdditionalStudentsUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TrainingcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //The additionalstudents option only needs to be visble if the user wants the training, so when its not checked its invisble
            AdditionalStudentsUpDown.Visible= TrainingcheckBox.Checked;
            AdditionalStudentslabel.Visible= TrainingcheckBox.Checked;
        }        
        
        private void Exitbutton_Click(object sender, EventArgs e)
        {

            //exit button
            this.Close();
        }

        private void LicenseYearlySubbutton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void LicenseLifetimebutton_CheckedChanged(object sender, EventArgs e)
        {

            //since tech support is included in the yearly plan, it only needs to show when the user selecrs the Lifetime plan
            TechSupportcheckbox.Visible = LicenseLifetimebutton.Checked;
        }

        private void GetTotalbutton_Click(object sender, EventArgs e)
        {
            //values to hold for totals
            int LicenseSum = 0;
            int SupportSum = 0;
            //training multiplier 
            int TrainingMult = 200;
            
            switch (true)
            {
                //depending on which License the user picked, it will switch the amount that will be added to the total
                case bool _ when LicenseYearlySubbutton.Checked:
                    LicenseSum += 5000;
                    break;

                case bool _ when LicenseLifetimebutton.Checked:
                    LicenseSum += 20000;
                    break;

                    //error checking in the case the user does not select a license option
                default:
                    MessageBox.Show("Please select a license option.");
                    return;
            }
            //if the support checkbox is checked and the lifetime plan is checked, it adds 2500 to the total
            //this ensures in the case the user accidently checks the tech support box but the changes their plan to the yearly plan
            if (TechSupportcheckbox.Checked && LicenseLifetimebutton.Checked) SupportSum += 2500;
            
            //if the Cloud Check box is check it adds 300 to the total
            if (CloudcheckBox.Checked) SupportSum += 300;
            
            //if the training check box is checked, it adds 2000
            if (TrainingcheckBox.Checked) SupportSum += 2000;
            

            //error checker if the user puts in a negative number for the amount of students who need additional training
            if (AdditionalStudentsUpDown.Value < 0)
            {
                MessageBox.Show("Please enter a valid number for the amount of additional stunders for training.");
                AdditionalStudentsUpDown.Value = 0;
                AdditionalStudentsUpDown.Focus();
               
            }
            //converts the UpDown value for additional training,converts it to an int and puts it in another variable
            int AdditionalStudentTraining = (int)AdditionalStudentsUpDown.Value;
            //then it takes the value holding the int UpDown and multiplys it by the training mult (200) and then adds it all together in the support sum
            SupportSum += AdditionalStudentTraining*TrainingMult;

            LicenseCostlabel.Text = $"Total License Cost:{LicenseSum}";
            SupportCostlabel.Text = $"Total Support Options Cost:{SupportSum}";
            int totalCost = LicenseSum + SupportSum;
            TotalCostlabel.Text = $"The total cost:{totalCost}";

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LicenseYearlySubbutton.Checked = false;
            LicenseLifetimebutton.Checked = false;

            TechSupportcheckbox.Checked = false;
            CloudcheckBox.Checked = false;
            TrainingcheckBox.Checked = false;

            

            AdditionalStudentsUpDown.Value = 0;

            LicenseCostlabel.Text = "Total License Cost: 0";
            SupportCostlabel.Text = "Total Support Options Cost: 0";
            TotalCostlabel.Text = $"The total cost:0:";
        }
        private void SetTabOrder()

        {
            //sets the tab order of the buttons

            //radio buttons
            LicenseYearlySubbutton.TabIndex = 0;
            LicenseLifetimebutton.TabIndex = 1;
            //check boxes
            TechSupportcheckbox.TabIndex = 2;
            CloudcheckBox.TabIndex = 3;
            TrainingcheckBox.TabIndex = 4;
            //get total button
            GetTotalbutton.TabIndex = 5;
            //description buttons
            LicenseDescriptionbutton.TabIndex = 6;
            SupportDescriptionbutton.TabIndex = 7;
            //reset and exit buttons
            ResetButton.TabIndex = 8;
            Exitbutton.TabIndex = 9;
        }

    }
}
