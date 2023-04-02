namespace Programming_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialStore")]
    public partial class MaterialStore
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string StoreN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }
    }
}
