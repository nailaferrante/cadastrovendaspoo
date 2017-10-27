using System;
using System.IO;

namespace cadastrovendaspoo.classes{
    public class SalvarProduto{
        public string Salvar(Produto produto){
            string msg ="";
            StreamWriter arquivo = null;
            try{
                arquivo = new StreamWriter("cadProduto.csv",true);
                arquivo.WriteLine(
                    produto.Id+";"+
                    produto.Nomeproduto+";"+
                    produto.Descricao+";"+
                    produto.Preco
                );
                msg = "Produto salvo com sucesso!";
            }
            catch(Exception e){
                msg = "Erro ao cadastrar o produto :("+e.Message;
            }
            finally{
                arquivo.Close();
            }
            return msg;
        }
    }
}