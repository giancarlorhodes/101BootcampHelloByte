﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101BootcampHelloByte
{
    internal class Program
    {
        // Build a .net console application.
        // Your application should build and should take in a
        // number between 0 and 255 from the screen and output the
        // binary equivalent in the a Console.WriteLine() string.



        //Remember Console.ReadLine() and Console.WriteLine().
        //You will need to use these.

        //Example: If I enter 255 base 10, I should be back 1111111
        //in base 2 (binary). Output should always be 8 character so
        //we may need to pad the string.

        static void Main(string[] args)
        {

            // Example: If I enter 255 base 10, I should be back 1111111 in base 2 (binary).


            // loop until exit or number between 0 - 255, 

            bool IsContinue = true;

            while (IsContinue)
            {
                bool IsNumber;
                bool IsInRange;
                Console.WriteLine("Please enter a whole number between 0 and 255 and it will be converted to binary");

                string _input = Console.ReadLine();
                int _number;
                //IsNumber = Int32.TryParse(_input, out _number);
                IsNumber = int.TryParse(_input, out _number);

                // do some simple verification to a) process the number or b) loop again and get a valid number
                if (IsNumber == false) { IsContinue = true; }
                if (_number <= 255 && _number >= 0) { IsInRange = true; } else { IsInRange = false; }
                if (IsInRange == false) { IsContinue = true; }

                // at this point should be in range and a number
                string _binary = Convert.ToString(_number, 2); // method and converts to a specific base

                Console.WriteLine("Number {0} converts to {1} in binary.", _number, _binary);
                Console.WriteLine("Press x to exit program or c to continue converting");
                char _xOrc = Console.ReadKey().KeyChar;
                if (Char.ToLower(_xOrc) == 'x') { IsContinue = false; }
                Console.WriteLine();
            }

        }
    }
}
