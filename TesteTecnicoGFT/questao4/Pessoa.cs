using System;

public class Pessoa
{
    public string Nome { get; private set; }
    public string Rg { get; private set; }

    public Pessoa(string nome, string rg)
    {
        this.Nome = nome;
        this.Rg = rg;
    }
}
