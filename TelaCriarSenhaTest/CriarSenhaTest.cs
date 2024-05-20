using AOP3Gestao;

namespace TelaCriarSenhaTest {  // Testes para a funcionalidade "Criar Senha"
    public class CriarSenhaTests {
        private string matricula, senha, confirmaSenha, dataNascimento;
        private DadosEstudante estudante;

        [SetUp]
        public void Setup() {  // Configuração inicial dos dados do estudante
            estudante = new DadosEstudante("geraldo", "1234567890", "email3.com", "202201516", "25/01/1966");
            matricula = "202201516";
            senha = "1234567890";
            confirmaSenha = "1234567890";
            dataNascimento = "25/01/1966";
        }

        [Test]
        public void CamposNulosChecar() { // Teste para verificar se os campos não são nulos ou vazios
            Assert.Multiple(() => {
                Assert.That(matricula, Is.Not.Null.And.Not.Empty);
                Assert.That(senha, Is.Not.Null.And.Not.Empty);
                Assert.That(confirmaSenha, Is.Not.Null.And.Not.Empty);
                Assert.That(dataNascimento, Is.Not.Null.And.Not.Empty);
            });
        }
        [Test]
        public void ConfirmaSenha() {  // Teste para verificar se a confirmação da senha é igual à senha
            Assert.That(confirmaSenha, Is.EqualTo(senha));

        }
        [Test]
        public void checarMatriculaNascimento() {  // Teste para verificar se a matrícula e a data de nascimento estão corretas
            Assert.That(estudante.Registration, Is.EqualTo(matricula));
            Assert.That(estudante.Date, Is.EqualTo(dataNascimento));

        }
    }
}