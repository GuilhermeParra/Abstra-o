namespace Abstracao
{
    public class CartaoDebito : Cartao{
      public float saldo { get; set; }

        public string Transferir(){
            return "Tranferência efetuada";
        }

        public string Pagartitulo(){
            return "Título pago";
        }
    }
}