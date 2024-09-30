

namespace MauiAppGuiaCursos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Primeiro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Anos.Primeiro());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Segundo_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Anos.Segundo());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Terceiro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Anos.Terceiro());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }
    }

}
