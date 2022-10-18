using System;

namespace TestingDLL
{
    // The basic example for the DivideByZeroException() 
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
