using WebApi.Core.Contexts;
using WebApi.DataLayer.Services.Repositories;
using WebApi.DataLayer.UnitOfWork.Interfaces;

namespace WebApi.DataLayer.UnitOfWork.Implementations
{
    public class GeneralUnitOfWork : IGeneralUnitOfWork
    {
        private WebApiCoreDBContext _context { get; set; }
        private StudentRepository? _studentRepo;
        private SchoolRepository? _schoolRepo;

        public GeneralUnitOfWork(WebApiCoreDBContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public StudentRepository studentRepo()
        {
            if (_studentRepo == null)
            {
                _studentRepo = new StudentRepository(_context);
            }
            return _studentRepo;
        }

        public SchoolRepository schoolRepo()
        {
            if (_schoolRepo == null)
            {
                _schoolRepo = new SchoolRepository(_context);
            }
            return _schoolRepo;
        }
    }
}
