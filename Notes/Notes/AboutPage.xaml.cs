namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();

		
	}

	private async void LearMore_Clicked(object sender, EventArgs e)
	{
		await Launcher.Default.OpenAsync("https://www.google.com.br");

	}
}// Async => bloqueia a thread ("linha" do ingl�s") principal
// Paralismo ou Programa��o MultiThread => Sincrono
//Todo m�todo que � assincrono, preciso dizer o que o programa deve aguardar