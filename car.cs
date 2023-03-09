using System.Drawing;

class Vehicle
{
    public string brand;
    public void honk()
    {
        Console.WriteLine("Get outta the way!");
    }
}
class Car : Vehicle
{
    public string owner, make, model, color;
    public int year;
    public Car(string carOwner, string carMake, string carModel, string carColor, int carYear)
    {
        owner = carOwner;
        make = carMake;
        model = carModel;
        year = carYear;
        color = carColor;
    }
}