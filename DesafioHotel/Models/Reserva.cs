using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHotel.Models
{
    public class Reserva
    {
        public Reserva() {}
        public Reserva(int diasReservados) 
        {
            this.DiasReservados = diasReservados;
   
        }
        public int DiasReservados { get; set; }
        public List<Pessoa> Hospedes {get; set;}
        public Suite Suite {get; set;}
     
        

        public void CadastrarSuite(Suite suite){
            {
                Suite = suite;
            }
        }
        public void CadastrarHospedes(List<Pessoa> hospedes){
            if ( hospedes.Count() <=  Suite.Capacidade )
            {
                Hospedes = hospedes;  
            }
            else{
                throw new ArgumentNullException("O numero de hospedes não pode ser maior que a capacidade da Suíte.");
            }
          
        }

        public int ObterQuantidadeHospedes(){
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria(){
            if (DiasReservados > 10)
            {
                var diariaComDesconto = Suite.ValorDaDiaria - (Suite.ValorDaDiaria * 0.10M);
                return diariaComDesconto * DiasReservados;
            }
            else
            {
                return Suite.ValorDaDiaria * DiasReservados;
            }
            
        }
    }
}