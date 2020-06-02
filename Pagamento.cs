using System;

namespace Abstracao
{
    public class Pagamento
    {
      public DateTime data {get; set;}
      public float valor {get; set;} //permissão de leitura e escrita// 
      public string Pagar(float valorPago){
          return "Valor pago: R$"+valorPago;
      }  
      public string Cancelar(){
          return "Pagamento cancelado";
      }  
    
    }
}