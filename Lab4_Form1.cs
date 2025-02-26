using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            //both list boxes are cleared when the form is loaded to make sure there are no items in it
            Not_NumslistBox.Items.Clear();
            NumslistBox.Items.Clear();
            
            //the write file is invisble at first when the form is loaded
            WriteFileButton.Visible = false;
            

        }
    //the filepath variable starts as empty to start
    private string filepath = string.Empty;
    //pointer to use for output file
    private decimal TotalNums = 0;

    //user clicks the button to select a file to read from
    private void UserInputButton_Click(object sender, EventArgs e)
        {
            //user selects the file from their local machine
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Please select a file."


            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //if the file selected by the user loads right it saves the file path in the variable and displays to the user that it was loaded
                filepath= openFileDialog.FileName;
                MessageBox.Show("File loaded successfully.");
            }
            else
            {
                //if the file was not loaded successfully, it displays that to the user and asks them to try again
                MessageBox.Show("File was not loaded successfully" +
                    "\nPlease try agin");
            }





        }

        private void ReadFilebutton_Click(object sender, EventArgs e)
        {
            //clears the listboxes every time the button is pressed so they are not filled with the same elements over and over again
            NumslistBox.Items.Clear();
            Not_NumslistBox.Items.Clear();

            //variable to display total sum of numbers
            decimal NumsTotal = 0;

            if (string.IsNullOrEmpty(filepath))
            {
                //if the user did not choose a file or a correct one, it will prompt them to choose one first
                MessageBox.Show("Please choose a file to read from.");
                return;
            }
            //gets all lines form the file to read from
            string[] lines = File.ReadAllLines(filepath);

            foreach(string line in lines)
            {
                //trims the lines to make it more readable
                string trimline=line.Trim();

                //if it reaches white space, it skips over it
                if (string.IsNullOrWhiteSpace(trimline))
                    continue;

                //it reads through and if it finds a number in a line, it parses it and makes its "out" varible number and then
                //number is added to the NumsListBox 
                if (decimal.TryParse(trimline, out decimal number))
                {
                    //adds number to the listbox
                    NumslistBox.Items.Add(number);
                    //adds each number to the total
                    NumsTotal += number;

                }
                else
                {
                    //any other element that is found is added to the non-nums listbox
                    Not_NumslistBox.Items.Add(trimline);

                }
                //pointer to use to write to outputfile
                TotalNums = NumsTotal;
                //displays the sum of the nums to the user
                TotalNumslabel.Text = $"Total of the numbers:{NumsTotal}";
                //after the read file button is pressed, the write file button becomes visble
                WriteFileButton.Visible = true;
            }

        }

        //exit button to close form
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WriteFileButton_Click(object sender, EventArgs e)
        {
            //uses streamwriter for output
            StreamWriter output;
            //makes the output go to the users Desktop just to make it easy to find
            output = File.CreateText("output.txt");

            //i starts at the last element count and goes down each element backwards to go to the start
            for (int i = NumslistBox.Items.Count - 1; i >= 0; i--)
            {
                //writes the current element of i to the output.txt file
                output.WriteLine(NumslistBox.Items[i].ToString());
            }
            //writes the total nums to the output file
            output.WriteLine($"The running sum of the numbers is {TotalNums}");

            //closes the file after the for loop is over
            output.Close();
            //lets the user know the file is done being written to
            MessageBox.Show("File is done being written to.");


        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

            //resets listboxes to be empty
            NumslistBox.Items.Clear();
            Not_NumslistBox.Items.Clear();
            //resets the label so the total is zero
            TotalNumslabel.Text = $"Total of the numbers:0";
            //makes the write file button invisable again
            WriteFileButton.Visible = false;
            //makes the filepath variable empty again
            filepath = string.Empty;


    }
    }
}
