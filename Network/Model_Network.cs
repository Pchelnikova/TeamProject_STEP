namespace Network_DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model_Network : DbContext
    {
        // Your context has been configured to use a 'Model_Network' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Network.Model_Network' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model_Network' 
        // connection string in the application configuration file.
        public Model_Network()
            : base("name=Model_Network")
        {
            Database.SetInitializer<Model_Network>(new MyInitializer<Model_Network>());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Thing> Things { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<CategoryThing> CategoryThings { get; set; }
        public virtual DbSet<CategoryService> CategoryServices { get; set; }
        public virtual DbSet<StatusLot> StatusLots { get; set; }
        public virtual DbSet<StatusUser> StatusUsers { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Street> Streets { get; set; }

    }

}