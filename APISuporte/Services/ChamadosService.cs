using APISuporte.Data;
using APISuporte.Models;

namespace APISuporte.Services;

public class ChamadosService
{
    private readonly SuporteContext _context;

    public ChamadosService(SuporteContext context)
    {
        _context = context;
    }

    public DetalhesChamado Get(int idChamado)
    {
        return _context.Chamados.Where(c => c.Id == idChamado)
            .Select(c => new DetalhesChamado()
            {
                Id = c.Id,
                DataChamado = c.DataAbertura.ToString("yyyy-MM-dd HH:mm:ss"),
                Email = c.Email,
                DescritivoRequisicao = c.DescritivoRequisicao,
                Solucionado = c.Solucionado
            })
            .FirstOrDefault()!;
    }

    public ResultadoInclusao Save(RequisicaoSuporte requisicaoSuporte)
    {
        var chamado = new Chamado()
        {
            DataAbertura = DateTime.UtcNow.AddHours(-3),
            Email = requisicaoSuporte.Email,
            DescritivoRequisicao = requisicaoSuporte.Email, // FIXME: Simulacao de falha
            //DescritivoRequisicao = requisicaoSuporte.DescritivoRequisicao,
            Solucionado = true // FIXME: Simulacao de falha
            //Solucionado = false            
        };
        _context.Chamados.Add(chamado);
        _context.SaveChanges();
        
        return new ResultadoInclusao()
        {
            IdChamado = chamado.Id,
            Mensagem = "Chamado registrado com sucesso!"
        };
    }
}