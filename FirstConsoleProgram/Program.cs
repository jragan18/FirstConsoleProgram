using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleProgram
{
    class Program {
    static void Main(string[] args)
    {
        int num, sum = 0, d;
        Console.WriteLine("Enter a Number : ");
        num = int.Parse(Console.ReadLine());
        while (num != 0)
    {
        d = num % 10;
        num = num / 10;
        sum = sum + d;
    }
    Console.WriteLine("Sum of Digits of the Number : "+sum);
    Console.ReadLine();
    }
                  }

    }