namespace Aula20
{
    public class Pedido
    {
        public string Itens { get; set; }
        public string Clientes { get; set; }
        public string Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago;
        
            public Pedido(string _itens, string _clientes, string _restaurante , string _formadepgto, bool _pedidopago){
                this.Itens = _itens;
                this.Clientes = _clientes;
                this.Restaurante = _restaurante;
                this.FormaDePGTO = _formadepgto;
                this.PedidoPago = _pedidopago;
                
                }
                
            }
        }