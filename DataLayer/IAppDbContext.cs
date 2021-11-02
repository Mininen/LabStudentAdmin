using System.Data.Entity;
using BusinessEntities;

namespace DataLayer
{
    public interface IAppDbContext
    {
        DbSet<Aktivitet> Aktiviteter { get; set; }
        DbSet<Alumn> Alumner { get; set; }
        DbSet<Personal> Personaler { get; set; }
        DbSet<Utskick> Utskicks { get; set; }

        void Reset();
    }
}