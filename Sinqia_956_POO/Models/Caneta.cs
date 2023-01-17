using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia_956_POO.Models
{
    public class Caneta
    {
        public string cor { get; set; }
        public string marca { get; set; }

        public string tipo { get; set; }

        public Caneta(string cor, string marca, string tipo)
        {
            this.cor = cor;
            this.marca = marca;
            this.tipo = tipo;
        }

        public void newObject(string cor, string marca, string tipo)
        {
            this.cor = cor;
            this.marca = marca;
            this.tipo = tipo;
        }
    }
}
