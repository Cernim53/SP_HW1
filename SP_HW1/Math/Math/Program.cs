using System;

namespace Math
{
    class Program
    {
        static int Main(string[] args)
        {
            int a, b;
            try
            {
                a = Convert.ToInt32(args[0]);
                b = Convert.ToInt32(args[1]);
            }
            catch (Exception)
            {
                a = b = 0;
            }
            return a + b;
        }
    }
}
