using AtividadePolimorfismo.Entidades;
using AtividadePolimorfismo.Interfaces;

namespace AtividadePolimorfismo.Implementacoes
{
    public class RegistroCertificadoConsole : IRegistroDeCertificado
    {
        public void Registrar(Certificado certificado)
        {
            Console.WriteLine("[LOG CONSOLE] Registrando emissão no console do sistema.");
            Console.WriteLine(certificado.ObterResumo());
        }
    }
}