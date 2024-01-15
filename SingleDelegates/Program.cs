using System;

public delegate int Sumation(int firstNumber, int secondNumber);

class Program
{
    static void Main()
    {
        //Sumation sumation = new Sumation(Sum);
        Sumation sumation = Sum;
       //int result= sumation.Invoke(12, 23);
       int result= sumation(12, 23);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    static int Sum(int firstNumber, int secondNumber)=> firstNumber+ secondNumber;
    
}
