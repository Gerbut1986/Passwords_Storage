namespace Storage_App.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Age { get; set; }
        public int Id_WorkArea { get; set; }
        public System.DateTime? Date_Register { get; set; }
        public override string ToString()
        {
            return
              $"Id: {Id}\n" +
              $"First Name: {First_Name}\n" +
              $"Last Name: {Last_Name}\n" +
              $"Login: {Login}\n" +
              $"Password: {Password}\n" +
              $"Role: {Role}\n" +
              $"Age: {Age}\n" +
              $"Id Work of Area: {Id_WorkArea}\n" +
              $"Date Register: {Date_Register}\n";
        }
    }
}
