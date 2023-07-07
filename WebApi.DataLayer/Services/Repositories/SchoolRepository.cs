using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Core.Contexts;
using WebApi.Core.Domains;

namespace WebApi.DataLayer.Services.Repositories
{
    public class SchoolRepository : GenericRepository<School>
    {
        public SchoolRepository(WebApiCoreDBContext context) : base(context) { }
    }
}
