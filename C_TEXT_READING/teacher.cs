using System;
using System.Data;
using System.IO;

namespace C_TEXT_READING
{
    class teacher
    {
        static void Main1(string[] args)
        {
            System.Console.WriteLine("Start of Text");
            string[] lines = File.ReadAllLines(@"D:\FSD_Training\Projects\Teacher_Table.txt");
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Name"), new DataColumn("Class") });
            for (int i = 0; i < lines.Length; i++)
            {
                dt.Rows.Add(lines[i].ToString().Split(','));
            }

            Console.WriteLine("\r\n");
            Console.WriteLine("Input Teacher ID");
            String ID = Console.ReadLine();
            Console.WriteLine("Input Teacher Name");
            String Name = Console.ReadLine();
            Console.WriteLine("Input Teacher Class");
            String Class = Console.ReadLine();
            Console.WriteLine("Input Teacher Section");
            String Section = Console.ReadLine();
            String[] Data = { ID, Name, Class, Section };
            System.IO.File.AppendAllLines(@"D:\FSD_Training\Projects\Teacher_Table.txt", Data);
            System.Console.WriteLine("End of Text");
            Console.WriteLine("Press enter to Exit");
            
        }

    }
}

