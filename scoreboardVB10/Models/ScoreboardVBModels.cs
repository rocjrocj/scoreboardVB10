using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace scoreboardVB10.Models
{
    public class ScoreboardVBModels
    {
        public int Id { get; set; }
        [DefaultValue("New Match")]
        public string MatchName { get; set; }
        [DefaultValue("Home")]
        public string HomeTeam { get; set; }
        [DefaultValue(0)]
        public int HomeTeamScore { get; set; }
        [DefaultValue("Guest")]
        public string GuestTeam { get; set; }
        [DefaultValue(0)]
        public int GuestTeamScore { get; set; }
        public string Set1Winner { get; set; }
        public string Set2Winner { get; set; }
        public string Set3Winner { get; set; }
        [Timestamp]
        public byte[] MatchDateTime { get; set; }
        [DefaultValue(1)]
        public int SetNumber { get; set; }
        [Timestamp]
        public byte[] CreatedDate { get; set; }
    }
}