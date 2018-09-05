using System;

namespace InfaTechnologies.Models
{
    public class Incident:Entity<Incident>
    {
        public DateTime OpenDate { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        public AppUser Operator { get; set; }
        public int OperatorId { get; set; }
        public string TeamViewerLogin { get; set; }
        public string TeamViewerPassword { get; set; }
        public string IncidentDescription { get; set; }
        public string SolvedDescription { get; set; }
        public string Invoice { get; set; }

        public override void Update(Incident item)
        {
            throw new NotImplementedException();
        }
    }
}