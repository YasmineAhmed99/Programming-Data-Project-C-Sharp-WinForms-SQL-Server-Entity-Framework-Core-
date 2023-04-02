namespace Programming_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dismissal")]
    public partial class Dismissal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PermNum { get; set; }

        [StringLength(50)]
        public string StoreName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PermDate { get; set; }

        [StringLength(50)]
        public string material { get; set; }

        public int? quantity { get; set; }

        [StringLength(50)]
        public string SupplierName { get; set; }

        public virtual Store Store { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
