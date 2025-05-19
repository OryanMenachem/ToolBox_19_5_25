using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox_19_5_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tool> listTools = new List<Tool>();
            
            Screwdriver screwdriver = new Screwdriver("screwdriver", 1.2f,"");
            Wrench wrench = new Wrench("wrench", 0.4f,"");
            Drill drill = new Drill("drill", 1.4f, "drilling"); 
            Hammer hammer = new Hammer("hammer", 0.4f,"");
            Saw saw = new Saw("saw", 0.5f, "");
            PipeCutter pipeCutter = new PipeCutter("pipeCutter", 1.1f, "");
            NailGun nailGun = new NailGun("nailGun", 0.6f, "");
            WireStripper wireStripper = new WireStripper("wireStripper", 0.6f, "");



            listTools.Add(screwdriver);
            listTools.Add(wrench);
            listTools.Add(drill);
            listTools.Add(hammer);
            listTools.Add(saw);
            listTools.Add(pipeCutter);
            listTools.Add(wireStripper);
            listTools.Add(nailGun);

            foreach (Tool tool in listTools)
            {
                tool.Describe();
                Console.WriteLine("");
                tool.Use();
                Console.WriteLine("\n");
            }
        }
    }
}
