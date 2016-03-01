using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDocuments.Model;
using eDocuments.DataAccess.Data;

namespace eDocuments.DataAccess.Rpositories
{
    public class DocumentVersionsRepository : RepositoryBase<DocumentVersion>
    {
        public DocumentVersionsRepository(DataContext context) : base(context){
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
