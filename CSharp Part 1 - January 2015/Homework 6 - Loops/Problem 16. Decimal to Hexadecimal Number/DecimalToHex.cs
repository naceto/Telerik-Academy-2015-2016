using System;

class DecimalToHex
{
    /* Using loops write a program that converts an integer number to its hexadecimal representation.
     * The input is entered as long. The output should be a variable of type string. 
     */
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long dec = long.Parse(Console.ReadLine());
        byte remainder = 0;
        string hexStr = "";
        while (dec > 0)
        {
            remainder = (byte)(dec % 16);
            if (remainder < 10)
            {
                hexStr = remainder.ToString() + hexStr;
            }
            else
            {
                char hexChar = '0';
                switch(remainder)
                {
                    case 10:
                        hexChar = 'A';
                        break;
                    case 11:
                        hexChar = 'B';
                        break;
                    case 12:
                        hexChar = 'C';
                        break;
                    case 13:
                        hexChar = 'D';
                        break;
                    case 14:
                        hexChar = 'E';
                        break;
                    case 15:
                        hexChar = 'F';
                        break;
                }
                hexStr = hexChar.ToString() + hexStr;
            }
            dec /= 16;
        }
        Console.WriteLine(hexStr);
    }
}
