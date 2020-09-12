namespace Storage_Admin_App.Model
{
    using System;
    using System.Data.SqlClient;
    using System.Collections.Generic;

    class ReadFromDatabase
    {
        public static IEnumerable<WorkArea> ShowAllAreas()
        {
            List<WorkArea> list = new List<WorkArea>();
            using (var conn = Connection.conn = new SqlConnection(Connection.connectstr))
            {
                conn.Open();
                using (var cmd = Connection.cmd = new SqlCommand("select * from WorkAreas", conn))
                {
                    var dreder = Connection.dreder = cmd.ExecuteReader();
                    while (dreder.Read())
                    {
                        WorkArea area = new WorkArea();
                        area.Coments = dreder["Coments"].ToString();
                        area.DateCreate = Convert.ToDateTime(dreder["DateCreate"].ToString());
                        area.SiteName = dreder["SiteName"].ToString();
                        area.Login = dreder["Login"].ToString();
                        area.Password = dreder["Password"].ToString();
                        area.Phone = Convert.ToInt32(dreder["Phone"].ToString());
                        area.URL = dreder["URL"].ToString();
                        area.Id = Convert.ToInt32(dreder["Id"].ToString());

                        list.Add(area);

                    }
                }
                return list;
            }
        }

        public static IEnumerable<User> ShowAllUsers()
        {
            List<User> list = new List<User>();
            using (var conn = Connection.conn = new SqlConnection(Connection.connectstr))
            {
                conn.Open();
                using (var cmd = Connection.cmd = new SqlCommand("select * from Users", conn))
                {
                    var dreder = Connection.dreder = cmd.ExecuteReader();
                    while (dreder.Read())
                    {
                        User area = new User();
                        area.Last_Name = dreder["Last_Name"].ToString();
                        area.First_Name = dreder["First_Name"].ToString();
                        area.Age = Convert.ToInt32(dreder["Age"]);
                        area.Date_Registr = Convert.ToDateTime(dreder["Date_Registr"].ToString());
                        area.Email = dreder["Email"].ToString();
                        area.Login = dreder["Login"].ToString();
                        area.Password = dreder["Password"].ToString();
                        area.Phone = Convert.ToInt32(dreder["Phone"].ToString());
                        area.Role = dreder["Role"].ToString();

                        list.Add(area);
                    }
                }
                return list;
            }
        }

        public static IEnumerable<UsersSessions> AllUsersSessions()
        {
            List<UsersSessions> list = new List<UsersSessions>();
            using (var conn = Connection.conn = new SqlConnection(Connection.connectstr))
            {
                conn.Open();
                using (var cmd = Connection.cmd = new SqlCommand("select * from UsersSessions", conn))
                {
                    var dreder = Connection.dreder = cmd.ExecuteReader();
                    while (dreder.Read())
                    {
                        UsersSessions area = new UsersSessions();
                        area.Rememb = Convert.ToBoolean(dreder["Rememb"]);
                        area.LastEnterDate = Convert.ToDateTime(dreder["LastEnterDate"].ToString());
                        area.CurLogin = dreder["CurLogin"].ToString();
                        area.CurPaswd = dreder["CurPaswd"].ToString();
                        area.Id = Convert.ToInt32(dreder["Id"].ToString());

                        list.Add(area);
                    }
                }
                return list;
            }
        }
    }
}
