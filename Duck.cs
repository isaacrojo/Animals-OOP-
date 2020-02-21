using System;

namespace Animals
{
    class Duck : Animal         //: es herencia
    {
        public Duck(string lastName)            //metodo constructor, tiene el mismo nombre de la clase
        {
            this.name = "Duck";
            this.lastName = lastName;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{this.name} goes Quack");         //interpolacion con $ en espacios especificos

        }

    }
}