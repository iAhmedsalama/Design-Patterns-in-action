using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Composite_Pattern
{
    internal interface IStructure
    {
        public void Enter();
        public void Exist();
        public void Location();
        public string GetName();
    }
}
