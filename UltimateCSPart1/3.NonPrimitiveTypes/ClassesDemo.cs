using System;

namespace UltimateCSPart1._3.NonPrimitiveTypes
{
    /* Classes combine fields and methods together
    * Classes have
    *  - access modifiers
    *  - variables - that also have access modifiers
    *  - methods
    *
    * Create objects
    *   - for objects we need to allocate memory with the 'new' operator
    *   - Person person = new Person();
    */
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + FirstName + " " + LastName);
        }
    }
}