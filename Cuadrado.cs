using System;

namespace P6___Areas
{
    class Cuadrado
    {
        int medidaLado;

        public Cuadrado(int medidaLado)
        {
            this.medidaLado = medidaLado;
        }

        public int CalcularArea()
        {
            if(this.medidaLado < 1)
            {
                System.Console.WriteLine("Error");
                return 0;
            }
            else
            {
                int area = this.medidaLado * this.medidaLado;
                return area;
            }   
        }
    }

}