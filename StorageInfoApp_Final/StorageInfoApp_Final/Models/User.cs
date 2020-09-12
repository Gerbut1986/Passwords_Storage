namespace StorageInfoApp_Final.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Indx_Last_Enter { get; set; }
        public string Role { get; set; }
        public int Id_WorkArea { get; set; }
        public System.DateTime Date_Registr { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nFirst Name: {First_Name}\nLast Name: {Last_Name}\nAge: {Age}\nLogin: {Login}\nPassword: {Password}\n" +
                   $"Email: {Email}\nPhone: {Phone}\nRole: {Role}\nIndx Last Enter: {Indx_Last_Enter}\nInfo number table: {Id_WorkArea}\n" +
                   $"Date of created: {Date_Registr}\n\n";
        }
    }
}
