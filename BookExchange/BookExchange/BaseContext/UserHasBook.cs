namespace BookExchange.BaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserHasBook
    {
        public long ID { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        public long BookID { get; set; }

        public DateTime TimeStamp { get; set; }

        public DateTime LstUpdate { get; set; }

        public byte? Status { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Book Book { get; set; }
    }
}
