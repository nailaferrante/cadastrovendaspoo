using System;
using System.IO;

namespace cadastrovendaspoo.classes{
    public class SalvarVenda{
        public string Salvar(Venda venda){
            string msg = ";";
            StreamWriter arquivo = null;
            try{
                arquivo = new StreamWriter("cadVenda.csv",true);
                    arquivo.WriteLine(
                    venda.Cpf+";"+
                    venda.Id+";"+
                    venda.Datavenda
            );
            msg = "Venda salva!";
        }
        catch(Exception e){
            msg = "A venda não foi salva."+e.Message;
        }
        finally{
            arquivo.Close();
        }
        return msg;
        }
    }
}