using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntities;

namespace BusinessLayer
{
    public class BusinessManager : IBusinessManager
    {
        public BusinessManager(AppDbContext appDbContext)
        {
            UnitOfWork = new UnitOfWork(appDbContext);
        }

        public UnitOfWork UnitOfWork { get; set; } 

        public BusinessManager()
        {
        }

        //ALUMNER---------------------------------------------------------------
        public List<Alumn> HämtaAlumner()
        {
            return UnitOfWork.Update(new AppDbContext()).alumnRepo.HämtaAlla().ToList(); //Uppdaterad med generic repo metoden
        }

        public List<Aktivitet> HämtaAlumnAktiviteter(Alumn alumn)
        {
            return UnitOfWork.Update(new AppDbContext()).alumnRepo.HämtaAlumnAktiviteter(alumn);
        }

        public bool LoggaInAlumn(string användarnamn, string lösenord)
        {
            bool kontroll;
            kontroll = UnitOfWork.alumnRepo.InloggningsKontrollAlumn(användarnamn, lösenord);
            return kontroll;
        }

        public void RedigeraAlum(Alumn alumn)
        {
            UnitOfWork.alumnRepo.RedigeraAlumn(alumn);
        }

        public void RegistreraAlumnTillAktivitet(Alumn alumn, Aktivitet nyaktivitet)
        {
            UnitOfWork.alumnRepo.RegistreraAktiviterTillAlumn(alumn, nyaktivitet);
        }

        public List<Alumn> HämtaSystemvetare()
        {
            return UnitOfWork.alumnRepo.GetAllSystemvetare();
        }

        public List<Alumn> HämtaSystemarkitekter()
        {
            return UnitOfWork.alumnRepo.GetAllSystemarkitekter();
        }
        public List<Alumn> HämtaDataekonomer()
        {
            return UnitOfWork.alumnRepo.GetAllDataekonomer();
        }
        public bool LoggautAlumn(Alumn alumn)
        {
            return UnitOfWork.alumnRepo.LoggaUtAlumn(alumn);
        }
        public Alumn HämtaInloggadAlumn()
        {
            return UnitOfWork.alumnRepo.HämtaInloggadAlumn();
        }

        public void LäggTillAlumn(Alumn alumn)
        {
            UnitOfWork.alumnRepo.LäggTill(alumn);
            UnitOfWork.Spara();
        }

        public void TaBortAlumnKonto(Alumn alumn)
        {
            UnitOfWork.alumnRepo.TaBort(alumn);
            UnitOfWork.Spara();
        }

        //AKTIVITETER----------------------------------------------------------------------------
        public List<Aktivitet> HämtaAktiviteter()
        {
            return UnitOfWork.Update(new AppDbContext()).AktivitetRepo.HämtaAlla().ToList(); 
        }

        public void RedigeraAktivitet(Aktivitet redigeradAktivitet)
        {
            UnitOfWork.AktivitetRepo.RedigeraAktivitet(redigeradAktivitet);
        }

        public void SkapaAktivitet(Aktivitet nyAktivitet) 
        {
            UnitOfWork.AktivitetRepo.LäggTill(nyAktivitet);
            UnitOfWork.Spara();

        }
        public void TaBortAktivitet(int aktivitetsId)
        {
            UnitOfWork.AktivitetRepo.TaBortAktivitet(aktivitetsId);
        }

        //Hämta aktiviteter utifrån id
        public Aktivitet HämtaAktivitetviaID(int aktivitetsId)
        {
            return UnitOfWork.AktivitetRepo.HämtaViaID(aktivitetsId);
        }

        //Hämta alumner registrerade på en aktivitet
        public List<Alumn> HittaRegistreradeAlumner(int aktivitetsId)
        {
            return UnitOfWork.AktivitetRepo.HittaRegistreradeAlumner(aktivitetsId);
        }

        //PERSONAL ----------------------------------------------------------------------------------
        public bool LoggaInPersonal(string användarnamn, string lösenord)
        {
            bool kontroll;
            kontroll = UnitOfWork.personalRepo.InloggningsKontrollPersonal(användarnamn, lösenord);
            return kontroll;
        }

        //UTSKICK -------------------------------------------------------------------------------------UPPDATERAD MED METODER FRÅN GENERIC REPOSITORY
        public void SkapaUtskick(Utskick utskick)
        {
            UnitOfWork.utskicksRepo.LäggTill(utskick);
            UnitOfWork.Spara();

        }
        public List<Utskick> HämtaUtskickListor()
        {
            return UnitOfWork.utskicksRepo.HämtaAlla().ToList();

        }

        public Utskick HämtaUtskicksID(int utskicksId)
        {
            return UnitOfWork.utskicksRepo.HämtaViaID(utskicksId);
        }

        public void RedigeraUtskick(Utskick RedUtsick)
        {
            UnitOfWork.utskicksRepo.RedigeraUtskick(RedUtsick);
        }

        public void TaBortUtskick(int id)
        {
            Utskick utskick = UnitOfWork.utskicksRepo.HämtaViaID(id);
            UnitOfWork.utskicksRepo.TaBort(utskick);
            UnitOfWork.Spara();
        }

        public List<Alumn> HämtaMottagare(int id)
        {
            return UnitOfWork.utskicksRepo.HittaMottagare(id);
        }

        public void TaBortMottagare(int utskicksId, int alumnId)
        {
            UnitOfWork.utskicksRepo.TaBortMottagare(utskicksId, alumnId);
        }

        public void LäggTillMottagare(int utksicksId, int alumnId)
        {
            Utskick utskick = UnitOfWork.utskicksRepo.HämtaViaID(utksicksId);
            Alumn alumn = UnitOfWork.alumnRepo.HämtaViaID(alumnId);
            UnitOfWork.utskicksRepo.LäggTillMottagare(utskick, alumn);
        }

    }
}
