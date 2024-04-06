using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace L01P022021DP650.Models
{
    public class facultad
    {
        [Key]
        public int id { get; set; }
        public string? facultades { get; set; }

    }
}
