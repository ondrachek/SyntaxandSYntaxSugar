using System;

namespace MyApp Syntax and Syntax Sugar
    internal class Program
    {
        static void Main(string[] args)
        {
        int answer = 4;
        string response;

        if (answer < 9)
        {
            response = answer + " is less than nine";
        }
        else
        {
            response = answer + "greater than or equal to nine";
        }
        var answer = 4;
        var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than opr equal to nine"; 
    }
    }
}