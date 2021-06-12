using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l7t14
{
    /*
    * Внутри метода Main() создайте словарь и заполните его 10 парами ключ-значение, введенными с клавиатуры.
    * Выведите на экран элементы словаря в следующем формате:
    * "key - value", где key и value соответствующие значения элемента словаря.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<string, string> vk = new Dictionary<string, string>(10);
            for (int i = 0; i < 10; i++)
            {
                vk.Add(Console.ReadLine(), Console.ReadLine());
            }
            foreach (KeyValuePair<string, string> keyValue in vk)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
            }
        }
    }
}