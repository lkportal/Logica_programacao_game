using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLogicaProgramacao.util {

   abstract class Mob {


        public string Nome { get; set; }
        public  double ataque { get; set; } 
        public double  defesa_fisica { get; set; } 
        public uint vida { get; set; } 
        public double taxa_critica { get; set; } 
        public double dano_critico { get; set; } 
        public double dano_magico { get; set; } 
        public double defesa_magica { get; set; }
        public uint lv { get; set; } = 1;

        public uint Mana { get; set; }
        
        public double Resistencia_Fisica { get; set; }

        public double Resistencia_Magica { get; set; }



        public abstract double AtaqueCriticoFisico();


        public abstract void DefesaFisica(double a);

        public abstract void DefesaMagica(double a);

        public abstract void ResetLv();

        public abstract string Details();

        public abstract double Magic();
          

    }


}
