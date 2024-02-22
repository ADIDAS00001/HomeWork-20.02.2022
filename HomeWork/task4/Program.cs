

using task4;


var car = new Car("Toyota","Camry", 2022);
System.Console.WriteLine($"Make: {car.Make}");
System.Console.WriteLine($"Model: {car.Model}");
System.Console.WriteLine($"Year: {car.Year}");
System.Console.WriteLine($"Milage: {car.Mileage} miles");
System.Console.WriteLine($"Fuel level: {car.Fuel} gallons");
car.Drive(100);
car.AddFuel(10);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine($"You have driven {car.Mileage} miles.");

