using System.ComponentModel.DataAnnotations;


namespace Assignment.Shared
{
    public class BrandCreateRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
