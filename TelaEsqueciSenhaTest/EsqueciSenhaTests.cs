using AOP3Gestao;

namespace TelaEsqueciSenhaTest { // Testes para a funcionalidade "Esqueci a Senha"
    public class EsqueciSenhaTests {
        private string matriculaCorreta, emailCorreto;
        private DadosEstudante estudante;

        [SetUp]
        public void Setup() {  // Configura��o inicial dos dados do estudante
            estudante = new DadosEstudante("geraldo", "7897890000", "email3.com", "202201516", "12/12/1995");
            matriculaCorreta = "202201516";
            emailCorreto = "email3.com";
        }

        [Test]
        public void checandoMatriculaSenha() {  // Teste para verificar se a matr�cula e o email est�o corretos
            Assert.That(estudante.Registration, Is.EqualTo(matriculaCorreta));
            Assert.That(estudante.Email, Is.EqualTo(emailCorreto));
        }
    }
}