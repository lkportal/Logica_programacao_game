using JogoLogicaProgramacao.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLogicaProgramacao.assents {
    class Scene {

        Monstros monstro = new Monstros();
        string choice;
        int fase = 1;


        public void PlayGame(int fase,string nome) {
            Personagem player = new Personagem(nome);
        Inicio:
            
            for(int i = 0;i != player.vida; i++) {

                player.RestauraMana();
                Textos.FaseAtual(fase);
                Console.WriteLine(player.Details() + "\n Monstro: \n" + monstro.Details());
                Textos.Choice();
                choice = Console.ReadLine();
                switch (choice.ToLower()) {
                    case "a":

                        Textos.TXTipoDano("Fisico");
                        monstro.DefesaFisica(player.AtaqueCriticoFisico());
                        player.GanhoPocaoLife();
                        player.GanhoPocaoMana();
                        if (monstro.vida <= player.AtaqueCriticoFisico()) {
                            Textos.TXTDiedMonster();
                            player.AumentaLVPlayer();
                            monstro.AumentaLVMonstro();
                            fase++;

                        }
                        else {
                            player.DefesaFisica(monstro.AtaqueCriticoFisico());
                            if (player.vida <= monstro.AtaqueCriticoFisico()) {
                                Textos.TXTDiedYou();
                                fase = 1;
                            }
                        }
                        break;

                    case "m":

                        Textos.TXTipoDano("Magico");
                        monstro.DefesaMagica(player.Magic());
                        player.GanhoPocaoLife();
                        player.GanhoPocaoMana();

                        if (monstro.vida <= player.Magic()) {
                            player.GanhoPocaoLife();
                            player.GanhoPocaoMana();
                            Textos.TXTDiedMonster();
                            player.AumentaLVPlayer();
                            monstro.AumentaLVMonstro();
                            fase++;
                            if (player.vida <= monstro.AtaqueCriticoFisico()) {
                                player.DefesaMagica(monstro.AtaqueCriticoFisico());
                            }
                        }
                        
                        break;

                    case "p":
                        player.RestauraVidaPocao();

                        break;
                    case "t":
                        player.RestauraManaPocao();

                        break;
                    default:
                        Textos.TextInformacao("Comando Invalido");
                        goto Inicio;


                }
            }

            
             




         











        }

    }



}

    

