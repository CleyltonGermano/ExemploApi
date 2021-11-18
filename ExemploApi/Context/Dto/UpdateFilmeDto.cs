using System.ComponentModel.DataAnnotations;

namespace ExemploApi.Context.Dto
{
    public class UpdateFilmeDto
    {
        [MaxLength(50)]
        [Required]
        public string Titulo { get; set; }
        [MaxLength(50)]
        public string Diretor { get; set; }
        [MaxLength(20)]
        public string Genero { get; set; }
        [Range(1, 200)]
        public int Duracao { get; set; }
    }
}
