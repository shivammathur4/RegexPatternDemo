using System;

namespace RegexPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern pattern = new pattern();
            //bool result=pattern.validatePinCode("abc-100-100@.nt.in");
            //bool result = pattern.validatePinCode("400 088");
            bool result = pattern.validatePinCode("abc@bridgelabz.com");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
