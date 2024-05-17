using System.ComponentModel.DataAnnotations;

namespace MyContactApp.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }
        public string? Phone { get; set; }
        public string? CellPhone { get; set; }
        public string? Email { get; set; }
        [Required(ErrorMessage = "Type is required")]
        public required string Type { get; set; }


        public override string ToString()
        {
            return $"\n{{\n\tName: {Name},\n\tEmail: {Email},\n\tPhone: {Phone},\n\tCellPhone: {CellPhone},\n\tType: {Type}\n}}";
        }
    }
}