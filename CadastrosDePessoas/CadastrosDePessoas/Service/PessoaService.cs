using CadastrosDePessoas.Model;
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

        public static string DeletePessoaFisica(string cpfExcluir)
        {
            foreach(PessoaFisica pessoa in pessoas)
            {
                if(IsPessoaEquals(pessoa, cpfExcluir))
                {
                    pessoas.Remove(pessoa);
                    return "Cadastro removido com sucesso!!";
                }
            }
            return "Cadastro não localizado.";
        }

        public static string DeletePessoaJuridica(string cnpjExcluir)
        {
            foreach(PessoaJuridica pessoa in pessoas)
            {
                if(IsPessoaEquals(pessoa, cnpjExcluir))
                {
                    pessoas.Remove(pessoa);
                    return "Cadastro removido com sucesso!!";
                }
            }
            return "Cadastro não localizado.";
        }
    }
}
