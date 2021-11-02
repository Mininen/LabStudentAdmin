namespace BusinessEntities
{
    public interface IPerson
    {
        string Användarnamn { get; set; }
        string Email { get; set; }
        bool Inloggad { get; set; }
        string Lösenord { get; set; }
        string Namn { get; set; }
    }
}