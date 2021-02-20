using System.ComponentModel;

namespace assignment01.Models
{
    public class Player
    {
        public Person person {get; set;}
        [DisplayName("Jersery Number")]
        public string jerseyNumber {get; set;}

        public Position position {get; set;}
    }
}