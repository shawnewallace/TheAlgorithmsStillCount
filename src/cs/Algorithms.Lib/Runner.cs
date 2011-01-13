using System;

namespace Algorithms.Lib
{
    public class Runner<T, TReturn>
    {
        public TReturn Invoke(Func<T, TReturn> method, T param)
        {
            return method(param);
        }
    }
}