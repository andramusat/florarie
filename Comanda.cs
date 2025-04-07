using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace florarie
{
    public class Comanda
    {
        private int id;
        private int idProdus;
        private int cantitate;
        private string numeClient;
        private string prenumeClient;
        private string telefonContact;
        private string metodaPlata;

        public Comanda() { }
        public Comanda(int id, int idProdus, int cantitate, string numeClient, string prenumeClient, string telefonContact, string metodaPlata)
        {
            this.id = id;
            this.idProdus = idProdus;
            this.cantitate = cantitate;
            this.numeClient = numeClient;
            this.prenumeClient = prenumeClient;
            this.telefonContact = telefonContact;
            this.metodaPlata = metodaPlata;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdProdus
        {
            get { return idProdus; }
            set { idProdus = value; } 
        }
        public int Cantitate
        {
            get { return cantitate; }
            set { cantitate = value; } 
        }
        public string NumeClient 
        {
            get { return numeClient; }
            set { numeClient = value; }
        }
        public string PrenumeClient 
        {
            get { return prenumeClient; }
            set { prenumeClient = value; }
        }
        public string TelefonContact 
        {
            get { return telefonContact; }
            set { telefonContact = value; }
        }
        public string MetodaPlata 
        {
            get { return metodaPlata; }
            set { metodaPlata = value; }
        }

        
    }
}
