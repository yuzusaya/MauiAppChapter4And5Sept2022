namespace MauiApp1.Views;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
	{
		InitializeComponent();
		collectionView.ItemsSource=new List<object>()
        {
			new{Name="test"},
			new{Name="test2"},
			new{Name="test3"},
			new{Name="test4"},
			new{Name="test2"},
			new{Name="test2"},
			new{Name="test2"},
			new{Name="test2"},
			new{Name="test2"},
			new{Name="test2"},
        };
	}

    private void CollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        throw new NotImplementedException();
    }
}