using System.Collections.Generic;

namespace EmployeeManagerEngine.Core.Model
{
    public class Gender : BaseModel
    {
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
