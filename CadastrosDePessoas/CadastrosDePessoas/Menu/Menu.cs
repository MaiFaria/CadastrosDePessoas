using CadastrosDePessoas.MenuService;
using CadastrosDePessoas.Service;
using System;

namespace CadastrosDePessoas.Menu
{
    class Menu
    {
        public static void Main(String[] args)
        {
            int valorMenu = 1;

            do
            {
                MenuDeCadastro cadastro = new MenuDeCadastro();
                cadastro.Menu();

                valorMenu = Int32.Parse(Console.ReadLine());

                switch (valorMenu)
                {
                    case 1:
                        NovoCadastroPessoFisica.InitPessoaFisica();
                        break;
                    case 2:
                        NovoCadastroPessoaJuridica.InitPessoaJuridica();
                        break;
                    case 3:
                        Console.WriteLine("Informe a opção desejada: ");
                        cadastro.Editar();
                        break;
                    case 4:
                        Console.WriteLine("Digite 1 para remover Pessoa Física ou 2 para Pessoa Jurídica: ");
                        string opcao = Console.ReadLine();

                        if(opcao = 1)
                        {
                            Console.WriteLine("\nInforme o CPF para exclusão: ");
                            string cpfExcluir = Console.ReadLine();
                            Console.WriteLine(PessoaService.DeletePessoaFisica(cpfExcluir));
                        } 
                        else if(opcao = 2)
                        {
                            Console.WriteLine("\nInforme o CNPJ para exclusão: ");
                            string cnpjExcluir = Console.ReadLine();
                            Console.WriteLine(PessoaService.DeletePessoaJuridica(cnpjExcluir));
                        }
                        break;
                }   

            } while ();
        }
    }
}
