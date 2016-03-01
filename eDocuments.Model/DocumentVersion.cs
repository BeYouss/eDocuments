using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eDocuments.Model
{
    public class DocumentVersion
    {
        public int VersionId { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
