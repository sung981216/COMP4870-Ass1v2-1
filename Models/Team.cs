using System.ComponentModel;

namespace assignment01.Models
{
    public class Team
    {
        [DisplayName("ID")]
        public int id {get;set;}
        [DisplayName("Team Name")]
        public string name {get;set;}
        [DisplayName("Short Name")]
        public string teamName {get;set;}
        [DisplayName("Abbreviation")]
        public string abbreviation {get;set;}
        public string locationName {get;set;}

    }
}