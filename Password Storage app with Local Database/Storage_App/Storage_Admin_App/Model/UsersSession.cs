namespace Storage_Admin_App.Model
{
    public class UsersSessions
    {
        public int Id { get; set; }
        public string CurLogin { get; set; }
        public string CurPaswd { get; set; } 
        public bool Rememb { get; set; } 
        public System.DateTime LastEnterDate { get; set; }
    }
}
