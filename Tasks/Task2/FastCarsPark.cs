namespace Task2;

public class FastCarsPark : ICarChecker
{
    public double MinSpeedInKilometers;

    public readonly List<Car> Cars;
    
    public FastCarsPark(double minSpeedInKilometers)
    {
        MinSpeedInKilometers = minSpeedInKilometers;
        Cars = new List<Car>(10);
    }

    public void AddCar(Car car)
    {
        if (CheckCar(car) is false)
        {
            throw new InvalidOperationException($"Can only add FAST cars (min speed in kmh {MinSpeedInKilometers})");
        }
        
        Cars.Add(car);
    }
    
    public bool CheckCar(Car car)
    {
        return car.SpeedInKilometers > MinSpeedInKilometers;
    }
}