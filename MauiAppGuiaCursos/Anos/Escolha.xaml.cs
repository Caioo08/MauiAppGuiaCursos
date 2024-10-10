namespace MauiAppGuiaCursos.Anos;

public partial class Escolha : ContentPage
{
	public Escolha()
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
            DisplayAlert("N�o encontrado", ex.Message, "OK");
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
            DisplayAlert("N�o encontrado", ex.Message, "OK");
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
            DisplayAlert("N�o encontrado", ex.Message, "OK");
        }
    }
}