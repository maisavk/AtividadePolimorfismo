using System;
using AtividadePolimorfismo.Entidades;
using AtividadePolimorfismo.Implementacoes;
using AtividadePolimorfismo.Interfaces;
using AtividadePolimorfismo.Servicos;

namespace AtividadePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE EMISSÃO DE CERTIFICADOS POLYMORPHIC ===");

            // 1. Instanciando as implementações escolhidas (Acoplamento apenas aqui no montador)
            IEmissorDeCertificado emissorPdf = new EmissorCertificadoPdf();
            IRegistroDeCertificado registroConsole = new RegistroCertificadoConsole();
            INotificador notificadorEmail = new EmailNotificador();

            // 2. Injetando as dependências no serviço genérico
            CertificadoService servico = new CertificadoService(emissorPdf, registroConsole, notificadorEmail);

            // 3. Criando os dados para testes
            Curso cursoDotNet = new Curso("Formação C# e .NET Core", 40);
            
            Aluno alunoAprovado = new Aluno("Maisa Vendrame", "maisa@email.com", cursoConcluido: true);
            Aluno alunoPendente = new Aluno("Pedro Silva", "pedro@email.com", cursoConcluido: false);

            // 4. Executando os cenários polimórficos
            Console.WriteLine("\n--- Cenário 1: Aluno com curso concluído ---");
            servico.EmitirCertificado(alunoAprovado, cursoDotNet);

            Console.WriteLine("\n--- Cenário 2: Aluno com pendências ---");
            servico.EmitirCertificado(alunoPendente, cursoDotNet);

            Console.WriteLine("\n=======================================================");
        }
    }
}