namespace EmployeeManagerEngine.Model.Contracts.Employee
{
    public class UpdateEmployeeRequest : CreateEmployeeRequest
    {
        public int Id { get; set; }
    }
}
