using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Name...")]
        public string Name { get; set; }
    }
}
