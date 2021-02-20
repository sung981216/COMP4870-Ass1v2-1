using System.ComponentModel;

namespace assignment01.Models
{
    public class Position
    {
        public string code {get; set;}
        [DisplayName("Position")]
        public string name {get; set;}
        public string type {get; set;}
        public string abbreviation {get; set;}

    }
}