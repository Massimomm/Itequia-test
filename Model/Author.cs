using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        // Used for collection navigation scope
        public virtual ICollection<Book> Books { get; set; }

    }
}
