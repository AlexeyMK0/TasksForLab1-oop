namespace Task1;

public class AutoPark
{
    private List<Car> _cars;

    public AutoPark(IEnumerable<Car> cars)
    {
        _cars = cars.ToList();
    }

    public Car FindCarById(int carId)
    {
        if (carId <= 0)
        {
            throw new InvalidOperationException($"wrong carId {carId}");
        }

        Car? car = _cars.FirstOrDefault(c => c.CarId == carId);

        if (car is null)
        {
            throw new KeyNotFoundException("Car not found");
        }

        return car;
    }
}