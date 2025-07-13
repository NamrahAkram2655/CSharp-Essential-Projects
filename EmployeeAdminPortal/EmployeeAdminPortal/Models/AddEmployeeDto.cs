namespace EmployeeAdminPortal.Models
{
    public class AddEmployeeDto
    {
        //for using it in the controller
        public required string name { get; set; }
        public required string email { get; set; }
        public string? phone { get; set; }
        public decimal salary { get; set; }
    }
}
