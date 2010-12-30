using System.Linq;

namespace Algorithms
{
    public static class Methods
    {
        public static string DoSomething(string value)
        {
            return value.ToUpper();
        }

        public static string DoSomethingElse(string value)
        {
            return new string(value.Reverse().ToArray());
        }

        public static string DoSomethingElseMore(string value)
        {
            return (DoSomething(DoSomethingElse(value)));
        }
    }
}