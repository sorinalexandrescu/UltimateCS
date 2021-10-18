using System;

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
            Person person = new Person();
            person.Name = "Sorin";
            person.Introduce();

            int result = Calculator.Add(2, 3);

        }
    }
}