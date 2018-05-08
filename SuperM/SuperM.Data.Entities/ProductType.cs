namespace SuperM.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class ProductType
    {
        public int ProductTypeId { get; set; }

        [Required]
        public string ProductTypeName { get; set; }
    }
}
