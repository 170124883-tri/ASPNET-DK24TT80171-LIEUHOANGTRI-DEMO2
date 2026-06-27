using System.Configuration;
using System.Data.SqlClient;

namespace ASPNET_dk24tt80171_HoangTri_AppleStore.DAL
{
    public class KetNoi
    {
        public static SqlConnection GetConnection()
        {
            string connStr =
                ConfigurationManager.ConnectionStrings["AppleStoreDB"].ConnectionString;

            return new SqlConnection(connStr);
        }
    }
}