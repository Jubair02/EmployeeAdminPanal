﻿namespace EmployeeAdminPanal.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string? Phone { get; set; }
        public decimal salary { get; set; }
    }
}

