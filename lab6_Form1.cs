using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //list box is cleared when loaded
            SalesListBox.Items.Clear();
            //Caculate button cannot be seen until the user selects a valid file
            Calculatebutton.Visible = false;
            //the result labels cannot be seen when the form is loaded
            TotalSaleslabel.Visible = false;
            AvgSaleslabel.Visible = false;
            SmallestSalelabel.Visible = false;
            LargestSalelabel.Visible = false;

            //tab order
            setTabOrder();
        }
        //the filepath variable starts as empty to start
        private string filepath = string.Empty;
        
        private void UserFilebutton_Click(object sender, EventArgs e)
        {
            //user selects the file from their local machine
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Please select a file."
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //if the file selected by the user loads right it saves the file path in the variable and displays to the user that it was loaded
                filepath = openFileDialog.FileName;
                //when the file is loaded correctly, the button can be seen by the user
                Calculatebutton.Visible = true;
                MessageBox.Show("File loaded successfully.");
            }
            else
            {
                //if the file was not loaded successfully, it displays that to the user and asks them to try again
                MessageBox.Show("File was not loaded successfully" +
                    "\nPlease try agin");
            }

        }

        //method to get the Total Sales 
        private decimal GetTotalSales(List<decimal> SalesList)
        {
            //Sales start at zero
            decimal Sales = 0;
            foreach (decimal i in SalesList)
            {
                //adds each value from the list to total sales
                Sales += i;
            }
            //returns total amount of sales
            return Sales;
        }
        
        //method to get the average of the sales
        private decimal GetAverageSales(List<decimal> SalesList,decimal total)
        {
            
            //gets length of list
            int ListLen=SalesList.Count;
            //gets the average
            decimal avg=total/ListLen;
            //returns the avgerage
            return avg;

        }

        //method to get the largest sale value
        private decimal GetLargestSale(List<decimal> SalesList)
        {
            //just makes the first value in the list the largest for now
            decimal Largest = SalesList[0];

            //starts the for loop at the second element in the list and loops through each one
            for(int i = 1; i < SalesList.Count; i++)
            {
                //if any element is bigger than any of the previous ones it makes the current
                //loop variable (i) the now largest variable
                if (SalesList[i] > Largest)
                {
                    //reassignment
                    Largest = SalesList[i];
                }
                //if its not, it continue's to the next iteration of the loop
                else
                    continue;
            }
            //then at the end returns the largest value
            return Largest;

        }

        //method to get the smallest sale value 
        private decimal GetSmallestSale(List<decimal> SalesList)
        {
            //just makes the first value in the list the smallest for now
            decimal Smallest = SalesList[0];

            //starts the for loop at the second element in the list and loops through each one
            for (int i = 1; i < SalesList.Count; i++)
            {
                //if any element is smaller than any of the previous ones it makes the current
                //loop variable (i) the now smallest variable
                if (SalesList[i] < Smallest)
                {
                    //reassignment
                    Smallest = SalesList[i];
                }
                //if its not, it continue's to the next iteration of the loop
                else
                    continue;
            }
            //then at the end returns the smallest value
            return Smallest;

        }
        //method to create error log file
        private void WriteToErrorLog(List<string> SaleError)
        {
            //to write errorlog
            StreamWriter output;
            //creates error log file
            output = File.CreateText("ErrorLog.txt");
            //for each elemet in the error list, it is written to ErrorLog.txt file
            for (int i=0; i < SaleError.Count; i++)
            {
                //writes to the file
                output.WriteLine(SaleError[i]);
            }
            //closes the file once it is done
            output.Close();
            //lets the user know the file was created and written to
            MessageBox.Show("Errors found in the sales were"+"\nwritten to the error log file.");
        }

        //exit button
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AvgSaleslabel_Click(object sender, EventArgs e)
        {

        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            //Counter for error count
            int ErrorCount = 0;

            //List to hold valid nums to do calculations
            List<decimal> ValidNums = new List<decimal>();
            //list to hold not valid elements to go into error log
            List<string>NotValidEls=new List<string>();

            //clears the list box so the same elements are not in the list box again and again
            SalesListBox.Items.Clear();

            //another error catcher just in case for the user file
            if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("Please choose a valid file to read from");
                return;
            }
            //reads all lines from valid file
            string[] FileLines=File.ReadAllLines(filepath);

            //loop to add each line to the listbox
            foreach(string i in FileLines)
            {
                //adds each item to the listbpx
                SalesListBox.Items.Add(i);
            }

            foreach (string i in FileLines)
            {
                //trims lines to make them more readable
                string trimlined=i.Trim();
                //if it reaches a white space, it skips over it
                if (string.IsNullOrWhiteSpace(trimlined))
                    continue;
                //if the number(current string type) can be parsed as a decimal it is added to the valid nums list
                if (decimal.TryParse(trimlined,out decimal num))
                {
                    //adds the deicmal
                    ValidNums.Add(num);
                }
                //if it cannot be parsed, it is added to the not valid element list
                else
                {
                    //adds the element
                    NotValidEls.Add(trimlined);
                    //increments the error count by one
                    ErrorCount += 1;
                }
            }
            //calls of the methods to do the calcuations
            decimal TotalSales = GetTotalSales(ValidNums);
            decimal AvgSales=GetAverageSales(ValidNums,TotalSales);
            decimal SmallestSale = GetSmallestSale(ValidNums);
            decimal LargestSale=GetLargestSale(ValidNums);

            //displays the results to the user
            TotalSaleslabel.Visible = true;
            AvgSaleslabel.Visible = true;
            LargestSalelabel.Visible = true;
            SmallestSalelabel.Visible = true;


            TotalSaleslabel.Text = $"Total Sales:${TotalSales}";
            //formats the average to two deciaml places
            AvgSaleslabel.Text = $"Average Sales:${AvgSales:F2}";
            LargestSalelabel.Text=$"Largest Sale:${LargestSale}";
            SmallestSalelabel.Text=$"Smallest Sale:${SmallestSale}";

            //if the error count is larger than 0, it calls the Error Method
            if (ErrorCount > 0)
            {
                WriteToErrorLog(NotValidEls);
            }

        }
        //reset button
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            //resets the value for the file path
            string filepath = string.Empty;
            //resets all of the labels
            TotalSaleslabel.Text = "Total Sales:$0";
            AvgSaleslabel.Text = "Average Sales:$0";
            LargestSalelabel.Text = "Largest Sale:$0";
            SmallestSalelabel.Text = "Smallest Sale:$0";
            //clears the ListBox
            SalesListBox.Items.Clear();
            //user cannot see the calucate button anymore until they submit a valid file
            Calculatebutton.Visible = false;

        }
        //sets tab order
        private void setTabOrder()
        {
            UserFilebutton.TabIndex = 0;
            Calculatebutton.TabIndex = 1;
            SalesListBox.TabIndex = 2;
            Resetbutton.TabIndex = 3;
            Exitbutton.TabIndex = 4;
        }
    }
}
