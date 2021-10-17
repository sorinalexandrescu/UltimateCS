using System;

namespace UltimateCSPart1
{
    public class PrimitivesTypes
    {
        // Variables / Constants
        // Variable: a name given to a storage location in memory
        // Constant: an immutable value
        public void VariableAndConstants()
        {
            // Identifiers cannot start with a number, has to be one word, and cannot be a key word
            // It has to be clear
            // Naming conventions:
            //      - Camel Case: firstName
            //      - Pascal Case: FirstName
            //      - Hungarian Notation: strFileName (not used in C#)

            // For local variables: Camel Case      int number;
            // For constants: Pascal Case           const int MaxZoom = 5;

            // Primitive Types
            // Integral Numbers: byte, short, int, long
            // Real Numbers: float (f), double, decimal (m)
            // Character: char
            // Boolean: bool

            // int number; --> this would not compile, it needs to be initialized
            int number = 1;
            const float Pi = 3.14f;
            const decimal numberdecimal = 1.2m;
        }

        // Overflowing: if you try to store data inside a variable which exceeds its data type
        // you get an error
        public void Overflow()
        {
            byte number = 255;
            //number = number + 1; ----> this will overflow, you will get 0

            // You can stop it using the checked keyword,
            // it will throw an exception and the program will crash
            checked
            {
                byte number2 = 255;
                number2 = (byte)(number2 + 1); // will throw an exception
            }
        }

        // Scope: variables have meaning only inside the block they are declared
        public void Scope()
        {
            byte a = 1;
            {
                byte b = 2;
                {
                    byte c = 3;
                }
            }
            // if I try to access b here I get a compile error
            // because it is meaningful only inside its block
        }

        // Variables and Constants
        public void VarsAndNumbers()
        {
            // You can declare your variables using the data type, but you can use var
            // var will use the underlying data type of the data you load
            var number = 5; // we need to initialize the variable on declaration 
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Sorin";
            var isWorking = true;
            var isNotWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(isNotWorking);

            // MinValue, MaxValue
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // Constants
            const float Pi = 3.14f; // cannot change it anymore during the program
            // Pi = 1; --> it won't work
        }

        // Type Conversions
        public void TypeConversion()
        {
            int i = 1;

            // byte b = i; won't compile, because the data in integer can be bigger than the max data in byte
            // In this case it cannot implicitly convert

            // Explicit conversion: casting
            float f = 1.0f;
            int j = (int)f;

            // Non-compatible types
            string s = "1";
            int k = Convert.ToInt32(s); // converts a string to an Int32, 4 bytes x 8 bits
            int l = int.Parse(s); // converts a string to an int in this case
        }
        
        // TypeConversion Demo
        public void TypeConversionDemo()
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
        }
    }
}