using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    internal class Employee <T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public int Summa { get; set; }

        //public Employee(T num, string name, int summa)
        //{
        //    Num = num;
        //    Name = name;
        //    Summa = summa;
        //}
        public string getInfo()
        {
            return$"{Num} {Name} {Summa}";
        }

        public void Input()
        {
            Console.WriteLine("VVOD INT nomer");
            Num = (T)Convert.ChangeType(Console.ReadLine(),typeof(T));
            
            Console.WriteLine("Vvod Name");
            Name = Console.ReadLine();

            Console.WriteLine("vvod ZP");
            Summa = Convert.ToInt32(Console.ReadLine());
        }
    }
}