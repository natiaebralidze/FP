using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int DepartmentId { get; set; }
        public int AddressId { get; set; }
        public int SemesterId { get; set; }
        public string LasttName { get; set; }
        public string PersonalId { get; set; }
        public int StartYear { get; set; }
        public Department Department { get; set; }
        public Address Address { get; set; }
        public Semester Semester { get; set; }
        public IEnumerable<StudentSubject> StudentSubjects { get; set; }
        public IEnumerable<Balance> Balances { get; set; }
    }
}
