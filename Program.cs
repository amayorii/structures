using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExecuteInput;
using Block2Andrii;

namespace struct_lab_student
{
    public class Program
    {
        static void Var8(List<Student> studs)
        {
            for(int i = 0; i < studs.Count; i++)
            {
                if (studs[i].physicsMark == '2' || studs[i].physicsMark == '-' || 
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
            Block2.Do(studs);
        }

        static void Main(string[] args)
        {
            List<Student> studs = Input.ReadData("Input.txt");
            RunMenu(studs);
        }
    }
}
