using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nafibel.Data.Model;
using static Nafibel.Data.Repositories.UildConverter;

namespace Nafibel.Data.Repositories
{
    public class NafibelDbContext : DbContext
    {
        public DbSet<HairStyle> HairStyles { get; set; }

        public DbSet<Hairdresser> Hairdressers { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<HairStylePrice> HairStylePrices { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<HairdresserHairStyle> HairdresserHairStyles { get; set; }
        public DbSet<HairStyleImage> HairStyleImages { get; set; }
        public DbSet<HairStyleNameLocale> HairStyleNameLocales { get; set; }
        public DbSet<HairStylePopularity> HairStylePopularities { get; set; }



        public NafibelDbContext()
        {
            
        }

        public NafibelDbContext(DbContextOptions<NafibelDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer(DbConnection.ToString());
            //}
#if DEBUG
            optionsBuilder.UseSqlServer(
                @"Server=SQLEXPRESS\MSSQLSERVER2022;Database=NafibelDdb01;Trusted_Connection=True;TrustServerCertificate=true",
                x => x.UseNetTopologySuite());
#endif
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
                .Properties<Ulid>()
                .HaveConversion<UlidToStringConverter>()
                .HaveConversion<UlidToBytesConverter>();
        }
    }
}
