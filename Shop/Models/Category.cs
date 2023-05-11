using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        public Category()
        {

        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        [Key]
        [Required(ErrorMessage = " Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo é obrigatório")]
        [MaxLength(50, ErrorMessage = "Titulo deve ter no máximo 50 caracteres")]
        [MinLength(5, ErrorMessage = "Titulo deve ter no mínimo 5 caracteres")]
        public string Name { get; set; }

        public List<Product> Products { get; set; } = new();
    }
}
