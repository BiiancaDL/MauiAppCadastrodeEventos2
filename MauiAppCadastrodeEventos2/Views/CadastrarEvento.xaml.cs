using MauiAppCadastrodeEventos2.Models;

namespace MauiAppCadastrodeEventos2.Views
{
    public partial class CadastrarEvento : ContentPage
    {
        private Evento evento;

        public CadastrarEvento()
        {
            InitializeComponent();

            evento = new Evento
            {
                DataInicio = DateTime.Now,  // Define a data atual para DataInicio
                DataTermino = DateTime.Now  // Define a data atual para DataTermino
            };

            BindingContext = evento;
        }

        private async void Button_Clicked_four(object sender, EventArgs e)
        {
            // Navega para a próxima página e passa o objeto evento
            await Navigation.PushAsync(new EventoCadastrado(evento));
        }

        private async void Button_Clicked_five(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

