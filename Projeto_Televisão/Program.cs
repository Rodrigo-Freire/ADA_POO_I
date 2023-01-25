namespace Projeto_Televisão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            TV televisao= new TV();

            televisao.Ligar();
            televisao.Ligar();
            televisao.Desligar();
            televisao.Desligar();
            televisao.Ligar();
            televisao.MudarCanal(13);
            televisao.MudarCanal(04);
            televisao.AumentarVolume(1);
            televisao.AumentarVolume(50);
            televisao.AumentarVolume(60);
            televisao.AumentarVolume(10);
            televisao.DiminuirVolume(1);
            televisao.DiminuirVolume(90);
            televisao.DiminuirVolume(9);
            televisao.DiminuirVolume(10);


            Console.ReadKey();
        }
    }
}