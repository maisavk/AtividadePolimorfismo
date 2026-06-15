using AtividadePolimorfismo.Entidades;
using AtividadePolimorfismo.Interfaces;

namespace AtividadePolimorfismo.Implementacoes
{
    public class RegistroCertificadoMemoria : IRegistroDeCertificado
    {
        private readonly List<Certificado> _certificados = new();

        public void Registrar(Certificado certificado)
        {
            _certificados.Add(certificado);
            Console.WriteLine($"[MEMÓRIA] Certificado guardado na lista interna. Total na memória: {_certificados.Count}");
        }
    }
}