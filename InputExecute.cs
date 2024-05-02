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
                Console.WriteLine("Неможливо відкрити файл: \n" + e.Message);
                input.Close();
                return list;
            }
            StreamReader sReader = new StreamReader(input);
            try
            {
                while (!sReader.EndOfStream)
                {
                    string s = null;
                    try
                    {
                        s = sReader.ReadLine();
                        Student student = new Student(s);
                        Zodiac.WhatZodiac(student);
                        list.Add(student);
                    }
                    catch(Exception e) { Console.WriteLine($"Ми не змогли прочитать дані про студента з рядка {s}"); }
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