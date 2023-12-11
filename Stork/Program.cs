using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UUZooLibrary
{
    public class Stork : Bird
    {
        //Default Constructor for Stork
        public Stork()
        {
            this.Name = "Jasper";
            this.Wingspan = 162;
            this.Age = 22;
            this.Species = "Jabiru";
            this.Weight = 4.1;
            this.HasTeeth = false;

        }
        //Custom Constructor for Stork class
        public Stork(double wingspan, string name, string species, int age, double weight, bool hasTeeth)
        {
            Name = name;
            Wingspan = wingspan;
            Species = species;
            Age = age;
            Weight = weight;
            HasTeeth = hasTeeth;
        }
        //The Eat override method for Stork adds 80% of the food given to the weight of the flamingo the weight of the stork
        public override void Eat(double amount)
        {
            double gain = amount * 0.8;
            Weight = Weight + gain;
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