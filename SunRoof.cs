public class SunRoof : CarDecorator
{
    public SunRoof(Car car) : base(car) { }
    
    public override string Description => car.Description + ", Sun Roof";

    public override double Cost()
    {
        // The cost of the Sun Roof varies by car model
        double additionalCost = 0;
        switch (car)
        {
            case CModel _:
                additionalCost = 1940;
                break;
            case EModel _:
                additionalCost = 2240;
                break;
            case CSModel _:
                additionalCost = 3400;
                break;
        }
        return car.Cost() + additionalCost;
    }
}
