using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantator.Views;

public partial class AddPlant : ContentPage
{
    public AddPlant()
    {
        InitializeComponent();
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

}