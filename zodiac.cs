using struct_lab_student;
using System;
using System.Globalization;
namespace Zodiacs
{
    class Zodiac
    {
        public static void WhatZodiac(Student student)
        {
            string data = $"{student.surName} {student.firstName} {student.patronymic} {student.sex} {student.dateOfBirth} {student.mathematicsMark} {student.physicsMark} {student.informaticsMark} {student.scholarship}";
            FileStream creator = null;
            DateTime date = Convert.ToDateTime(student.dateOfBirth);
            switch (date.Month)
            {
                case 1:
                    if (date.Day <= 20) creator = new FileStream("data_Capricorn.txt", FileMode.Append);
                    else creator = new FileStream("data_Aquarius.txt", FileMode.Append);
                    break;
                case 2:
                    if (date.Day <= 19) creator = new FileStream("data_Aquarius.txt", FileMode.Append);
                    else creator = new FileStream("data_Pisces.txt", FileMode.Append);
                    break;
                case 3:
                    if (date.Day <= 20) creator = new FileStream("data_Pisces.txt", FileMode.Append);
                    else creator = new FileStream("data_Aries.txt", FileMode.Append);
                    break;
                case 4:
                    if (date.Day <= 20) creator = new FileStream("data_Aries.txt", FileMode.Append);
                    else creator = new FileStream("data_Taurus.txt", FileMode.Append);
                    break;
                case 5:
                    if (date.Day <= 21) creator = new FileStream("data_Taurus.txt", FileMode.Append);
                    else creator = new FileStream("data_Gemini.txt", FileMode.Append);
                    break;
                case 6:
                    if (date.Day <= 22) creator = new FileStream("data_Gemini.txt", FileMode.Append);
                    else creator = new FileStream("data_Cancer.txt", FileMode.Append);
                    break;
                case 7:
                    if (date.Day <= 22) creator = new FileStream("data_Cancer.txt", FileMode.Append);
                    else creator = new FileStream("data_Leo.txt", FileMode.Append);
                    break;
                case 8:
                    if (date.Day <= 23) creator = new FileStream("data_Leo.txt", FileMode.Append);
                    else creator = new FileStream("data_Virgo.txt", FileMode.Append);
                    break;
                case 9:
                    if (date.Day <= 23) creator = new FileStream("data_Virgo.txt", FileMode.Append);
                    else creator = new FileStream("data_Libra.txt", FileMode.Append);
                    break;
                case 10:
                    if (date.Day <= 23) creator = new FileStream("data_Libra.txt", FileMode.Append);
                    else creator = new FileStream("data_Scorpio.txt", FileMode.Append);
                    break;
                case 11:
                    if (date.Day <= 22) creator = new FileStream("data_Scorpio.txt", FileMode.Append);
                    else creator = new FileStream("data_Sagittarius.txt", FileMode.Append);
                    break;
                case 12:
                    if (date.Day <= 21) creator = new FileStream("data_Sagittarius.txt", FileMode.Append);
                    else creator = new FileStream("data_Capricorn.txt", FileMode.Append);
                    break;
            }
            StreamWriter writer = new StreamWriter(creator);
            writer.WriteLine(data);
            writer.Flush();
            creator.Close();
        }
    }
}