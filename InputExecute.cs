using System;
using struct_lab_student;
using Zodiacs;

namespace ExecuteInput
{
    class Input
    {
        public static List<Student> ReadData(string fileName)
        {
            FileStream input=null;
            List<Student> list = new List<Student>();
            try
            {
                input = new FileStream(fileName, FileMode.Open);
            }
            catch (IOException e)
            {
                Console.WriteLine("��������� ������� ����: \n" + e.Message);
                input.Close();
                return list;
            }
            StreamReader sReader = new StreamReader(input);
            try
            {
                while (!sReader.EndOfStream)
                {
                    Student student = new Student(sReader.ReadLine());
                    Zodiac.WhatZodiac(student);
                    list.Add(student);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("��������� ��������� ����: \n" + e.Message);
            }
            input.Close();
            return list;

        }
    }
}