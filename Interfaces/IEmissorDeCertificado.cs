using AtividadePolimorfismo.Entidades;

namespace AtividadePolimorfismo.Interfaces
{
    public interface IEmissorDeCertificado
    {
        void Emitir(Aluno aluno, Curso curso);
    }
}