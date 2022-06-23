using MauiApp1.Pages;

namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Current.UserAppTheme = AppTheme.Light;

#if WINDOWS || MACCATALYST
		MainPage = new DesktopShell();
#else
		MainPage = new MobileShell();
#endif
	}
}
