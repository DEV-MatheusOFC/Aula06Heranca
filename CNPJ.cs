namespace Aula06Heranca
{
    public class CNPJ : Pessoa
    {
        public string cnpj;

        public bool ValidarCNPJ(){

            if(cnpj != "40028922119"){
                return true;
            }

            return false;
        }
    }
}