using NewTalent.Services;
namespace NewTalentTests;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "02/02/2020";
        Calculadora calc = new Calculadora(data);

        return calc;
    }
    
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (3, 4, 7)]
    public void TesteSomar(int val1, int val2, int resultadoEsperado)
    {
        Calculadora calc = construirClasse();
        
        //Act
        int resultado = calc.Somar(val1,val2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (3, 4, 12)]
    public void TesteMultiplicar(int val1, int val2, int resultadoEsperado)
    {
        Calculadora calc = construirClasse();
        
        //Act
        int resultado = calc.Multiplicar(val1,val2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData (4, 2, 2)]
    [InlineData (12, 4, 3)]
    public void TesteDividir(int val1, int val2, int resultadoEsperado)
    {
        Calculadora calc = construirClasse();
        
        //Act
        int resultado = calc.Dividir(val1,val2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData (4, 2, 2)]
    [InlineData (12, 4, 8)]
    public void TesteSubtrair(int val1, int val2, int resultadoEsperado)
    {
        Calculadora calc = construirClasse();
        
        //Act
        int resultado = calc.Subtrair(val1,val2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void TesteDividirpor0()
    {
        Calculadora calc = construirClasse();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        //Arrange
        Calculadora calc = construirClasse();
        calc.Somar(1,2);
        calc.Somar(4,2);
        calc.Somar(9,2);
        calc.Somar(1,25);

        // Act
        var lista = calc.Historico();

        // Assert
        Assert.NotEmpty(calc.Historico());
        Assert.Equal(3, lista.Count);
    }    
}