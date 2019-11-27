
using System;

namespace Oefening06
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p1 = new Persoon("Selie", "Peter", 'v');
            p1.LogOutput();
            Gebruiker g1 = new Gebruiker("Terham", "Bo", 'm');
            g1.LogOutput();
            Student s1 = new Student("Verleyen", "Arne", 'm');
            s1.LogOutput();
            Docent d1 = new Docent("Leybaert", "Ari", 'm');
            d1.LogOutput();
        }
    }
}