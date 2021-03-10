using System.Collections.Generic;

namespace CadastrosDePessoas.Service
{
    public class PessoaService
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();

        public static void SalvarPessoa(Pessoa pessoa) => pessoas.Add(pessoa);

        public static bool IsPessoaEquals(Pessoa pessoa, string valor)
        {
            return pessoa.Nome.Equals(valor);
        }

        public static List<Pessoa> GetPessoas()
        {
            return pessoas;
        }

        public static void DeletePessoa(Pessoa pessoa) => pessoas.Remove(pessoa);
    }
}
