using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPintura
{
    class Calculadora
    {
        private double areaParedes;
        private double areaTeto;

        public double CalcularAreaParedes(double largura, double profundidade, double altura)
        {
            areaParedes = 2 * (largura + profundidade) * altura;
            return areaParedes;
        }

        public double CalcularAreaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade;
            return areaTeto;
        }

        public double CalcularLitragem()
        {
            if(areaParedes  == 0 && areaTeto == 0)
            {
                Console.WriteLine("Não é possivel realizar o calculo da litragem. Tente novamente com outro valor!");
                Console.ReadLine();
                Environment.Exit(1);
            }
            return (areaParedes + areaTeto) / 10;
        }
    }
}
