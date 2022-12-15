using StaffManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Text;


namespace StaffManagement.Models
{
    public class PostgresqlserverStaffRepository : IStaffRepository
    {

        private readonly AppDbContext dbContext;

        public PostgresqlserverStaffRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        Staff IStaffRepository.Create(Staff staff)
        {
           dbContext.staffs.Add(staff);
            dbContext.SaveChanges();
            return staff;
        }



        Staff IStaffRepository.Delete(int id)
        {
            var staff = dbContext.staffs.Find(id);
            if (staff != null)
            {
                dbContext.staffs.Remove(staff);
                dbContext.SaveChanges();
            }
            return staff;
        }



        Staff IStaffRepository.Get(int id)
        {
            return dbContext.staffs.Find(id);
        }

        IEnumerable<Staff> IStaffRepository.GetAll()
        {
            return dbContext.staffs;
        }



        Staff IStaffRepository.Update(Staff updateStaff)
        {
           var staff =  dbContext.staffs.Attach(updateStaff);
            staff.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return updateStaff;
        }
    }
}
