using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebMVCAppAK1.Entities;

namespace WebMVCAppAK1.Models
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}
