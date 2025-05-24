using System.Threading.Tasks;

namespace UsodeLayouts;

public partial class StackPage : ContentPage
{
	public StackPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new FlexPage());
    }
}