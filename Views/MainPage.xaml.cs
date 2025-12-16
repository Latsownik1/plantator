namespace Plantator.Views;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }
    private async void OnAddPlantClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddPlant));
    }


   
}