namespace StorageInfoApp_Final.Models
{
    using System;

    public class UsersSessions
    {
        public int Id { get; set; }
        public string CurLogin { get; set; }
        public string CurPassword { get; set; }
        public bool RememberMe { get; set; }
        public bool IsActive { get; set; }
        public int Id_User { get; set; }
        public DateTime DateEnter { get; set; }
        public DateTime DateLeave { get; set; }
        public Guid AccessToken { get; set; }
        public override string ToString() =>
                 $"Username: {CurLogin}\nCurrent Password: {CurPassword}\nRemember Me(check): {RememberMe}\n" +
                 $"IsActive: {IsActive}\nId User: {Id_User}\nDate Enter: {DateEnter}\nDate Leave: {DateLeave}\n" +
                 $"AccessToken: {AccessToken}\n";
    }
}
