namespace LineGeometryCrash;

public partial class BrokenPage : ContentPage
{
	public BrokenPage()
	{
		InitializeComponent();
	}

  private async void ReturnBtn_Clicked(object sender, EventArgs e)
  {
    await Navigation.PopAsync();
  }
}