using System;
using UltimateCSPart1._3.NonPrimitiveTypes;
using UltimateCSPart1._3.NonPrimitiveTypes.Math;

namespace UltimateCSPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            // First program
            Console.WriteLine("Hello World!");

            // Primitive Types and Expressions
            PrimitivesTypes pt = new PrimitivesTypes();
            pt.VarsAndNumbers();
            pt.TypeConversionDemo();
            
            // Non Primitive Types
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = Calculator.Add(2, 3);
            Console.WriteLine(result);
        }
    }
}