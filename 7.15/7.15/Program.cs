using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t16
{
    /*
    * Внутри метода Main() удалите из множества set все элементы, которые больше либо равны среднему
    * арифметическому всех элементов множества. Выведите все оставшиеся элементы в консоль, каждый с новой строки.
    * Шаблон задачи изменять нельзя.
    */
    public class Program
    {
        public static HashSet<int> set = new HashSet<int>() { 11, 1, 1, 2, 3, 4, 0, 2, 12, 14, 3, 5, 6, 7, 8, 9, 1 };
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int i = 0;
            int a = 0;
            foreach (int value in set)
            {
                a= a+ value;
                i++;
            }
            int b = a / i;
            foreach (int value in set)
            {
                if (value >= b)
                {
                    set.Remove(value);
                }
            }
                
            
        }
    }
}