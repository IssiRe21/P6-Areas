using System;
using NUnit.Framework;

namespace P6___Areas
{
    // Agregar atributo para indicar que es una clase con pruebas
    [TestFixture]
    class UnitTests
    {
        [Test]
        [TestCase(TestName = "Se debe crear y calcular correctamente el area de algunos triangulos")]
        public void CalcularAreaTriangulo()
        {
            //5*5/2= 12.5 -> 12
            Triangulo triangulo = new Triangulo(5,5);
            Assert.That(triangulo.CalcularArea(), Is.EqualTo(12));

            // Con numeros menores a 0 da 0 y escribe "Error"
            Triangulo triangulo1 = new Triangulo(8,-2);
            Assert.That(triangulo1.CalcularArea(), Is.EqualTo(0));


        }


        [Test]
        [TestCase(TestName = "Se debe crear y calcular correctamente el area de algunos cuadrados")]
        public void CalcularAreaCuadrado()
        {
            //3*3 = 9
            Cuadrado cuadrado = new Cuadrado(3);
            Assert.That(cuadrado.CalcularArea(), Is.EqualTo(9));

            Cuadrado cuadrado1 = new Cuadrado(-5);
            Assert.That(cuadrado1.CalcularArea(), Is.EqualTo(0));

            //50*50 = 2500
            Cuadrado cuadrado3 = new Cuadrado(50);
            Assert.That(cuadrado3.CalcularArea(), Is.EqualTo(2500));
        }

        [Test]
        [TestCase(TestName = "Se debe crear y calcular correctamente el area de algunos rectangulos")]
        public void CalcularAreaRectangulo()
        {
            //9*21 = 189
            Rectangulo rectangulo = new Rectangulo(9,21);
            Assert.That(rectangulo.CalcularArea(), Is.EqualTo(189));

            //80*20 = 1600
            Rectangulo rectangulo1 = new Rectangulo(80,20);
            Assert.That(rectangulo1.CalcularArea(), Is.EqualTo(1600));

            Rectangulo rectangulo2 = new Rectangulo(0,0);
            Assert.That(rectangulo2.CalcularArea(), Is.EqualTo(0));
        }

        [Test]
        [TestCase(TestName = "Se debe crear y calcular correctamente el area de algunos pentagonos")]
        public void CalcularAreaPentagono()
        {
            //50*4/2 = 100
            Pentagono pentagono = new Pentagono(50,4);
            Assert.That(pentagono.CalcularArea(), Is.EqualTo(100));

            Pentagono pentagono1 = new Pentagono(-6,4);
            Assert.That(pentagono1.CalcularArea(), Is.EqualTo(0));

            //93*7/2 = 325.5 
            Pentagono pentagono2 = new Pentagono(93,7);
            Assert.That(pentagono2.CalcularArea(), Is.EqualTo(325));
        }

        [Test]
        [TestCase(TestName = "Se debe crear y calcular correctamente el area de algunos Circulos")]
        public void CalcularAreaCirculo()
        {
            //6*6*π = 113.097... -> 113
            Circulo circulo = new Circulo(6);
            Assert.That(circulo.CalcularArea(), Is.EqualTo(113));

            //34*34*π = 3631.681... -> 3632
            Circulo circulo1 = new Circulo(34);
            Assert.That(circulo1.CalcularArea(), Is.EqualTo(3632));
        }
    }
}