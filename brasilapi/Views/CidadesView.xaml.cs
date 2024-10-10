using brasilapi.ViewModels;
namespace brasilapi.Views;

public partial class CidadesView : ContentPage
{
	public CidadesView()
	{
		InitializeComponent();
		BindingContext = new CidadeViewModel();
	}
}