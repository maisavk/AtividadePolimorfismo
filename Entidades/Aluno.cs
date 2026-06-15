namespace AtividadePolimorfismo.Entidades
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public bool CursoConcluido { get; private set; }

        public Aluno(string nome, string email, bool cursoConcluido)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome do aluno é obrigatório.");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("O e-mail do aluno é obrigatório.");

            Nome = nome;
            Email = email;
            CursoConcluido = cursoConcluido;
        }
    }
}