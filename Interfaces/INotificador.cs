namespace AtividadePolimorfismo.Interfaces
{
    public interface INotificador
    {
        void Enviar(string destinatario, string mensagem);
    }
}