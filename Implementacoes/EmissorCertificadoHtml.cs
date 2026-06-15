using AtividadePolimorfismo.Entidades;
using AtividadePolimorfismo.Interfaces;

namespace AtividadePolimorfismo.Implementacoes
{
    public class EmissorCertificadoHtml : IEmissorDeCertificado
    {
        public void Emitir(Aluno aluno, Curso curso)
        {
            Console.WriteLine($"[HTML] Gerando página web certificado_{aluno.Nome}.html com tags de marcação.");
        }
    }
}