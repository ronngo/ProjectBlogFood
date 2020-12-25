using System.Data;
using System.Data.SqlClient;

namespace ORDERFOOD.DAL
{
    public class BaseRepository
    {
        protected IDbConnection connect;
        public BaseRepository()
        {
            connect = new SqlConnection(@"Data Source=VAN-BINH;Initial Catalog=OrderFood;Integrated Security=True");
        }
    }
}

