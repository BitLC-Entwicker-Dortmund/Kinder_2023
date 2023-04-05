using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinder_2023 {
    internal class Magen {
        private List<Nahrung> magenInhalt = new List<Nahrung>();
        public void nahrungAufnehmen(Nahrung n) {
            magenInhalt.Add(n);
        }

        public void nahrungVerdauen() { 
            magenInhalt.RemoveAt(0);
        }
    }
}
