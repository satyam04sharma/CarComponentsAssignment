public class V12Engine : CarDecorator
{
    public V12Engine(Car car) : base(car) { }

    public override string Description => car.Description + ", V-12 Engine";

    public override double Cost()
    {
        return car.Cost() + 8000;
    }
}

// Similarly implement other decorators like V12Engine, SunRoof, OversizedGasTank, etc.
