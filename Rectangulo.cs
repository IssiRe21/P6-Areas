using System;

namespace P6___Areas
{
    class Rectangulo
    {
       int valorBase;
       int altura;

       public Rectangulo(int valorBase, int altura)
       {
           this.valorBase = valorBase;
           this.altura = altura;
       }

       public int CalcularArea()
       {
            if(this.valorBase < 1 || this.altura < 1)
            {
                System.Console.WriteLine("Error");
                return 0;
            }
            else
            {
                int area = this.valorBase * this.altura;
                return area;
            }   
        }
    }
}