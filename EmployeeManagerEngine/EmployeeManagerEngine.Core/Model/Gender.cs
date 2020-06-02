using System.Collections.Generic;

namespace EmployeeManagerEngine.Model
{
    public class Gender : BaseModel
    {
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
