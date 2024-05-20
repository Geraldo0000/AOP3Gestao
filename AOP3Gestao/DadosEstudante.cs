using System;

namespace AOP3Gestao {
    // Classe representando os dados do estudante
    public class DadosEstudante {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Registration { get; set; }
        public string Date { get; set; }
        // Construtor para inicializar os dados do estudante
        public DadosEstudante(string nome, string senha, string email, string registration, string data) {

            Name = nome;
            Password = senha;
            Email = email;
            Registration = registration;
            Date = data;
        }
        // Método para representar os dados do estudante como string
        public override string ToString() {
            return $"Name: {Name}, Password: {Password}, Email: {Email}, Registration: {Registration}, Date: {Date}";
        }

        public static void Main() { // Teste inicial dos dados do estudante
            DadosEstudante student = new DadosEstudante("marcelo", "123456", "email.com", "202201516", "10/04/1993");
            Console.WriteLine(student);
            DadosEstudante student1 = new DadosEstudante("geraldo", "654321", "email2.com", "202199260", "25/01/1966");
            Console.WriteLine(student1);

        }
    }



}

