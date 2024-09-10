using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Feladat
{
    internal class Feladat
    {
        public List<Foci> Meccsek = new(); 
        public void GetData(string fileName)
        {
            foreach(var line in File.ReadAllLines(fileName).Skip(1))
            {
                int f = int.Parse(line.Split(" ")[0]);
                int hg = int.Parse(line.Split(" ")[1]);
                int vg = int.Parse(line.Split(" ")[2]);
                int hf = int.Parse(line.Split(" ")[3]);
                int vf = int.Parse(line.Split(" ")[4]);
                string h = line.Split(" ")[5];
                string v = line.Split(" ")[6];

                Meccsek.Add(new Foci(f, hg, vg, hf, vf, h, v));
            }
        }
    }
}
