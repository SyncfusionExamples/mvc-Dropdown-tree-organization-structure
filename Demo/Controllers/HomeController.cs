using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        public List<Employee> GetData()
        {
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee
            {
                EmpId = "1",
                EmpName = "Steven Buchanan",
                EmpImage = "10",
                Role = "General Manager",
                HasTeam = true,
                Expanded = true
            });
            Employees.Add(new Employee
            {
                EmpId = "2",
                ReportingEmpId = "1",
                EmpName = "Laura Callahan",
                EmpImage = "2",
                Role = "Product Manager",
                HasTeam = true
            });
            Employees.Add(new Employee
            {
                EmpId = "3",
                ReportingEmpId = "1",
                EmpName = "Nancy Davolio",
                EmpImage = "4",
                Role = "Product Manager",
                HasTeam = true
            });
            Employees.Add(new Employee
            {
                EmpId = "4",
                ReportingEmpId = "1",
                EmpName = "Janet Leverling",
                EmpImage = "3",
                Role = "HR",
                HasTeam = true
            });
            Employees.Add(new Employee
            {
                EmpId = "5",
                ReportingEmpId = "2",
                EmpName = "Andrew Fulle",
                EmpImage = "7",
                Role = "Team Lead",
                HasTeam = true
            });
            Employees.Add(new Employee
            {
                EmpId = "6",
                ReportingEmpId = "3",
                EmpName = "Michael Suyama",
                EmpImage = "9",
                Role = "Team Lead",
                HasTeam = true
            });
            Employees.Add(new Employee
            {
                EmpId = "7",
                ReportingEmpId = "5",
                EmpName = "Anne Dodsworth",
                EmpImage = "1",
                Role = "Senior Developer",
                HasTeam = true
            });
            Employees.Add(new Employee
            {
                EmpId = "8",
                ReportingEmpId = "5",
                EmpName = "Lilly",
                EmpImage = "5",
                Role = "Developer",
                HasTeam = true
            });
            Employees.Add(new Employee
            {
                EmpId = "9",
                ReportingEmpId = "6",
                EmpName = "Robert King",
                EmpImage = "8",
                Role = "Senior Developer",
                HasTeam = true
            });
            Employees.Add(new Employee
            {
                EmpId = "10",
                ReportingEmpId = "6",
                EmpName = "Mary",
                EmpImage = "6",
                Role = "Developer",
                HasTeam = true
            });
            return Employees;
        }
        public ActionResult Index()
        {
            ViewBag.Val = null;
            ViewBag.DataSource = this.GetData();
            return View();
        }

        public List<Payslip> GetPayslipData()
        {
            List<Payslip> Employees = new List<Payslip>();
            Employees.Add(new Payslip
            {
                EmpId = "1",
                EmpName = "Steven Buchanan",
                Date = "1/1/2020",
                Role = "General Manager",
                Salary = "$5000",
                Deductions = "$100",
                NetSalary = "$4990"
            });
            Employees.Add(new Payslip
            {
                EmpId = "2",
                EmpName = "Laura Callahan",
                Date = "2/2/2020",
                Role = "Product Manager",
                Salary = "$1000",
                Deductions = "$50",
                NetSalary = "$950"
            });
            Employees.Add(new Payslip
            {
                EmpId = "3",
                EmpName = "Nancy Davolio",
                Date = "3/3/2020",
                Role = "Product Manager",
                Salary = "$900",
                Deductions = "$50",
                NetSalary = "$850"
            });
            Employees.Add(new Payslip
            {
                EmpId = "4",
                EmpName = "Janet Leverling",
                Date = "4/4/2020",
                Role = "HR",
                Salary = "$700",
                Deductions = "$40",
                NetSalary = "$660"
            });
            Employees.Add(new Payslip
            {
                EmpId = "5",
                EmpName = "Andrew Fulle",
                Date = "5/5/2020",
                Role = "Team Lead",
                Salary = "$500",
                Deductions = "$30",
                NetSalary = "$470"
            });
            Employees.Add(new Payslip
            {
                EmpId = "6",
                EmpName = "Michael Suyama",
                Date = "6/6/2020",
                Role = "Team Lead",
                Salary = "$400",
                Deductions = "$30",
                NetSalary = "$370"
            });
            Employees.Add(new Payslip
            {
                EmpId = "7",
                EmpName = "Anne Dodsworth",
                Date = "7/7/2020",
                Role = "Senior Developer",
                Salary = "$300",
                Deductions = "$10",
                NetSalary = "$290"
            });
            Employees.Add(new Payslip
            {
                EmpId = "8",
                EmpName = "Lilly",
                Date = "8/8/2020",
                Role = "Developer",
                Salary = "$200",
                Deductions = "$10",
                NetSalary = "$190"
            });
            Employees.Add(new Payslip
            {
                EmpId = "9",
                EmpName = "Robert King",
                Date = "9/9/2020",
                Role = "Senior Developer",
                Salary = "$250",
                Deductions = "$10",
                NetSalary = "$240"
            });
            Employees.Add(new Payslip
            {
                EmpId = "10",
                EmpName = "Mary",
                Date = "10/10/2020",
                Role = "Developer",
                Salary = "$150",
                Deductions = "$10",
                NetSalary = "$140"
            });
            return Employees;
        }
        [HttpPost]
        public ActionResult Index(string[] ddt)
        {
            List<Payslip> PayData = new List<Payslip>();
            ViewBag.Val = ddt;
            ViewBag.DataSource = this.GetData();
            List<Payslip> TempData = this.GetPayslipData();
            if (ddt != null)
            {
                foreach (var Data in TempData)
                {
                    for (var i = 0; i < ddt.Length; i++)
                    {
                        if (Data.EmpId == ddt[i])
                        {
                            PayData.Add(Data);
                        }
                    }
                }
            }
            ViewBag.PayslipData = PayData;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}