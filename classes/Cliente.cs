using System;

namespace cadastrovendaspoo.classes{
    /// <summary>
    /// A Classe cliente possui informações sobre os dados do cliente.
    /// </summary>
    public class Cliente{
        private string nome;
        private string email;
        private string cpf;
        private DateTime datacadastro;
        /// <summary>
        /// Constroi o objeto cliente.
        /// </summary>
        public Cliente()
        {
            
        }
        /// <summary>
        /// Constroi o objeto Cliente e indica os parâmetros necessários.
        /// </summary>
        /// <param name="nome">Informe o nome do cliente em formato texto.</param>
        /// <param name="email">Informe o e-mail do cliente em formato texto.</param>
        /// <param name="cpf">Informe o CPF do cliente em formato texto.</param>
        /// <param name="datacadastro">Informe a data do cadastro em formato DateTime.</param>
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