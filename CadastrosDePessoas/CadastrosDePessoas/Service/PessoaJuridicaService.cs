using CadastrosDePessoas.Model;

namespace CadastrosDePessoas.Service
{
    class PessoaJuridicaService : PessoaService
    {
        public static bool IsPessoaJuridicaEquals(PessoaJuridica pessoa, string valor)
        {
            return pessoa.CNPJ.Equals(valor);
        }

        public static Pessoa BuscaPessoaJuridica(string cnpjConsultar)
        {
            foreach (PessoaJuridica pessoa in pessoas)
            {
                if (IsPessoaJuridicaEquals(pessoa, cnpjConsultar))
                {
                    return pessoa;
                }
            }
            return null;
        }

        public static string DeletePessoaJuridica(string cnpjExcluir)
        {
            foreach (PessoaJuridica pessoa in pessoas)
            {
                if (IsPessoaJuridicaEquals(pessoa, cnpjExcluir))
                {
                    pessoas.Remove(pessoa);
                    return "Cadastro removido com sucesso!!";
                }
            }
            return "Cadastro não localizado.";
        }
    }
}
