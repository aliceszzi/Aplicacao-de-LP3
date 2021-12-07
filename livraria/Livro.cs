using System;

class Livro
{
    //atributos ->
    public string[] nome = new string[5];
    public string[] autor = new string[5];
    public int[] paginas = new int[5];
    public double[] valor = new double[5];
    int con, esc, i, obs;
    double vt;

    // métodos ->
    public void msg()
    {
        Console.WriteLine("Bem-vindo a livraria!!");
        do
        {
            vt = 0;
            do
            {
                esc = 0;
                i = 0;
                obs = 0;
                Console.WriteLine("\nEscolha um dos livros abaixo para comprar!!\nObs: Digite o respectivo número do livro.\n");
                Console.WriteLine("1 - 1984 \nPreço: 19.90 \n2 - O Príncipe Cruel \nPreço: 29.90 \n3 - A Vida Invisível de Addie Larue \nPreço: 59.90 \n4 - O Melhor de Mim \nPreço: 19.90 \n5 - Senhora \nPreço: 29.89\n");
                esc = Int32.Parse(Console.ReadLine());

                for (i = 1; i <= 5; i++)
                {
                    if (i == esc)
                    {
                        vt = vt + valor[esc - 1];
                        Console.WriteLine("\nVocê escolheu o livro:\n" + nome[esc - 1] + "\nAutor: " + autor[esc - 1] + "\nNº de páginas: " + paginas[esc - 1] + "\nPreço: " + valor[esc - 1] + " reais\n");
                    }
                }
                Console.WriteLine("Você deseja adicionar mais algum livro ao seu carrinho? (Digite 1 para sim e 2 para não)");
                obs = Int32.Parse(Console.ReadLine());
            }
            while (obs == 1);

            Console.WriteLine("\nO valor total da sua compra é: " + vt + " reais.");

            Console.WriteLine("\nDeseja fazer outra compra? (Digite 1 para sim e 2 para não)");

            con = Int32.Parse(Console.ReadLine());
        } while (con == 1);

        Console.WriteLine("\nMuito obrigada por comprar na nossa livraria!");
    }
}