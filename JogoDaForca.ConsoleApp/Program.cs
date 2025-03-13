namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    string[] palavras = {
                    "ABACATE",
                    "ABACAXI",
                    "ACEROLA",
                    "ACAI",
                    "ARACA",
                    "ABACATE",
                    "BACABA",
                    "BACURI",
                    "BANANA",
                    "CAJA",
                    "CAJU",
                    "CARAMBOLA",
                    "CUPUACU",
                    "GRAVIOLA",
                    "GOIABA",
                    "JABUTICABA",
                    "JENIPAPO",
                    "MACA",
                    "MANGABA",
                    "MANGA",
                    "MARACUJA",
                    "MURICI",
                    "PEQUI",
                    "PITANGA",
                    "PITAYA",
                    "SAPOTI",
                    "TANGERINA",
                    "UMBU",
                    "UVA",
                    "UVAIA"
                };

            Random geradorDeNumeros = new Random();

            int indiceEscolhido = geradorDeNumeros.Next(palavras.Length);

            string palavraEscolhida = palavras[indiceEscolhido];

            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractereAtual = 0; caractereAtual < letrasEncontradas.Length; caractereAtual++) 
                letrasEncontradas[caractereAtual] = '_';
            
            int quantidadeErros = 0;
            bool jogadorGanhou = false;
            bool jogadorPerdeu = false;

            do
            {

                string cabecaDoDesenho = quantidadeErros >= 1 ? " o " : " ";
                string troncoDoDesenho = quantidadeErros >= 2 ? "x" : " ";
                string troncoInferiorDoDesenho = quantidadeErros >= 2 ? " x " : " ";
                string bracoEsquerdoDoDesenho = quantidadeErros >= 3 ? "/" : " ";
                string bracoDireitoDoDesenho = quantidadeErros >= 4 ? "\\" : " ";
                string pernasDoDesenho = quantidadeErros >= 5 ? "/ \\" : " ";


                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(" ___________        ");
                Console.WriteLine(" |/        |        ");
                Console.WriteLine(" |        {0}       ", cabecaDoDesenho);
                Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdoDoDesenho, troncoDoDesenho, bracoDireitoDoDesenho);
                Console.WriteLine(" |        {0}       ", troncoInferiorDoDesenho);
                Console.WriteLine(" |        {0}       ", pernasDoDesenho);
                Console.WriteLine(" |                  ");
                Console.WriteLine(" |                  ");
                Console.WriteLine("_|____              ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Erros do Jogador " + quantidadeErros);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Palavra Escolhida: " + string.Join(" ", letrasEncontradas));
                Console.WriteLine("-----------------------------------------");

                //dado um caractere
                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()!.ToUpper()[0];

                //logica do jogo
                

                bool letraFoiEncontrada = false;
                
                for (int contadorCaracteres = 0; contadorCaracteres < palavraEscolhida.Length; contadorCaracteres++)
                {
                    char caractereAtual = palavraEscolhida[contadorCaracteres];

                    if (chute == caractereAtual)
                    {
                        letrasEncontradas[contadorCaracteres] = caractereAtual;
                        letraFoiEncontrada = true;
                    }
                    
                }

                if (letraFoiEncontrada == false)
                    quantidadeErros++;

                string palavraEncontradaCompleta = string.Join("", letrasEncontradas);

                jogadorGanhou = palavraEncontradaCompleta == palavraEscolhida;
                jogadorPerdeu = quantidadeErros > 5;

                if (jogadorGanhou) 
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"Voce acertou a palavra {palavraEscolhida}, parabens");
                    Console.WriteLine("-----------------------------------------");
                }

                if (jogadorPerdeu) 
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"Que azar! Tente novamente");
                    Console.WriteLine("-----------------------------------------");
                    
                }
               
            } while (jogadorGanhou == false && jogadorPerdeu == false);
            
            Console.ReadLine();
        }
    }
}
