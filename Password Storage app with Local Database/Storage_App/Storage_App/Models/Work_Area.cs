namespace Storage_App.Models
{
    public class Work_Area
    {
        public int Id { get; set; }
        public string Site_Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
        public string Phone { get; set; }
        public string Comments { get; set; }
        public System.DateTime DateCreated { get; set; }

        public override string ToString()
        {
            return
                $"Id: {Id}\n" +
                $"Site name: {Site_Name}\n" +
                $"Email: {Email}\n" +
                $"Login: {Login}\n" +
                $"Password: {Password}\n" +
                $"Url: {URL}\n" +
                $"Phone: {Phone}\n" +
                $"Comments: {Comments}\n" +
                $"Date Created: {DateCreated}\n";
        }
    }
}
