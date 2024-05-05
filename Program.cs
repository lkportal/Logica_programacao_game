using JogoLogicaProgramacao.assents;
using JogoLogicaProgramacao.util;

namespace JogoLogicaProgramacao {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Batalha Por Turnos");

          
            int fase = 1;
            Textes.DigiteName();
            string nome = Console.ReadLine();



            Scene scene = new Scene();
            scene.PlayGame(fase,nome);

           





        }
    }
}