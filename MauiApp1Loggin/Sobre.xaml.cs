namespace MauiApp1Loggin;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private async void btn_desconectar_Clicked(object sender, EventArgs e)
    {
		bool confirmacao = await DisplayAlert("Desconectar", "Tem certeza?", "Sim", "Não");
		if(confirmacao)
		{
			App.Current.MainPage = new Login();
		}
    }
}