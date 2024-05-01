using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using struct_lab_student;
using Block2Nazariy;
using Karina2Block;
using Block2Andrii;
using System.ComponentModel.Design;
using ExecuteInput;

namespace Menushka
{
    class Menu
    {
        static void Main()
        {
            RunMenu();
        }
        static void RunMenu()
        {
            
            while (true)
            {
                string[] studentName = { "Andrii", "Nazar", "Karina" };
                string name = SelectStudent();
                if (studentName.Contains(name))
                {
                    SelectStudent(name);
                }
                else if (name == "0")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Try again");
                }
                    
            }
        }
        static string SelectStudent()
        {
            Console.WriteLine("Choose student or 0 to exit:\nAndrii\nNazar\nKarina");
            return Console.ReadLine();
        }
        static void SelectStudent(string name)
        {
            switch (name)
            {
                case "Andrii":
                    Block2.Do(Input.ReadData("Input.txt"));
                    break;
                case "Nazar":
                    NazariyBlock.Var8(Input.ReadData("Input.txt"));
                    break;
                case "Karina":
                    Block2_Karina.Block2_22(Input.ReadData("Input.txt"));
                    break;

            }
        }
    }
}
