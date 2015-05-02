using System;

class MaximalSequence
{
    /* Write a program that finds the maximal 
     * sequence of equal elements in an array. 
     */
    static void Main()
    {
        Console.Write("Enter the size array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 1; i <= size; i++)
        {
            Console.Write("Enter {0}/{1} integer: ", i, size);
            array[i - 1] = int.Parse(Console.ReadLine());
        }

        int seqNum = 0;
        int counter = 1;

        int tempSeqNum = 0;
        int tempCounter = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                tempSeqNum = array[i];
                ++tempCounter;
            }
            else
            {
                tempSeqNum = 0;
                tempCounter = 1;
            }

            if (tempCounter > counter)
            {
                seqNum = tempSeqNum;
                counter = tempCounter;
            }
        }
        for (int i = 0; i < counter; i++)
        {
            Console.Write("{0} ", seqNum);   
        }
    }
}
