using System;
using System.ComponentModel.DataAnnotations;

namespace PrimeiroEf.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="É imprescindível o preenchimento deste campo!")]
        [StringLength(50,ErrorMessage="Você deve utilizar no máximp 50 caracteres!")]
        public string Nome { get; set; }

        [Required]
        [StringLength(50,ErrorMessage="Utilize apenas 50 caracteres!")]
        public string Email { get; set; }

        [Required]
        [Range(1,150)]
        public int Idade { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

    }
}