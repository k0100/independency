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
            ConfigureDependencies();

            DoWork();
        }

        private static void DoWork()
        {
            var worldGreeter = new Greeter();

            Console.WriteLine(worldGreeter.Greet());


            var eartGreeter = new Greeter("Earth");

            Console.WriteLine(eartGreeter.Greet());

            Console.ReadLine();
        }

        private static void ConfigureDependencies()
        {
            Greeter.Is(
                (args) => args.Any()
                ? new MyGreeter(args[0].ToString())
                : new MyGreeter()
                );
        }
    }
}
