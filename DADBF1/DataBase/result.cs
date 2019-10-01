namespace DADBF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("result")]
    public partial class result
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public result()
        {
            tournaments = new HashSet<tournament>();
        }

        public int id { get; set; }

        public int? place1 { get; set; }

        public int? place2 { get; set; }

        public int? place3 { get; set; }

        public int? place4 { get; set; }

        public int? place5 { get; set; }

        public int? place6 { get; set; }

        public int? place7 { get; set; }

        public int? place8 { get; set; }

        public int? place9 { get; set; }

        public int? place10 { get; set; }

        public virtual driver driver { get; set; }

        public virtual driver driver1 { get; set; }

        public virtual driver driver2 { get; set; }

        public virtual driver driver3 { get; set; }

        public virtual driver driver4 { get; set; }

        public virtual driver driver5 { get; set; }

        public virtual driver driver6 { get; set; }

        public virtual driver driver7 { get; set; }

        public virtual driver driver8 { get; set; }

        public virtual driver driver9 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tournament> tournaments { get; set; }
    }
}
