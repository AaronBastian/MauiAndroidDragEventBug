namespace MauiAndroidDragEventBug;

public class MainPageItemModel
{
    public string Name { get; init; }
    public string City { get; init; }
    public string State { get; init; }

    public MainPageItemModel(string name, string city, string state)
    {
        Name = name;
        City = city;
        State = state;
    }

}