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
            while (player.vida != 0) {
                player.RestauraMana();
                Textes.FaseAtual(fase);
                Console.WriteLine(player.Details() + "\n Monstro: \n" + monstro.Details());
               

                Textes.Choice();
                choice = Console.ReadLine();

                if(choice == "a" || choice == "A") {
                    Textes.TXTipoDano("Fisico");
                    monstro.DefesaFisica(player.AtaqueCriticoFisico());
                    player.DefesaFisica(monstro.AtaqueCriticoFisico());

                    if(monstro.vida <= player.AtaqueCriticoFisico()) {
                        player.GanhoPocaoLife();
                        player.GanhoPocaoMana();
                        Textes.TXTDiedMonster();    
                        player.AumentaLVPlayer();
                        monstro.AumentaLVMonstro();
                        fase++;

                    }else if(player.vida <= monstro.AtaqueCriticoFisico()) {

                        Textes.TXTDiedYou();
                        player.ResetLv();
                        monstro.ResetLv();
                        fase = 1;
                    }
                }else if(choice == "p" || choice == "P") {
                    player.RestauraVidaPocao();
                }else if(choice == "m" || choice == "M") {
                    Textes.TXTipoDano("Magico");
                    monstro.DefesaMagica(player.Magic());
                    if (monstro.vida <= player.Magic()) {
                        player.GanhoPocaoLife();
                        player.GanhoPocaoMana();
                        Textes.TXTDiedMonster();
                        player.AumentaLVPlayer();
                        monstro.AumentaLVMonstro();
                        fase++;

                    }
                }else if(choice == "t" || choice == "T") {
                    player.RestauraManaPocao();
                }
                else {
                    Textes.TextInformacao("Comando Invalido");
                    goto Inicio;
                }


            }











        }

    }



}

    

