using System;
using System.Collections.Generic; //позволяет работать с динамическими массивами 

namespace Списки
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>(); //Таким образом выделаем память для списка

            nums.Add(73); // Жобавляем элемент в список
            nums.Add(42);

            nums.RemoveAt(1); //Удаляем элемент по индексу
            //nums.Remove(73) Удаляет элемент переданный указаный в скобках
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + ", ");
            }
        }
    }
}
