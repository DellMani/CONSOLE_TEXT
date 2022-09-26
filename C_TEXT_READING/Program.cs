using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TEXT_READING
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Start of Text");
            // Read the file into a string.
            string text = System.IO.File.ReadAllText(@"D:\FSD_Training\Projects\Text_file.txt");

            // To Write the file contents to the console screen.
            System.Console.WriteLine($"{text}", text);

            System.Console.WriteLine("End of Text");
            System.Console.WriteLine();
        }
    }
}
