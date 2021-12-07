using System;

class Funcionario : Pessoa //a classe Funcionario deriva da classe Pessoa
{
    //atributos ->
    private double salario;

    //método construtor
    public Funcionario(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemFuncionario();
    }

    //método
    private void mensagemFuncionario()
    {
        Console.WriteLine("Salario: " + salario);
    }
}
