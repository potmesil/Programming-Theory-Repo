public class Square : Shape // INHERITANCE
{
    protected override void Start()
    {
        base.Start();
    }

    protected override string DisplayText() // POLYMORPHISM
    {
        return $"Clicked on {ColorName.ToLower()} square";
    }
}