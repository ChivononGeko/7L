using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l7t17
{
    /*
    * Внутри метода Main() необходимо заполнить словарь personsInDaClub экземплярами класса Person, в качестве ключа
    * необходимо использовать порядковые номера, начиная с единицы. Словарь необходимо заполнять до тех пор, пока в
    * нём не появится 15 посетителей, которые бы полностью удовлетворяли всем условиям фейсконтроля.
    * Создайте публичный статический метод FaceControl, который принимает экземпляр класса Person и возвращает
    * результат проверки. Логика проверки должна учитывать:
    * 1) Никаких посетителей моложе 18.
    * 2) Никаких посетителей у кого менее 250 наличных в кармане.
    * Шаблон задачи изменять нельзя.
    */
    public class FashionClub
    {
        public static Dictionary<int, Person> personsInDaClub = new Dictionary<int, Person>();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
          
           
            for (int i = 0; i < personsInDaClub.Count+1; i++)
            {
                personsInDaClub.Add(i, FaceControl(new Person()));
            }
            foreach (KeyValuePair<int, Person> keyValue in personsInDaClub)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Age + "-" + keyValue.Value.Cash);
            }

        }
        public static Person FaceControl(Person person)
        {
            if (person.Age>=18 && person.Cash>=250)
            {
                return person;
            }
            else
            {
                return null;
            }
        }
    }
    public class Person
    {
        static Random r = new Random();
        public int Age { get; private set; }
        public int Cash { get; private set; }
        public Person()
        {
            Age = r.Next(10, 36);
            Cash = r.Next(100, 1001);
        }
    }
}