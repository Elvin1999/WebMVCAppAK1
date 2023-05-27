using System.Collections.Generic;
using System.Threading.Tasks;
using WebMVCAppAK1.Entities;

namespace WebMVCAppAK1.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllByKey(string key = "");
    }
}
