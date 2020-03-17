namespace ACEmployees.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ACEmployees.Models.ApplicationDbContext>
    {
        public const string sAddress1 =
@"Avenida principal con calle 1
casa N. 54";

        public const string sAddress2 =
@"Avenida 2 con calle 3
casa N. 147";

        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ACEmployees.Models.ApplicationDbContext context)
        {
            try
            {
                context.Employees.AddOrUpdate(x => x.Id,
                    new Models.Employee()
                    {
                        Id = 1,
                        FullName = "Alfredo Castro",
                        DocumentId = "V-12689895",
                        BirthDate = new DateTime(1974, 09, 16),
                        ContractDate = new DateTime(2020, 01, 15),
                        Address = sAddress1,
                        PhoneNumber = "0412-219-4278",
                        EMail = "alcastronava@hotmail.com",
                        IsFreelance = true,
                        PayRate = 15.00M
                    }
                );

                for (int i = 0; i <= 15; i++)
                {
                    context.Employees.AddOrUpdate(x => x.Id,
                        new Models.Employee
                        {
                            Id = i + 2,
                            FullName = $"{letters[i]} Empleado",
                            DocumentId = $"V-{i + 1}111111",
                            BirthDate = new DateTime(1974, 09, 16).AddMonths(i + 1),
                            ContractDate = new DateTime(2020, 01, 15).AddMonths(-i - 1),
                            Address = (i % 2 == 0) ? sAddress1 : sAddress2,
                            PhoneNumber = "5555-222-3333",
                            EMail = $"alcastronava{i + 1}@gmail.com",
                            IsFreelance = (i % 2 == 0),
                            PayRate = (i % 2 == 0) ? 15.00M : 0
                        });
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
