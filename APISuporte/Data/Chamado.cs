using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APISuporte.Data;

public class Chamado
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public DateTime DataAbertura { get; set; }
    
    [Required]
    [MaxLength(100)]
    [Column(TypeName = "varchar")]    
    public string? Email { get; set; }

    [Required]
    [MaxLength(500)]
    [Column(TypeName = "varchar")]
    public string? DescritivoRequisicao { get; set; }

    [Required]
    public bool Solucionado { get; set; }
}