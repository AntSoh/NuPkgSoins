namespace ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IntervenantExterne : Intervenant
    {
        private string _specialite;

        public string Specialite
        {
            get { return _specialite; }
        }
        private string _adresse;

        public string Adresse
        {
            get { return _adresse; }
            
        }
        private string _tel;

        public string Tel
        {
            get { return _tel; }
           
        }
        ////////////////////////////////

        public IntervenantExterne(string nom, string prenom,string specialite, string adresse, string tel):base(nom, prenom)
        {
            this._specialite = specialite;
            this._adresse = adresse;
            this._tel = tel;
        }
        /// <inheritdoc/>
        public override string ToString()
        {
            return base.ToString() + " Spécialité : " + this.Specialite + "\n\t\t  " + this.Adresse + " - " +this.Tel ;
        }
    }
}
