using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            numbers()
            {
                //Tells you the quantity of pineapples.
                pineapplecount = 25;

                printf("Amount of pineapples: ", pineapplecount);
            }
            char()
            {
                //prints 2 lines.
                characters = "Here is the first line. \n";
                    "Here is the second line.";
                printf(characters);
                bool i = equal(45, 30);
                printf(i);
            }
            //Checks if both numbers are equal and the result.
            bool equal(int a, int b)
            {
                if(a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
