using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Bil
    {
        public string ModelNamn;
        private decimal _milMatare;

        public Bil(string modellnamn)
        {
            this.ModelNamn = modellnamn;
        }

        public string RegistreringsNummer { get; set; }
        public int ViktIKilo { get; set; }
        public DateTime RegistreringsDatum { get; set; }
        public bool Elbil { get; set; }

        public void KorMil(decimal mil)
        {
            if (mil > 0)
            {
                this._milMatare += mil;
            }
        }

        public string GetMil()
        {
            return this._milMatare.ToString();
        }
    }
}
