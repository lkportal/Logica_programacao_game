﻿using JogoLogicaProgramacao.assents;

namespace JogoLogicaProgramacao {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Batalha Automatica");
            Console.WriteLine("A cada turno você pode decidir em ataca ou defender\n Ataque: Causa dano ao mostro \n Defender: não causa dano mais aumenta a defesa em +1");
            Console.WriteLine();
            int fase = 1;


            Personagem principal = new Personagem();
            Personagem mostro = new Personagem();
            Inicio:
            while(principal.getVida() >=0) {
                Console.WriteLine("fase Atual: " + fase);  
                Console.WriteLine("Principal: \n" + principal.details());
                Console.WriteLine();
                Console.WriteLine("Mostro: \n" + mostro.details());
                Console.WriteLine();
                Console.WriteLine("Gostaria de ataca ou Defende \n Ataque(a) \n Defender(d)");
                
              string choice = Console.ReadLine();

                if (choice == "a") {
                    mostro.defender(principal.getAtaque());

                    if (mostro.getVida() < principal.getAtaque()) {
                        Console.WriteLine("Voce matou o mostro e subiu de nivel");
                        principal.AumentaLV();
                        mostro.reset();
                        mostro.AumentaLV();
                        fase++;

                    }

                }
                else if (choice == "d") {
                    principal.aumtdefesa();
                    principal.defender(mostro.getAtaque());
                    if (principal.getVida() < mostro.getAtaque()) {
                        principal.reset();
                        mostro.reset();
                        fase = 1;
                        goto Inicio;
                    }
                }
                else if (choice != "a" || choice != "d") {
                    Console.WriteLine("Digitou Comando errado!");
                    goto Inicio;
                }



                }

           





        }
    }
}