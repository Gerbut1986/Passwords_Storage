namespace StorageInfoApp_Final.DAO
{
    using System.Data.SqlClient;
    using StorageInfoApp_Final.Models;

    class DeleteLogic
    {
        public static string DeleteInfo(WorkArea d, int num_table)
        {
            string msg = "";
            using (var conn = Connection.conn = new SqlConnection(Connection.connectstr))
            {
                conn.Open();
                using (var cmd = Connection.cmd = new SqlCommand($"delete from WorkAreas_{num_table} where id = {d.Id}", conn))
                {
                    int res = cmd.ExecuteNonQuery();

                    if (res == 1)
                        msg = $"info about - {d.SiteName} was delete successfuly";
                    else if (res == 0)
                        msg = $"info about - {d.SiteName} has NOT delete...";
                }
            }

            return msg;
        }

        public static string DeleteUser(User d)
        {
            string msg = "";
            using (var conn = Connection.conn = new SqlConnection(Connection.connectstr))
            {
                conn.Open();
                using (var cmd = Connection.cmd = new SqlCommand($"delete from Users where id = {d.Id}", conn))
                {
                    int res = cmd.ExecuteNonQuery();

                    if (res == 1)
                        msg = $"User - {d.First_Name} was delete successfuly";
                    else if (res == 0)
                        msg = $"User - {d.First_Name} has NOT delete...";
                }
            }

            return msg;
        }
    }
}
