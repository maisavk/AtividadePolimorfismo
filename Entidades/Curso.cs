namespace AtividadePolimorfismo.Entidades
{
    public class Curso
    {
        public string Nome { get; private set; }
        public int CargaHoraria { get; private set; }

        public Curso(string nome, int cargaHoraria)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome do curso é obrigatório.");

            if (cargaHoraria <= 0)
                throw new ArgumentException("A carga horária deve ser maior que zero.");

            Nome = nome;
            CargaHoraria = cargaHoraria;
        }
    }
}