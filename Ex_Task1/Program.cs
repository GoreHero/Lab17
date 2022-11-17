using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Ex_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("VVOD INT nomer");
            //int numINT = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Vvod Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("vvod ZP");
            //int summa = Convert.ToInt32(Console.ReadLine());

            //Employee<int> employee1 = new Employee<int>(numINT,name,summa);
            //Console.WriteLine(employee1.getInfo());

            //Console.WriteLine("VVOD STR nomer");
            //string numSTR = Console.ReadLine();
            //Console.WriteLine("Vvod Name");
            //name = Console.ReadLine();
            //Console.WriteLine("vvod ZP");
            //summa = Convert.ToInt32(Console.ReadLine());

            //Employee<string> employee2 = new Employee<string>(numSTR,name,summa);
            //Console.WriteLine(employee2.getInfo());

            Employee<int> employee1 = new Employee<int>();
            employee1.Input();
            Console.WriteLine(employee1.getInfo());

            Employee<string> employee2 = new Employee<string>();
            employee2.Input();
            Console.WriteLine(employee2.getInfo());

        }
    }
}