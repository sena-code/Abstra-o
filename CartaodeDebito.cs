namespace Abstração
{
    public class CartaodeDebito : Cartao
    {
        public string Transferir(float valor){
            return $"R$ {valor} transferido de sua conta";
        }

        public bool titulodebito;

        public string Pagardebitotitulo(){

            if(titulodebito == true){
                return PagarTitulo();
            }
            return "Ok";
        }

        public string PagarTitulo(){
            return "Título pago com cartão de débito";
        }
    }
}