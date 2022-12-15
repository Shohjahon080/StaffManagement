using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.Models
{
    public class MockStaffRepository : IStaffRepository
    {
        private List<Staff> _staffs = null;

        public MockStaffRepository()
        {
            _staffs = new List<Staff>()
            {
                new Staff() {Id = 1, FirstName = "Temur", LastName = "Oybekov", Email = "timati@gmail.com", Department=Department.Admin },
                new Staff() {Id = 2, FirstName = "Shohjahon", LastName = "Normuminov", Email = "Shoh@gmail.com", Department=Department.Production },
                new Staff() {Id = 3, FirstName = "Asad", LastName = "Zokirovich", Email = "Asad@mafiyagmail.com", Department=Department.RnD}
            };
        }

        //CREATE

        public Staff Create(Staff staff)
        {
            staff.Id = _staffs.Max(s => s.Id) + 1;
            _staffs.Add(staff);
            return staff;
        }


        //DELETE
        public Staff Delete(int id)
        {
             var staff = _staffs.FirstOrDefault(s => s.Id.Equals(id));
            if (staff != null)
            {
                _staffs.Remove(staff);
            }
            return staff;
        }



        public Staff Get(int id)
        {
            return _staffs.FirstOrDefault(staff => staff.Id.Equals(id));
        }

        public IEnumerable<Staff> GetAll()
        {
            return _staffs;
        }


        //UPDATE

        public Staff Update(Staff updateStaff)
        {
            var staff = _staffs.FirstOrDefault(s => s.Id.Equals(updateStaff.Id));
            if (staff != null)
            {
                staff.FirstName = updateStaff.FirstName;
                staff.LastName = updateStaff.LastName;
                staff.Email = updateStaff.Email;
                staff.Department = updateStaff.Department;

            }
            return staff;
        }
    }
}
