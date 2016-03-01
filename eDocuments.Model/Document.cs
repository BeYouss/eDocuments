using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eDocuments.Model
{
    public class Document
    {
        public int DocumentId { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }

        public ICollection<DocumentVersion> versions { get; set; }
    }
}
