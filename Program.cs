using System;

namespace IsNaturalNumber
{
    public class IsNaturalNumber
    {
        public static void Main()
        {
            const string MsgInput = "Enter a value to check if it's a natural number:";
            const string MsgOk = " is a natural number.";
            const string MsgKo = " is NOT a natural number.";

            int value;
            bool isNatural;

            Console.WriteLine(MsgInput);
            value = int.Parse(Console.ReadLine());

            if (value >= 0)
            {
                isNatural = true;
            }
            else
            {
                isNatural = false;
            }

            if (isNatural)
            {
                Console.WriteLine(value + MsgOk);
            }
            else
            {
                Console.Write(value + MsgKo);
            }
        }
    }
}