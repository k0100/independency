using System;
using System.Collections.Generic;
using System.Text;

namespace InDependency
{
    public abstract class Dependency<T>
    {
        private static Func<T> activator;

        private static T constant;

        protected T implementation;

        public Dependency()
        {
            implementation = activator();
        }

        public static T Constant()
        {
            return constant;
        }

        public static void Is(Func<T> activator)
        {
            Dependency<T>.activator = activator;
            constant = activator();
        }
    }
}
