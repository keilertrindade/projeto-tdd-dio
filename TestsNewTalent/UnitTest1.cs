using NewTalents;

namespace TestsNewTalent;

public class UnitTest1
{


    public Calculadora construirClasse(){
        string data = "02/02/2020";
        Calculadora calc = new Calculadora("02/02/2022");

        return calc;
    }



    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Somar(val1,val2);
        Assert.Equal(resultado,resultadoCalculadora);

    }


    [Theory]
    [InlineData(1,2,2)]
    [InlineData(4,5,20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Multiplicar(val1,val2);
        Assert.Equal(resultado,resultadoCalculadora);

    }

    [Theory]
    [InlineData(6,2,4)]
    [InlineData(5,5,0)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Subtrair(val1,val2);
        Assert.Equal(resultado,resultadoCalculadora);

    }

    [Theory]
    [InlineData(6,2,3)]
    [InlineData(5,5,1)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Dividir(val1,val2);
        Assert.Equal(resultado,resultadoCalculadora);

    }

    [Fact]
    public void TestarDivisaoPorZero(){
        Calculadora calc = new Calculadora();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));

    }

    public void TestarHistorico(){
        Calculadora calc = new Calculadora();

        calc.Somar(1,2);
        calc.Somar(2,2);
        calc.Somar(1,6);
        calc.Somar(1,89);
        
        var lista = calc.Historico();


        Assert.NotEmpty(lista);
        Assert.Equal(3,lista.Count);
    }
}