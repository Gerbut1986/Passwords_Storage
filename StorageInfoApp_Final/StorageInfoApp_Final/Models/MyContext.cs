namespace StorageInfoApp_Final.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;

    public partial class MyContext : DbContext
    {
        public MyContext() : base("StorageInfoApp_Final.Properties.Settings.Storage_DBConnectionString") { }

        public virtual DbSet<User> Users { get; set; }

        internal void Refresh(RefreshMode clientWins, User add_wa)
        {
            throw new NotImplementedException();
        }
    }
}
