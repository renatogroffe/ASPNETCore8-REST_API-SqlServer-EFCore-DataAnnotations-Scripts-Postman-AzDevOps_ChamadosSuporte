namespace APISuporte.Models;

public class DetalhesChamado
{
    public int Id { get; set; }
    public string? DataChamado { get; set; }
    public string? Email { get; set; }
    public string? DescritivoRequisicao { get; set; }
    public bool Solucionado { get; set; }
}