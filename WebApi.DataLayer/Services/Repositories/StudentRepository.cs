using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Core.Contexts;
using WebApi.Core.Domains;

namespace WebApi.DataLayer.Services.Repositories
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(WebApiCoreDBContext context) : base(context) { }
    }
}
