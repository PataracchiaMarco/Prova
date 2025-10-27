using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal class moto
    {
        public string Targa { get; set; }
        private string Marca { get; set; }
        private int Anno { get; set; }

        public moto(string Targa, string Marca, int Anno)
        {
            this.Targa = Targa;
            this.Marca = Marca;
            this.Anno = Anno;
        }

        public virtual void MostraDettagli()
        {
            Console.WriteLine($"Veicolo:{Marca} {Targa}, Anno:{Anno}");
        }
    }
}
