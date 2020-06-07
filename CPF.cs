namespace Aula06Heranca
{
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;

        public bool ValidarCPF(){
           
           if(cpf != "40028922-11"){
               return true;
           }

           return false;
        }
    }
}