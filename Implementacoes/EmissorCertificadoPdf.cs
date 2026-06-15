using AtividadePolimorfismo.Entidades;
using AtividadePolimorfismo.Interfaces;

namespace AtividadePolimorfismo.Implementacoes
{
    public class EmissorCertificadoPdf : IEmissorDeCertificado
    {
        public void Emitir(Aluno aluno, Curso curso)
        {
            Console.WriteLine($"[PDF] Gerando arquivo certificado_{aluno.Nome}_{curso.Nome}.pdf com layout oficial.");
        }
    }
}