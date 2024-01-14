namespace ExtenstionMethod;
public static class Extenstion
{
    public static string PersonalInfo(this Person person)=> $"Id: {person.Id},Name:{person.Name},Address :{person.Address}";
}
