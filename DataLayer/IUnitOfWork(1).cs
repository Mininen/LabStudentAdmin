namespace DataLayer
{
    public interface IUnitOfWork
    {
        AktivitetsRepository AktivitetRepo { get; set; }
        AlumnRepository alumnRepo { get; set; }
        AppDbContext AppDbContext { get; set; }
        PersonalRepository personalRepo { get; set; }
        UtskicksRepository utskicksRepo { get; set; }

       // void Spara(AppDbContext appDbContext);
        void Update();
        UnitOfWork Update(AppDbContext appDbContext);
    }
}