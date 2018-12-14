using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Dependencies
{
    class MyGreeter : IGreeter
    {
        public string GetMessage()
        {
            return "Hello, world!";
        }
    }
}
