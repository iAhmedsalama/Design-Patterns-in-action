using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Adapter_Pattern.Coffee_Machine
{
    internal class CoffeeTouchscreenAdapter:ICoffeeMachineInterface
    {
        OldCoffeeMachine oldCoffeeMachine;

        public CoffeeTouchscreenAdapter(OldCoffeeMachine NewMachine)
        {
            this.oldCoffeeMachine = NewMachine;
        }

        public void NewSelectionA()
        {
            oldCoffeeMachine.SelectedA();
        }

        public void NewSelectionB()
        {
            oldCoffeeMachine.SelectedB();
        }
    }
}
