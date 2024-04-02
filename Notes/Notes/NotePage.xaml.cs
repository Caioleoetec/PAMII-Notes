
namespace Notes;

public partial class NotePage : ContentPage
{
    string _filepath = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");//  "_" indica que pode ser nulo File
	public NotePage()
	{
		InitializeComponent();
        //Null
        if (File.Exists(_filepath))
        {
            TextEditor.Text = File.ReadAllText(_filepath);
        }
	}

    private async void SaveBtn_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(_filepath, TextEditor.Text);
        await DisplayAlert("Sucesso", "Arquivo criado com sucesso", "Ok");
    }

    private async void DeleteBtn_Clicked(object sender, EventArgs e)
    {
        if(File.Exists(_filepath))
        {
            File.Delete(_filepath);
            await DisplayAlert("Sucesso", "Arquivo deletado com sucesso", "Ok");
            TextEditor.Text = "";

        }
        else
        {
            await DisplayAlert("Arquivo não encontrado", "Nenhum arquivo foi encontrado", "Ok");
        }
    }
}