using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebApplicationPartialpostBack16.Models
{
    public class DynamicRows
    {
        
    }
    public class EmployeeModel
    {
        public List<Information> InfoModel { get; set; }
    }
    public class Information
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Contact { get; set; }
        public string Address { get; set; }
    }
}
