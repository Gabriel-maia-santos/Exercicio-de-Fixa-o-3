namespace Aula20
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        public Restaurante(string _nomefantasia, string _endereco){
            this.NomeFantasia = _nomefantasia;
            this.Endereco = _endereco;
        }
    }
}