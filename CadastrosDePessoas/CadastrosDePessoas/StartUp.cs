using CadastrosDePessoas.Model;
using System;

namespace CadastrosDePessoas
{
    public class StartUp
    {
       static void Main(string[] args)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Joao";

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Maria";

            Console.WriteLine("Nome da pessoa: " + pessoaFisica.Nome);

            Console.WriteLine("Nome da pessoa: " + pessoaJuridica.Nome);
            Console.ReadLine();
        }

    }
}
