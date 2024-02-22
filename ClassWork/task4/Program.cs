



using task4;

var emp=new Employee();
System.Console.Write("Enter employee's FirstName: ");
emp.FirstName=Console.ReadLine();
System.Console.Write("Enter employee's LastName: ");
emp.LastName=Console.ReadLine();
System.Console.Write("Enter employee's Age: ");
emp.Age=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter employee's Position: ");
emp.Position=Console.ReadLine();
System.Console.Write("Enter employee's Salary: ");
emp.Salary=Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine(emp.GetInfo());
