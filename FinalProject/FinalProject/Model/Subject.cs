using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Subject
    {
        public int Id { get; set; }
        public int Credit { get; set; }
        public string Name { get; set; }
        public int LowerBound { get; set; }
        public IEnumerable<Schedule> Schedules { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<StudentSubject> StudentSubjects { get; set; }
    }
}
