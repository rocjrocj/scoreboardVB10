using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace scoreboardVB10.Models
{
    public class SvbMatches
    {
        public int Id { get; set; }
        public int MatchName { get; set; }
        public int HomeTeamId { get; set; }
        public int GuestTeamId { get; set; }
        public int Set1WinnerId { get; set; }
        public int Set2WinnerId { get; set; }
        public int Set3WinnerId { get; set; }

    }
}