using System.Linq.Expressions;

namespace MauiAppCadastrodeEventos2.Views;

public partial class SobreNos : ContentPage
{
    public SobreNos()
    {
        InitializeComponent();
    }

    private void Button_Clicked_two(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}