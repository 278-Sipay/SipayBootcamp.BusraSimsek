using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SipayBootcamp.AssignmentApi.Model
{
    public class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public int AccessLevel { get; set; }
        public decimal Salary { get; set; }
    }
}
