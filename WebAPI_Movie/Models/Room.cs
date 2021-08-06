namespace WebAPI_Movie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [StringLength(8)]
        public string RoomId { get; set; }

        [StringLength(8)]
        public string User1 { get; set; }

        [StringLength(8)]
        public string User2 { get; set; }

        [StringLength(8)]
        public string User3 { get; set; }

        [StringLength(8)]
        public string User4 { get; set; }

        [StringLength(8)]
        public string User5 { get; set; }

        [StringLength(8)]
        public string User6 { get; set; }

        [StringLength(8)]
        public string User7 { get; set; }

        [StringLength(8)]
        public string User8 { get; set; }

        [StringLength(8)]
        public string User9 { get; set; }

        [StringLength(8)]
        public string User10 { get; set; }
    }
}
