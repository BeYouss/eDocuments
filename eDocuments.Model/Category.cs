using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eDocuments.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
