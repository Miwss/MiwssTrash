using System;

namespace NinjaTest
{
    class HidenFeal
    {
        private int NumTeam;
        private string name;
        private string coach;


        public int NumTeamm
        {
            get;
            set;
        }
        //public int NumTeamm
        //{
        // get
        //  {
        //      return NumTeam;
        //  }
        //  set
        //  {
        //     if (value < 1)
        //         NumTeam = 1;
        //     else if (value > 5)
        //          NumTeam = 5;
        //       else
        //           NumTeam = value;
        //   }
        // }

        public HidenFeal()
        {
            NumTeam = 0;
            name = "";
            coach = "";

            print();
        }

        public HidenFeal(int NumTeam, string name, string coach)
        {
            this.NumTeam = NumTeam;
            this.name = name;
            this.coach = coach;

            print();
        }

        public void print()
        {
            Console.WriteLine("NumTEam: " + NumTeam);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Coach: " + coach + "\n");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //HidenFeal first = new HidenFeal(1, "Neji, TenTen, Hnata", "Minato");
            //Console.Write("NumTeam: " + first.NumTeam + "\n" + "Members: " + first.name + "\n" + "Coach: " + first.coach);
            HidenFeal second = new HidenFeal();
            second.NumTeamm = 7;
            Console.WriteLine(second.NumTeamm);
        }
    }
}
