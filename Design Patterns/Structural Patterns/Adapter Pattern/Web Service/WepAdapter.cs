using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Adapter_Pattern
{
    internal class WepAdapter : IWebRequester
    {
        private WebService service;
        
        public void connect(WebService CurrentService)
        {
            this.service = CurrentService;
        }

        public int request(object obj)
        {
            throw new NotImplementedException();
        }
    }

    internal class WebService
    {
    }
}
