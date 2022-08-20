using System.ComponentModel.DataAnnotations;

namespace Api.Models;

public class Produto : Entity
{
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
    public string Descricao { get; set; }
}
