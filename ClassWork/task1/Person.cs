namespace task1;

public class Person
{
    public string? FirstName ;
    public string? LastName ;
    public int Age ;
    public void GetInfo()
    {
        System.Console.WriteLine($"FirstName : {FirstName}\nLastName : {LastName}\nAge : {Age}");
    }
}
