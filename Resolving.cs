using System;
using System.Collections.Generic;
using System.Text;

namespace InjectDemo
{
    public abstract class Resolving<T>
    {
        private static Func<T> activator;

        private static T constant;

        protected T implementation;

        public Resolving()
        {
            implementation = activator();
        }

        public static T Constant()
        {
            return constant;
        }

        public static void Is(Func<T> activator)
        {
            Resolving<T>.activator = activator;
            constant = activator();
        }
    }
}
