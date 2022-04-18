using System;
using System.IO;
using System.Collections.Generic;

namespace SimpleCSV
{
    class Program
    {
        static string filename = "info.txt";
        static List<Record> records = new List<Record>();

        public static void LoadData()
        {
            if(File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);

                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] info = record.Split(",");
                    records.Add(new Record(info[0], int.Parse(info[1]), int.Parse(info[2])));
                    Console.WriteLine($"processed: {record}");
                }

                reader.Close();
            }else
            {
                Console.WriteLine($"Unable to locate file {filename}");
            }

        }
        static void Main(string[] args)
        {
            LoadData();
            while(true)
            {
                Console.WriteLine("Menu\n1.Write data\n2.Show record\n3. Delete record");
                switch (Console.ReadLine())
                {
                    case "1":
                        StreamWriter writer = new StreamWriter(filename);
                        while (true)
                        {
                            Console.WriteLine("Enter data(separate by ,)");
                            string input = Console.ReadLine();
                            if (string.IsNullOrEmpty(input))
                                break;

                            writer.WriteLine(input);
                        }

                        writer.Close();
                        break;
                    case "2":
                        foreach (Record record in records)
                        {
                            Console.WriteLine(record.ToString());
                        }
                        break;
                    case "3":
                        Console.Write("Who do you want to remove(Name:)");
                        string name = Console.ReadLine();

                        StreamWriter writer2 = new StreamWriter(filename);
                        foreach(Record record in records)
                        {
                            if (record.Name != name)
                                writer2.WriteLine($"{record.Name},{record.Year},{record.Fails}");
                        }
                        
                        writer2.Close();
                        LoadData();
                        break;
                    default:
                        Console.WriteLine("I got no words....");
                        break;
                }
            }

    
        }
    }
}
