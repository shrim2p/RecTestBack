namespace RECTESTBACK;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //PREPARAR
        int soma = 10+25;
        //TESTAR(UTILIZAR A FERRAMENTA QUE ESTAMOS TESTANDO)
        int calculadoraSoma = Calculadora.soma(10,25);
        //VALIDAR O RESULTADO
        Assert.Equal(soma, calculadoraSoma);
    }

    [Fact]
    public void FiltraNomes()
    {
        //PREPARAR
        List<string> NomesCriados = new List<string>(); //Cria a lista
        NomesCriados.Add("Gustavo Lima");
        NomesCriados.Add("Fernando Mamoru");
        NomesCriados.Add("Guilherme Dantas");
        NomesCriados.Add("Gabriel Ferraz ");
        //TESTAR(UTILIZAR A FERRAMENTA QUE ESTAMOS TESTANDO)
        Filtro filtro = new Filtro();
        int qtdNome = filtro.FiltrarNome(NomesCriados);
        //VALIDAR O RESULTADO
        Assert.Equal(qtdNome,3);

    }
}