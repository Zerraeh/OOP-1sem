using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab06.Program.Program;

namespace Lab06
{
    internal partial class Program
    {
        public class Printer
        {
            public void IAmPrinting(transportMove item)
            {
                item.ToString();
            }
        }
    }
}
