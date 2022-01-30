using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Functionalities
{
    public class CSV_Handler
    {
        public void TransferToCSV(string address)
        {
            string path = $@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\HW1\HomeWork-Store\CSV\{address}.csv";

            // Set the variable "delimiter" to ", ".
            string comma = ", ";

            //// This text is added only once to the file.
            //if (!File.Exists(path))
            //{
            //    // Create a file to write to.
            //    string createText = "Column 1 Name" + comma + "Column 2 Name" + comma + "Column 3 Name" + comma + Environment.NewLine;
            //    File.WriteAllText(path, createText);
            //}

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is text for Column 1" + comma + "This is text for Column 2" + comma + "This is text for Column 3" + comma + Environment.NewLine;
            File.AppendAllText(path, appendText);
        }
        public void TransferFromCSV(string address)
        {
            string path = $@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\HW1\HomeWork-Store\CSV\{address}.csv";
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}