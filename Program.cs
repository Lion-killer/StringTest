using System;


namespace StringTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testStr = "A1:B2";
            var testresult = testStr.Split(':', 2, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
