using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l7t5
{
    /*
    * Создайте класс Cat с публичной статической переменной allCats. Реализуйте класс Cat таким образом,
    * чтобы при создании каждого экземпляра класса Cat, он попадал в переменную allCats.
    * Внутри метода Main() создайте 10 экземпляров класса Cat. Выведите на экран содержимое переменной
    * allCats, каждое значение с новой строки.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            for (int i = 0; i < 11; i++)
            {
                new Cat();
                Console.WriteLine(Cat.allCats);
            }
            
        }
    }
    /* Добавьте свой код ниже */
    public class Cat
    {
        public static List<Cat> allCats = new List<Cat>();
      
        public Cat()
        {
            Cat cat = this;
            allCats.Add(cat);
        }
    }
}