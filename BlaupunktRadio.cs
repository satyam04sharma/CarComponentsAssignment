public class BlaupunktRadio : CarDecorator
{
    public BlaupunktRadio(Car car) : base(car) { }
    
    public override string Description => car.Description + ", Blaupunkt New York 800 Radio";

    public override double Cost() => car.Cost() + 940;
}
