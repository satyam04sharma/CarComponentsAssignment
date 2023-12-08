public abstract class CarDecorator : Car
{
    protected Car car;

    public CarDecorator(Car car)
    {
        this.car = car;
    }

    public override string Description => car.Description;

    public override double Cost()
    {
        return car.Cost();
    }
}
