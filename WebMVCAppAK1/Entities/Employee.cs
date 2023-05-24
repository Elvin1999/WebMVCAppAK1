using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCAppAK1.Entities
{
    public class Employee
    {
        [Range(1,20)]
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required()]
        public string Firstname { get; set; }
        [DisplayName("Surname")]
        [Required()]
        public string Lastname { get; set; }
        public int CityId { get; set; }
    }
}
