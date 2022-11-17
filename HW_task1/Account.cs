using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_task1
{
    //Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
    internal class Account<T>
    {
        private T accountName { get; set; }
        private int accountBalance { get; set; }
        private string accountDetails { get; set; }


        public string getInfo()
        {
            return $"Номер счета: {accountName} | Баланс: {accountBalance} | ФИО: {accountDetails}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            accountName = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            //Console.WriteLine("Баланс");
            accountBalance = 1589624;

            //Console.WriteLine("ФИО");
            accountDetails = "Зайцев Кирилл Сергеевич";
        }

    }
}
