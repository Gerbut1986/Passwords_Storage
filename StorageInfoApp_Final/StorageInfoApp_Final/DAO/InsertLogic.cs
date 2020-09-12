namespace StorageInfoApp_Final.DAO
{
    using StorageInfoApp_Final.Models;

    class InsertLogic
    {
        public static string AddUser(User user, int num)
        {
            string msg = string.Empty,
                query = $"insert into Users(Last_Name, First_Name, Age, Login, Password, Email, Phone, Indx_Last_Enter, Role, Id_WorkArea, Date_Registr) " +
                    $"values(@Last_Name, @First_Name, @Age, @Login, @Password, @Email, @Phone, @Indx_Last_Enter, @Role, @Id_WorkArea, @Date_Registr)";
          
            using (var conn = Connection.conn = new System.Data.SqlClient.SqlConnection(Connection.connectstr))
            {
                conn.Open();
                using (var cmd = Connection.cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@First_Name", user.First_Name);
                    cmd.Parameters.AddWithValue("@Last_Name", user.Last_Name);
                    cmd.Parameters.AddWithValue("@Age", user.Age);
                    cmd.Parameters.AddWithValue("@Login", user.Login);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@Indx_Last_Enter", user.Indx_Last_Enter);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@Id_WorkArea", user.Id_WorkArea);
                    cmd.Parameters.AddWithValue("@Date_Registr", user.Date_Registr = System.DateTime.Now);

                    int res = cmd.ExecuteNonQuery();

                    if (res == 1)
                        msg = "Info about User has inserted Successfuly!!!";
                    else msg = "Something went wrong...";
                }
            }

            return msg;
        }

        public static string AddWorkArea(WorkArea area, int num)
        {
            string msg = string.Empty,
                query = $"insert into WorkAreas_{num}(SiteName, Email, Login, Password, URL, Phone, Coments, DateCreate) " +
                    $"values(@SiteName, @Email, @Login, @Password, @URL, @Phone, @Coments, @DateCreate)";
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
                        msg = "Info about Website has inserted Successfuly!!!";
                    else msg = "Something went wrong...";
                }
            }

            return msg;
        }

        public static string AddUserSession(UsersSessions usses, int num_table)
        {
            string msg = string.Empty,
                query = $"insert into UserSessions_{num_table}(CurLogin, CurPassword, RememberMe, IsActive, AccessToken, DateEnter, DateLeave)" +
                $"values(@CurLogin, @CurPassword, @RememberMe, @IsActive, @AccessToken, @DateEnter, @DateLeave)";
            using (var c = Connection.conn = new System.Data.SqlClient.SqlConnection(Connection.connectstr))
            {
                c.Open();
                using (var cmd = Connection.cmd = new System.Data.SqlClient.SqlCommand(query, c))
                {
                    cmd.Parameters.AddWithValue("@CurLogin", usses.CurLogin);
                    cmd.Parameters.AddWithValue("@CurPassword", usses.CurPassword);
                    cmd.Parameters.AddWithValue("@RememberMe", usses.RememberMe);
                    cmd.Parameters.AddWithValue("@IsActive", usses.IsActive);
                    cmd.Parameters.AddWithValue("@AccessToken", usses.AccessToken);
                    cmd.Parameters.AddWithValue("@DateEnter", usses.DateEnter);
                    cmd.Parameters.AddWithValue("@DateLeave", usses.DateLeave);

                    int res = cmd.ExecuteNonQuery();

                    if (res == 1)
                        msg = "Info about Website has inserted Successfuly!!!";
                    else msg = "Something went wrong...";
                }

            }

            return msg;
        }
    }
}
