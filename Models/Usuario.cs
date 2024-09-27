using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_api_fuel_manager.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }

        public string Password { get; set; }
       
        public Perfil Perfil { get; set; }


    }
    public enum Perfil
    {
        [Display(Name = "Administrador")]
        Administrador,
        [Display(Name = "Usuario")]
        Usuario
    }
}
