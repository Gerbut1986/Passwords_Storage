namespace Storage_App.Models
{
    using System.Configuration;
    using System.Data.SqlClient;

    class Add_WorkArea
    {
        public string Insert(Work_Area e, int uniq_numb)
        {
            string MSG = string.Empty;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_Context"].ConnectionString);

            if (uniq_numb != 1)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Work_Area_{uniq_numb}(Site_Name, Email, Login, Password, URL, Phone, Comments, DateCreated) " +
                    "VALUES(@Site_Name, @Email, @Login, @Password, @URL, @Phone, @Comments, @DateCreated)", conn);
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
                    MSG = e.Site_Name + " Inserted Successfully!";
                else
                    MSG = e.Site_Name + " NOT Inserted! Try to Find this Error";
                conn.Close();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Work_Area(Site_Name, Email, Login, Password, URL, Phone, Comments, DateCreated) " +
                                                 "VALUES(@Site_Name, @Email, @Login, @Password, @URL, @Phone, @Comments, @DateCreated)", conn);
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
                    MSG = e.Site_Name + " Inserted Successfully!";
                else
                    MSG = e.Site_Name + " NOT Inserted! Try to Find this Error";
                conn.Close();
            }
           
            return MSG;
        }
    }
}
