namespace MauiApp1Loggin;

public partial class Protegida : ContentPage
{
	public Protegida()
	{
		InitializeComponent();
		string? usuario_logado = null;

		Task.Run(async () =>
		{
			usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");
			lbl_boasvindas.Text = $"Bem vindo (a) {usuario_logado}";
		});
	}

	private async void btn_desconectar_Clicked(object sender, EventArgs e)
	{
		bool confirmacao = await DisplayAlert("Tem certeza?", "Sair do App?", "Sim", "Não");

		if (confirmacao)
		{
			SecureStorage.Default.Remove("usuario_logado");
			App.Current.MainPage = new Login();
		}
	}
}