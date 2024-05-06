using JogoLogicaProgramacao.assents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLogicaProgramacao.util {
      static class Textos {



        public static void TXTipoDano(string dano) {
            Console.WriteLine("Tipo de dano: " + dano);
        }
        public static void TextInformacao(string txt) {
            Console.WriteLine(" "+ txt + " ");
        }
        public static void DigiteName() {
            Console.WriteLine("Escreva o Nome do Heroi.");
        }
        public static void TextName(string nome) {
            Console.WriteLine("\n Nome: " + nome);
        }
        public static void TXTDiedMonster() {
         
            Console.WriteLine("------SUBIU DE NIVEL!-------\n");  
        }

        public static void  Choice() {
            Console.WriteLine(" Comandos:Ataque:(A) Usa Poção:(P) Usa Magia:(M) Usa Poção Mana(T)");
        }

        public static void TXTCritico(string TXT) {
            Console.WriteLine("GOLPE CRITICO !" + TXT);
        }


        public static void TXTDiedYou() {
            Console.WriteLine("VOCÊ MORREU!");
        }
        public static string FaseAtual(int _fase) {
           
            int auxFase = 1;
            string text;

            if (_fase > 10) {
                _fase = 1;
                auxFase+= _fase;
                text =  "Fase Atual: " + auxFase + " - " + _fase + "\n";
                Console.WriteLine(text);
                return text;
            }
            else {
                text = "Fase Atual: " + auxFase + " - " + _fase + "\n";
                Console.WriteLine(text);
                return text;
            }
           
        }

        


    }
}
