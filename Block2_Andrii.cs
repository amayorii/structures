using System;
using System.Collections.Generic;
using struct_lab_student;

namespace Block2Andrii
{
	class Block2
	{
		public static void Do(List<Student> students)
		{
			DisplayParticularStudents(students);
		}

		static bool WithinRange(string birthdayDate)
		{
			DateTime today = DateTime.Today;
			DateTime startDate = today.AddDays(-14);
			DateTime endDate = today.AddDays(7);
			DateTime birthdayDateParsed = ParseDate(birthdayDate);

			DateTime birthdayThisYear = new DateTime(today.Year, birthdayDateParsed.Month, birthdayDateParsed.Day);

			if (!DateTime.IsLeapYear(today.Year) && birthdayDateParsed.Month == 2 && birthdayDateParsed.Day == 29)
			{
				birthdayThisYear = new DateTime(today.Year, 2, 28);
			}

			return (birthdayThisYear >= startDate && birthdayThisYear <= endDate);
		}

		static void DisplayParticularStudents(List<Student> students)
		{
			foreach (var student in students)
			{
				if (WithinRange(student.dateOfBirth))
				{
					DisplayDataStudent(student);
				}
			}
		}

		static void DisplayDataStudent(Student student)
		{
			Console.WriteLine("----------------------------------------------------------------------");
			Console.WriteLine($"{student.surName} {student.firstName}");
			Console.WriteLine($"Mathematics mark: {student.mathematicsMark}, Physics mark: {student.physicsMark}, Informatics mark: {student.informaticsMark}.");
		}

		static DateTime ParseDate(string date)
		{
			string[] parts = date.Split('.');
			
			int day = int.Parse(parts[0]);
			int month = int.Parse(parts[1]);
			int year = int.Parse(parts[2]);

			return new DateTime(year, month, day);
		}
	}
}
