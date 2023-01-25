using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Televisão
{
    public class TV_Com_Construtor : TV
    {
        public TV_Com_Construtor(int canal, int volume, string ligada)
        {
            this.canal = canal;
            this.volume = volume;
            this.ligada = ligada;
        }

    }
}
