using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prova1
{
    class moto : Veicolo
    {
        public bool HaSidecar { get; set; }

        public moto(string marca, string modello, int anno, bool haSidecar)
            : base(marca, modello, anno)
        {
            HaSidecar = haSidecar;
        }

        public override void MostraInfo()
        {
            string sidecar = HaSidecar ? "con sidecar" : "senza sidecar";
            Console.WriteLine($"Moto: {Marca} {Modello}, Anno: {Anno}, {sidecar}");
        }
    }
}
