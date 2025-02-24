using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet0001.Modeles
{
    public class Client
    {
        #region attributs
        private string pseudo;
        private string url;
        #endregion
        #region constructeurs
        public Client(string pseudo, string url)
        {
            this.pseudo = pseudo;
            this.url = url;
        }
        #endregion
        #region getters setters
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Url { get => url; set => url = value; }
        #endregion
        #region methodes
        #endregion
    }
}
