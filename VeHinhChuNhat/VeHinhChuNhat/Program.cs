//lần đầu tiên code bài kiểu này :))
using System;

namespace VeHinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int dai = 50;
            int rong = 10;
            for(int i = 0 ; i < rong ; i++)
                for(int j = 0 ; j < dai ; j++)
                    if (i == 0 || j == 0 || j == (dai - 1) || i == (rong - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*");
                        if (j == (dai - 1))
                            Console.Write("\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("-");
                    }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
