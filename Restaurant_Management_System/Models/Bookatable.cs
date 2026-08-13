using System.ComponentModel.DataAnnotations;

namespace Restaurant_Management_System.Models
{
    public class Bookatable
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int tablenumber { get; set; }
        public int Reserved { get; set; }
    }
}
