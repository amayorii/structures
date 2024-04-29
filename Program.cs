using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace struct_lab_student
{
    public class Program
    {
        static List<Student> ReadData(string fileName)
        {
            FileStream input;
            List<Student> list = [];
            try
            {
                input = new FileStream(fileName, FileMode.Open);
            }
            catch (IOException e)
            {
                Console.WriteLine("Неможливо відкрити файл: \n" + e.Message);
                return list;
            }
            StreamReader sReader = new(input);
            try
            {
                while (!sReader.EndOfStream)
                {
                    list.Add(new Student(sReader.ReadLine()));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Неможливо прочитати файл: \n" + e.Message);
            }
            return list;
            
        }

        static void Var8(List<Student> studs)
        {
            for(int i = 0; i < studs.Count; i++)
            {
                if (    studs[i].physicsMark == '2' || studs[i].physicsMark == '-' || 
                    studs[i].mathematicsMark == '2' || studs[i].mathematicsMark == '-' || 
                    studs[i].informaticsMark == '2' || studs[i].informaticsMark == '-')
                {
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine("Surname: " + studs[i].surName);
                    Console.WriteLine($"Mathematics mark: {studs[i].mathematicsMark}, Physics mark: {studs[i].physicsMark}, Informatics mark: {studs[i].informaticsMark}.");
                }
                
            }
        }
        static void RunMenu(List<Student> studs)
        {
            Var8(studs);
        }

        static void Main(string[] args)
        {
            List<Student> studs = ReadData("input.txt");
            RunMenu(studs);
        }
    }
}
