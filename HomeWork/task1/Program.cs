


using task1;

var person = new Person();
person.FirstName="Shahrom";
person.LastName="Sharipov";
person.Age=2000;
person.Address="district Sino";
System.Console.Write($"My name is ");
System.Console.WriteLine(person.GetFullName());
System.Console.Write("My birth year is ");
System.Console.WriteLine(person.GetBirthYear());