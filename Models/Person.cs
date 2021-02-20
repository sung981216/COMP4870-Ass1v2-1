using System.ComponentModel;

namespace assignment01.Models
{
    public class Person
    {
        [DisplayName("Full Name")]
        public string fullName {get; set;}
        public int id {get; set;}

    }
}