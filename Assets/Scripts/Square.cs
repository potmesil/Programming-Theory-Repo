public class Square : Shape
{
    protected override void Start()
    {
        base.Start();
    }

    protected override string DisplayText()
    {
        return $"Clicked on {ColorName.ToLower()} square";
    }
}