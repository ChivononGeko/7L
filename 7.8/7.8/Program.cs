using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l7t8
{
    /*
    * Внутри метода Main() дан список строк list. Реализуйте следующую логику работы со списком:
    * 1) Удалите из списка все слова, содержащие букву Т.
    * 2) Все слова содержащие букву Б сделайте в ВЕРХНЕМ РЕГИСТРЕ.
    * 3) Во всех словах, содержащих букву Р - замените её на букву Л.
    * Шаблон задачи изменять нельзя.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "собака", "улыбака", "мурка", "кот", "бурка", "Сивка", "баркаc" };
            /* Добавьте свой код ниже */
            for (int i = 0; i < list.Count; i++)
            {
                char[] a = list[i].ToCharArray();
                for (int j = 0; j < a.Length; j++)
                {
                                      
                    if (Convert.ToString(a[j]) == "т")
                    {
                        list.RemoveAt(i);
                        i--;
                    }
                    if (Convert.ToString(a[j]) == "б")
                    {
                       list[i] = list[i].ToUpper();
                    }
                    if (Convert.ToString(a[j]) == "р")
                    {
                       a[j] = Convert.ToChar("л");
                    }
                }
                
            }
            foreach (var str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}