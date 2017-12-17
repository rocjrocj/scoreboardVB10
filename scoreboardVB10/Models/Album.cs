using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace scoreboardVB10.Models
{
    public class Album
    {
        public int Id { get; set; }
        [DefaultValue("Radiohead")]
        public string Artist { get; set; }
        [DefaultValue("Kid A")]
        public string AlbumName { get; set; }
        [DefaultValue("Alt Rock")]
        public string Genre { get; set; }
        [Timestamp]
        public byte[] CreatedDate { get; set; }
    }
}