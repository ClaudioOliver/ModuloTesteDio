using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resuldado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resuldado);


    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        //Act
        int resuldado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(20, resuldado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;

        //Act
        bool resuldado = _calc.EhPar(numero);

        //Assert
        Assert.True(resuldado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]

    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Act / Assert

        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}