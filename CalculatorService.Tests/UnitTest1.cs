namespace CalculatorService.Tests;

public class DivisaoTest
{
    private readonly CalculadoraService calc = new CalculadoraService();

    #region Cenários Esperados
    [Fact]
    public void TestarPositivos()
    {
        double a = 20;
        double b = 2;

        double result = calc.Divisao(a, b);
        Assert.Equal(10, result);
    }

    [Fact]
    public void TestarPositivoENegativo()
    {
        double a = 30;
        double b = -2;

        double result = calc.Divisao(a, b);
        Assert.Equal(-15, result);
    }

    [Fact]
    public void TestarNegativos()
    {
        double a = -40;
        double b = -20;

        double result = calc.Divisao(a, b);
        Assert.Equal(20, result);
    }

    [Fact]
    public void TestarDivisaoZero()
    {
        double a = 20;
        double b = 0;

        double result = calc.Divisao(a, b);
        Assert.Equal(20, result);
    }
    #endregion
    #region Cenários Não Esperados
    [Fact]
    public void TestarDivisaoComNaN()
    {
        // Arrange
        double a = 2.0;
        double b = double.NaN;

        // Act
        double resultado = calc.Divisao(a, b);

        // Assert
        Assert.True(double.IsNaN(resultado));
    }
    #endregion
}

public class SomaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();


    #region Cenários Esperados
    [Fact]
    public void TestarSomaComMaiorNumero()
    {
        int a = int.MaxValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Soma(a, b));
    }

    [Fact]
    public void TestarSomaPositivos()
    {
        int a = 2 ;
        int b = 3;

        int result = calc.Soma(a, b);
        Assert.Equal(5, result);
    }

    [Fact]
    public void TestarSomaPositivoENegativo()
    {
        int a = -4 ;
        int b = 3;

        int result = calc.Soma(a, b);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void TestarSomaNegativos()
    {
        int a = -5;
        int b = -2;

        int result = calc.Soma(a, b);
        Assert.Equal(-7,result);
    }
    #endregion

    #region Cenários Não Esperados

    /*[Fact]
    public void TestarSomaComNaN()
    {
        int a = 1 ;
        int b = 0; //revisar

        double result = calc.Soma(a, b);
        Assert.True(double.IsNaN(result));
    }*/
    #endregion
}

public class SubtracaoTest
{
    private readonly CalculadoraService calc = new CalculadoraService();

    #region Cenários Esperados
    [Fact]
    public void TestarSubPositivos()
    {
        int a = 6;
        int b = 4;

        int result = calc.Subtracao(a, b);
        Assert.Equal(2, result);
    }

    [Fact]
    public void TestarSubPositivoENegativo()
    {
        int a = -10;
        int b = 5;

        int result = calc.Subtracao(a, b);
        Assert.Equal(-15, result);
    }
    
    [Fact]
    public void TestarNegativos()
    {
        int a = -10;
        int b = -9;

        int result = calc.Subtracao(a, b);
        Assert.Equal(-1, result);
    }

    #endregion
    #region Cenários Não Esperados

    #endregion
}


public class MultipliocacaoTest
{
    private readonly CalculadoraService calc = new CalculadoraService();

    #region Cenários Esperados
    [Fact]
    public void TestarPositivos()
    {
        int a = 1;
        int b = 4;

        int result = calc.Multiplicacao(a, b);
        Assert.Equal(4, result);
    }

    [Fact]
    public void TestarMulPositivoENegativo()
    {
        int a = 2;
        int b = 10;

        int result = calc.Multiplicacao(a, b);
        Assert.Equal(20, result);
    }

    [Fact]
    public void TestarMultNegativos()
    {
        int a = 10;
        int b = 40;

        int result = calc.Multiplicacao(a, b);
        Assert.Equal(400, result);
    }
    #endregion
    #region Cenários Não Esperados

    #endregion
}


public class MediaTest
{
    private readonly CalculadoraService calc = new CalculadoraService();

    #region Cenários Esperados

    [Fact]
    public void TestarNegativos()
    {
        double a = -10;
        double b = -40;

        double result = calc.Media(a, b);
        Assert.Equal(-25, result);
    }


    [Fact]
    public void TestarPositivos()
    {
        double a = 20;
        double b = 40;

        double result = calc.Media(a, b);
        Assert.Equal(30, result);
    }

    [Fact]
    public void TestarTresNumerosReais()
    {
        double a = 2;
        double b = 2;
        double c = 4;

        double result = calc.Media(a, b, c);
        Assert.Equal(4, result);
    }
    #endregion
    #region Cenários Não Esperados

    #endregion
}

public class MedianaTest
{
    private readonly CalculadoraService calc = new CalculadoraService();

    #region Cenários Esperados

    #endregion
    #region Cenários Não Esperados

    #endregion
}