using CadastrosDePessoas.Service;
using CadastrosDePessoas.Model;
using System;

namespace CadastrosDePessoas.MenuService
{
    class EditarCadastroPessoaFisica : MenuDeCadastro
    {
        public static void Init(string cpf)
        {
            int valorMenu = 1;
            
            do
            {
                NovoCadastroPessoFisica editarPessoaFisica = new NovoCadastroPessoFisica();
                string cpfEditar = Console.ReadLine();

                if (valorMenu == 1)
                {
                    foreach (PessoaFisica p in PessoaFisicaService.GetPessoas())
                    {
                        if (PessoaFisicaService.IsPessoaFisicaEquals(p, cpfEditar))
                        {

                            editarPessoaFisica.EditarPessoaFísica();
                            Console.WriteLine("Digite a opção a ser editada");
                            int menu = Int32.Parse(Console.ReadLine());

                            switch (menu)
                            {
                                case 1:
                                    Console.WriteLine("Digite o seu Nome completo para alteração");
                                    string nomeEditado = Console.ReadLine();
                                    p.Nome = nomeEditado;

                                    Console.WriteLine("Confirme os dados para alteração - Digite 1 ");
                                    int confirmaNome = Int32.Parse(Console.ReadLine());

                                    if (confirmaNome == 1)
                                    {
                                        PessoaFisicaService.SalvarPessoa(p);
                                        Console.WriteLine("Cadastro alterado com SUCESSO");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o seu CPF para alteração");
                                    string cpfEditado = Console.ReadLine();
                                    p.CPF = cpfEditado;

                                    Console.WriteLine("Confirme os dados para alteração - Digite 1 ");
                                    int confirmaCPF = Int32.Parse(Console.ReadLine());

                                    if (confirmaCPF == 1)
                                    {
                                        PessoaFisicaService.SalvarPessoa(p);
                                        Console.WriteLine("Cadastro alterado com SUCESSO!!!");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Digite o contato para alteração");
                                    string contatoEditado = Console.ReadLine();
                                    p.Contato = contatoEditado;

                                    Console.WriteLine("Confirme os dados para alteração - Digite 1");
                                    int confirmaContato = Int32.Parse(Console.ReadLine());

                                    if (confirmaContato == 1)
                                    {
                                        PessoaFisicaService.SalvarPessoa(p);
                                        Console.WriteLine("Cadastro alterado com SUCESSO!!!");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("CPF não localizado!");
                        }
                    }
                }
            }while(valorMenu != 0);
        }
    }
}
