using System.Security.Cryptography.X509Certificates;

namespace Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladat t = new Feladat();
            t.GetData("meccs.txt");
            t.Feladat1();
        }
    }
}
