using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Semester
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int AvailableGPA { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<Schedule> Schedules { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Balance> Balances { get; set; }
    }
}
