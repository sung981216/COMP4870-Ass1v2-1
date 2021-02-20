using System.ComponentModel;
namespace assignment01.Models
{
    public class People
    {
        [DisplayName("Name")]
        public string fullName {get; set;}
        public Team currentTeam {get; set;}
        [DisplayName("Age")]
        public int currentAge {get; set;}
        [DisplayName("Nationality")]
        public string nationality {get; set;}
        public Position primaryPosition {get; set;}
    }
}