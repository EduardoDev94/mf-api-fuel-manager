﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_api_fuel_manager.Models
{
    [Table("Consumos")]
    public class Consumo : LinksHATEOS
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required]
        public TipoCombustivel Tipo { get; set; }
        [Required]
        public int VeiculoId { get; set; }//Referência da chave estrangeira de Veiculo sendo 1 veículo para muitos consumos

        public Veiculo Veiculo { get; set; }

    }
    public enum TipoCombustivel
    {
        Diesel,
        Etanol,
        Gasolina
    }
}
