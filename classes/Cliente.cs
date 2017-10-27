using System;

namespace cadastrovendaspoo.classes{
    public class Cliente{
        private string nome;
        private string email;
        private string cpf;
        private DateTime datacadastro;

        public Cliente()
        {
            
        }
        public Cliente(string nome, string email, string cpf, DateTime datacadastro)
        {
            this.nome=nome;
            this.email=email;
            this.cpf=cpf;
            this.datacadastro=datacadastro;
        }
        public string Nome { get{return nome;} set{nome=value;}}
        public string Email { get{return email;} set{email=value;}}
        public string Cpf { get{return cpf;} set{cpf=value;}}
        public DateTime Datacadastro { get{return datacadastro;} set{datacadastro=value;}}
    }
}