namespace Storage_Admin_App.Model
{
    using System.Data.SqlClient;

    class Connection
    {
        public static string connectstr = 
            System.Configuration.ConfigurationManager.ConnectionStrings["Storage_Admin_App.Properties.Settings.Storage_DBConnectionString"].ConnectionString;
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader dreder = null;
    }
}
