#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcEmployeeDetails.Data;

namespace MvcEmployeeDetails.Models
{
    public class EmployeesControllerTwo : Controller
    {
        private readonly MvcEmployeeDetailsContext _context;

        public EmployeesControllerTwo(MvcEmployeeDetailsContext context)
        {
            _context = context;
        }

        // GET: EmployeesControllerTwo
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: EmployeesControllerTwo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: EmployeesControllerTwo/Create
        //[Route("/new-employee-details")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeesControllerTwo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,FullAddress,MailingAddressSameAsFullAddress,MailingAddress,EmailAddress,PhoneNumber,CitizenshipStatus,EmploymentStartDate,EmploymentType,PositionTitle,EmergencyContactName,EmergencyContactRelationship,EmergencyContactPhoneNumber,EmployeeSignature")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Details", new { Id = employee.Id } );
            }
            return View(employee);
        }

        // GET: EmployeesControllerTwo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: EmployeesControllerTwo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,FullAddress,MailingAddressSameAsFullAddress,MailingAddress,EmailAddress,PhoneNumber,CitizenshipStatus,EmploymentStartDate,EmploymentType,PositionTitle,EmergencyContactName,EmergencyContactRelationship,EmergencyContactPhoneNumber,EmployeeSignature")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: EmployeesControllerTwo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: EmployeesControllerTwo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }
    }
}
