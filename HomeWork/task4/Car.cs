namespace task4;

public class Car
{
    public string? Make;
    public string? Model;
    public int Year;
    public double Mileage;
    public double Fuel;
    public Car(string make,string model,int year)
    {
        Make=make;
        Model=model;
        Year=year;
    }
    public void Drive(double miles)
    {
        if(Fuel<0)
        {
            System.Console.WriteLine("Необходимо заправится");
        }
        else
        {
            Fuel--;
            miles++;
        }
    }
    public void AddFuel(double gallons)
    {

    }
}
