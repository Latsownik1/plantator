using Plantator.Views;

namespace Plantator;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(AddPlant), typeof(AddPlant));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}
