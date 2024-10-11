namespace MauiAppGuiaCursos.Anos;

public partial class Segundo : ContentPage
{
	public Segundo()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        text1.IsVisible = !text1.IsVisible;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        text2.IsVisible = !text2.IsVisible;
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        text3.IsVisible = !text3.IsVisible;
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        text4.IsVisible = !text4.IsVisible;
    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {
        text5.IsVisible = !text5.IsVisible;
    }

}