using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Animal(); tipo variable, nombre variable, y nueva clase tipo pato
            Duck duck = new Duck("Donald");

            duck.MakeSound();
            Console.WriteLine(duck.GetFullName());

            Console.WriteLine(duck.LastName);
            duck.LastName = "Smith";
            Console.WriteLine(duck.LastName);
            Console.WriteLine(duck.GetFullName());


            Animal dog = new Dog("Doggy");
            Animal duck2 = new Duck("McDonald");

            Animal [] pets = new Animal[2];      //polimorfismo
            pets[0] = dog;
            pets[1] = duck2;


        }

    }
}