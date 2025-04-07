using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace florarie
{
    [Serializable]
    public class Produs
    {
        private int id;
        private string denumire;
        private string descriere;
        private double pret;
        private string producator;

        public Produs() { }

        public Produs(int id, string denumire, string descriere, double pret, string producator)
        {
            this.id = id;
            this.denumire = denumire;
            this.descriere = descriere;
            this.pret = pret;
            this.producator = producator;
        }

        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        public string Denumire 
        {  
            get { return denumire; } 
            set { denumire = value; } 
        }
        public string Descriere 
        {
            get { return descriere; }
            set { descriere = value; }
        }
        public double Pret
        {
            get { return pret; }
            set { pret = value; }
        }
        public string Producator
        {
            get { return producator; }
            set { producator = value; } 
        }
        
    }
}
