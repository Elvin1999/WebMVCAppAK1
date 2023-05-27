using System.Collections.Generic;
using System.Threading.Tasks;
using WebMVCAppAK1.Entities;

namespace WebMVCAppAK1.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task Add(Student student);
    }
}
