using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Dependencies
{
    class MyGreeter : IGreeter
    {
        public MyGreeter() : this("World")
        {
        }

        public MyGreeter(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public string Greet()
        {
            return $"Hello, {Name}!";
        }
    }
}
