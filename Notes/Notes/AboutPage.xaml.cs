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
}// Async => bloqueia a thread ("linha" do inglês") principal
// Paralismo ou Programação MultiThread => Sincrono
//Todo método que é assincrono, preciso dizer o que o programa deve aguardar