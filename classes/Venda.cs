using System;

namespace cadastrovendaspoo.classes{
    /// <summary>
    /// A Classe Venda indica dados da venda.
    /// </summary>
    public class Venda{
        private string cpf;
        private int id;
        private DateTime datavenda;      
    /// <summary>
    /// Construtor vazio que permite a criação da Classe Venda.
    /// </summary>
    public Venda()
    {
        
    }
    /// <summary>
    /// Construtor que inclui os parâmteros da Classe Venda.
    /// </summary>
    /// <param name="cpf">Informar o cpf do cliente com números no padrão de variável string.</param>
    /// <param name="id">Informar o id do produto com números no padrão de variável int.</param>
    /// <param name="datavenda">Informe a data da venda em formato DateTime.</param>
    public Venda(string cpf, int id, DateTime datavenda)
    {
        this.cpf=cpf;
        this.id=id;
        this.datavenda=datavenda;
    }
    public string Cpf { get{return cpf;} set{cpf=value;}}
    public int Id { get{return id;} set{id=value;}}
    public DateTime Datavenda { get{return datavenda;} set{datavenda=value;}}
    }
}