using System;

namespace P6___Areas
{
    class Circulo
    {
       int radio;

       public Circulo(int radio)
       {
           this.radio = radio;
       }

       public int CalcularArea()
       {
            if(this.radio < 1)
            {
                System.Console.WriteLine("Error");
                return 0;
            }
            else
            {
                double areaDecimal = this.radio * this.radio * Math.PI;
                int area = Convert.ToInt32(areaDecimal);
                return area;
            }   
        }
    }
}