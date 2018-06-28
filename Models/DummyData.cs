using sqlite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sqlite.Models
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            if (! db.Students.Any())
            {
                db.Students.Add(
                    new Student
                    {
                        FirstName = "Bob",
                        LastName = "Doe",
                        School = "Engineering",
                        StartDate = Convert.ToDateTime("2015/09/09")
                    });
                db.SaveChanges();

            }
        }

    }
}
