namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(2, 2);

            // Assert
            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(1, 1 ,2)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 2, 6)]
        [InlineData(7, 2, 9)]
        [InlineData(6, 6, 12)]
        [InlineData(9, 9, 18)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double x, double y, double total)
        {
            // Arrange 
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(x, y);

            //Assert
            Assert.Equal(total, resultado);
        }

        [Fact]
        public void Calculadora_Dividir_RetornarValorDivisao()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Dividir(10, 2);

            //Assert
            Assert.Equal(5, resultado);
        }

    }
}
