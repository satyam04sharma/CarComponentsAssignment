public abstract class Car
{
    public virtual string Description { get; set; } = "Unknown Model";

    public abstract double Cost();
}
