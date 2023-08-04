using TaskerDemo.Views;

namespace TaskerDemo;

public partial class App : Application
{
	public App(MainView mainView)
	{
		InitializeComponent();

		MainPage = new NavigationPage(mainView);
	}
}
