
using System.Collections.Generic;
using assignment01.Models;
namespace assignment01.DS
{

    public class ResponsePlayerDS
    {
        public string copyright {get;set;}
        public ICollection<Player> roster {get;set;}
    }
}
