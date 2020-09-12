namespace StorageInfoApp_Final.DAO
{
    using StorageInfoApp_Final.Models;

    class EditLogic
    {
        public static string EditUser(User user)
        {
            string msg = "", query =
           $"UPDATE Users SET First_Name=@First_Name, Last_Name=@Last_Name, Email=@Email, Login=@Login, Password=@Password, Age=@Age, Phone=@Phone, Date_Registr=@Date_Registr WHERE Id={user.Id}";

            using (var c = Connection.conn = new System.Data.SqlClient.SqlConnection(Connection.connectstr))
            {
                c.Open();
                using (var cmd = Connection.cmd = new System.Data.SqlClient.SqlCommand(query, c))
                {

                    cmd.Parameters.AddWithValue("@First_Name", user.First_Name);
                    cmd.Parameters.AddWithValue("@Last_Name", user.Last_Name);
                    cmd.Parameters.AddWithValue("@Login", user.Login);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@Age", user.Age);
                    cmd.Parameters.AddWithValue("@Date_Registr", user.Date_Registr = System.DateTime.Now);

                    int res = cmd.ExecuteNonQuery();

                    if (res == 1)
                        msg = $"User - {user.First_Name} was Update successfuly";
                    else if (res == 0)
                        msg = $"User - {user.First_Name} has NOT update...";
                }
            }
            return msg;
        }

        public static string EditInfo(WorkArea area, int num_tab)
        {
            string msg = "";
            string query =
           $"UPDATE WorkAreas_{num_tab} SET SiteName=@SiteName, Email=@Email, Login=@Login, Password=@Password, URL=@URL, Phone=@Phone, Coments=@Coments, DateCreate=@DateCreate WHERE Id={area.Id}";

            using (var c = Connection.conn = new System.Data.SqlClient.SqlConnection(Connection.connectstr))
            {
                c.Open();
                using (var cmd = Connection.cmd = new System.Data.SqlClient.SqlCommand(query, c))
                {

                    cmd.Parameters.AddWithValue("@SiteName", area.SiteName);
                    cmd.Parameters.AddWithValue("@Email", area.Email);
                    cmd.Parameters.AddWithValue("@Login", area.Login);
                    cmd.Parameters.AddWithValue("@Password", area.Password);
                    cmd.Parameters.AddWithValue("@URL", area.URL);
                    cmd.Parameters.AddWithValue("@Phone", area.Phone);
                    cmd.Parameters.AddWithValue("@Coments", area.Coments);
                    cmd.Parameters.AddWithValue("@DateCreate", area.DateCreate = System.DateTime.Now);

                    int res = cmd.ExecuteNonQuery();

                    if (res == 1)
                        msg = $"info about - {area.SiteName} was Update successfuly";
                    else if (res == 0)
                        msg = $"info about - {area.SiteName} has NOT update...";
                }
            }
            return msg;
        }
    }
}
