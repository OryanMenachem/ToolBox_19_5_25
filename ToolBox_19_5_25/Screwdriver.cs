using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox_19_5_25
{
    internal class Screwdriver : Tool
    {


        public Screwdriver(string name, float weight, string category) : base(name, weight, category)  
        {
            Name = name;
            Weight = weight;
            Category = category;
            UseCount = 0;
        }
        public override void Describe()
        {
            Console.WriteLine($"{Name}: A tool used to turn screws. And its weight is {Weight}");
        }
        public override void Use()
        {
            Console.WriteLine($"The {Name} turns screws");
            UseCount++;
        }
    }
}
