using AOP3Gestao;

namespace TelaLoginTest {   // Testes para a funcionalidade "Login"
    public class DadosEstudanteTests {
        private DadosEstudante estudante1;
        private string senhaCorreta;
        private string loginCorreto;
        private int tamanhoRegistration, tamanhoMimimoSenha, tamanhoMaximoSenha;
       

        [SetUp]
        public void Setup() { // Configuração inicial dos dados do estudante
            estudante1 = new DadosEstudante("geraldo", "7897890000", "email3.com", "202201516", "12/12/1995");
            senhaCorreta = "7897890000";
            loginCorreto = "202201516";
            tamanhoRegistration = 9;
            tamanhoMimimoSenha = 5;
            tamanhoMaximoSenha = 19;
        }

        [Test]
        public void checarLoginSenhaCorretos() {  // Teste para verificar se o login e a senha estão corretos
            Assert.That(estudante1.Registration,Is.EqualTo(loginCorreto));
            Assert.That(estudante1.Password, Is.EqualTo(senhaCorreta));
        }
        [Test]
        public void checarLimiteLoginSenha() {  // Teste para verificar os limites de tamanho do login e da senha
            Assert.That(estudante1.Password.Length, Is.GreaterThan(tamanhoMimimoSenha));
            Assert.That(estudante1.Password.Length, Is.LessThan(tamanhoMaximoSenha));
            Assert.That(estudante1.Registration.Length, Is.EqualTo(tamanhoRegistration));
        }
        [Test]
        public void checarCamposNulos() {  // Teste para verificar se os campos não são nulos ou vazios
            Assert.That(estudante1.Registration, Is.Not.Empty);
            Assert.That(estudante1.Password, Is.Not.Empty);
        }
    }
}