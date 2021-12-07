using System; //using é usado para importar alguma funcionalidade

namespace biblioteca //pasta em que o arquivo está localizado
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia de um objeto ->
            Livro obj = new Livro();
            obj.nome[0] = "1984";
            obj.nome[1] = "O Príncipe Cruel";
            obj.nome[2] = "A Vida Invisível de Addie Larue";
            obj.nome[3] = "O Melhor de Mim";
            obj.nome[4] = "Senhora";
            obj.autor[0] = "George Orwell";
            obj.autor[1] = "Holly Black";
            obj.autor[2] = "V. E. Schwab";
            obj.autor[3] = "Nicholas Sparks";
            obj.autor[4] = "José de Alencar";
            obj.paginas[0] = 416;
            obj.paginas[1] = 322;
            obj.paginas[2] = 504;
            obj.paginas[3] = 352;
            obj.paginas[4] = 332;
            obj.valor[0] = 19.90;
            obj.valor[1] = 29.90;
            obj.valor[2] = 59.90;
            obj.valor[3] = 19.90;
            obj.valor[4] = 29.89;
            obj.msg();
        }
    }
}