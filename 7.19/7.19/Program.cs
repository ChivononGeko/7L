using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l7t19
{
    /*
    * Реализуйте класс Cat, он должен:
    * 1) Содержать свойство Id.
    * 2) Содержать конструктор, который принимает один целочисленный параметр и присваивает его свойству.
    * 3) Переопределите метод ToString() так, чтобы он выводил фразу "Я котик и мой id = XXX". XXX - Id экземпляра класса.
    * 4) Создайте статический метод GetFreshKitties(), который возвращает 100 экземпляров класса Cat со случайными значениями Id
    * в диапазоне от 1 до 50 включительно.
    * Внутри метода Main() создайте две коллекции экземпляров класса Cat. Пусть первая коллекция содержит в себе результат вызова
    * метода GetFreshKitties(), а вторая содержит перечень экземпляров класса Cat с уникальными ID из первой коллекции.
    * Выведите на экран все элементы второй коллекции, каждое значение с новой строки. Для вывода используйте цикл foreach.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            ArrayList arraylist = new ArrayList();
            HashSet<object> hashset = new HashSet<object>();
            arraylist.AddRange(Cat.GetFreshKitties());
            foreach (var value in arraylist)
            {
                hashset.Add();
            }
         
        }
    }
    public class Cat
    {
       
        private int id; 
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public static ArrayList GetFreshKitties()
        {
            Random rnd = new Random();
            ArrayList fresh = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                fresh.Add(new Cat(rnd.Next(1, 50)));
            }
            return fresh;
           
        }
        public Cat(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"Я котик и мой id = {Id}";
        }
       
    }
}