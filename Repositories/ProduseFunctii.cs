using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace florarie.Repositories
{
    public class ProduseFunctii
    {
        public BindingList<Produs> GetAll()
        {
            BindingList<Produs> produse = new BindingList<Produs>();

            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "SELECT * FROM produse_c# ORDER BY id";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Produs produs = new Produs();
                        produs.Id = int.Parse(reader["id"].ToString());
                        produs.Denumire = reader["denumire"].ToString();
                        produs.Descriere = reader["descriere"].ToString();
                        produs.Pret = double.Parse(reader["pret"].ToString());
                        produs.Producator = reader["producator"].ToString();
                        produse.Add(produs);
                    }
                }
                conn.Close();
            }
                return produse;
        }
        public void AdaugaProdus(Produs produs)
        {
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "INSERT INTO produse_c# (id, denumire, descriere, pret, producator) VALUES (:id, :denumire, :descriere, :pret, :producator)";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    comm.Parameters.Add("id", OracleDbType.Int64).Value = produs.Id;
                    comm.Parameters.Add("denumire", OracleDbType.Varchar2).Value = produs.Denumire.ToString();
                    comm.Parameters.Add("descriere", OracleDbType.Varchar2).Value = produs.Descriere.ToString();
                    comm.Parameters.Add("pret", OracleDbType.Double).Value = produs.Pret;
                    comm.Parameters.Add("producator", OracleDbType.Varchar2).Value = produs.Producator.ToString();
                    int adaugare = comm.ExecuteNonQuery();
                    Console.WriteLine($"{adaugare} rând a fost adăugat.");
                }
                conn.Close();
            }
        }
        public void ModificaProdus(Produs produs)
        {
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "UPDATE produse_c# SET denumire = :denumire , descriere = :descriere , pret = :pret , producator = :producator WHERE id = :id";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    comm.Parameters.Add("denumire", OracleDbType.Varchar2).Value = produs.Denumire.ToString();
                    comm.Parameters.Add("descriere", OracleDbType.Varchar2).Value = produs.Descriere.ToString();
                    comm.Parameters.Add("pret", OracleDbType.Double).Value = produs.Pret;
                    comm.Parameters.Add("producator", OracleDbType.Varchar2).Value = produs.Producator.ToString();
                    comm.Parameters.Add("id", OracleDbType.Int64).Value = produs.Id;
                    int editare = comm.ExecuteNonQuery();
                    Console.WriteLine($"{editare} rând a fost editat.");
                }
                conn.Close();
            }
        }
        public void StergeProdus(Produs produs)
        {
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "DELETE FROM produse_c# WHERE id = :id";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    comm.Parameters.Add("id", OracleDbType.Int64).Value = produs.Id;
                    int stergere = comm.ExecuteNonQuery();
                    Console.WriteLine($"{stergere} rând a fost șters.");
                }
            }
        }
        public int getMaxID()
        {
            int id = -1;
            using (OracleConnection conn = new OracleConnection(" ")) //my data source connection
            {
                conn.Open();
                string sql = "SELECT MAX(id) FROM produse_c#";
                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    id = int.Parse(comm.ExecuteScalar().ToString());
                }
            }
            return id;
        }
    }
}
