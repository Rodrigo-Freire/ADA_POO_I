using System.Globalization;

namespace Boletim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boletins boletim= new Boletins();
            boletim.GetNome();
            boletim.ValidaAno();
            boletim.GetSemestre();
            boletim.MediaNotas();

            Console.WriteLine($"Olá {boletim.nome}!");
            Console.WriteLine($"Você começou a Faculdade em {boletim.ano}.");
            Console.WriteLine($"Atualmente você esta no {boletim.semestre} período.");
            Console.WriteLine($"A média das suas notas esse semestre é {boletim.mediaNotas}.");

            Console.ReadKey();

        }

    }
}