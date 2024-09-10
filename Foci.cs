using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat
{
    internal class Foci
    {
        public Foci(int fordulo, int hazaigol, int vendeggol, int felidoh, int vendegh, string hazainev, string vendegnev)
        {
            this.fordulo = fordulo;
            this.hazaigol = hazaigol;
            this.vendeggol = vendeggol;
            this.felidoh = felidoh;
            this.vendegh = vendegh;
            this.hazainev = hazainev;
            this.vendegnev = vendegnev;
        }

        public int fordulo { get; set; }
        public int hazaigol { get; set; }
        public int vendeggol { get; set; }
        public int felidoh { get; set; }
        public int vendegh { get; set; }
        public string hazainev {  get; set; }
        public string vendegnev { get; set; }
    
    }
}
