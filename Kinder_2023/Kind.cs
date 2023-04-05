using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinder_2023 {
    internal class Kind {
        public string Name { get; set; }
        public Magen Magen { get; set; } = new Magen();

        public void Essen(Nahrung n) {
            Magen.nahrungAufnehmen(n);
            Console.WriteLine("Es kommt was im Magen an!");
        }

        public void Toben() {
            Magen.nahrungVerdauen();
            Console.WriteLine("verbrauche Kalorien");
        }
    }
}
