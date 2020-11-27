using System;

namespace P6___Areas
{
    class Pentagono
    {
       int perimetro;
       int apotema;
       public Pentagono(int perimetro, int apotema)
       {
           this.perimetro = perimetro;
           this.apotema = apotema;
       }

       public int CalcularArea()
       {
            if(this.perimetro < 1 || this.apotema < 1)
            {
                System.Console.WriteLine("Error");
                return 0;
            }
            else
            {
                int area = this.perimetro * this.apotema / 2;
                return area;
            }   
        }
    }
}