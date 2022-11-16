using System;
using System.Data;
using System.IO;


namespace C_TEXT_READING
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name;
            String Class1;
            System.Console.WriteLine("Start of Text");
            string[] lines = File.ReadAllLines(@"D:\FSD_Training\Projects\Text_file.txt");
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Name"), new DataColumn("Class")});
            for (int i = 0; i < lines.Length; i++)
            {
                dt.Rows.Add(lines[i].ToString().Split(','));
            } 
            Console.WriteLine("Sorting Based On Name");
            DataView dv = dt.DefaultView;
            dv.Sort = "Name desc";
            foreach (DataRow S in dt.Rows)
            {
                Console.WriteLine("Name = {0}, Class = {1}", S[0], S[1]);
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Input your name");
            var expression = Console.ReadLine();
            foreach (DataRow o in dt.Select("Name = '" + expression + "'"))
            {
                Console.WriteLine("\t" +  o["Name"] + "\t" + o["Class"] );
            }
            System.Console.WriteLine("End of Text");
            Console.WriteLine("Press enter to Exit");
            var Exit = Console.ReadLine();
        }



    }
}
