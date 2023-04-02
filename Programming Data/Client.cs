namespace Programming_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [Key]
        [StringLength(50)]
        public string Name { get; set; }

        public int? Telephone { get; set; }

        public int? Fax { get; set; }

        public int? Mobile { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Website { get; set; }
    }
}
