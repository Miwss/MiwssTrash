using System;

namespace practick_oop
{
    class Ninja
    {
        protected int level = 0;
        protected string rank;

        public void setRang(int level, string rank)
        {
            this.level = level;
            this.rank = rank;
        }
        public void getRang()
        {
            Console.WriteLine("Уровень ниндзя: " + this.level + "\n" + "Текущее звание: " + this.rank);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ninja yunger = new Ninja();
            yunger.setRang(1, "Ниндзя новичок");
            yunger.getRang();
           // yunger.level = 1;
           // yunger.rank = "Ninja novichek";
           //Console.WriteLine("Уровень ниндзя: " + yunger.level + "\n" + "Текуще звание: " + yunger.rank);
        }
    }
}
