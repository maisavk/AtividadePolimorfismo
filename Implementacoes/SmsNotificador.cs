using AtividadePolimorfismo.Interfaces;

namespace AtividadePolimorfismo.Implementacoes
{
    public class SmsNotificador : INotificador
    {
        public void Enviar(string destinatario, string mensagem)
        {
            Console.WriteLine($"[SMS] Enviando mensagem de texto para o celular {destinatario}: {mensagem}");
        }
    }
}