using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace florarie.Repositories
{
    public class ComenziFunctii
    {
        public BindingList<Comanda> getAll()
        {
            BindingList<Comanda> comenzi = new BindingList<Comanda>();
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "SELECT * FROM comenzi_c# ORDER BY id";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Comanda comanda = new Comanda();
                        comanda.Id = int.Parse(reader["id"].ToString());
                        comanda.IdProdus = int.Parse(reader["id_produs"].ToString());
                        comanda.Cantitate = int.Parse(reader["cantitate"].ToString());
                        comanda.NumeClient = reader["nume_client"].ToString();
                        comanda.PrenumeClient = reader["prenume_client"].ToString();
                        comanda.TelefonContact = reader["telefon_contact"].ToString();
                        comanda.MetodaPlata = reader["metoda_plata"].ToString();
                        comenzi.Add(comanda);
                    }
                }
                conn.Close();
            }
            return comenzi;
        }
        public void AdaugaComanda(Comanda comanda)
        {
            using (OracleConnection conn = new OracleConnection("")) //my data source connection
            {
                conn.Open();
                string sql = "INSERT INTO comenzi_c# (id, id_produs, cantitate, nume_client, prenume_client, telefon_contact, metoda_plata) VALUES (:id, :id_produs, :cantitate, :nume_client, :prenume_client, :telefon_contact, :metoda_plata)";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    comm.Parameters.Add("id", OracleDbType.Int64).Value = comanda.Id;
                    comm.Parameters.Add("id_produs", OracleDbType.Int64).Value = comanda.IdProdus;
                    comm.Parameters.Add("cantitate", OracleDbType.Varchar2).Value = comanda.Cantitate.ToString();
                    comm.Parameters.Add("nume_client", OracleDbType.Varchar2).Value = comanda.NumeClient.ToString();
                    comm.Parameters.Add("prenume_client", OracleDbType.Varchar2).Value = comanda.PrenumeClient.ToString();
                    comm.Parameters.Add("telefon_contact", OracleDbType.Varchar2).Value = comanda.TelefonContact.ToString();
                    comm.Parameters.Add("metoda_plata", OracleDbType.Varchar2).Value = comanda.MetodaPlata.ToString();

                    int adaugare = comm.ExecuteNonQuery();
                    Console.WriteLine($"{adaugare} rând a fost adăugat.");
                }
                conn.Close();
            }
        }
        public void EditeazaComanda(Comanda comanda)
        {
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "UPDATE comenzi_c# SET id_produs = :id_produs, cantitate = :cantitate, nume_client = :nume_client, " +
                    "prenume_client = :prenume_client, telefon_contact = :telefon_contact, metoda_plata = :metoda_plata WHERE id = :id";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    comm.Parameters.Add("id_produs", OracleDbType.Int64).Value = comanda.IdProdus;
                    comm.Parameters.Add("cantitate", OracleDbType.Varchar2).Value = comanda.Cantitate.ToString();
                    comm.Parameters.Add("nume_client", OracleDbType.Varchar2).Value = comanda.NumeClient.ToString();
                    comm.Parameters.Add("prenume_client", OracleDbType.Varchar2).Value = comanda.PrenumeClient.ToString();
                    comm.Parameters.Add("telefon_contact", OracleDbType.Varchar2).Value = comanda.TelefonContact.ToString();
                    comm.Parameters.Add("metoda_plata", OracleDbType.Varchar2).Value = comanda.MetodaPlata.ToString();
                    comm.Parameters.Add("id", OracleDbType.Int64).Value = comanda.Id;
                    int editare = comm.ExecuteNonQuery();
                    Console.WriteLine($"{editare} rând a fost editat.");
                }
                conn.Close();
            }
        }
        public void StergeComanda(Comanda comanda)
        {
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "DELETE FROM comenzi_c# WHERE id = :id";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    comm.Parameters.Add("id", OracleDbType.Int64).Value = comanda.Id;
                    int stergere = comm.ExecuteNonQuery();
                    Console.WriteLine($"{stergere} rând a fost șters.");
                }
            }
        }
        public int getMaxID()
        {
            int id = 0;
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "SELECT MAX(id) FROM comenzi_c#";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    var result = comm.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        id = Convert.ToInt32(result);

                    }
                    conn.Close();
                }
                return id;
            }
        }
    }
}
