

namespace DesafioHotel.Models
{
    public class Suite
    {
        
        public Suite(string tipoDeSuite,int capacidade, decimal valorDaDiaria) 
        {
            this.TipoDeSuite = tipoDeSuite;
            this.Capacidade =   capacidade;
            this.ValorDaDiaria = valorDaDiaria;
   
        }
        public string TipoDeSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDaDiaria { get; set; }
        
        
        
    }
}