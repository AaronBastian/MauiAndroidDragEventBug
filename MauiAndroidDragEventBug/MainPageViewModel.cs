using System.Collections.ObjectModel;

namespace MauiAndroidDragEventBug;

public class MainPageViewModel
{
    public ObservableCollection<MainPageItemModel> Items { get; } = new();

    public MainPageViewModel()
    {
        Items.Add(new MainPageItemModel("Person 1", "Spring Hill", "TN"));
        Items.Add(new MainPageItemModel("Person 2", "Spring Hill", "TN"));
        Items.Add(new MainPageItemModel("Person 3", "Spring Hill", "TN"));
        Items.Add(new MainPageItemModel("Person 4", "Spring Hill", "TN"));
        Items.Add(new MainPageItemModel("Person 5", "Spring Hill", "TN"));
        Items.Add(new MainPageItemModel("Person 6", "Franklin", "TN"));
        Items.Add(new MainPageItemModel("Person 7", "Franklin", "TN"));
        Items.Add(new MainPageItemModel("Person 8", "Franklin", "TN"));
        Items.Add(new MainPageItemModel("Person 9", "Nashville", "TN"));
        Items.Add(new MainPageItemModel("Person 10", "Nashville", "TN"));
        Items.Add(new MainPageItemModel("Person 11", "Chapel Hill", "TN"));
        Items.Add(new MainPageItemModel("Person 12", "Chapel Hill", "TN"));
        Items.Add(new MainPageItemModel("Person 13", "Chapel Hill", "TN"));
    }

}