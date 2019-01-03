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
        public Greeter()
        {
        }

        public Greeter(string name) : base(name)
        {
        }

        public string Greet()
        {
            return implementation.Greet();
        }
    }
}
