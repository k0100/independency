using System;

namespace InDependency
{
    public abstract class Dependency<T>
    {
        private static Func<object[], T> activator;

        protected T implementation;

        public Dependency(params object[] args)
        {
            implementation = activator(args);
        }

        public static void Is(Func<object[], T> activator)
        {
            Dependency<T>.activator = activator;
        }
    }
}