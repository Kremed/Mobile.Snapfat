global using Mobile.Snapfat.Views;
global using Mobile.Snapfat.Models;
global using Mobile.Snapfat.ViewModels;

namespace Mobile.Snapfat;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Matemasie-Regular.ttf", "Mate");
				fonts.AddFont("Roboto-Bold.ttf", "Bold");
				fonts.AddFont("Roboto-Light.ttf", "Light");
				fonts.AddFont("Roboto-Regular.ttf", "Regular");
			});
		builder.Services.AddSingleton<MasterView>();
		builder.Services.AddSingleton<MasterViewModel>();

		return builder.Build();
	}
}
