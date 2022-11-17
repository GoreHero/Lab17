using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account<int> account = new Account<int>();
                account.Input();
                Console.WriteLine(account.getInfo());
            }
            catch
            {
                Account<int> account = new Account<int>();
                account.Input();
                Console.WriteLine(account.getInfo());
            }
            
            //Employee<int> employee1 = new Employee<int>();
            //employee1.Input();
            //Console.WriteLine(employee1.getInfo());

            //Employee<string> employee2 = new Employee<string>();
            //employee2.Input();
            //Console.WriteLine(employee2.getInfo());
        }
    }
}
