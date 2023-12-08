public class SpareTire : CarDecorator
{
    public SpareTire(Car car) : base(car) { }
    
    public override string Description => car.Description + ", Spare Tire";

    public override double Cost() => car.Cost() + 440;
}
