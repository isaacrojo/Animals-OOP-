using System;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string lastName)            //metodo constructor, tiene el mismo nombre de la clase
        {
            this.name = "Dog";
            this.lastName = lastName;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{this.name} goes Whaww");         //interpolacion con $ en espacios especificos

        }

    }
}