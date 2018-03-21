using System;

namespace MathLibrary
{
    public class MathStuff
    {
        public double Tan(double input)
        {
            double radians;
            double result;
            radians = input * (Math.PI / 180);
            result = Math.Tan(radians);
            Console.WriteLine("The tangent of " + input + " degrees is {0}.", result);
            return result;
        }
        public double Cos(double input)
        {
            double answer;
            answer = Math.Cos(input);
            return answer;
        }
        public double Square(double input)
        {
            double answer;
            answer = Math.Sqrt(input);
            return answer;
        }
        public double Cube(double input)
        {
            double answer;
            answer = Math.Ceiling(Math.Pow(input, (double)1 / 3));
            return answer;
        }
        public double Inv(double input)
        {
            double answer;
            answer = input - (input * 2);
            return answer;
        }
        public double Sin(double input)
        {
            double answer;
            answer = Math.Sin(input);
            return answer;
        }
        public double add(double a, double b)
        {
            double answer;
            answer = a + b;
            return answer;
        }

        public double subtract(double a, double b)
        {
            double answer;
            answer = a - b;
            return answer;
        }

        public double multiply(double a, double b)
        {
            double answer;
            answer = a * b;
            return answer;
        }

        public double divide(double a, double b)
        {
            double answer;
            answer = a / b;
            return answer;
        }
    }
}
