public class V8Engine : CarDecorator
{
    public V8Engine(Car car) : base(car) { }

    public override string Description => car.Description + ", V-8 Engine";

    public override double Cost()
    {
        return car.Cost() + 4400;
    }
}

// Similarly implement other decorators like V12Engine, SunRoof, OversizedGasTank, etc.
