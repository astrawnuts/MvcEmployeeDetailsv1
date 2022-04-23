using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcEmployeeDetails.Data;
using System;
using System.Linq;

namespace MvcEmployeeDetails.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcEmployeeDetailsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcEmployeeDetailsContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                //Seed Initial Data
                context.Employee.AddRange(
                    new MvcEmployeeDetails.Models.Employee
                    {
                        FirstName = "Bill",
                        LastName = "Gates",
                        FullAddress = "11 Times Square New York, NY,USA 10036",
                        MailingAddressSameAsFullAddress = true,
                        MailingAddress = null,
                        EmailAddress = "bill@microsoft.com",
                        PhoneNumber = "(212) 245-2100",
                        CitizenshipStatus = "Citizen",
                        EmploymentStartDate = new DateTime(2022,04,22),
                        EmploymentType = "Full-Time",
                        PositionTitle = "CEO",
                        EmergencyContactName = "Melinda French Gates",
                        EmergencyContactRelationship = "Spouse",
                        EmergencyContactPhoneNumber = "(212) 245-2100",
                        EmployeeSignature = "Bill Gates",
                    },

                    new MvcEmployeeDetails.Models.Employee
                    {
                        FirstName = "Steve",
                        LastName = "Jobs",
                        FullAddress = "11 Fredrick Street Cupertino, NY,USA 10036",
                        MailingAddressSameAsFullAddress = false,
                        MailingAddress = "22 Fredrick Street Cupertino, NY,USA 10036",
                        EmailAddress = "steve@apple.com",
                        PhoneNumber = "(414) 245-2100",
                        CitizenshipStatus = "Citizen",
                        EmploymentStartDate = new DateTime(2022, 04, 22),
                        EmploymentType = "Full-Time",
                        PositionTitle = "CEO",
                        EmergencyContactName = "Lisa Anne Jobs",
                        EmergencyContactRelationship = "Daughter",
                        EmergencyContactPhoneNumber = "(717) 245-2100",
                        EmployeeSignature = "Steve Jobs",
                    }

                );
                context.SaveChanges();
            }
        }
    }
}