namespace DADBF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("race")]
    public partial class race
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public race()
        {
            tournaments = new HashSet<tournament>();
        }

        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? race_day { get; set; }

        [StringLength(255)]
        public string location { get; set; }

        public int? laps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tournament> tournaments { get; set; }
    }
}
