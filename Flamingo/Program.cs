using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UUZooLibrary
{
    public class Flamingo : Bird
    {
        //Default Flamingo Constructor
        public Flamingo()
        {
            Name = "Frank";
            Wingspan = 100;
            Age = 14;
            Species = "James' Flamingo";
            Weight = 6.3;
            HasTeeth = false;
        }
        //Customer Flamingo Constructor
        public Flamingo(double wingspan, string name, string species, int age, double weight, bool hasTeeth)
        {
            this.Name = name;
            this.Wingspan = wingspan;
            this.Species = species;
            this.Age = age;
            this.Weight = weight;
            this.HasTeeth = hasTeeth;
        }
        // The Eat override method adds 20% of the food given to the weight of the flamingo
        public override void Eat(double amount)
        {
            double gain = amount * 0.2;
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