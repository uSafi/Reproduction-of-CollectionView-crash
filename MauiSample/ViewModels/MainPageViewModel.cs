using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiSample.ViewModels;

public partial class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    public ObservableCollection<Person> _people;

    [ObservableProperty]
    string _entryText;
    public MainPageViewModel()
    {
        People = new ObservableCollection<Person>();

        var names = new List<string> { "Tim", "Jakson", "Carl", "Violet", "Sarah", "Michael", "Emma", "Olivia", "Ava", "Isabella" }; ;
        var random = new Random();

        for (int i = 0; i < 20; i++)
        {
            int index = random.Next(0, names.Count);
            People.Add(new Person { Name = names[index] });
        }
    }
}
