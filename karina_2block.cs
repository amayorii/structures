using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;
using struct_lab_student;

namespace Karina2Block
{
    partial class Block2_Karina
    {
       public static void Block2_22(List<Student>list)
        {
            DateTime localDate = DateTime.Now.Date;
            for(int i = 0; i < list.Count; i++)
            {
                DateTime birth = DateTime.ParseExact(list[i].dateOfBirth, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                int diffOfYears = (localDate.Year- birth.Year);
                if (localDate.Month <= birth.Month && localDate.Day < birth.Day) diffOfYears--;
                if (diffOfYears < 18 && (list[i].mathematicsMark=='2'|| list[i].mathematicsMark == '-'|| list[i].physicsMark == '2'|| list[i].physicsMark == '-'|| list[i].informaticsMark == '2' || list[i].informaticsMark == '2'))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Surname: {list[i].surName}");
                    Console.WriteLine($"Name: {list[i].firstName}");
                    Console.WriteLine($"Date of Birth: {list[i].dateOfBirth}");
                    Console.WriteLine();
                }
            }
            
        }
       
    }
}
