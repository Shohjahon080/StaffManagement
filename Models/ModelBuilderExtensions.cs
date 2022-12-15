using Microsoft.EntityFrameworkCore;

namespace StaffManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().HasData(
                new Staff
                {
                    Id = 1,
                    FirstName = "Shohjahon",
                    LastName = "Normuminov",
                    Email = "shoh@gmail.com",
                    Department = Department.Admin
                },
               new Staff
               {
                   Id = 2,
                   FirstName = "Temur",
                   LastName = "Oybekov",
                   Email = "timati@gmail.com",
                   Department = Department.Production
               }
               );
        }


    }
}
