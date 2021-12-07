using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herança2
{
    public class cPBase
    {
        private string nome;
        private string cidade;
        private int nFilhos;
        private int idade;
        private int Uf;

        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public int NFilhos { get => nFilhos; set => nFilhos = value; }
        public int Idade { get => idade; set => idade = value; }
        public int Uf1 { get => Uf; set => Uf = value; }
    }
}

namespace herança2
{

    public class cPFisica : cPBase
    {

        private string cpf;
        private string mAniversario;
        public string Cpf { get => cpf; set => cpf = value; }
        public string MAniversario { get => mAniversario; set => mAniversario = value; }
    }

}

namespace herança2
{

    public class cPJuridica : cPBase
    {

        private string cnpj;
        private string rsocial;
        private string nfuncionarios;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Rsocial { get => rsocial; set => rsocial = value; }
        public string Nfuncionarios { get => nfuncionarios; set => nfuncionarios = value; }
    }

}