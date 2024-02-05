namespace Polymorphism;

public class ClassB:ClassA
{
    public override void Add(int firstNumber, int secondNumber)
    {
        base.Add(firstNumber, secondNumber);
        Console.Write($"ClassB Ans is :{firstNumber - secondNumber}");
    }
}
