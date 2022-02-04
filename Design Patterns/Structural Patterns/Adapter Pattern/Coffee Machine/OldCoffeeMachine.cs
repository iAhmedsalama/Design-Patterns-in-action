using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Adapter_Pattern.Coffee_Machine
{
    internal class OldCoffeeMachine : ICoffeeMachineInterface
    {
        public void SelectedA()
        {
            Console.WriteLine("A is Selected");
        }

        public void SelectedB()
        {
            Console.WriteLine("B is Selected");
        }
    }
}
