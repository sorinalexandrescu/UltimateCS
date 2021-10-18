using System;

namespace UltimateCSPart1
{
    public class NonPrimitiveTypes
    {
           /* Classes combine fields and methods together
            * Classes have
            *  - access modifiers
            *  - variables - that also have access modifiers
            *  - methods
            */
           
           /*
            * Create objects
            *   - for objects we need to allocate memory with the 'new' operator
            *   - Person person = new Person();
            */
           
           
    }

    public class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name);
        }
    }
    
    public class Calculator
    {
        private int number;

       /*
        * Static methods: no matter how many instances of the Calculator object we create, there will be only
        * one place in the memory for the Add method.
        * As a matter of fact, you cannot call the static method from the instantiated object.
        * You need to call it like this:
        * int result = Calculator.Add(2, 3);
        */
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}