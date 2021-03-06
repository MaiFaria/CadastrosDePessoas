using CadastrosDePessoas.Model;
using CadastrosDePessoas.Service;
using System;

namespace CadastrosDePessoas.MenuService
{
    public class NovoCadastroPessoaFisica : MenuDeCadastro
    {
        public static void InitPessoaFisica()
        {
            Console.WriteLine("Novo Cadastro");
            PessoaFisica pessoaF = new PessoaFisica();

            Console.WriteLine("Digite o seu nome completo");
            string nome = Console.ReadLine();
            pessoaF.Nome = nome;
            
            Console.WriteLine("Digite o seu CPF");
            string cpf = Console.ReadLine();
            pessoaF.CPF = cpf;

            Console.WriteLine("Digite o seu Contato");
            string contato = Console.ReadLine();
            pessoaF.Contato = contato;

            Console.WriteLine($"Os dados estão corretos? \nNome: {nome} \nCPF: {cpf} \nContato: {contato}");

            Console.WriteLine("Confirme os dados - Digite 1;");
            int confirmacao = Int32.Parse(Console.ReadLine());

            if (confirmacao != 1)
            {
                throw new ArgumentException("Cadastro não realizado!");
            }
            PessoaService.SalvarPessoa(pessoaF);
            Console.WriteLine("Cadastro realizado com Sucesso!!");
        }
    }
}
