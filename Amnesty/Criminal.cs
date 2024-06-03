namespace Amnesty
{
    internal class Criminal
    {
        public Criminal(string fullName,string crime) 
        {
            FullName = fullName;

            Сrime = crime;
        }

        public string FullName { get; private set; }
        public string Сrime { get; private set; }
    }
}