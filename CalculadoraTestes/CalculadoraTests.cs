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
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]

    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    {
        //Arrange

        //Act
        bool resuldado = _calc.EhPar(numero);

        //Assert
        Assert.True(resuldado);
    }
}