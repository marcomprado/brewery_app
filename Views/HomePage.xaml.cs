namespace bebrewery.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnNovaReceitaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NovaReceitaPage());
    }

    private async void OnGerenciarReceitasClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DiretorioReceitasPage());
    }
}