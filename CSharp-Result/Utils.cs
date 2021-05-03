using System;

namespace CSharp_Result
{
    public static class Utils
    {
        public static T Identity<T>(this T t)
        {
            return t;
        }

        public static Predicate<object> Is<T>()
        {
            return o => o is T;
        }

        public static Predicate<object> Or<T>(this Predicate<object> pred)
        {
            return o => pred(o) || o is T;
        }

        public static Result<T> As<T>(this object o)
        {
            if (o is T t) return t;
            return new InvalidCastException($"Unable to cast {o} as type {typeof(T)}!");
        }
        
        
    }
}