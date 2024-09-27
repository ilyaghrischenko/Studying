using System.Collections.Generic;
using Microsoft.Build.Framework;

namespace WebMVC_2.Models
{
    public class Auth
    {
        public int Id { get; set; } 
        
        [Required]
        public string Name { get; set; }
        
        public virtual ICollection<Book>? Books { get; set; } = new List<Book>();
    }
}
