using System.Threading.Tasks;

namespace UsodeLayouts;

public partial class AbsolutePage : ContentPage
{
	public AbsolutePage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridPage());
    }

}