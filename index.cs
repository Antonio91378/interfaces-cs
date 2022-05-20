using System;

//as interfaces são semelhantes à elementos abstracts, porém ele esboça apenas métodos para a classe.
//a classe que usar essa interface terá que obrigatóriamente terá que implementar os métodos declarados
public interface Veiculo
{
    void ligar();

    void desligar();

    void info();
}

public interface Combate
{
    void disparar();
}

class Carro : Veiculo, Combate
{
    public bool ligado;

    public Carro()
    {
    }

    public void ligar()
    {
        this.ligado = true;
    }

    public void desligar()
    {
        this.ligado = false;
    }

    public void info()
    {
    }

    public void disparar()
    {
    }
}

class Principal
{
    static void Main()
    {
        Carro c1 = new Carro();
    }
}
