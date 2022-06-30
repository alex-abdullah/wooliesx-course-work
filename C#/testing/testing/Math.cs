using System;
namespace CodeProject
{
    public class Math
    {
        public Math()
        {
        }
            public static int Add(int num1, int num2)
            {
                return num1 + num2;
            }

        public static double Divide(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException();
            return num1 / num2;
        }


    }
}
