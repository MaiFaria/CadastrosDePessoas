using CadastrosDePessoas.MenuService;
using CadastrosDePessoas.Service;
using System;

namespace CadastrosDePessoas.Menu
{
    class Menu
    {
        public static void Main(string[] args)
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
                        int opcaoExcluir = Int32.Parse(Console.ReadLine());

                        if(opcaoExcluir == 1)
                        {
                            Console.WriteLine("\nInforme o CPF para exclusão: ");
                            string cpfExcluir = Console.ReadLine();
                            Console.WriteLine(PessoaService.DeletePessoaFisica(cpfExcluir));
                        } 
                        else if(opcaoExcluir == 2)
                        {
                            Console.WriteLine("\nInforme o CNPJ para exclusão: ");
                            string cnpjExcluir = Console.ReadLine();
                            Console.WriteLine(PessoaService.DeletePessoaJuridica(cnpjExcluir));
                        }
                        break;
                    case 5:
                        Console.WriteLine("Informe 1 para consulta Pessoa Física ou 2 para Pessoa Jurídica: ");
                        int opcaoConsulta = Int32.Parse(Console.ReadLine());

                        if(opcaoConsulta == 1)
                        {
                            Console.WriteLine("Informe o CPF para consulta");
                            string cpfConsulta = Console.ReadLine();
                            Console.WriteLine(PessoaService.BuscaPessoaFisica(cpfConsulta));
                        }
                        if(opcaoConsulta == 2)
                        {
                            Console.WriteLine("Informe o CNPJ para consulta");
                            string cnpjConsulta = Console.ReadLine();
                            Console.WriteLine(PessoaService.BuscaPessoaJuridica(cnpjConsulta));
                        }
                        break;
                }   
            } while (valorMenu != 0);
        }
    }
}
