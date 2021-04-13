using System.ComponentModel.DataAnnotations;

namespace CadastrosDePessoas
{
    public abstract class Pessoa
    {
        public Pessoa() { }

        public string Nome { get; set; }
        public string Contato { get; set; }
    }
}
