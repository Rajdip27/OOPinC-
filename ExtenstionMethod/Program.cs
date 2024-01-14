
using ExtenstionMethod;

Person Person= new Person();
Person.Id=1;
Person.Name = "Abcd";
Person.Address = "jkndfjkn";
string personalInfo = Person.PersonalInfo();
Console.WriteLine(personalInfo);
Console.ReadKey();
