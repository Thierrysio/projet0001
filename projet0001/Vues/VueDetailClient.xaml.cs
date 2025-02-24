using projet0001.Modeles;

namespace projet0001.Vues;

public partial class VueDetailClient : ContentPage
{
	public VueDetailClient(Client leClient)
	{
		InitializeComponent();
		BindingContext = this;

		L1.Text = leClient.Pseudo;
		I1.Source = leClient.Url;
	}
}