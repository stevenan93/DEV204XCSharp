//Steven An
//prints out a chessboard style pattern with x's and o's
//alternates between each line 

using System;

public class mainClass
{
    public static void Main(string[] args)
    {
        char x = 'X', o = 'O';
        int tableHeight = 2, tableWidth = 8;
        for(int i = 0; i < tableHeight * tableWidth; i++)
        {
            if(i % tableWidth == 0)
            {
                Console.WriteLine();
                char temp = x;
                x = o;
                o = temp;
            }
            if(i % 2 == 0)
                Console.Write(o.ToString());
            else
                Console.Write(x.ToString());
        }
        Console.WriteLine("\nHeight: {0} / Width: {1}\n", tableHeight, tableWidth);
    }
}

