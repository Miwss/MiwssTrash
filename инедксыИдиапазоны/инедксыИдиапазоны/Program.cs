using System;

namespace инедксыИдиапазоны
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 10, 5, 6, 77, 89, 1 };

            //проверяет берем ли мы элемент с конца массива isFromEnd.


            string str = "Hello World !!=)";
            Console.WriteLine(str[6..11]);

            int[] myArray4 = myArray[^4..^1];
 
            Range myRange3 = ^4..^1;

            Range myRange2 = new Range(1,4);//start and konec - так же как и ниже, только другая запись


            Range myRange = 1..4;
            int[] myArray2 = myArray[myRange];




            Index myIndex1 = new Index(3, true);//Указав ТРУ - мы берем элемент с конца массива, Указав ФОЛС либо ничего, то зайдем с начала массива и указаного индекса
            Index myIndex = 3; //Указываем свой диапазон, используя ^1 - берез значение с конца, указам просто число, укажим просто индекс элемента
            Console.WriteLine(myArray[myIndex]);
            Console.WriteLine();

            //int[] myArray2 = myArray[1..4];//диапазон от и до которого мы хотим взять по индексу.[..4][4..];
            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}"); ;
            //Console.WriteLine(myArray[^1]); - синтаксический сахар, получаем последнее значение массива
        }
    }
}
