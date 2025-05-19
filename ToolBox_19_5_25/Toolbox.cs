using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox_19_5_25
{
    internal class Toolbox
    {

        List<Tool> ToolList;
        public Toolbox(Tool tool)
        {

            ToolList.Add(tool);
        }

        public void GetTools()
        {
            foreach (Tool tool in ToolList)
            {
                Console.WriteLine(tool);
            }
        }
    }
}
