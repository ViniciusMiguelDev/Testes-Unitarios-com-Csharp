namespace CalculadoraApp.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora calc = new Calculadora();

        [Fact]
        public void Somar_DeveRetornarValorCorreto()
        {
            int resultado = calc.Somar(2, 3);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Dividir_PorZero_DeveLancarExcecao()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
        }
    }
}
