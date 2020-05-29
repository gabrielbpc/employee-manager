using System;

namespace EmployeeManagerEngine.Core.Model
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime LastModified { get; set; }
    }
}
