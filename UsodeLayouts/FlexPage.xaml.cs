using System.Threading.Tasks;

namespace UsodeLayouts;

public partial class FlexPage : ContentPage
{
	public FlexPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new AbsolutePage());
    }
}