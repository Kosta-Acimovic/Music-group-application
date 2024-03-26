using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Commonn.Domain
{
    [Serializable]
    public class MuzickaGrupa : IEntity
    {
        public int GrupaId { get; set; }
        public string Naziv { get; set; }
        public string Scenograf { get; set; }

        public string TableName => "MuzickaGrupa";
        public string DisplayValue => Naziv;
        public string PrimaryKey => "GrupaId";
        public string GetByIDQuery()
        {
            return $"GrupaId={GrupaId}";
        }
        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                return new MuzickaGrupa
                {
                    GrupaId = (int)reader["GrupaId"],
                    Naziv = (string)reader["Naziv"],
                    Scenograf = (string)reader["Scenograf"],
                };
            }
            else return null;
        }

        public string GetFilterQuery(string filter)
        {
            return $"LOWER(Naziv) LIKE CONCAT('%',LOWER('{filter}'),'%');";
        }

        public string GetParametres()
        {
            return "@Naziv,@Scenograf";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                MuzickaGrupa grupa = new MuzickaGrupa
                {
                    GrupaId = (int)reader["GrupaId"],
                    Naziv = (string)reader["Naziv"],
                    Scenograf = (string)reader["Scenograf"],
                };
                entities.Add(grupa);
            }
            return entities;
        }

        public string GetSearchAttributes()
        {
            return $"GrupaId,Naziv,Scenograf";
        }

        public string JoinQuery()
        {
            return "";
        }

        public void PrepareCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Naziv", Naziv);
            cmd.Parameters.AddWithValue("@Scenograf", Scenograf);
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                MuzickaGrupa grupa = new MuzickaGrupa()
                {
                    GrupaId = (int)reader["GrupaId"],
                    Naziv = (string)reader["Naziv"],
                };
                entities.Add(grupa);
            }
            return entities;
        }

        public string UpdateQuery()
        {
            return $"Naziv='{Naziv}',Scenograf='{Scenograf}'";
        }
        public override string ToString()
        {
            return Naziv;
        }

    }

}
