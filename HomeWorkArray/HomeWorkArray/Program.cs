using System;
using System.Linq;

namespace HomeWorkArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1,1,2,3,4,5,6,7, 2, 3, 4, 5, 6 };
            int[] result = myArray.Distinct().ToArray();//Оставляет только уникальные элементы массива.
            int[] result1 = myArray.OrderBy(i => i).ToArray();//сортерует массив, создает новый и записывает результат.
            int[] result2 = myArray.OrderByDescending(i => i).ToArray();//Сотреровка по убыванию.
            //Так же есть методы Find/FindAll/FindLast - 1)Ищет подходящее первое нам значение и выдает его 2)Ищет все подходящие значения и записывает в отдельный массив 3)Ище первое подходящее значение начиная с конца.
            //Array.Reverse(ARray); - Выводит в оьратном порядке
            //FirstOrDefault - Используем когда обращаемся к элементам а там их нет.\
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            //Array.Sort(myArray);
                //Console.WriteLine(myArray);
            
            
            //int result = myArray.Max();
            //int result = myArray.Sum();
            //int result = myArray.Where(i => i % 2==0).Sum();

            //Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());//сумма всех четных чисел
            //Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());//Самое маленькое не четное число массива
        }
    }
}
