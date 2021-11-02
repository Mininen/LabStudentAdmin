using BusinessEntities;
using System.Data.SqlClient;
using System.Data.Entity;

namespace DataLayer
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext() : base("WindowsFormsApp1")
        {

        }

        public DbSet<Alumn> Alumner { get; set; }
        public DbSet<Personal> Personaler { get; set; }
        public DbSet<Aktivitet> Aktiviteter { get; set; }
        public DbSet<Utskick> Utskicks { get; set; }

        public void Reset()
        {
            using (SqlConnection conn = new SqlConnection(Database.Connection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT all'; EXEC sp_msforeachtable 'DROP TABLE ?'", conn))
            {
                conn.Open();
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (System.Exception)
                    {
                        // throw;
                    }
                }
                conn.Close();
            }
            Database.Initialize(true);
            LaddaInAlumn();
            LaddaInPersonal();
            LaddaInAktiviteter();
            SaveChanges();
        }

        //Ladda in alumner
        private void LaddaInAlumn()
        {
            Alumner.Add(new Alumn()
            {
                Namn = "Pelle",
                Användarnamn = "Pelle1",
                Lösenord = "Pelle1",
                Program = "Systemvetare",
                Email = "Pelle@live.se"
            });

            Alumner.Add(new Alumn()
            {
                Namn = "Lisa",
                Användarnamn = "Lisa2",
                Lösenord = "Lisa2",
                Program = "Systemarkitekt",
                Email = "Lisa@live.se"
            });

            Alumner.Add(new Alumn()
            {
                Namn = "Juha",
                Användarnamn = "Juha3",
                Lösenord = "Juha3",
                Program = "Systemarkitekt",
                Email = "Juha@live.se"
            });

            Alumner.Add(new Alumn()
            {
                Namn = "Stina",
                Användarnamn = "Stina3",
                Lösenord = "Stina3",
                Program = "Dataekonom",
                Email = "Stina@live.se"
            });

            Alumner.Add(new Alumn()
            {
                Namn = "Maija",
                Användarnamn = "Maija4",
                Lösenord = "Maija4",
                Program = "Dataekonom",
                Email = "Maija@live.se"
            });

            Alumner.Add(new Alumn()
            {
                Namn = "a",
                Användarnamn = "a",
                Lösenord = "a",
                Program = "Systemvetare",
                Email = "a@live.se"
            });
        }

        //Ladda in personal
        private void LaddaInPersonal()
        {
            Personaler.Add(new Personal()
            {
                Namn = "Sara",
                Användarnamn = "Sara1",
                Lösenord = "Sara1",
                Email = "Sara@live.se"
            });

            Personaler.Add(new Personal()
            {
                Namn = "Kent",
                Användarnamn = "Kent1",
                Lösenord = "Kent1",
                Email = "Kent@live.se"
            });

            Personaler.Add(new Personal()
            {
                Namn = "Britt",
                Användarnamn = "Britt1",
                Lösenord = "Britt1",
                Email = "Britt@live.se"
            });

            Personaler.Add(new Personal()
            {
                Namn = "Jonas",
                Användarnamn = "Jonas1",
                Lösenord = "Jonas1",
                Email = "Jonas@live.se"
            });

            Personaler.Add(new Personal()
            {
                Namn = "q",
                Användarnamn = "q",
                Lösenord = "q",
                Email = "q@live.se"
            });
        }

        //Ladda in aktiviteter
        private void LaddaInAktiviteter()
        {
            Aktiviteter.Add(new Aktivitet()
            {
                Aktivitetsnamn = "C# Workshop",
                Beskrivning = "Ta med ditt projekt så hjälps vi åt!"
            });

            Aktiviteter.Add(new Aktivitet()
            {
                Aktivitetsnamn = "Alumnfika",
                Beskrivning = "Ta en kaffe med gamla klasskompisar"
            });

            Aktiviteter.Add(new Aktivitet()
            {
                Aktivitetsnamn = "Spelkväll",
                Beskrivning = "Vi spelar brädspel så ta med din favorit"
            });

            Aktiviteter.Add(new Aktivitet()
            {
                Aktivitetsnamn = "Jobbsökarträff",
                Beskrivning = "Så fixar du arbetsintervjun"
            });
        }


    }
}
