using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Balance
    {
        public int Id { get; set; }
        public long Amount { get; set; }
        public int SemesterId { get; set; }
        public int StudentId { get; set; }
        public long Debth { get; set; }
        public Semester Semester { get; set; }
        public Student Student { get; set; }

    }
}
