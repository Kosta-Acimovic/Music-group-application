using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Commonn.Domain
{
    [Serializable]
    public class Izvodjac : IEntity
    {
        [Browsable(false)]
        public int IzvodjacId { get; set; }
        public string ImeIzvodjaca { get; set; }
        public string PrezimeIzvodjaca { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int BrojNastupa { get; set; }
        public MuzickaGrupa MuzickaGrupa { get; set; }
        [Browsable(false)]
        public string TableName => "Izvodjac";
        [Browsable(false)]
        public string DisplayValue => ImeIzvodjaca + " " + PrezimeIzvodjaca;
        [Browsable(false)]
        public string PrimaryKey => "IzvodjacId";

        public string GetByIDQuery()
        {
            return $"IzvodjacId={IzvodjacId}";
        }
        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                MuzickaGrupa muzickaGrupa = new MuzickaGrupa();
                muzickaGrupa.GrupaId = (int)reader["GrupaId"];
                muzickaGrupa.Naziv = (string)reader["naziv"];
                muzickaGrupa.Scenograf = (string)reader["scenograf"];
                return new Izvodjac
                {
                    IzvodjacId = (int)reader["IzvodjacId"],
                    ImeIzvodjaca = (string)reader["ImeIzvodjaca"],
                    PrezimeIzvodjaca = (string)reader["PrezimeIzvodjaca"],
                    DatumRodjenja = (DateTime)reader["DatumRodjenja"],
                    BrojNastupa = (int)reader["BrojNastupa"],
                    MuzickaGrupa = muzickaGrupa,
                };
            }
            else return null;
        }

        public string GetFilterQuery(string filter)
        {
            return $"LOWER(ImeIzvodjaca) LIKE CONCAT('%',LOWER('{filter}'),'%');";
        }

        public string GetParametres()
        {
            return "@ImeIzvodjaca,@PrezimeIzvodjaca,@DatumRodjenja,@BrojNastupa,@GrupaId";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                MuzickaGrupa muzickaGrupa = new MuzickaGrupa();
                muzickaGrupa.GrupaId = (int)reader["GrupaId"];
                muzickaGrupa.Naziv = (string)reader["naziv"];
                muzickaGrupa.Scenograf = (string)reader["scenograf"];

                Izvodjac izvodjac = new Izvodjac
                {
                    IzvodjacId = (int)reader["IzvodjacId"],
                    ImeIzvodjaca = (string)reader["ImeIzvodjaca"],
                    PrezimeIzvodjaca = (string)reader["PrezimeIzvodjaca"],
                    DatumRodjenja = (DateTime)reader["DatumRodjenja"],
                    BrojNastupa = (int)reader["BrojNastupa"],
                    MuzickaGrupa = muzickaGrupa
                };
                entities.Add(izvodjac);
            }
            return entities;
        }

        public string GetSearchAttributes()
        {
            return $"IzvodjacId,ImeIzvodjaca,PrezimeIzvodjaca,DatumRodjenja,BrojNastupa,izvodjac.GrupaId,mg.Naziv, mg.Scenograf";
            //return $"*";
        }

        public string JoinQuery()
        {
            return "join muzickagrupa mg on(mg.GrupaId=Izvodjac.GrupaId)";
        }

        public void PrepareCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@ImeIzvodjaca", ImeIzvodjaca);
            cmd.Parameters.AddWithValue("@PrezimeIzvodjaca", PrezimeIzvodjaca);
            cmd.Parameters.AddWithValue("@DatumRodjenja", DatumRodjenja);
            cmd.Parameters.AddWithValue("@BrojNastupa", BrojNastupa);
            if (MuzickaGrupa != null) cmd.Parameters.AddWithValue("@GrupaId", MuzickaGrupa.GrupaId);
            else cmd.Parameters.AddWithValue("@GrupaId", DBNull.Value);

        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                MuzickaGrupa muzickaGrupa = new MuzickaGrupa();
                muzickaGrupa.GrupaId = (int)reader["GrupaId"];
                muzickaGrupa.Naziv = (string)reader["naziv"];
                muzickaGrupa.Scenograf = (string)reader["scenograf"];

                Izvodjac izvodjac = new Izvodjac
                {
                    IzvodjacId = (int)reader["IzvodjacId"],
                    ImeIzvodjaca = (string)reader["ImeIzvodjaca"],
                    PrezimeIzvodjaca = (string)reader["PrezimeIzvodjaca"],
                    DatumRodjenja = (DateTime)reader["DatumRodjenja"],
                    BrojNastupa = (int)reader["BrojNastupa"],
                    MuzickaGrupa = muzickaGrupa
                };
                entities.Add(izvodjac);
            }
            return entities;
        }

        public string UpdateQuery()
        {
            return $"PrezimeIzvodjaca = '{PrezimeIzvodjaca}',BrojNastupa='{BrojNastupa}',GrupaID='{MuzickaGrupa.GrupaId}'";
        }
        
    }
}
