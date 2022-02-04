using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Adapter_Pattern
{
    internal interface IWebRequester
    {
        public int request(Object obj);
    }
}
