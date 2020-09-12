namespace StorageInfoApp_Final.Models
{
    using System.Data.SqlClient;

    class Connection
    {
        public static string connectstr =
            System.Configuration.ConfigurationManager.ConnectionStrings["StorageInfoApp_Final.Properties.Settings.Storage_DBConnectionString"].ConnectionString;
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader dreder = null;
    }
}
