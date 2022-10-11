using System;

namespace TestingDLL
{
    public static class MathService
    {

        public static int Divide(int x, int y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }

            return x / y;
        }
        
    }
}
