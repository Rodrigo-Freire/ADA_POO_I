using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    public class Boletins
    {
        public string nome { get; set; }
        public int ano { get; set; }
        public int semestre { get; set; }
        public double mediaNotas {get; set; }

        
        public void ValidaAno()
        {
            int anoMínimo = 1964;
            int anoAtual = DateTime.Now.Year;
            int anoConvertido;
            while(true)
            {
                Console.Write("Por favor digige o ano de ingresso a partir de 1964: ");
                string inputAno = Console.ReadLine();
                if(int.TryParse(inputAno, out anoConvertido)&& anoConvertido>= anoMínimo && anoConvertido <= anoAtual)
                {
                    this.ano= anoConvertido;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ano Inválido!");
                }
            }

        }

        public void GetNome()
        {
            while(true)
            {
                Console.Write("Por favor, digite seu nome completo: ");
                string nomeCompleto = Console.ReadLine();
                if(nomeCompleto.Split(' ').Length >= 2)
                {
                    this.nome= nomeCompleto;    
                    break;
                }
                else { Console.Clear(); Console.WriteLine("Nome Inválido!"); }
            }
            
        }

        public void GetSemestre()
        {
            while(true)
            {
                Console.Write("Por favo, digite o semestre que esta cursando entre 1-14: ");
                string inputSemestre = Console.ReadLine();
                if (int.TryParse(inputSemestre, out int semeste) && semeste >= 1 && semeste <= 14)
                {
                    this.semestre= semeste;
                    break;
                }
                else { Console.Clear(); Console.WriteLine("Semestre inválido!"); }
            }
        }

        public void MediaNotas()
        {
            List<int> notas= new List<int>();
            int numeroMateria = 0;
            List<string> nomeMaterias= new List<string>();
            nomeMaterias.Add("Português");
            nomeMaterias.Add("Matemática");
            nomeMaterias.Add("História");
            nomeMaterias.Add("Física");
            nomeMaterias.Add("Biologia");
            nomeMaterias.Add("Química");            
            

            while (notas.Count < 6)
            {
                
                while (true)
                {
                    Console.Write($"Por favor, digite sua nota de ({nomeMaterias[numeroMateria]}): ");
                    string inputNota = Console.ReadLine();
                    if (int.TryParse(inputNota, out int nota) && nota >= 0 && nota <= 10)
                    {
                        notas.Add(nota);
                        numeroMateria++;
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear(); Console.WriteLine("Nota inválida!");
                    }
                }


            }

            int somaNotas = 0;
            foreach(int i in notas)
            {
                somaNotas += i;
            }
            this.mediaNotas = somaNotas / notas.Count;

            

        }
    }
}
