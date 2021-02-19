
using System.Collections.Generic;
using assignment01.Models;
namespace assignment01.DS
{

    public class ResponseDS
    {
        public string copyright {get;set;}
        public ICollection<Team> teams {get;set;}
    }
}
