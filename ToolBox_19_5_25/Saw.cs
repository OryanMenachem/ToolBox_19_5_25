using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox_19_5_25
{
    internal class Saw : Tool
    {
        public Saw(string name, float weight, string category) : base(name, weight, category)
        {
            Name = name;
            Weight = weight;
            Category = category;
            UseCount = 0;
        }
        public override void Describe()
        {
            Console.WriteLine($"{Name}: A tool with a blade used for cutting wood or other materials. And its weight is {Weight}");
        }

        public override void Use()
        {
            Console.WriteLine($"The {Name} cuts wood");
            UseCount++;
        }
    }
}
