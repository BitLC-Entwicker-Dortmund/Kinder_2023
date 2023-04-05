using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinder_2023 {
    internal class Fuetterer {
        public void Fuettert(Kind k, Nahrung n) {
            k.Essen(n);
        }
    }
}
