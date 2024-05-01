using System;
using struct_lab_student;

namespace ExecuteInput
{
    class Input
    {
        public static List<Student> ReadData(string fileName)
        {
            FileStream input=null;
            List<Student> list = [];
            try
            {
                input = new FileStream(fileName, FileMode.Open);
            }
            catch (IOException e)
            {
                Console.WriteLine("Неможливо відкрити файл: \n" + e.Message);
                input.Close();
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
            input.Close();
            return list;

        }
    }
}