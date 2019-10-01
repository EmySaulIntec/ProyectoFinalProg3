using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace DatabaseProject.Contexts
{
    public class CashDbContext : DbContext
    {
        public CashDbContext() : base("ConnStringDb1")
        {

        }

        // Mis modelos o entidades
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Transaction> Transactions { get; set; }
        public DbSet<Models.DailyClose> DailyCloses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
          .Where(type => !String.IsNullOrEmpty(type.Namespace))
          .Where(type => type.BaseType != null && type.BaseType.IsGenericType
               && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
