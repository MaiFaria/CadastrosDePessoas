using CadastrosDePessoas.Model;

namespace CadastrosDePessoas.Service
{
    class PessoaFisicaService : PessoaService
    {
        public static bool IsPessoaFisicaEquals(PessoaFisica pessoa, string valor)
        {
            return pessoa.CPF.Equals(valor);
        }

        public static Pessoa BuscaPessoaFisica(string cpfConsultar)
        {
            foreach (PessoaFisica pessoa in pessoas)
            {
                if (IsPessoaFisicaEquals(pessoa, cpfConsultar))
                {
                    return pessoa;
                }
            }
            return null;
        }

        public static string DeletePessoaFisica(string cpfExcluir)
        {
            foreach (PessoaFisica pessoa in pessoas)
            {
                if (IsPessoaFisicaEquals(pessoa, cpfExcluir))
                {
                    pessoas.Remove(pessoa);
                    return "Cadastro removido com sucesso!!";
                }
            }
            return "Cadastro não localizado.";
        }
    }
}
