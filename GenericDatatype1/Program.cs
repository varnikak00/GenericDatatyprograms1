﻿using System;

namespace GenericDatatype1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter three number");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());
            GenericType gt = new GenericType();
            float maxNumber = gt.FindMax(num1, num2, num3);
            Console.WriteLine("Max number is {0}", maxNumber);

        }
    }
}
