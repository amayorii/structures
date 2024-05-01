using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;

namespace struct_lab_student
{
    partial class Program
    {
        static List<Student> ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill data inside array of Student
            List <Student> list = new();
            FileStream input;
            try
            {
                input = new FileStream(fileName, FileMode.Open);
            }
            catch (IOException e)
            {
                Console.WriteLine("Неможливо відкрити файл: \n" + e.Message);
                return list;
            }
            StreamReader strReader = new(input);
            try
            {
                while (!strReader.EndOfStream)
                {
                    list.Add(new Student(strReader.ReadLine()));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Неможливо прочитати файл: \n" + e.Message);
            }
            return list;
        }
        static void Block2_22(List<Student>list)
        {
            DateTime localDate = DateTime.Now.Date;
            for(int i = 0; i < list.Count; i++)
            {
                DateTime birth = DateTime.ParseExact(list[i].dateOfBirth, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                int diffOfYears = (localDate.Year- birth.Year);
                if (localDate.Month <= birth.Month && localDate.Day < birth.Day) diffOfYears--;
                if (diffOfYears < 18 && (list[i].mathematicsMark=='2'|| list[i].mathematicsMark == '-'|| list[i].physicsMark == '2'|| list[i].physicsMark == '-'|| list[i].informaticsMark == '2' || list[i].informaticsMark == '2'))
                {
                    Console.WriteLine($"Surname: {list[i].surName}");
                    Console.WriteLine($"Name: {list[i].firstName}");
                    Console.WriteLine($"Date of Birth: {list[i].dateOfBirth}");
                    Console.WriteLine();
                }
            }
            
        }
        static void RunMenu(List<Student> studs)
        {
            Block2_22(studs);
        }

        static void Main(string[] args)
        {
            List<Student> studs = ReadData("input.txt");
            RunMenu(studs);
        }
    }
}
