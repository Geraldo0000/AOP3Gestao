using AOP3Gestao;

namespace TelaEsqueciSenhaTest { // Testes para a funcionalidade "Esqueci a Senha"
    public class EsqueciSenhaTests {
        private string matriculaCorreta, emailCorreto;
        private DadosEstudante estudante;

        [SetUp]
        public void Setup() {  // Configuração inicial dos dados do estudante
            estudante = new DadosEstudante("geraldo", "7897890000", "email3.com", "202201516", "12/12/1995");
            matriculaCorreta = "202201516";
            emailCorreto = "email3.com";
        }

        [Test]
        public void checandoMatriculaSenha() {  // Teste para verificar se a matrícula e o email estão corretos
            Assert.That(estudante.Registration, Is.EqualTo(matriculaCorreta));
            Assert.That(estudante.Email, Is.EqualTo(emailCorreto));
        }
    }
}