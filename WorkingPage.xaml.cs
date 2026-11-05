namespace LineGeometryCrash;

public partial class WorkingPage : ContentPage
{
	public WorkingPage()
	{
		InitializeComponent();
	}

  private async void ReturnBtn_Clicked(object sender, EventArgs e)
  {
		await Navigation.PopAsync();
  }
}