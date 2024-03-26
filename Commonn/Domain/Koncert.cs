using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commonn.Domain
{
    [Serializable]
    public class Koncert : IEntity
    {
        public int KoncertId { get; set; }
        public string Adresa { get; set; }
        public int Kapacitet { get; set; }
        public TipKoncerta TipKoncerta { get; set; }
        public Grad Grad { get; set; }
        public string TableName => "Koncert";

        public string DisplayValue => " ";

        public string PrimaryKey => "KoncertId";

        public string GetByIDQuery()
        {
            return $"KoncertId={KoncertId}";
        }
        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                Koncert koncert = new Koncert
                {
                    KoncertId = (int)reader["KoncertId"],
                    Adresa = (string)reader["Adresa"],
                    TipKoncerta = (TipKoncerta)Enum.Parse(typeof(TipKoncerta), (string)reader["TipKoncerta"]),
                    Kapacitet = (int)reader["Kapacitet"]
                };
                if (reader["Grad"] != DBNull.Value)
                {
                    Grad grad = new Grad()
                    {
                        GradId = (int)reader["GradId"],
                        NazivGrada = (string)reader["Naziv"],
                    };
                    koncert.Grad = grad;
                }
                else koncert.Grad = null;
                return koncert;
            }
            else return null;
        }


        public string GetFilterQuery(string filter)
        {
            return $"LOWER(Adresa) LIKE CONCAT('%',LOWER('{filter}'),'%');";
        }

        public string GetParametres()
        {
            return "@Adresa,@Kapacitet,@TipKoncerta,@GradId";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Koncert koncert = new Koncert()
                {
                    KoncertId = (int)reader["KoncertId"],
                    Adresa = (string)reader["Adresa"],
                    Kapacitet = (int)reader["Kapacitet"]
                };
                if (reader["Grad"] != DBNull.Value)
                {
                    Grad grad = new Grad()
                    {
                        GradId = (int)reader["GradId"],
                        NazivGrada = (string)reader["Naziv"],
                    };
                    koncert.Grad = grad;
                }
                else koncert.Grad = null;
                entities.Add(koncert);
            }
            return entities;
        }

        public string GetSearchAttributes()
        {
            //k.KoncertId,k.Adresa,k.Kapacitet,k.GradId as Grad,g.Naziv
            return $"*";
        }

        public string JoinQuery()
        {
            return "k JOIN Grad g ON k.GradId=g.GradId";
        }

        public void PrepareCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Adresa", Adresa);
            cmd.Parameters.AddWithValue("@TipKoncerta", TipKoncerta.ToString());
            if (Grad != null) cmd.Parameters.AddWithValue("@GradId", Grad.GradId);
            else cmd.Parameters.AddWithValue("@GradId", DBNull.Value);
            cmd.Parameters.AddWithValue("@Kapacitet", Kapacitet);
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Grad grad = new Grad()
                {
                    GradId = (int)reader[5],
                    NazivGrada = (string)reader["Naziv"],
                };
                Koncert koncert = new Koncert()
                {
                    KoncertId = (int)reader["KoncertId"],
                    Adresa = (string)reader["Adresa"],
                    TipKoncerta = (TipKoncerta)Enum.Parse(typeof(TipKoncerta), (string)reader["TipKoncerta"].ToString()),
                    Kapacitet = (int)reader["Kapacitet"],
                    Grad = grad,
                };
                entities.Add(koncert);
            };
            return entities;
        }

        public string UpdateQuery()
        {
            string grad = Grad == null ? "" : $",GradId = '{Grad.GradId}'";
            return $"Adresa='{Adresa}',Kapacitet='{Kapacitet}'" + grad;
        }
        public override string ToString()
        {
            return Adresa;
        }
    }
}
