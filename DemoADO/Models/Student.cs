using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADO.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int SectionId { get; set; }
        public int YearResult { get; set; }
        public bool Active { get; set; } = true;
    }
}
