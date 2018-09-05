using InfaTechnologies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfaTechnologies.Core
{
    public abstract class Database : IDisposable
    {
        public IDbSet<Card> Cards { get; protected set; }
        public IDbSet<AppUser> Users { get; protected set; }
        public IDbSet<Incident> Incidents { get; protected set; }

        public abstract void Dispose();
    }
}
