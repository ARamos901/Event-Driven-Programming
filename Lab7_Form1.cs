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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //makes sure the file path is valid before checking names and ssn's
            if (CheckFilePath())
            {
               
                ValidNamesAndSSN();
            }

        }
        //lisst to display to user when select name chnages
        List<string> ssnList = new List<string>();  // list for ssns
        List<string> nameList = new List<string>();  // list for names

        //gets the filepath for the user
        string filepath = @"E:\Event-Driven Programming\Lab7\Personnel.txt";
        //makes this false at first
        bool ErrorLogExists = false;
        void WriteErrorFile(string Log)
        {
            StreamWriter output;
            if (!ErrorLogExists)
            {

                //creates error log
                output = File.CreateText("ErrorLog.txt");
                //writes error message to the ErrorLog
                output.WriteLine(Log);
                //closes the file
                output.Close();
                //makes the flag true now
                ErrorLogExists = true;
            }
            else
            {
                //opens the log file
                output = new StreamWriter("ErrorLog.txt", true);
                //writes the error message as a new line
                output.WriteLine(Log);
                //closes the file
                output.Close();

            }


        }
        bool CheckFilePath()
        {

            if (!File.Exists(filepath))
            {
                //if the Personal.txt file cannot be found it cannot be opened
                //so the error message is wrriten to the errorlog file
                WriteErrorFile("Unable to open Personal.txt file.");
                MessageBox.Show("Unable to open Personal.txt file.\nPlease check the personal.txt file");
                return false;

            }
            return true;
        }

        bool ValidSSN(string num)
        {
            //if the current ssn number is a 9 numbers it is a valid number
            if (num.Length == 9 && int.TryParse(num, out _))
            {
                //returns true if it is valid
                return true;
            }
            else
            {
                //otherwise returns false
                return false;
            }
        }
       
        bool CheckName(string name)
        {
            //checks to see if each charcter in the name is a charcter
            foreach (char i in name)
            {
                //if it is not it returns false
                if (!char.IsLetter(i))
                {
                    return false;
                }

            }
            //if it gets here then all charcters are a letter
            return true;
        }

        void ValidNamesAndSSN()
        {
            //reads all lines from valid file
            string[] FileLines = File.ReadAllLines(filepath);
            //starts looping through each line
            foreach (string Lines in FileLines)
            {
                // splits each line up based off a comma
                string[] line = Lines.Split(',');

                if (line.Length == 3)
                {
                    //takes ssn out
                    string ssn=line[0].Trim();
                    //takes the first name out
                    string first = line[1].Trim();
                    //takes out last name
                    string last = line[2].Trim();



                    // Check if SSN is valid
                    if (!ValidSSN(ssn))
                    {
                        // writes to errorlog if ssn is invalid and skips line
                        WriteErrorFile($"Invalid SSN Number: {ssn}");
                        continue;
                    }


                    //checks to see if they are empty or valid
                    if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(last))
                    {
                        // write to error file
                        WriteErrorFile("Missing first or last name.");
                        continue;  // skips line 
                    }



                    //validates the first and last names amd skips the line if they are not
                    if (!CheckName(first))
                    {
                        WriteErrorFile($"Invalid first name:{first}");
                        continue;
                    }

                    if (!CheckName(last))
                    {
                        WriteErrorFile($"Invalid last name:{last}");
                        continue;
                    }
                    
                    //if the code gets here, all inputs are valid
                   
                        //make sure the names are capitazed
                        string FirstName=Caps(first);
                        string LastName=Caps(last);

                        string Name =$"{LastName} {FirstName}";

                        ssnList.Add(ssn);
                        nameList.Add(Name);


                        Names_listbox.Items.Add(Name);


                }
                else
                {
                    //if there is not enough names it writes to the error log file
                    WriteErrorFile("Invalid names");
                }
            }
            //method to capitaze names
            string Caps(string name)
            {
                return char.ToUpper(name[0])+name.Substring(1).ToLower();
            }

        }

        
        //method to change the label when the user changes selection of list box
        private void Names_listbox_SelectedValueChanged(object sender, EventArgs e)
        {
            //gets the users current selected index
            int CurName=Names_listbox.SelectedIndex;

            if (CurName >=0 && CurName < ssnList.Count)
            {
                //gets the names ssn by crossrefercing it to the ssn list
                string TempSSN=ssnList[CurName];
                //formats the ssn number to have the hypens
                string CurSSN= $"{TempSSN.Substring(0, 3)}-{TempSSN.Substring(3, 2)}-{TempSSN.Substring(5, 4)}";
                //displays result to user
                ssndiplay_label.Text = $"SSN:{CurSSN}";
            }
        }
        //exit button
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            //if the errorlog was made, it was written to so a messagebox was displayed
            if (ErrorLogExists)
            {
                MessageBox.Show("Errors were written to the\nerror log in the bin.");
            }
            this.Close();
        }
    }
}
