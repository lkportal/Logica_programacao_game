using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLogicaProgramacao.assents {
     class Personagem {

        private uint ataque = 10;
        private uint defesa = 30;
        private uint vida =100;

        private  uint lv = 0;


       public Personagem() { }

        Personagem(uint ataque, uint defesa, uint vida) {
            this.ataque = ataque;
            this.defesa = defesa;   
            this.vida = vida;   
        }    
        public void aumtdefesa() {
            this.defesa += 1;
            
        }
        public uint getAtaque() {
            return this.ataque;
        }
     

        public uint getVida() {
            return this.vida;
        }
        public uint defender(uint ataque) {
           uint valorDano= (this.defesa - ataque);
            if(vida < valorDano) {
                Console.WriteLine("Morreu!");
                reset();
            }
           return vida -= valorDano;

        }

        public void reset() {
            this.ataque = 10;
            this.defesa = 30;
            this.vida = 100;    
            this.lv = 0;
        }

        public void AumentaLV() {
            this.lv += 1;
            this.ataque += 2;
            this.defesa += 1;
            this.vida += 5;
        }

     



        public string details() {
            return "Ataque: " + ataque + "\n" + "Defesa: " + defesa + "\n" + "Vida:" + vida + "\n" + "Nivel:" + lv;
        }
    }
}
