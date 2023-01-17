using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia_956_POO.Models
{
    public class Pessoa
    {
        public string nomeCompleto { get; set; }        
        public string email { get; set; }
        
        
        public Pessoa(string nomeCompleto, string email)
        {
            
            this.nomeCompleto = nomeCompleto;
            this.email = email;            

        }

        public void primeiroNome() 
        {
            if(nomeCompleto != null)
            {
                string[] partesNome= nomeCompleto.Split(' ');
                string primeiroNome = partesNome[0];
                Console.WriteLine(primeiroNome);
            }
        }
    }
            
}
