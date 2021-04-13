using CadastrosDePessoas.Model;
using CadastrosDePessoas.Service;
using System;

namespace CadastrosDePessoas.MenuService
{
    public class NovoCadastroPessoaJuridica : MenuDeCadastro
    {
        public static void InitPessoaJuridica()
        {
            Console.WriteLine("Novo Cadastro");
            PessoaJuridica pessoaJ = new PessoaJuridica();

            Console.WriteLine("Digite o seu nome completo: ");
            string nome = Console.ReadLine();
            pessoaJ.Nome = nome;

            Console.WriteLine("Digite o seu CNPJ: ");
            string cnpj = Console.ReadLine();
            pessoaJ.CNPJ = cnpj;

            Console.WriteLine("Digite o seu contato: ");
            string contato = Console.ReadLine();
            pessoaJ.Contato = contato;

            Console.WriteLine($"Os dados estão corretos? \nNome: {nome} \nCNPJ: {cnpj} \nContato: {contato}");

            Console.WriteLine("Confirme os dados - Digite 1;");
            int confirmacao = Int32.Parse(Console.ReadLine());

            if (confirmacao != 1)
            {
                throw new ArgumentException("Cadastro não realizado!");

            }
            PessoaService.SalvarPessoa(pessoaJ);
            Console.WriteLine("Cadastro realizado com sucesso!!");
        }
    }
}
