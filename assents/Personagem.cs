using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLogicaProgramacao.assents {
    class Personagem {

        private double ataque = 10;
        private double defesa = 30;
        private double vida = 100;
        private double taxa_critica = 0.05;
        private double dano_critico = 1;
        private uint lv = 0;


        public Personagem() { }


        public void aumtdefesa() {
            this.defesa += 1;

        }
        public double getAtaque() {
            return this.ataque;
        }

        public double getVida() {
            return this.vida;
        }



        public double AtaqueCritico() {
            Random randon = new Random();
            double chance = randon.NextDouble();
            if (chance < this.taxa_critica) {
                Console.WriteLine("Golpe Critico!");
                return this.ataque + this.dano_critico;

            }
            else {
                return this.ataque;
            }

        }


        public double defender(double ataque) {
            double valorDano = (this.defesa - AtaqueCritico());
            if (vida < valorDano) {
                Console.WriteLine("Morreu!");
                reset();
            }
            return vida -= valorDano;
            
        }

        public void reset() {
            this.ataque = 10;
            this.defesa = 30;
            this.vida = 100;
            this.dano_critico = 5.0;
            this.taxa_critica = 0.1;
            this.lv = 0;
        }

        public void AumentaLV() {
            this.lv += 1;
            this.ataque += (this.ataque * 0.1);
            this.defesa += (this.defesa * 0.1);
            this.vida += (this.vida * 0.2);
            this.dano_critico += (this.dano_critico * 0.05);
            this.taxa_critica += (this.taxa_critica * 0.05);
        }



        public string details() {
            return
                "Nivel: "
                + lv
                + "\n"
                + "Ataque: "
                + ataque.ToString("N")
                + "\n"
                + "Defesa: "
                + defesa.ToString("N")
                + "\n"
                + "Vida: "
                + vida.ToString("N")
                + "\n"
                + "Taxa critica: "
                + taxa_critica.ToString("N")
                + "\n"
                + "Dano critico: "
                +  dano_critico.ToString("N");
        }
    }
}
