using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestBuilders;

public partial class MainPage : ContentPage
{
	int count = 0;

	ObservableCollection<Test> tests = new ObservableCollection<Test>();

	public MainPage()
	{
		InitializeComponent();
        ListTest.ItemsSource = tests;
	}

	private void CreateTest(object sender, EventArgs e)
	{
		
	}

	private void DeleteTest(object sender, EventArgs e)
	{
        var SwItem = sender as SwipeItem;
        var test = SwItem.BindingContext as Test;
		tests.Remove(test);
    }
}


