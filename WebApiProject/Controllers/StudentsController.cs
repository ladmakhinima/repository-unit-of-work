using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Core.Domains;
using WebApi.DataLayer.UnitOfWork.Implementations;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private GeneralUnitOfWork _unitOfWork;

        public StudentsController(GeneralUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<List<Student>> FindAll()
        {
            return await _unitOfWork.studentRepo().Find();
        }
    }
}
