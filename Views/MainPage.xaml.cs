using bebrewery.ViewModels;

namespace bebrewery;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
    private void OnBotaoClicado(object sender, EventArgs e)
    {
        if (BindingContext is MainPageViewModel vm)
        {
            vm.Incrementar();
        }
    }
    private async void OnIrParaLeveduraPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.LeveduraPage());
    }
}