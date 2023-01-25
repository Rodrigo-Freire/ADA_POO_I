using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Televisão
{
    public class TV
    {
        public int canal { get; set; }
        public int volume { get; set; }
        public string? ligada { get; set; }

        public string Ligar()
        {
            if (ligada != "On")
            {
                ligada = "On";
                Console.WriteLine($"O status da TV é {ligada} e ela esta ligada.");
                
            }
            else
            {
                Console.WriteLine("TV já esta ligada");
            }
            return ligada;
        }

        public string Desligar()
        {
            if (ligada == "On")
            {
                ligada = "Off";
                Console.WriteLine($"O status da TV é {ligada} e ela esta desligada.");
            }
            else
            {
                Console.WriteLine("TV já esta desligada");
            }
            return ligada;
        }

        public int MudarCanal (int canal)
        {
            if (this.ligada == "Off")
            {
                Console.WriteLine("Não é possível mudar o canal! TV esta desligada");
            }
            else
            {
                this.canal = canal;
                Console.WriteLine($"TV sintonizada no canal {canal}");
            }
            return canal;
        }

        public int AumentarVolume(int volume)
        {
            if (this.ligada == "Off")
            {
                Console.WriteLine("Não é possível aumentar o volume! TV esta desligada");
            }
            else
            {
                if (this.volume < 100)
                {
                    this.volume += volume;
                    if (this.volume > 100)
                    {
                        this.volume = 100;
                        Console.WriteLine("Volume Máximo!");
                    }
                    else
                    {
                        Console.WriteLine($"Volume ajustado para {this.volume}");
                    }
                }
                else
                {
                    Console.WriteLine("TV já está no volume máximo!");
                }
            }            
            return volume;
        }

        public int DiminuirVolume(int volume)
        {
            if (this.ligada == "Off")
            {
                Console.WriteLine("Não é possível diminuir o volume! TV esta desligada");
            }
            else
            {
                if (this.volume > 0)
                {
                    this.volume -= volume;
                    if (this.volume <= 0)
                    {
                        this.volume = 0;
                        Console.WriteLine("Volume Mínimo!");
                    }
                    else
                    {
                        Console.WriteLine($"Volume ajustado para {this.volume}");
                    }
                }
                else
                {
                    Console.WriteLine("TV já esta no volume mínimo!");
                }
            }            
            return volume;
        }
    }
}
