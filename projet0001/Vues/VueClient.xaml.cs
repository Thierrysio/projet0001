using projet0001.Modeles;
using System.Collections.ObjectModel;

namespace projet0001.Vues;

public partial class VueClient : ContentPage
{
    public ObservableCollection<Client> Clients { get; } = new ObservableCollection<Client>();

    public VueClient()
	{
		InitializeComponent();
		BindingContext = this;
		Clients.Add(new Client("TOTO", "https://c8.alamy.com/compfr/r1adk8/etudiant-diplome-teen-girl-r1adk8.jpg"));
        Clients.Add(new Client("TITI", "https://c8.alamy.com/compfr/r1adk8/etudiant-diplome-teen-girl-r1adk8.jpg"));
        Clients.Add(new Client("TUTU", "https://c8.alamy.com/compfr/r1adk8/etudiant-diplome-teen-girl-r1adk8.jpg"));
    }
}