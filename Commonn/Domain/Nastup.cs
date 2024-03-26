using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commonn.Domain
{
    [Serializable]
    public class Nastup : IEntity
    {
        [Browsable(false)]
        public int IdNastupa { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public int CenaUlaznice { get; set; } = -1;
        public int RBTacke { get; set; }
        public MuzickaGrupa MuzickaGrupa { get; set; }
        public Koncert Koncert { get; set; }
        [Browsable(false)]
        public string TableName => "Nastup";
        [Browsable(false)]
        public string DisplayValue => DatumOdrzavanja.Date.ToString();
        [Browsable(false)]
        public string PrimaryKey => "NastupId,GrupaId,KoncertId";

        public string GetByIDQuery()
        {
            return $"NastupId={IdNastupa}";
        }
        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                Nastup nastup = new Nastup()
                {
                    IdNastupa = (int)reader["NastupId"],
                    CenaUlaznice = (int)reader["CenaUlaznice"],
                    DatumOdrzavanja = (DateTime)reader["DatumOdrzavanja"],
                    RBTacke = (int)reader["RBTacke"],
                };
                return nastup;
            }
            return null;
        }

        public string GetFilterQuery(string filter)
        {
            return $"n.DatumOdrzavanja LIKE CONCAT('%',LOWER('-{filter}-'),'%');";
        }

        public string GetParametres()
        {
            return "@KoncertId,@GrupaId,@DatumOdrzavanja,@CenaUlaznice,@RBTacke";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Nastup nastup = new Nastup()
                {
                    IdNastupa = (int)reader["NastupId"],
                    CenaUlaznice = (int)reader["CenaUlaznice"],
                    DatumOdrzavanja = (DateTime)reader["DatumOdrzavanja"],
                    RBTacke = (int)reader["RBTacke"],
                };
                if (reader["GrupaId"] != DBNull.Value)
                {
                    MuzickaGrupa mg = new MuzickaGrupa()
                    {
                        GrupaId = (int)reader["GrupaId"],
                        Naziv = (string)reader["Naziv"],
                        Scenograf = (string)reader["Scenograf"]
                    };
                    nastup.MuzickaGrupa = mg;
                }
                else nastup.MuzickaGrupa = null;
                if (reader["KoncertId"] != DBNull.Value)
                {
                    Koncert k = new Koncert()
                    {
                        KoncertId = (int)reader["KoncertId"],
                        Adresa = (string)reader["Adresa"],
                        Kapacitet = (int)reader["Kapacitet"],
                    };
                    nastup.Koncert = k;
                }
                else nastup.Koncert = null;
                entities.Add(nastup);
            }
            return entities;
        }
        public string GetSearchAttributes()
        {
            //n.NastupId, n.DatumOdrzavanja, n.CenaUlaznice, n.GrupaId as MuzickaGrupa, n.KoncertId as Koncert, mg.Naziv as NazivMuzickeGrupe, mg.RBTacke, mg.Scenograf, k.Adresa, k.Kapacitet
            return $"*";
        }

        public string JoinQuery()
        {
            return "n JOIN MuzickaGrupa mg ON n.GrupaId=mg.GrupaId left join Koncert k on n.KoncertId=k.KoncertId";
        }

        public void PrepareCommand(SqlCommand cmd)
        {
            if (Koncert != null) cmd.Parameters.AddWithValue("@KoncertId", Koncert.KoncertId);
            else cmd.Parameters.AddWithValue("@KoncertId", DBNull.Value);
            if (MuzickaGrupa != null) cmd.Parameters.AddWithValue("@GrupaId", MuzickaGrupa.GrupaId);
            else cmd.Parameters.AddWithValue("@GrupaId", DBNull.Value);
            cmd.Parameters.AddWithValue("@DatumOdrzavanja", DatumOdrzavanja);
            cmd.Parameters.AddWithValue("@CenaUlaznice", CenaUlaznice);
            cmd.Parameters.AddWithValue("@RBTacke", RBTacke);

        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Nastup nastup = new Nastup()
                {
                    IdNastupa = (int)reader["NastupId"],
                    CenaUlaznice = (int)reader["CenaUlaznice"],
                    DatumOdrzavanja = (DateTime)reader["DatumOdrzavanja"],
                    RBTacke = (int)reader["RBTacke"],
                };
                if (reader["GrupaId"] != DBNull.Value)
                {
                    MuzickaGrupa mg = new MuzickaGrupa()
                    {
                        GrupaId = (int)reader[2],
                        Naziv = (string)reader["Naziv"],
                        Scenograf = (string)reader["Scenograf"]
                    };
                    nastup.MuzickaGrupa = mg;
                }
                else nastup.MuzickaGrupa = null;
                if (reader["KoncertId"] != DBNull.Value)
                {
                    Koncert k = new Koncert()
                    {
                        KoncertId = (int)reader[1],
                        Adresa = (string)reader["Adresa"],
                        Kapacitet = (int)reader["Kapacitet"],
                    };
                    nastup.Koncert = k;
                }
                else nastup.Koncert = null;
                entities.Add(nastup);
            }
            return entities;
        }
        public string UpdateQuery()
        {
            string cena = CenaUlaznice.ToString() == "-1" ? "" : $",CenaUlaznice = '{CenaUlaznice}'";
            return $"DatumOdrzavanja='{DatumOdrzavanja.ToString("yyyy-MM-dd")}',RBTacke={RBTacke}" + cena;
        }
    }
}
