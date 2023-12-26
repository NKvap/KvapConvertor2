using KvapConvertor;

namespace KvapConvertor;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new ConverterMainViewModel();
	}
}

