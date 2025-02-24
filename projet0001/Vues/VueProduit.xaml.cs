using projet0001.Modeles;

namespace projet0001.Vues;

public partial class VueProduit : ContentPage
{
	public VueProduit()
	{
		InitializeComponent();
		Produit P1 = new Produit("Disney","riri");

        l1.Text = P1.ConcatNomPrenom();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		string res = E1.Text;
		l1.Text = res;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        string nb1 = N1.Text;
        string nb2 = N2.Text;
        int nbre1 = int.Parse(nb1);
        int nbre2 = int.Parse(nb2);
        int resultat = nbre1 + nbre2;
        LResultat.Text = resultat.ToString();
    }
}