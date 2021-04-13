using CadastrosDePessoas.Model;
using CadastrosDePessoas.Service;
using System;

namespace CadastrosDePessoas.MenuService
{
    public class EditarCadastroPessoaJuridica
    {
        public static void InitEdicaoPessoaJuridica(string cpf)
        {
            int valorMenu = 1;

            do
            {
                foreach (PessoaJuridica p in PessoaJuridicaService.GetPessoas())
                {
                    if (PessoaJuridicaService.IsPessoaJuridicaEquals(p, cpf))
                    {
                        NovoCadastroPessoaJuridica editarPessoaJuridica = new NovoCadastroPessoaJuridica();
                        editarPessoaJuridica.EditarPessoaJuridica();
                        Console.WriteLine("Digite a opção a ser editada");
                        int menu = Int32.Parse(Console.ReadLine());

                        switch (menu)
                        {
                            case 1:
                                Console.WriteLine("Digite o NOME completo para alteração");
                                string nomeEditado = Console.ReadLine();
                                p.Nome = nomeEditado;

                                Console.WriteLine($"Confirme o NOME para alteração: \nNome {nomeEditado} - Digite 1");
                                int confirmaNome = Int32.Parse(Console.ReadLine());

                                if (confirmaNome != 1)
                                {
                                    throw new ArgumentException("Cadastro não alterado!");
                                }
                                PessoaJuridicaService.SalvarPessoa(p);
                                Console.WriteLine("Cadastro ALTERADO com sucesso!");
                                break;
                            case 2:
                                Console.WriteLine("Digite o CNPJ para alteração");
                                string cnpjEditado = Console.ReadLine();
                                p.CNPJ = cnpjEditado;

                                Console.WriteLine($"Confirme dados para alteração: \nCNPJ: {cnpjEditado} - Digite 1");
                                int confirmaCnpj = Int32.Parse(Console.ReadLine());

                                if (confirmaCnpj == 1)
                                {
                                    throw new ArgumentException("Cadastro não alterado!");
                                }
                                PessoaJuridicaService.SalvarPessoa(p);
                                Console.WriteLine("Cadastro ALTERADO com sucesso!");
                                break;
                            case 3:
                                Console.WriteLine("Digite o Contato para alteração");
                                string contatoEditado = Console.ReadLine();
                                p.Contato = contatoEditado;

                                Console.WriteLine($"Confirme os dados para alteração: \nContato: {contatoEditado} - Digite 1");
                                int confirmaContato = Int32.Parse(Console.ReadLine());

                                if (confirmaContato == 1)
                                {
                                    throw new ArgumentException("Cadastro não alterado!");
                                }
                                PessoaJuridicaService.SalvarPessoa(p);
                                Console.WriteLine("Cadastro alterado com sucesso!");
                                break;
                        }
                    }
                }
            } while (valorMenu != 0);
        }
    }
}
