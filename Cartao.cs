namespace Abstração
{
    public class Cartao : Pagamento
    {
        public int numero{ get; set;}

        public string titular {get; set;}

        public string bandeira {get; set;}
        public string cvv {get; set;}

        private string token = "randow code";

        public bool validarToken(){

            if(token != null){
                return true;
            }
            return false;
        }
    }
}