using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet0001.Modeles
{
    public class Produit
    {
        #region attributs

        private string nom;
        private string prenom;

        #endregion

        #region contructeurs
        public Produit(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        #endregion

        #region getters/setters


        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        #endregion

        #region methodes

       public string ConcatNomPrenom()
        {  
            return this.nom + " " + this.prenom;
        }

        #endregion
    }
}
