using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Room
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public Boolean IsFree { get; set; }
        public int MaxNumberOfStudents { get; set; }
        public IEnumerable<Schedule> Schedules { get; set; }
    }
}
