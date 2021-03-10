using System.ComponentModel.DataAnnotations;

namespace CadastrosDePessoas.Model
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica() { }

        [Required(ErrorMessage = "Campo CNPJ obrigatório")]
        public string CNPJ { get; set; }

    }
}
