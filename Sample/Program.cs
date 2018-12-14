using Sample.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterDependencies();

            DoWork();
        }

        private static void DoWork()
        {
            var greeter = new Greeter();

            Console.WriteLine(greeter.GetMessage());

            Console.ReadLine();
        }

        private static void RegisterDependencies()
        {
            Greeter.Is(() => new MyGreeter());
        }
    }
}
