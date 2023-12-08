public class OversizedGasTank : CarDecorator
{
    public OversizedGasTank(Car car) : base(car) { }
    
    public override string Description => car.Description + ", Oversized Gas Tank";

    public override double Cost() => car.Cost() + 940;
}
