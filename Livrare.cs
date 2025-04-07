using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace florarie
{
    public class Livrare
    {
        private int id;
        private int idComanda;
        private string adresaLivrare;
        private string firmaCurierat;
        private DateTime dataEstimataDeLivrare;

        public Livrare() { }

        public Livrare(int id, int idComanda, string adresaLivrare, string firmaCurierat, DateTime dataEstimataDeLivrare)
        {
            this.id = id;
            this.idComanda = idComanda;
            this.AdresaLivrare = adresaLivrare;
            this.FirmaCurierat = firmaCurierat;
            this.DataEstimataDeLivrare = dataEstimataDeLivrare;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdComanda 
        {
            get { return idComanda; }
            set { idComanda = value; }
        }
        public string AdresaLivrare 
        {
            get { return adresaLivrare; }
            set { adresaLivrare = value; }
        }
        public string FirmaCurierat
        {
            get { return firmaCurierat; }
            set { firmaCurierat = value; }
        }
        public DateTime DataEstimataDeLivrare 
        {
            get { return dataEstimataDeLivrare; }
            set { dataEstimataDeLivrare = value; }
        }
    }
}
