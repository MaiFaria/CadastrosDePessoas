using System;

namespace CadastrosDePessoas
{
    public class MenuDeCadastro
    {
        public void Menu()
        {
            string mensagem = "*** Menu de Cadastro ***\n" + 
                "1 - Novo Cadastro de Pessoa Física\n" +
                "2 - Novo Cadastro de Pessoa Jurídica\n" +
                "3 - Editar\n" +
                "4 - Excluir\n" +
                "5 - Consultar\n" +
                "0 - Sair\n";
            Console.WriteLine(mensagem);
        }

        public void EditarPessoaFísica() 
        {
            string mensagem = "*** Menu de Edição de Pessoa Física ***\n" +
                "1 - Nome\n" +
                "2 - CPF\n" +
                "3 - Contato\n" +
                "0 - Sair\n";
            Console.WriteLine(mensagem);
        }

        public void EditarPessoaJurídica()
        {
            string mensagem = "*** Menu de Edição de Pessoa Jurídica ***\n" +
                "1 - Nome\n" +
                "2 - CNPJ\n" +
                "3 - Contato\n" +
                "0 - Sair\n";
            Console.WriteLine(mensagem);
        }
    }
}
