using InDependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Dependencies
{
    class Greeter : Dependency<IGreeter>, IGreeter
    {
        public string GetMessage()
        {
            return implementation.GetMessage();
        }
    }
}
