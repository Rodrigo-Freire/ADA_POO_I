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

            TV_Com_Construtor televisao2 = new TV_Com_Construtor(0, 0, "Off");

            Console.WriteLine();
            Console.WriteLine("Iniciando TV2");
            televisao2.Ligar();
            televisao2.Ligar();
            televisao2.Desligar();
            televisao2.Desligar();
            televisao2.Ligar();
            televisao2.MudarCanal(13);
            televisao2.MudarCanal(04);
            televisao2.AumentarVolume(1);
            televisao2.AumentarVolume(50);
            televisao2.AumentarVolume(60);
            televisao2.AumentarVolume(10);
            televisao2.DiminuirVolume(1);
            televisao2.DiminuirVolume(90);
            televisao2.DiminuirVolume(9);
            televisao2.DiminuirVolume(10);


            Console.ReadKey();
        }
    }
}