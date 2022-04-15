using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ToSerializeOrNotToSerialize
{
    class Program
    {
        static List<StudentRecord> records = new List<StudentRecord>();
        static string filename = "students.json";

        static void Main(string[] args)
        {

            LoadDataFromFile();
            while (true)
            {
                Console.WriteLine("1. Create new record\n2. Show Recordsn\n3.Remove Record\n4. Save Records");
                Console.WriteLine("What do you want to do?");
                switch (Console.ReadLine())
                {
                    case "1":
                        CreateRecords();
                        break;
                    case "2":
                        ShowRecord();
                        break;
                    case "4":
                        Save();
                        break;
                    default:
                        Console.WriteLine("Really now?");
                        break;
                }
            }

        }

        public static void LoadDataFromFile()
        {
            //read from the file only if it exist
            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);
                string record = reader.ReadToEnd();

                records = JsonConvert.DeserializeObject<List<StudentRecord>>(record);

            }
        }

        public static void ShowRecord()
        {
            foreach(StudentRecord record in records)
            {
                Console.WriteLine(record);
            }
        }

        public static void Save()
        {
            string record = JsonConvert.SerializeObject(records);
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine(record);
            writer.Close();
        }

        public static void CreateRecords()
        {
            while(true)
            {
                Console.Write("Name:");
                string name = Console.ReadLine();

                Console.Write("Major:");
                string major = Console.ReadLine();

                Console.Write("Year:");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Cumulative GPA:");
                double gpa = double.Parse(Console.ReadLine());

                StudentRecord record = new StudentRecord(name, major, year, gpa);
                records.Add(record);

                Console.Write("Do you want to add another student? ");
                if (char.Parse(Console.ReadLine().ToLower()) == 'n')
                    break;
            }
        }
    }
}
