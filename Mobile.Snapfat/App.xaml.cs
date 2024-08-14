namespace Mobile.Snapfat;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new MasterView();
	}
}
