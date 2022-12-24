public class Triangle : Shape
{
    protected override void Start()
    {
        base.Start();
    }

    protected override string DisplayText()
    {
        return $"Clicked on {ColorName.ToLower()} triangle";
    }
}