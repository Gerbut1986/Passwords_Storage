namespace Storage_App.Models
{
    using System.Data.Entity;

    public partial class My_Context : DbContext
    {
        public My_Context() : base("Storage_App.Properties.Settings.Storage_DBConnectionString") { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Work_Area> Works_Datas { get; set; }
    }
}
