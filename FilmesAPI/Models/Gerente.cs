using FilmesAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace study_dotnet5.Models
{
    public class Gerente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<Cinema> Cinemas { get; set; }
    }
}
