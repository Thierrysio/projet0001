using projet0001.Modeles;
using System.Collections.ObjectModel;

namespace projet0001.Vues;

public partial class VueProduit : ContentPage
{
    // Déclaration publique pour le binding
    public ObservableCollection<Produit> Items { get; } = new ObservableCollection<Produit>();

    public VueProduit()
    {
        InitializeComponent();
        BindingContext = this;

        // Création des produits
        Produit P1 = new Produit("Disney", "riri");
        Produit P2 = new Produit("Disney", "fifi");
        Produit P3 = new Produit("Disney", "loulou");

        Items.Add(P1);
        Items.Add(P2);
        Items.Add(P3);

        l1.Text = P1.ConcatNomPrenom();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        string res = E1.Text;
        l1.Text = res;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        int nbre1 = int.Parse(N1.Text);
        int nbre2 = int.Parse(N2.Text);
        int resultat = nbre1 + nbre2;
        LResultat.Text = resultat.ToString();
    }
}
