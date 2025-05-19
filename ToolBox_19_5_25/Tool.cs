using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox_19_5_25;

namespace ToolBox_19_5_25
{
    internal  class Tool
    {
        public string Name;
        public float Weight;
        public string Category;
        public int UseCount;


        public Tool(string name, float weight, string category) 
        {
            Name = name;
            Weight = weight;
            Category = category;
        }

        public virtual void Describe()
        {
            Console.WriteLine($"The tool - {Name} does...");
        }

        public virtual void Use()
        {
            Console.WriteLine($"{Name} is being used");
            UseCount++;
        }
        

    }
}











