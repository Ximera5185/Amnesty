namespace Amnesty
{
    internal class UserInterface
    {
       private Database _database = new Database();

       public UserInterface() 
       {
            _database.ShowCriminals();

            _database.ClearCriminals();

            _database.ShowCriminals();
       }
    }
}