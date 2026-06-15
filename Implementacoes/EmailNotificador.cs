using AtividadePolimorfismo.Interfaces;

namespace AtividadePolimorfismo.Implementacoes
{
    public class EmailNotificador : INotificador
    {
        public void Enviar(string destinatario, string mensagem)
        {
            Console.WriteLine($"[E-mail] Enviando correio eletrônico para {destinatario}: {mensagem}");
        }
    }
}