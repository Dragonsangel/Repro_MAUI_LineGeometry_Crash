namespace LineGeometryCrash;

public partial class MainPage : ContentPage
{
  public MainPage()
  {
    InitializeComponent();
  }

  private async void WorkingBtn_Clicked(object sender, EventArgs e)
  {
    await Navigation.PushAsync(new WorkingPage());
  }

  private async void BrokenBtn_Clicked(object sender, EventArgs e)
  {
    await Navigation.PushAsync(new BrokenPage());
  }
}
