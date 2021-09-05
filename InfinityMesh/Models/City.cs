using System.Collections.Generic;

namespace InfinityMesh.Models
{
    public class City
    {
        public string Name { get; set; }
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}
