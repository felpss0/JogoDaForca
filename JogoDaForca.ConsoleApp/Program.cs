namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos jogo = new Metodos();

            do
            {
                jogo.ExibirEstadoDoJogo();
               
                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()!.ToUpper()[0];

                jogo.ProcessarChute(chute);
            
            } while (jogo.JogoContinua());

            jogo.ExibirResultadoFInal();
            Console.ReadLine();
        }

    }
}