using System;

namespace Animals
{
    abstract class Animal
    {
        protected string name;     //protected ENCAPSULACION, 

        protected string lastName;

        public string LastName  {
            get => $"Mr. {lastName}"; 
            set => lastName = value;
        }

        public abstract void MakeSound();           

        public string GetFullName(){
            return $"{this.name} {this.lastName}" ;
        }
    }
}