using System.ComponentModel.DataAnnotations;

namespace CadastrosDePessoas.Model
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica() { }

        [Required(ErrorMessage = "Campo CPF obrigatório")]
        public string CPF { get; set; }

    }
}
