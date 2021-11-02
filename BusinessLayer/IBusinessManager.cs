using BusinessEntities;
using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IBusinessManager
    {
        UnitOfWork UnitOfWork { get; set; }

        List<Alumn> HittaRegistreradeAlumner(int aktivitetsId);
        List<Aktivitet> HämtaAktiviteter();
        Aktivitet HämtaAktivitetviaID(int aktivitetsId);
        List<Aktivitet> HämtaAlumnAktiviteter(Alumn alumn);
        List<Alumn> HämtaAlumner();
        List<Alumn> HämtaDataekonomer();
        Alumn HämtaInloggadAlumn();
        List<Alumn> HämtaSystemarkitekter();
        List<Alumn> HämtaSystemvetare();
        List<Utskick> HämtaUtskickListor();
        Utskick HämtaUtskicksID(int utskicksId);
        bool LoggaInAlumn(string användarnamn, string lösenord);
        bool LoggaInPersonal(string användarnamn, string lösenord);
        bool LoggautAlumn(Alumn alumn);
        void LäggTillAlumn(Alumn alumn);
        void RedigeraAktivitet(Aktivitet redigeradAktivitet);
        void RedigeraUtskick(Utskick RedUtsick);
        void RegistreraAlumnTillAktivitet(Alumn alumn, Aktivitet nyaktivitet);
        void SkapaAktivitet(Aktivitet nyAktivitet);
        void SkapaUtskick(Utskick utskick);
        void TaBortAktivitet(int aktivitetsId);
        void TaBortAlumnKonto(Alumn alumn);
    }
}