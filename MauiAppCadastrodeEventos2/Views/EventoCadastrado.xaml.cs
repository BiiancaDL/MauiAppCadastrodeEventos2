using MauiAppCadastrodeEventos2.Models;

namespace MauiAppCadastrodeEventos2.Views
{
    public partial class EventoCadastrado : ContentPage
    {
        public EventoCadastrado(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }

        private async void Button_Clicked_three(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }
}
