using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Employee
    {
        public string EmpId { get; set; }
        public string ReportingEmpId { get; set; }
        public string EmpName { get; set; }
        public bool? HasTeam { get; set; }
        public bool? Expanded { get; set; }
        public string Role { get; set; }
        public string EmpImage { get; set; }
    }
    public class Payslip
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string Role { get; set; }
        public string Date { get; set; }
        public string Salary { get; set; }
        public string Deductions { get; set; }
        public string NetSalary { get; set; }
    }
}