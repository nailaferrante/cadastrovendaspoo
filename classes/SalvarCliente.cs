using System;
using System.IO;

namespace cadastrovendaspoo.classes{
    public class SalvarCliente{
        public string Salvar(Cliente cliente){
            string msg = "";
            StreamWriter arquivo = null;
            try{
                arquivo = new StreamWriter("cadClientes.csv",true);
                if(cpfValido(cliente.Cpf)){
                    arquivo.WriteLine(
                        cliente.Nome+";"+
                        cliente.Email+";"+
                        cliente.Cpf+";"+
                        cliente.Datacadastro
                    );
                    msg = "Cliente salvo com sucesso!!!";
                }
                else{
                    msg ="CPF inválido :(";
                }
            }
            catch(Exception ex){
                msg = "Erro ao gravar o arquivo :( "+ex.Message;
            }
            finally{
                arquivo.Close();
            }
            return msg;
        }
        /// <summary>
        /// É uma função que informa se o CPF é válido, realizando a verificação do dígito verificador.
        /// </summary>
        /// <param name="cpfusuario">Deve conter o CPF que será testado</param>
        /// <returns>Se o CPF testado for igual ao calcualdo retorna true, se não, retorna false.</returns>
        private bool cpfValido(string cpf){ // bool espera string
            int[] v1 = {10,9,8,7,6,5,4,3,2};
            int[] v2 = {11,10,9,8,7,6,5,4,3,2};
            
            bool retorno = true;

            string cpfcalculo = "";
                                  
            int resultado = 0;
            int resto = 0;
            
            cpfcalculo = cpf.Substring(0,9);

            for(int i = 0; i < cpfcalculo.Length; i++){
                resultado+=Int16.Parse(cpfcalculo[i].ToString())*v1[i]; //cpfcalculo pega como char, por isso precisa transformar em string. 
            }
                resto = resultado % 11;
                if(resto < 2)
                cpfcalculo+="0";
                else
                cpfcalculo+=(11-resto).ToString();
                

                resultado = 0;
                
             for(int i = 0; i < cpfcalculo.Length; i++){
                resultado+=Int16.Parse(cpfcalculo[i].ToString())*v2[i]; //cpfcalculo pega como char, por isso precisa transformar em string. 
            }
                resto = resultado % 11;
                if(resto < 2)
                cpfcalculo+="0";
                else
                cpfcalculo+=(11-resto).ToString();
                             

            if(cpfcalculo!=cpf){
               retorno = false;
            }
            return retorno;
        }

        }

    }
