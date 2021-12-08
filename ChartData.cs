// create ChartData.cs for ChartViewModel.cs
// should have category, value

public class ChartData
{
    public string Category { get; set; }
    public double Value { get; set; }

    public ChartData(string category, double value)
    {
        Category = category;
        Value = value;
    }
}