using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
    class Metodos
    {
        public string[] palavras = {
                "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA",
                "BACABA", "BACURI", "BANANA", "CAJA", "CAJU",
                "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA",
                "JABUTICABA", "JENIPAPO", "MACA", "MANGABA",
                "MANGA", "MARACUJA", "MURICI", "PEQUI",
                "PITANGA", "PITAYA", "SAPOTI", "TANGERINA",
                "UMBU", "UVA", "UVAIA"
                };

        public string palavraEscolhida;
        public char[] letrasEncontradas;
        public int quantidadeErros;
        public bool jogadorGanhou;
        public bool jogadorPerdeu;

        public Metodos() 
        {
            palavraEscolhida = EscolherPalavraAleatoria();
            letrasEncontradas = new char[palavraEscolhida.Length];
            for (int caractereAtual = 0; caractereAtual < letrasEncontradas.Length; caractereAtual++)
                letrasEncontradas[caractereAtual] = '_';

            int quantidadeErros = 0;
            bool jogadorGanhou = false;
            bool jogadorPerdeu = false;
        }

        public string EscolherPalavraAleatoria() 
        {
            Random geradorDeNumeros = new Random();
            int indiceEscolhido = geradorDeNumeros.Next(palavras.Length);
            return palavras[indiceEscolhido];
        }

        public void ExibirEstadoDoJogo() 
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("-----------------------------------------");
            DesenharForca();
            Console.WriteLine("Erros do Jogador " + quantidadeErros);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Palavra Escolhida: " + string.Join(" ", letrasEncontradas));
            Console.WriteLine("-----------------------------------------");
        }

        public void DesenharForca() 
        {
            string cabecaDoDesenho = quantidadeErros >= 1 ? " o " : " ";
            string troncoDoDesenho = quantidadeErros >= 2 ? "x" : " ";
            string troncoInferiorDoDesenho = quantidadeErros >= 2 ? " x " : " ";
            string bracoEsquerdoDoDesenho = quantidadeErros >= 3 ? "/" : " ";
            string bracoDireitoDoDesenho = quantidadeErros >= 4 ? "\\" : " ";
            string pernasDoDesenho = quantidadeErros >= 5 ? "/ \\" : " ";

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
        }

        public void ProcessarChute(char chute) 
        {
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

        }

        public void ExibirResultadoFInal() 
        {
            
            if (jogadorGanhou)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Voce acertou a palavra {palavraEscolhida}, parabens");
                Console.WriteLine("-----------------------------------------");
            } 
            if(jogadorPerdeu)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Que azar! Tente novamente");
                Console.WriteLine("-----------------------------------------");

            }
        }

        public bool JogoContinua() 
        {
            return !jogadorGanhou && !jogadorPerdeu;
        }

    }
}
