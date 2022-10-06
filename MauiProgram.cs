using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MauiAppCenter;

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
			});

		AppCenter.Start(
			"android=c86d8086-5d05-4934-92ec-983860f15d13;" +
            "ios=80387b76-f8b5-474f-8c1f-6bfd47639b09;" +
            "windowsdesktop=6c5566b4-11e8-4dbc-affc-5e2c605e557c", 
			typeof(Analytics), typeof(Crashes));

		return builder.Build();
	}
}
