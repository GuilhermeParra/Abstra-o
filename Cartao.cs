namespace Abstracao
{
    public class Cartao : Pagamento
    {
        protected string token = "uhuHUIhhUHHhbHIOIHIs";
        public string titular { get; set; }
        public int numero { get; set; }
        public string  cvv { get; set; }
        public bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}