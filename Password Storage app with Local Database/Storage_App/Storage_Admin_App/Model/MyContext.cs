namespace Storage_Admin_App.Model
{
    using System.Data.Entity;

    public class MyContext : DbContext
    {
        public MyContext() : base("Storage_Admin_App.Properties.Settings.Storage_DBConnectionString") { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WorkArea> WorkAreas { get; set; }
        public virtual DbSet<UsersSessions> UsersSessions { get; set; }
    }
}