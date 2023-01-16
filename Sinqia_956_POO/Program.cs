using Sinqia_956_POO.Models;

namespace Sinqia_956_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(100, "Rodrigo", 123456);

            conta.extrato();
            Console.WriteLine("\nRealizando Saque...");
            conta.Sacar(9.90);
            Console.WriteLine("\nSaque efetuado!\n");
            conta.extrato();
            Console.WriteLine("\n Realizando Transferência...");
            conta.Transferir(40);
            Console.WriteLine("\nTransferência conluída!\n");
            conta.extrato();

        }
    }
}