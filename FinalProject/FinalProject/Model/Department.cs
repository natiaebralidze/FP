using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SemesterId { get; set; }
        public int MaximumNumberOfStudents { get; set; }
        public int CurrentAmount { get; set; }
        public Semester Semester { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
