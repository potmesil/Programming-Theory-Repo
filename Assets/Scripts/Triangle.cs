public class Triangle : Shape // INHERITANCE
{
    protected override void Start()
    {
        base.Start();
    }

    protected override string DisplayText() // POLYMORPHISM
    {
        return $"Clicked on {ColorName.ToLower()} triangle";
    }
}