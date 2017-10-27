namespace cadastrovendaspoo.classes{
    /// <summary>
    /// A Classe Produto permite cadstrar dados do produto.
    /// </summary>
    public class Produto{
        private int id;
        private string nomeproduto;
        private string descricao;
        private double preco;
        /// <summary>
        /// Construtor que permite a criação da Classe Produto.
        /// </summary>
        public Produto()
        {
            
        }
        /// <summary>
        /// Construtor que define os argumentos da classe Produto.
        /// </summary>
        /// <param name="id">Informar o id do produto com números no padrão de variável int.</param>
        /// <param name="nomeproduto">Informar o Nome do Produto em formato texto no padrão de variável string.</param>
        /// <param name="descricao">Informar a descrição em formato texto no padrão de variável string.</param>
        /// <param name="preco">Informar o preço do produto com números no padrão de variável double.</param>
        public Produto(int id, string nomeproduto, string descricao, double preco)
        {
            this.id=id;
            this.nomeproduto=nomeproduto;
            this.descricao=descricao;
            this.preco=preco;
        }
        public int Id { get{return id;} set{id = value;}}
        public string Nomeproduto { get{return nomeproduto;} set{nomeproduto=value;}}
        public string Descricao { get{return descricao;} set{descricao=value;}}
        public double Preco { get{return preco;} set{preco=value;}}
    }
}