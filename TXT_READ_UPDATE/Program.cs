using System;
using System.Data;
using System.IO;


namespace TXT_READ_UPDATE
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Start of Text");
            string[] lines = File.ReadAllLines(@"D:\FSD_Training\Projects\Teacher_Table.txt");
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("ID"), new DataColumn("Name"), new DataColumn("Class"), new DataColumn("Section") });
            for (int i = 0; i < lines.Length; i++)
            {
                dt.Rows.Add(lines[i].ToString().Split(','));
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tN - New Record");
            Console.WriteLine("\tU - Update");
            Console.WriteLine("\tS - Search");
            Console.Write("Your option? ");
            Char selection = Convert.ToChar(Console.ReadLine());
            if (selection == 'N')
            {
                Console.WriteLine("\r\n");
                Console.WriteLine("Input Teacher ID");
                String ID = Console.ReadLine();
                Console.WriteLine("Input Teacher Name");
                String Name = Console.ReadLine();
                Console.WriteLine("Input Teacher Class");
                String Class = Console.ReadLine();
                Console.WriteLine("Input Teacher Section");
                String Section = Console.ReadLine();
                String Data = ID + "," + Name + "," + Class + "," + Section + "\r\n";
                System.IO.File.AppendAllText(@"D:\FSD_Training\Projects\Teacher_Table.txt", Data);
                Console.WriteLine("New Record Successfully Added");
                var Exit = Console.ReadLine();
            }
            else if (selection == 'U')
            {
                Console.WriteLine("Input ID to Update");
                foreach (DataRow S in dt.Rows)
                {
                    Console.WriteLine("ID = {0}, Name = {0}, Class = {1}, Section = {1}", S[0], S[1], S[2], S[3]);

                }
                String ID = Console.ReadLine();
           
                foreach (DataRow o in dt.Select("ID = '" + ID + "'"))
                {
              
                    String NewData = "" + o["ID"] + "," + o["Name"] + "," + o["Class"] + "," + o["Section"];
                    Console.WriteLine("\t" + o["ID"] + "\t" + o["Name"] + "\t" + o["Class"] + "\t" + o["Section"]);
                    Console.WriteLine("Input Teacher Class");
                    String Class = Console.ReadLine();
                    Console.WriteLine("Input Teacher Section");
                    String Section = Console.ReadLine();
                    String NewDatam = "" + o["ID"] + "," + o["Name"] + "," + Class + "," + Section;
                    string text = File.ReadAllText(@"D:\FSD_Training\Projects\Teacher_Table.txt");
                    text = text.Replace(NewData, NewDatam);
                    File.WriteAllText(@"D:\FSD_Training\Projects\Teacher_Table.txt", text);
                    Console.WriteLine("Record has been Updated Successfully");
                    var Exit = Console.ReadLine();

                }
                System.Console.WriteLine("End of Text");
                Console.WriteLine("Press enter to Exit");
            }
            else if (selection == 'S')
            {
                Console.WriteLine("Input Name of teacher");
                var expression = Console.ReadLine();
                foreach (DataRow o in dt.Select("Name = '" + expression + "'"))
                {
                    Console.WriteLine("\t" + o["ID"] + "\t" + o["Name"] + "\t" + o["Class"] + "\t" + o["Section"]);
                }
                System.Console.WriteLine("End of Text");
                Console.WriteLine("Press enter to Exit");
                var Exit = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Choose from the given option");
                var Exit = Console.ReadLine();
            }
            

        }
    }
}
