using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace florarie.Repositories
{
    public class LivrariFunctii
    {
        public BindingList<Livrare> getAll()
        {
            BindingList<Livrare> livrari = new BindingList<Livrare>();
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "SELECT * FROM livrari_c# ORDER BY id";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Livrare livrare = new Livrare();
                        livrare.Id = int.Parse(reader["id"].ToString());
                        livrare.IdComanda = int.Parse(reader["id_comanda"].ToString());
                        livrare.AdresaLivrare = reader["adresa_livrare"].ToString();
                        livrare.FirmaCurierat = reader["firma_curierat"].ToString();
                        livrare.DataEstimataDeLivrare = DateTime.Parse(reader["data_livrare"].ToString());
                        livrari.Add(livrare);
                    }
                }
                conn.Close();
            }
            Console.WriteLine(livrari.Count);
            return livrari;
        }
        public void AdaugaLivrare(Livrare livrare)
        {
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "INSERT INTO livrari_c# (id, id_comanda, adresa_livrare, firma_curierat, data_livrare) VALUES (:id, :id_comanda, :adresa_livrare, :firma_curierat, :data_livrare)";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    comm.Parameters.Add("id", OracleDbType.Int64).Value = livrare.Id;
                    comm.Parameters.Add("id_comanda", OracleDbType.Int64).Value = livrare.IdComanda;
                    comm.Parameters.Add("adresa_livrare", OracleDbType.Varchar2).Value = livrare.AdresaLivrare;
                    comm.Parameters.Add("firma_curierat", OracleDbType.Varchar2).Value = livrare.FirmaCurierat;
                    comm.Parameters.Add("data_livrare", OracleDbType.Varchar2).Value = livrare.DataEstimataDeLivrare.ToString();


                    int adaugare = comm.ExecuteNonQuery();
                    Console.WriteLine($"{adaugare} rând a fost adăugat.");
                }
                conn.Close();
            }
        }
        public void EditeazaLivrare(Livrare livrare)
        {
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "UPDATE livrari_c# SET id_comanda = :id_comanda, adresa_livrare = :adresa_livrare, firma_curierat = :firma_curierat, " +
                   "data_livrare = :data_livrare WHERE id = :id";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    comm.Parameters.Add("id_comanda", OracleDbType.Int64).Value = livrare.IdComanda;
                    comm.Parameters.Add("adresa_livrare", OracleDbType.Varchar2).Value = livrare.AdresaLivrare;
                    comm.Parameters.Add("firma_curierat", OracleDbType.Varchar2).Value = livrare.FirmaCurierat;
                    comm.Parameters.Add("data_livrare", OracleDbType.Varchar2).Value = livrare.DataEstimataDeLivrare.ToString();
                    comm.Parameters.Add("id", OracleDbType.Int64).Value = livrare.Id;

                    int editare = comm.ExecuteNonQuery();
                    Console.WriteLine($"{editare} rând a fost editat.");
                }
                conn.Close();
            }
        }
        public void StergeLivrare(Livrare livrare)
        {
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "DELETE FROM livari_c# WHERE id = :id";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    comm.Parameters.Add("id", OracleDbType.Int64).Value = livrare.Id;
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
                string sql = "SELECT MAX(id) FROM livrari_c#";
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
