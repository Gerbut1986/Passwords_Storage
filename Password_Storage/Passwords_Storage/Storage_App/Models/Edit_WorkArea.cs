namespace Storage_App.Models
{
    using System.Configuration;
    using System.Data.SqlClient;

    class Edit_WorkArea
    {
        public string Update(Work_Area e, int uniq_numb)
        {
            string MSG = string.Empty;
            if (uniq_numb != 1)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_Context"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Work_Area_{uniq_numb} SET Site_Name=@Site_Name, " +
                    $"Email=@Email, Login=@Login, Password=@Password, URL=@URL, Phone=@Phone, Comments=@Comments, DateCreated=@DateCreated " +
                    $"WHERE Id={e.Id}", conn);
                cmd.Parameters.AddWithValue("@Site_Name", e.Site_Name);
                cmd.Parameters.AddWithValue("@Email", e.Email);
                cmd.Parameters.AddWithValue("@Login", e.Login);
                cmd.Parameters.AddWithValue("@Password", e.Password);
                cmd.Parameters.AddWithValue("@URL", e.URL);
                cmd.Parameters.AddWithValue("@Phone", e.Phone);
                cmd.Parameters.AddWithValue("@Comments", e.Comments);
                cmd.Parameters.AddWithValue("@DateCreated", e.DateCreated);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    MSG = e.Site_Name + " Updated Successfully!";
                else
                    MSG = e.Site_Name + " NOT Updated! Try to Find this Error";
                conn.Close();
            }
            else
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_Context"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Work_Area SET Site_Name=@Site_Name, " +
                    $"Email=@Email, Login=@Login, Password=@Password, URL=@URL, Phone=@Phone, Comments=@Comments, DateCreated=@DateCreated " +
                    $"WHERE Id={e.Id}", conn);
                cmd.Parameters.AddWithValue("@Site_Name", e.Site_Name);
                cmd.Parameters.AddWithValue("@Email", e.Email);
                cmd.Parameters.AddWithValue("@Login", e.Login);
                cmd.Parameters.AddWithValue("@Password", e.Password);
                cmd.Parameters.AddWithValue("@URL", e.URL);
                cmd.Parameters.AddWithValue("@Phone", e.Phone);
                cmd.Parameters.AddWithValue("@Comments", e.Comments);
                cmd.Parameters.AddWithValue("@DateCreated", e.DateCreated);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    MSG = e.Site_Name + " Updated Successfully!";
                else
                    MSG = e.Site_Name + " NOT Updated! Try to Find this Error";
                conn.Close();
            }

            return MSG;
        }
    }
}
