using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commonn.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string DisplayValue { get; }
        string PrimaryKey { get; }
        List<IEntity> GetReaderList(SqlDataReader reader);
        IEntity GetReaderResult(SqlDataReader reader);
        string GetParametres();
        void PrepareCommand(SqlCommand cmd);
        string UpdateQuery();
        string JoinQuery();
        string GetByIDQuery();
        string GetSearchAttributes();
        string GetFilterQuery(string filter);
        List<IEntity> ReadAllSearch(SqlDataReader reader);
    }
}
