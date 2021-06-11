using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t9
{
    /*
    * Внутри метода Main() создайте новую переменную и присвойте ей словарь, со строковым типом ключа и значения.
    * Добавьте в словарь 5 ваших любимых игрушек из детства и дайте их краткое описание. Выведите на экран
    * содержимое словаря в следующем формате:
    * "Мою игрушку зовут KEY и это: VALUE", где KEY и VALUE это соответствующие элементы словаря.
    * Метод Main() не должен ничего считывать с клавиатуры.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<string, string> toys = new Dictionary<string, string>(5);
            toys.Add("Tigra", "Tiger");
            toys.Add("Robin", "Feya");
            toys.Add("Vinni", "Pendiskiy Vinni Pux");
            toys.Add("Pyatochok", "Svin");
            toys.Add("Ia", "Osel");

            foreach (KeyValuePair<string, string> keyValue in toys)
            {
                Console.WriteLine("My igrushka is name " + keyValue.Key + " i this is: " + keyValue.Value);
            }
        }
    }
}