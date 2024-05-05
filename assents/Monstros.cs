using JogoLogicaProgramacao.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLogicaProgramacao.assents {
        class Monstros: Mob {
            Random randon = new Random();

        public Monstros() {
            ataque = 15.00;
            defesa_fisica = 10;
            vida = 100;
            dano_magico = 10;
            taxa_critica = 0.01;
            dano_critico = 0.05;
            defesa_magica = 5;
            Resistencia_Fisica = 0.05;
            Resistencia_Magica = 0.05;
        }

        public void AumentaLVMonstro() {
            lv += 1;
            ataque +=  0.2;
            defesa_fisica += 0.2;
            defesa_magica += 5;
            vida += 200;
            dano_critico +=  0.05;
            taxa_critica +=  0.05;
            Resistencia_Fisica += 0.02;
            Resistencia_Magica += 0.02;

        }

        public override double AtaqueCriticoFisico() {
            double chance = randon.NextDouble();
            if (taxa_critica > chance) {
                Textes.TXTCritico("Monstro");
                return ataque += dano_critico;
            }
            else {
                return ataque;
            }
        }

        public override void DefesaFisica(double ataqueFisico) {

            double valorDano = (ataqueFisico - defesa_fisica);
            double chanceResistencia = randon.NextDouble();
            double resistenciaDano = (defesa_fisica + Resistencia_Fisica) - ataqueFisico;

           if (chanceResistencia < this.Resistencia_Fisica) {
                Console.WriteLine("Resistencia Ativada! Mosntro");
               vida -= (uint) resistenciaDano;
            }
                vida -= (uint) valorDano;
        }

        public override void ResetLv() {
            ataque = 15;
            defesa_fisica = 20;
            vida = 100;
            dano_critico = 5.0;
            taxa_critica = 0.1;
            Resistencia_Magica = 0.05;
            Resistencia_Magica = 0.05;
            lv = 1;
        }

        public override double Magic() {
            return dano_magico;
        }

        public override void DefesaMagica(double ataqueMagico) {
            double valorDano;
            double chanceResistencia = randon.NextDouble();
            double resistenciaDano;

            if (ataqueMagico > 0) {
                valorDano = (ataqueMagico - defesa_magica);
                chanceResistencia = randon.NextDouble();
                resistenciaDano = (defesa_magica + Resistencia_Magica) - ataqueMagico;
                if (chanceResistencia < Resistencia_Magica) {
                    Console.WriteLine("Resistencia Magica Ativada!Monstro");
                    vida -= (uint)resistenciaDano;
                }
                else {
                    vida -= (uint)valorDano;
                }

            }
            else {
                vida = vida;
            }
           
        }
        public override string Details() {
            return
              "Nivel: "
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
              + "\n";
 

        }
    }
}
