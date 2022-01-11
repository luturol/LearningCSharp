using System.ComponentModel.DataAnnotations;

namespace MVC_Contatos.Data.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Fone { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        [EmailAddress(ErrorMessage = "Formato do Email Inválido")]
        public string Email { get; set; }
        public string EstadoCivil { get; set; }
    }
}
