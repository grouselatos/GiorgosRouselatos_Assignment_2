namespace Giorgos_Rouselatos_Assignment_2.Managers
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Giorgos_Rouselatos_Assignment_2.Models;

    public class TrainerDb : DbContext
    {
        // Your context has been configured to use a 'TrainerDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Giorgos_Rouselatos_Assignment_2.Managers.TrainerDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TrainerDb' 
        // connection string in the application configuration file.
        public TrainerDb()
            : base("name=TrainerDb")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
    }
}