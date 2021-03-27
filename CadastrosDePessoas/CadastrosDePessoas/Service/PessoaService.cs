using System.Collections.Generic;

namespace CadastrosDePessoas.Service
{
    public class PessoaService
    {
        protected static List<Pessoa> pessoas = new List<Pessoa>();

        public static void SalvarPessoa(Pessoa pessoa) => pessoas.Add(pessoa);

        public static List<Pessoa> GetPessoas()
        {
            return pessoas;
        }


    }
}
