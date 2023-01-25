using Sinqia_956_POO.Models;

namespace Sinqia_956_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conta 
            /*Conta conta = new Conta(100, "Rodrigo", 123456);

            conta.extrato();
            Console.WriteLine("\nRealizando Saque...");
            conta.Sacar(9.90);
            Console.WriteLine("\nSaque efetuado!\n");
            conta.extrato();
            Console.WriteLine("\n Realizando Transferência...");
            conta.Transferir(40);
            Console.WriteLine("\nTransferência conluída!\n");
            conta.extrato();*/
            #endregion

            #region Pessoa
            /*Pessoa pessoa = new Pessoa("Rodrigo Freire", "rodrigo.freire@msn.com");
            Console.WriteLine($"Nome completo: {pessoa.nomeCompleto}" + $"\nemail: {pessoa.email}");
            Console.Write("Primeiro Nome: ");
            pessoa.primeiroNome();*/



            #endregion

            #region Caneta

            Caneta caneta = new Caneta("PRETA", "BIC", "ESFEROGRAFICA");


            Console.WriteLine($"Cor da Caneta: {caneta.cor}" +
                $"\nMarca da Caneta: {caneta.marca}" +
                $"\nTipo de Caneta: {caneta.tipo}");

            Console.WriteLine("\nMake a new object");

            caneta.newObject("AZUL", "CROW", "TINTEIRA");

            Console.WriteLine($"\nCor da Caneta: {caneta.cor}" +
                $"\nMarca da Caneta: {caneta.marca}" +
                $"\nTipo de Caneta: {caneta.tipo}");


            #endregion


        }
    }
}