using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public double FindMax(int num1, int num2)
        {
            /* local variable declaration */
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 100;
            int b = 200;
            Double ret;

            NumberManipulator n = new NumberManipulator();

            ret = n.FindMax(a, b);

            //calling the FindMax method
            
            Console.WriteLine("Max value is : {0}",ret);
            Console.ReadLine();
        }
    }
}