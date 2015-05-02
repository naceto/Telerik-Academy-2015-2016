using System;

class HexToDecimal
{
    /* Using loops write a program that converts a hexadecimal integer number to its decimal form.
     * The input is entered as string. The output should be a variable of type long. 
     */
    static void Main()
    {
        Console.Write("Enter the HEX number: ");
        string hexStr = Console.ReadLine();
        long sum = 0;
        for (int i = 0; i < hexStr.Length; i++)
        {
            int n;
            int index = hexStr.Length - i - 1;
            if (!int.TryParse(hexStr[index].ToString(), out n))
            {
                char c = hexStr[index];
                switch (c)
                {
                    case 'A':
                        n = 10;
                        break;
                    case 'B':
                        n = 11;
                        break;
                    case 'C':
                        n = 12;
                        break;
                    case 'D':
                        n = 13;
                        break;
                    case 'E':
                        n = 14;
                        break;
                    case 'F':
                        n = 15;
                        break;
                }
            }
            sum += (long) (n * Math.Pow(16, i));
        }
        Console.WriteLine(sum);
    }
}
