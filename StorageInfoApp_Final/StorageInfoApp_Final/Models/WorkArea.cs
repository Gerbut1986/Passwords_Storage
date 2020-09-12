namespace StorageInfoApp_Final.Models
{
    public class WorkArea
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
        public int Phone { get; set; }
        public string Coments { get; set; }
        public System.DateTime DateCreate { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nSite of name: {SiteName}\nEmail: {Email}\nLogin: {Login}\nPassword: {Password}\n" +
                $"URL: {URL}\nPhone: {Phone}\nComment: {Coments}\nDate of Create: {DateCreate} ";
        }
    }
}
