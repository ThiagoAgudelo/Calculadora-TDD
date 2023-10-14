using CalculadoraTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebaCalculadora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumaDosNumeros()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            string resultado = Calculadora.RealizarOperacion(1, num1, num2);

            // Assert
            Assert.AreEqual("8", resultado);
        }

        [TestMethod]
        public void DivisionPorCero()
        {
            // Arrange
            double num1 = 10;
            double num2 = 0;

            // Act
            string resultado = Calculadora.RealizarOperacion(4, num1, num2);

            // Assert
            Assert.IsTrue(resultado == "No se puede dividir x cero");
        }

        [TestMethod]
        public void Multiplicacion2Numeros()
        {
            double num1 = 3;
            double num2 = 4;


            string resultado = Calculadora.RealizarOperacion(3, num1, num2);

            Assert.AreEqual(12, resultado);
        }

    }
}
