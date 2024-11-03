using KurumsalTanıtım.Models.Entities;
using KurumsalTanıtım.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeRepository employeeRepository, ILogger<EmployeeController> logger)
        {
            _employeeRepository = employeeRepository;
            _logger = logger;
        }

        public async Task<IActionResult> Employee()
        {
            _logger.LogInformation("Index action called.");

            IEnumerable<Employee> employees;

            try
            {
                employees = await _employeeRepository.GetAll();
                _logger.LogInformation("Employees successfully retrieved.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while retrieving employees: {ex.Message}");
                return View("Error"); // Hata sayfasına yönlendirme
            }

            return View("~/Views/Home/Employee.cshtml", employees);
        }
    }
}
