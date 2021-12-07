using System;

class Pessoa
{
    //atributos ->
    protected string nome;
    protected int idade;

    //método
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
    }
}