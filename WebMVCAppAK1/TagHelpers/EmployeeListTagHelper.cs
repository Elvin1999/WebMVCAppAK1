using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebMVCAppAK1.Entities;

namespace WebMVCAppAK1.TagHelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper : TagHelper
    {
        public List<Employee> _employees;
        public EmployeeListTagHelper()
        {
            _employees = new List<Employee>
            {
                  new Employee
             {
                 Id=1,
                 Firstname="Arif",
                  Lastname="Arifli",
                  CityId=10
             },
             new Employee
             {
                 Id=2,
                  Firstname="Leyla",
                  Lastname="Mammadova",
                  CityId=55
             },
             new Employee
             {
                 Id=3,
                 Firstname="Huseyn",
                 Lastname="Huseynli",
                  CityId=44
             },
             new Employee
             {
                 Id=4,
                 Firstname="Ilkin",
                 Lastname="Suleymanov",
                 CityId=41
             }
            };
        }

        private const string ListCountAttribute = "count";
        [HtmlAttributeName(ListCountAttribute)]
        public int ListCount { get; set; }

        private const string SortAttribute = "sort";
        [HtmlAttributeName(SortAttribute)]
        public string SortAttributeValue { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            var query = _employees.Take(ListCount);

            if (SortAttributeValue.ToLower() == "a-z")
            {
                query = query.OrderBy(e => e.Firstname);
            }
            else
            {
                query = query.OrderByDescending(e => e.Firstname);
            }

            StringBuilder sb = new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendFormat("<h2><a href='/employee/detail/{0}'>{1}</a></h2>", item.Id, item.Firstname);
            }

            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
