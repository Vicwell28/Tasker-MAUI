using TaskerDemo.ViewModels;

namespace TaskerDemo.Views;

public partial class MainView : ContentPage
{
	private readonly MainViewModel viewModel;
	public MainView(MainViewModel MainViewModel)
	{
		InitializeComponent();
		viewModel = MainViewModel;
		this.BindingContext = viewModel; 
	}

	private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		viewModel.UpdateData();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		var taskView = new NewTaskView
		{
			BindingContext = new NewTaskViewModel
			{
				Tasks = viewModel.Tasks,
				Categories = viewModel.Categories,
			}
		};

		Navigation.PushAsync(taskView);
	}
}