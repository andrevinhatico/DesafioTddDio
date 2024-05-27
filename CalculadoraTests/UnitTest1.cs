using CalculadoraProj;

namespace CalculadoraTests
{
    public class UnitTest1
    {

        public Calculadora ConstruirClasse()
        {
            string data = "27/05/2024";

            Calculadora calc = new("27/05/2024");

            return calc;               
        }

      



        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void DeveRetornarSomaDe2Inteiros(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            // Arrange


            // Act
            int resultadoCalculadora = calc.Somar(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void DeveRetornarSubtracaoDe2Inteiros(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            // Arrange


            // Act
            int resultadoCalculadora = calc.Subtrair(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void DeveRetornarMultiplicacaoDe2Inteiros(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            // Arrange


            // Act
            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void DeveRetornarDivisaoDe2Inteiros(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            // Arrange


            // Act
            int resultadoCalculadora = calc.Dividir(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)

                );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = ConstruirClasse();

            calc.Somar(1,2);
            calc.Somar(2,8);
            calc.Somar(3,7);
            calc.Somar(4,1);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }

    }

}