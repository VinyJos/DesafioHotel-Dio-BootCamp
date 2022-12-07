using System;
using System.Collections.Generic;

namespace DesafioHotel.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Vinicius", sobrenome: "Jose");
            Pessoa p2 = new Pessoa(nome: "Carla");

            hospedes.Add(p1);
            hospedes.Add(p2);

            Suite suite = new Suite(tipoDeSuite: "Premium", capacidade: 2, valorDaDiaria: 100.00M);

            Reserva reserva = new Reserva(diasReservados: 12);

            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor total: {reserva.CalcularValorDiaria()}");
        }
    }
}
