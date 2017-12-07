using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace scoreboardVB10.Models
{
    public class ScoreboardVBModels
    {
        public int Id { get; set; }
        public string MatchName { get; set; }
        public string HomeTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public string GuestTeam { get; set; }
        public int GuestTeamScore { get; set; }
        public int Set1Winner { get; set; }
        public int Set2Winner { get; set; }
        public int Set3Winner { get; set; }
        public int MatchDateTime { get; set; }
        public int SetNumber { get; set; }
    }
}