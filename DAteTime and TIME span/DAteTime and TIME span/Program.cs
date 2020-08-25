using System;

namespace DAteTime_and_TIME_span
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выводим интересующую нас дату
            var date = new DateTime(2020, 1, 1);

            //Текущее время по гринвичу
            var newDay = DateTime.Now.ToUniversalTime();

            //Можем выбрать сами в каком виде будет подаватся информация 
            Console.WriteLine(newDay.ToString("D"));
            Console.WriteLine(newDay.ToString());

            //Текущее время
            var myTime = DateTime.Now;
            var utcTime = DateTime.Now.ToUniversalTime();

            Console.WriteLine(myTime);

            //Узнаем разницу между нашим времинем и гринвичем
            TimeSpan timeDiff = myTime - utcTime;

            //разница в часах
            var hoursDiff = timeDiff.Hours;

            //разница в минутах
            var minDiff = timeDiff.TotalMinutes;
            Console.WriteLine(hoursDiff);
            Console.WriteLine(minDiff);
        }
    }
}
