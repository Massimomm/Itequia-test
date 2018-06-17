using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Book
    {
        public Book()
        {
            this.Authors = new HashSet<Author>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public int FirstPublished { get; set; }
        public string AuthorsSummary { get; set; }

        // Used for collection navigation scope
        public virtual ICollection<Author> Authors { get; set; }

    }
}
