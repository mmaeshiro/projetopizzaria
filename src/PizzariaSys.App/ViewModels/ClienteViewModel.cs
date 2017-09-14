using System.ComponentModel.DataAnnotations;
using PizzariaSys.Dominio.Entidades;

namespace PizzariaSys.App.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = " * Campo Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = " * Campo Obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = " * Campo Obrigatório")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Za-z0-9]*\d+[A-Za-z0-9]*$",ErrorMessage ="Digite somente números")]
        public int Numero { get; set; }

        [Required(ErrorMessage = " * Campo Obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = " * Campo Obrigatório")]
        [Display(Name ="Telefone Fixo")]  
        public string TelefoneFixo { get; set; }

        [Required(ErrorMessage = " * Campo Obrigatório")]
        [Display(Name = "Telefone Cel.")]
        public string TelefoneCelular { get; set; }

        public ClienteViewModel()
        {

        }

        public ClienteViewModel(Cliente cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            Logradouro = cliente.Logradouro;
            Numero = cliente.Numero;
            Bairro = cliente.Bairro;
            TelefoneFixo = cliente.TelefoneFixo;
            TelefoneCelular = cliente.TelefoneCelular;

        }
    }
}