using System;

namespace CadastrosDePessoas
{
    public class MenuDeCadastro
    {
        public void Menu()
        {
            Console.WriteLine("*** Menu de Cadastro ***\n");
            Console.WriteLine("01 - Novo Cadastro de Pessoa Física\n");
            Console.WriteLine("02 - Novo Cadastro de Pessoa Jurídica\n");
            Console.WriteLine("03 - Editar\n");
            Console.WriteLine("04 - Excluir\n");
            Console.WriteLine("05 - Consultar\n");
            Console.WriteLine("0 - Sair\n");
        }

        public void EditarPessoaFísica() 
        {
            Console.WriteLine("*** Menu de Edição de Pessoa Física ***\n");
            Console.WriteLine("01 - Nome\n");
            Console.WriteLine("02 - CPF\n");
            Console.WriteLine("03 - Contato\n");
            Console.WriteLine("0 - Sair\n");
        }

        public void EditarPessoaJurídica()
        {
            Console.WriteLine("*** Menu de Edição de Pessoa Jurídica ***\n");
            Console.WriteLine("01 - Nome\n");
            Console.WriteLine("02 - CNPJ\n");
            Console.WriteLine("03 - Contato\n");
            Console.WriteLine("0 - Sair\n");
        }
    }
}
