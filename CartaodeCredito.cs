namespace Abstração
{
    public class CartaodeCredito : Cartao
    {
        public float limite { get; set; }

        public float AumentarLimite(float limiteAtual, float acrescimo ){
            return limiteAtual + acrescimo;
        }

        public string BloquearCartaoDeCrefito(){
            return "cartão de crédito bloqueado";
        }
        
    }
}