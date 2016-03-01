using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDocuments.Model;

namespace eDocuments.DataAccess.Data
{
    public class DataContext : DbContext
    {
        public DataContext():base("eDocsConnection")
        { 
        }

        public DbSet<Document> Documents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DocumentVersion> Versions { get; set; }
    }
}
