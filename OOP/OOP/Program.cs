using System;

namespace OOP
{
   // enum Models {AUDI, VOLVO, NISSAN, VOLKSWAGEN, PIRHSE, FORD}
    class Cars
    {
        public int wheels = 4;// Доступен во всех классах
        private float speed; //Доступен только в этом классе
        protected bool isWorking = true;//Доступен в классе в котором за делегирован и классах наследниках
       // public Models model;
        public static int test = 0;

        public static void Test()
        {
            Console.Write("Hi");
        }

        public void setValues(float speed, bool isWorking)// через эту функцию мы можем указывать параметры методам которые стоят с правами доступа privet и protected, благодаря переменным ниже
        {
            this.speed = speed; //this - ykazivaet 4to mu obrawaemsya imenno k peremennoi etogo klassa
            this.isWorking = isWorking;
        }

        public void getVelues()//Функция которая будет выводить данные на экран
        {
            Console.WriteLine("Car speed is: " + this.speed + ", car is working: " + this.isWorking);
        }
        public Cars(int wheels, float speed, bool isWorking)//конструктор класса, мы передаем все что нас интересует в этот конструктор, но, мы обязаны внести то количество данных, которое указали в нем, в нашем случае 3 параметра!(теперь как мы будет обращатся к функциям или конструкторам, то те данные мы и будем вводить, например, если вызвали сетер, то вводим 2 параметра как в нашем случае, если непосредственно конструктор, то 3 параметра если нет перегрузки)
        {
            this.speed = speed;
            this.isWorking = isWorking;
            this.wheels = wheels;
        }
        public Cars() { }// peregryzka konstyktora(kotorui nichego ne peredaet)(для того, что бы при создании обьекта не нужно было обязательно вводить все данные!)
    }

   // class Trucks : Cars
   //     public int passengers;

    //    public Trucks(int wheels, float speed, bool isWorking, int passengers) : base (wheels, speed, isWorking)
     //   {
     //       this.passengers = passengers;
     //   }
  //  }

    class Program
    {
        static void Main(string[] args)
        {
            //Cars.test = 23;
            //Cars.Test();
            //Console.WriteLine(Cars.test);

          //  Trucks man = new Trucks(8, 130.5f, true, 3);
         //   man.getVelues();
         //   Console.WriteLine(man.passengers);

            Cars toyota = new Cars(4, 230.5f, true);
           // toyota.model = Models.FORD;
           // Console.WriteLine(toyota.wheels);

           // toyota.setValues(230.5f, true);
            toyota.getVelues();

            Cars audi = new Cars();//Таким образом мы создаем объект класса и выделяем ему память
           // audi.wheels = 6;// В этой строке мы вызываем один из методов и можем присвоить любое значение, для какждого объекта может быть свое значение не зависимо от того, что установленно в классе, в классе установленно общае значение для всех.
           // audi.model = Models.AUDI;
            Console.WriteLine(audi.wheels);
            audi.setValues(260.0f, false);// указываем параметры для объекта 
            audi.getVelues();// выводим параметры кторые указали выше
        }
    }
}
