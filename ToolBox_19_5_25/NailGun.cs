using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToolBox_19_5_25
{
    internal class NailGun : Tool
    {
        
        public NailGun(string name, float weight, string category) : base(name, weight, category)
        {
            Name = name;
            Weight = weight;
            Category = category;
            UseCount = 0;
        }
        public override void Describe()
        {
            Console.WriteLine($"{Name}: A powered tool that rapidly drives nails into materials, allowing for quicker fastening than traditional hammers. And its weight is {Weight}");
        }
        public override void Use()
        {
            Console.WriteLine($"The {Name} Shoots nails");
            UseCount++;
        }
    }
}
