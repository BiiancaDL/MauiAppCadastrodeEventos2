namespace MauiAppCadastrodeEventos2.Views;

public partial class TelaInicial : ContentPage
{
    public TelaInicial()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new CadastrarEvento());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void Button_Clicked_two(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new SobreNos());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
