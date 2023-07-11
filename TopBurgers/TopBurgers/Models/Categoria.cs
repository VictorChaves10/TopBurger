using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopBurgers.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }


        [StringLength(100, ErrorMessage ="O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get; set; }


        [StringLength(200, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        public List<Lanche> Lanches { get; set; }
    }
}
