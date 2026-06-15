namespace AtividadePolimorfismo.Entidades
{
    public class Certificado
    {
        public Aluno Aluno { get; private set; }
        public Curso Curso { get; private set; }
        public DateTime DataEmissao { get; private set; }

        public Certificado(Aluno aluno, Curso curso)
        {
            Aluno = aluno ?? throw new ArgumentNullException(nameof(aluno));
            Curso = curso ?? throw new ArgumentNullException(nameof(curso));
            DataEmissao = DateTime.Now;
        }

        public string ObterResumo()
        {
            return $"Certificado de {Curso.Nome} emitido para {Aluno.Nome} em {DataEmissao:dd/MM/yyyy}.";
        }
    }
}