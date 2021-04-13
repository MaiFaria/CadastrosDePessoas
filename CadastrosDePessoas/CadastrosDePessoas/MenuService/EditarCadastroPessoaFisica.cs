using CadastrosDePessoas.Service;
using CadastrosDePessoas.Model;
using System;

namespace CadastrosDePessoas.MenuService
{
    public class EditarCadastroPessoaFisica
    {
        public static void InitEdicaoPessoaFisica(string cpf)
        {
            int valorMenu = 1;

            do
            {
                foreach (PessoaFisica p in PessoaFisicaService.GetPessoas())
                {
                    if (PessoaFisicaService.IsPessoaFisicaEquals(p, cpf))
                    {
                        NovoCadastroPessoaFisica editarPessoaFisica = new NovoCadastroPessoaFisica();
                        editarPessoaFisica.EditarPessoaFisica();
                        Console.WriteLine("Digite a opção a ser editada");
                        int menu = Int32.Parse(Console.ReadLine());

                        switch (menu)
                        {
                            case 1:
                                Console.WriteLine("Digite o seu Nome completo para alteração");
                                string nomeEditado = Console.ReadLine();
                                p.Nome = nomeEditado;

                                Console.WriteLine($"Confirme os dados para alteração: \nNome {nomeEditado} - Digite 1 ");
                                int confirmaNome = Int32.Parse(Console.ReadLine());

                                if (confirmaNome == 1)
                                {
                                    throw new ArgumentException("Cadastro não alterado!");
                                }
                                PessoaFisicaService.SalvarPessoa(p);
                                Console.WriteLine("Cadastro alterado com SUCESSO");
                                break;
                            case 2:
                                Console.WriteLine("Digite o seu CPF para alteração");
                                string cpfEditado = Console.ReadLine();
                                p.CPF = cpfEditado;

                                Console.WriteLine($"Confirme os dados para alteração: \nCPF {cpfEditado} - Digite 1 ");
                                int confirmaCPF = Int32.Parse(Console.ReadLine());

                                if (confirmaCPF == 1)
                                {
                                    throw new ArgumentException("Cadastro não alterado!");
                                }
                                PessoaFisicaService.SalvarPessoa(p);
                                Console.WriteLine("Cadastro alterado com SUCESSO!!!");
                                break;
                            case 3:
                                Console.WriteLine("Digite o contato para alteração");
                                string contatoEditado = Console.ReadLine();
                                p.Contato = contatoEditado;

                                Console.WriteLine($"Confirme os dados para alteração: \nContato {contatoEditado} - Digite 1");
                                int confirmaContato = Int32.Parse(Console.ReadLine());

                                if (confirmaContato == 1)
                                {
                                    throw new ArgumentException("Cadastro não alterado!");   
                                }
                                PessoaFisicaService.SalvarPessoa(p);
                                Console.WriteLine("Cadastro alterado com SUCESSO!!!");
                                break;
                        }
                    }
                }
            } while (valorMenu != 0);
        }
    }
}
