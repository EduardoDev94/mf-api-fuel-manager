using System.ComponentModel.DataAnnotations.Schema;

namespace mf_api_fuel_manager.Models
{
    [Table("VeiculoUsuarios")]
    public class VeiculoUsuario
    {
        public int VeiculoId { get; set; }

        public Veiculo Veiculo { get; set; }
        public int UsuarioId { get; set; }
        
        public Usuario Usuario { get; set; }
    }
}
