using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MauiAppCenter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		AppCenter.Start("android=\"c86d8086-5d05-4934-92ec-983860f15d13\"", typeof(Analytics), typeof(Crashes));

		MainPage = new AppShell();
	}
}
