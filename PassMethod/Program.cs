using System;

public delegate int Sumation(int firstNumber, int secondNumber);

class Program
{
    static void Main()
    {
        //Sumation sumation = new Sumation(Sum);
        Sumation sumation = Sum;
        //int result= sumation.Invoke(12, 23);
        //int result = sumation(12, 23);
        //Console.WriteLine(result);
        InvokeDelegates(sumation,10,20);


        Sumation sumation1 = new Sumation(Sub);
        InvokeDelegates(sumation1,10,20);
        Console.ReadKey();
    }

    static int Sum(int firstNumber, int secondNumber) => firstNumber + secondNumber;
    static int Sub(int firstNumber, int secondNumber) => firstNumber - secondNumber;
    public static void InvokeDelegates(Sumation sumation, int firstNumber,int secondNumber)
    {
        int result= sumation.Invoke(firstNumber, secondNumber);
        Console.WriteLine(result);
    }

}
