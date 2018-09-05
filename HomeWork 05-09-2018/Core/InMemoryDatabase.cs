using InfaTechnologies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfaTechnologies.Core
{
    public class InMemoryDatabase : Database
    {
        public InMemoryDatabase()
        {    
            Cards = new InMemoryDbSet<Card>();
            Users = new InMemoryDbSet<AppUser>();
        }
        public override void Dispose()
        {
            Cards = null;
            Users = null;
            Incidents = null;
        }
    }
}
