using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Personer
    {
        public string Namn { get; set; }
        public int Alder { get; set; }
        private List<Bil> _bilar;
        public List<Bil> Bilar
        {
            get
            {
                if (_bilar == null)
                {
                    _bilar = new List<Bil>();
                }
                return _bilar;
            }
        }
    }
}
