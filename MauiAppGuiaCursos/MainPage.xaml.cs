

namespace MauiAppGuiaCursos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Anos.Escolha());
            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }

}
