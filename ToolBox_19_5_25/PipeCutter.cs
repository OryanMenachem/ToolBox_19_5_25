using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox_19_5_25
{
    internal class PipeCutter : Tool
    {
        public PipeCutter(string name, float weight, string category) : base(name, weight, category)
        {
            Name = name;
            Weight = weight;
            Category = category;
            UseCount = 0;
        }
        public override void Describe()
        {
            Console.WriteLine($"The tool - {Name} does pipe cutter, And its weight is {Weight}");
        }

        public override void Use()
        {
            Console.WriteLine($"The {Name} cuts pipes");
            UseCount++;
        }
    }
}
