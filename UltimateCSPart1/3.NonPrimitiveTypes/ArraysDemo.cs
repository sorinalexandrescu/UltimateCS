namespace UltimateCSPart1._3.NonPrimitiveTypes
{
    public class NonPrimitiveTypes
    {
           
           
           /*
            * Structs
            * Are smaller, use them for simple things.
            * Combine related fields and methods together
            * What is the difference...a bit confusing
            */
           
           /*
            * Arrays
            * What is an array
            * Declare an array
            * Initialize an array
            * Access array elements
            */
           public void ArrayDemo()
           {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            
            // Or...you can use the object initialization syntax
            int[] quickNumbers = new int[3] { 1, 2, 3};
           }

    }
}