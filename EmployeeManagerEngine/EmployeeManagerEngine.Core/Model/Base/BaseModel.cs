using System;

namespace EmployeeManagerEngine.Model
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime LastModified { get; set; }

    }

    public static class BaseModelExtension
    {
        public static void UpdateLastModifiedDate(this BaseModel model)
        {
            model.LastModified = DateTime.Now;
        }
    }
}
