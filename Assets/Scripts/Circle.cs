public class Circle : Shape // INHERITANCE
{
    protected override void Start()
    {
        base.Start();
    }

    protected override string DisplayText() // POLYMORPHISM
    {
        return $"Clicked on {ColorName.ToLower()} circle";
    }
}