using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UUZooLibrary
{
    //Bird Class inherits from the Animal Class
    public abstract class Bird : Animal
    {
        //Fields
        private double wingspan;
        //Properties
        public double Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }
        //Default Constructor
        public Bird()
        {
            Name = "Nimbus";
            Wingspan = 18;
            Age = 3;
            Species = "Parrot";
            Weight = 1.2;
            HasTeeth = false;
        }
        //Customer Constructor
        public Bird(double wingspan, string name, string species, int age, double weight, bool hasTeeth)
        {
            this.Name = name;
            this.Wingspan = wingspan;
            this.Age = age;
            this.Weight = weight;
            this.Species = species;
            this.HasTeeth = hasTeeth;
        }
        //Fast Method - Reduce the animal’s weight by 1kg per hour
        public override void Fast(double amount)
        {
            double loss = amount / 2;
            Weight = Weight - loss;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return $"Name: {Name} Wingspan: {Wingspan} Age: {Age} Weight: {Weight} Species: {Species}";
        }
    }
}