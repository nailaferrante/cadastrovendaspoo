using System;
using cadastrovendaspoo.classes;

namespace cadastrovendaspoo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while(opcao!=9){
            
            Console.WriteLine("==================================");
            Console.WriteLine("=        SISTEMA DE VENDAS       =");
            Console.WriteLine("==================================");
            Console.WriteLine("Digite:\n1 - Para cadastro de Cliente\n2 - Para cadastro de Produto\n3 - Para cadastro de Venda\n4 - Para extrato de venda\n9 - Sair");
            opcao = int.Parse(Console.ReadLine());
            switch(opcao){
                case 1:
                    Console.WriteLine("Digite o nome do cliente: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite o e-mail do cliente: ");
                    string email = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do cliente:");
                    string cpf = Console.ReadLine();

                    Cliente cl = new Cliente(nome,email,cpf,DateTime.Now.Date);
                    SalvarCliente sc = new SalvarCliente();
                    Console.WriteLine(sc.Salvar(cl));
                    //Console.WriteLine(new SalvarCliente().Salvar(cl));
                                    
                break;
                case 2:
                    Console.WriteLine("Digite o ID do produto: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do produto: ");
                    string nomeproduto = Console.ReadLine();

                    Console.WriteLine("Digite a descrição do produto: ");
                    string descricao = Console.ReadLine();

                    Console.WriteLine("Digite o preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    
                    Produto pr = new Produto(id,nomeproduto,descricao,preco);
                    SalvarProduto sp = new SalvarProduto();
                    Console.WriteLine(sp.Salvar(pr));
                    
                break;

            }

            }
        }
    }
}
