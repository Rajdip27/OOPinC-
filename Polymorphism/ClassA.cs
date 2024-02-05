using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism;

public class ClassA
{
    public virtual void Add(int firstNumber,int secondNumber)=> Console.Write($"ClassA Ans is :{firstNumber+secondNumber}");
    
}
