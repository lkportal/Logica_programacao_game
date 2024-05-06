using JogoLogicaProgramacao.util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JogoLogicaProgramacao.assents {

  struct Pocao {
     public  double Restaura;
     public int Quantidade;
     public  double TAX_Pocoe;
    }
    class Personagem : Mob {


        
        Stopwatch sp = new Stopwatch();
        Random randon = new Random();



        public Personagem( string nome ) {
            this.ataque = 20 ;
            this.defesa_fisica = 10 ;
            this.vida = 200 ;
            this.dano_magico = 25;
            this.taxa_critica = 0.01;
            this.dano_critico = 0.05;
            this.defesa_magica = 15;
            this.Mana = 100;
            this.Nome = nome;
            this.Resistencia_Fisica = 0.09;
            this.Resistencia_Magica = 5;
            
           

        }



        Pocao PMana = new Pocao() {
            Restaura = 50,
            Quantidade = 0,
            TAX_Pocoe = 0.1,
        };


        Pocao Life = new Pocao() {
            Restaura = 20,
            Quantidade = 1,
            TAX_Pocoe = 0.15
        };

        public int GanhoPocaoLife() {
    
            double chance = randon.NextDouble();
            int pocoes = 0;
            if (chance < Life.TAX_Pocoe) {
                pocoes++;
                 return Life.Quantidade += pocoes;
            }
            else {
                return Life.Quantidade;
            }
        }
        public int GanhoPocaoMana() {

            double chance = randon.NextDouble();
            int pocoes = 0;
            if (chance < PMana.TAX_Pocoe) {
                pocoes++;
                return PMana.Quantidade += pocoes;
            }
            else {
                return PMana.Quantidade;
            }
        }
        public void RestauraVidaPocao() {
            if(Life.Quantidade > 0) {
                vida += (uint) Life.Restaura;
                --Life.Quantidade;
            }
            else {
                Console.WriteLine("Não Tem Poçoes de Vida");
            }
        }

        public void RestauraManaPocao() {
            if (PMana.Quantidade > 0) {
                Mana += (uint)PMana.Restaura;
                --PMana.Quantidade;
            }
            else {
                Console.WriteLine("Não Tem Poçoes de Mana");
            }
        }

        public void AumentaLVPlayer() {
            lv += 1;
            ataque += 0.1;
            defesa_fisica +=  0.2;
            vida += 100;
            dano_critico += 0.05;
            taxa_critica += 0.05;
            Resistencia_Fisica += 0.02;
            Resistencia_Magica += 0.03;
            Mana += 10;
            dano_magico += 5;
        }
        public override double AtaqueCriticoFisico() {
            double chance = randon.NextDouble();
            if (taxa_critica > chance) {
                Textos.TXTCritico(Nome);
                return ataque += dano_critico;
            }
            else {
                return ataque;
            }
        }

        public override void DefesaMagica(double ataqueMagico) {

            double valorDano = (ataqueMagico - defesa_magica);
            double chanceResistencia = randon.NextDouble();
            double resistenciaDano = (defesa_magica + Resistencia_Magica) - ataqueMagico;
            if (chanceResistencia < Resistencia_Magica) {
                Console.WriteLine("Resistencia Magica Ativada!");
                vida -= (uint)resistenciaDano;
            }
            vida -= (uint)valorDano;
        }
        public override void DefesaFisica(double ataqueFisico) {

            double valorDano = (ataqueFisico - defesa_fisica);
            double chanceResistencia = randon.NextDouble();
            double resistenciaDano = (defesa_fisica + Resistencia_Fisica) - ataqueFisico;
            if (chanceResistencia < Resistencia_Fisica) {
                Console.WriteLine("Resistencia Fisica Ativada!");
                vida -= (uint) resistenciaDano;
            }
                     vida -= (uint) valorDano;
        }
     
        public async  void RestauraMana() {
        InicioMana:
            sp.Start();
            uint resmana = Mana;
            while (Mana != resmana  ) {

                await Task.Delay(1000);
                Mana++;
                sp.Restart();

            }
            sp.Stop();
        }

        public override void ResetLv() {
            ataque = 10;
            defesa_fisica = 30;
            vida = 100;
            dano_critico = 5.0;
            taxa_critica = 0.1;
            lv = 1;
            Resistencia_Magica = 0.02;
            Resistencia_Magica = 0.03;
        }

        public override double Magic() {
            if(lv < 10 || Mana < 20) {
                Textos.TextInformacao("Nivel Baixo ou Mana Insuficiente");
                return 0;
            }
            else {
                Mana -= 20;
                return dano_magico;
            }
            
            

        }

        public override string Details() {
            return "Player: "
              + Nome
              + "\n"
              + "Nivel: "
              + lv
              + "\n"
              + "Ataque: "
              + ataque.ToString("N")
              + "\n"
              + "Defesa Fisica: "
              + defesa_fisica.ToString("N")
              + "\n"
              + "Vida: "
              + vida
              + "\n"
              + "Taxa critica: "
              + taxa_critica.ToString("N")
              + "\n"
              + "Dano critico: "
              + dano_critico.ToString("N")
              + "\n"
              + "Dano Magico: "
              + dano_magico.ToString("N")
              + "\n"
              + "Defesa Magica: "
              + defesa_magica.ToString("N")
              + "\n"
              + "Mana: "
              + Mana
              + "\n"
              + "POÇÃO VIDA: "
              + Life.Quantidade
              + "\n"
              + "POÇÃO MANA: "
              + PMana.Quantidade;
                
        }
    }
    
}
