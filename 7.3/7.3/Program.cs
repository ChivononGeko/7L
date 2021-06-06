﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l7t3
{
    /*
    * На вход в метод Main() будет подан массив строк args, каждая из строк будет содержать число типа double в строковом представлении, с различным количеством знаков после точки.
    * Создайте статический метод SmartCutter() который принимает массив строк и возвращает динамический массив, содержащий только те числа double из принятого массива,
    * в которых количество знаков после точки меньше либо равно 3.
    * Внутри метода Main() выведите результат работы метода SmartCutter() в консоль, каждый элемент с новой строки.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            string[] arr2 = new string[] { "1,12345", "2,1234", "3,123", "4,12", "5,1" };
            SmartCutter(arr2);


        }
        public static void SmartCutter(string[] arr)
        {
            ArrayList arr1 = new ArrayList();   
            for (int i = 0; i < arr.Length; i++)
            {
                string[] arr2 = arr[i].Split(',');
                double a = double.Parse(arr[i]);
                if (arr2[1].Length <= 3)
                {
                    arr1.Add(a);
                }
                
            }
        }
    }
}