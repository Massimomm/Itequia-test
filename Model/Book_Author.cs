using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Book_Author
    {
        [Required]
        public int BookID { get; set; }

        public int? AuthorID { get; set; }
    }
}
