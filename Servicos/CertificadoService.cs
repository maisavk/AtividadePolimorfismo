using AtividadePolimorfismo.Entidades;
using AtividadePolimorfismo.Interfaces;

namespace AtividadePolimorfismo.Servicos
{
    public class CertificadoService
    {
        private readonly IEmissorDeCertificado _emissor;
        private readonly IRegistroDeCertificado _registro;
        private readonly INotificador _notificador;

        public CertificadoService(
            IEmissorDeCertificado emissor, 
            IRegistroDeCertificado registro, 
            INotificador notificador)
        {
            _emissor = emissor ?? throw new ArgumentNullException(nameof(emissor));
            _registro = registro ?? throw new ArgumentNullException(nameof(registro));
            _notificador = notificador ?? throw new ArgumentNullException(nameof(notificador));
        }

        public void EmitirCertificado(Aluno aluno, Curso curso)
        {
            if (aluno is null)
                throw new ArgumentNullException(nameof(aluno));

            if (curso is null)
                throw new ArgumentNullException(nameof(curso));

            if (!aluno.CursoConcluido)
            {
                Console.WriteLine($"[AVISO] {aluno.Nome} não concluiu os requisitos do curso {curso.Nome}. Emissão cancelada.");
                return;
            }

            _emissor.Emitir(aluno, curso);
            
            var certificado = new Certificado(aluno, curso);
            _registro.Registrar(certificado);

            string mensagem = $"Olá {aluno.Nome}, seu certificado do curso {curso.Nome} foi emitido!";
            _notificador.Enviar(aluno.Email, mensagem);
        }
    }
}