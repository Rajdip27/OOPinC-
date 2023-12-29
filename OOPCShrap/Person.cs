namespace OOPCShrap;

public class Person
{
    public string fristName;
    public string middleName;
    public string lastName;
    public string GetFullName() => $"{fristName} {middleName} {lastName}";
}

//object is a real world entity.for example Chair,car,pen Mobile,Laptop ctc.
//object is an entity that has state and behavior. here ,state means data and behavior means functionality.