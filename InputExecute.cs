using System;
using struct_lab_student;

namespace ExecuteInput
{
    class Input
    {
        public static List<Student> ReadData(string fileName)
        {
            FileStream input;
            List<Student> list = [];
            try
            {
                input = new FileStream(fileName, FileMode.Open);
            }
            catch (IOException e)
            {
                Console.WriteLine("��������� ������� ����: \n" + e.Message);
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
                Console.WriteLine("��������� ��������� ����: \n" + e.Message);
            }

            return list;

        }
    }
}