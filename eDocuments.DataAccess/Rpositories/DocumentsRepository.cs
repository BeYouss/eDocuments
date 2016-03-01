using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDocuments.Model;
using eDocuments.DataAccess.Data;

namespace eDocuments.DataAccess.Rpositories
{
    public class DocumentsRepository : RepositoryBase<Document>
    {
        public DocumentsRepository(DataContext context) : base(context){
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
