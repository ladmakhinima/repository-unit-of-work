using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DataLayer.Services.Repositories;

namespace WebApi.DataLayer.UnitOfWork.Interfaces
{
    public interface IGeneralUnitOfWork : IDisposable
    {
        public StudentRepository studentRepo();
        public SchoolRepository schoolRepo();
        public Task Save();
    }
}
