using System.ComponentModel.DataAnnotations;

namespace APISuporte.Models;

public class RequisicaoSuporte
{
    [Required(ErrorMessage = "Preencha o campo 'Email'")]
    [EmailAddress(ErrorMessage = "Formato invalido para o campo 'Email'")]
    [StringLength(100, ErrorMessage = "O campo 'Email' deve possuir no maximo 100 caracteres")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Preencha o campo 'DescritivoRequisicao'")]
    [MinLength(15, ErrorMessage = "O campo 'DescritivoRequisicao' deve possuir no minimo 15 caracteres")]
    [StringLength(500, ErrorMessage = "O campo 'DescritivoRequisicao' deve possuir no maximo 500 caracteres")]
    public string? DescritivoRequisicao { get; set; }
}